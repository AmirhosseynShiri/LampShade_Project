using _0_FrameWork.Application;
using _0_FrameWork.Application.Zarinpal;
using _01_LampshadeQuery.Contract;
using _01_LampshadeQuery.Contract.Product;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Nancy.Json;
using ShopManagement.Application.Contracts.Order;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ServiceHost.Pages
{
    [Authorize]
    public class CheckOutModel : PageModel
    {
        public Cart Cart { get; set; }
        public const string CookieName = "cart-items";

        private readonly ICartService _cartService;
        private readonly IAuthHelper _authHelper;
        private readonly IProductQuery _productQuery;
        private readonly IOrderApplication _orderApplication;
        private readonly IZarinPalFactory _zarinPalFactory;
        private readonly ICartCalculatorService _cartCalculatorService;

        public CheckOutModel(ICartCalculatorService cartCalculatorService,
            ICartService cartService, IProductQuery productQuery,
            IAuthHelper authHelper, IOrderApplication orderApplication,
            IZarinPalFactory zarinPalFactory)
        {
            _cartCalculatorService = cartCalculatorService;
            _cartService = cartService;
            _productQuery = productQuery;
            _authHelper = authHelper;
            _orderApplication = orderApplication;
            _zarinPalFactory = zarinPalFactory;
        }

        public void OnGet()
        {
            var serializer = new JavaScriptSerializer();
            var value = Request.Cookies[CookieName];
            var cartItems = serializer.Deserialize<List<CartItem>>(value);
            foreach (var item in cartItems)
                item.CalculateTotalItemPrice();

            Cart = _cartCalculatorService.ComputeCart(cartItems);
            _cartService.Set(Cart);
        }

        public IActionResult OnPostPay(int paymentMethod)
        {
            var cart = _cartService.Get();
            cart.SetPaymentMethod(paymentMethod);

            var result = _productQuery.CheckInventoryStatus(cart.Items);
            if (result.Any(x => !x.IsInStock))
                return RedirectToPage("/Cart");

            var orderId = _orderApplication.PlaceOrder(cart);
            var accountMobile = _authHelper.CurrentAccountMobile();

            if (paymentMethod == 1)
            {
                var paymentResponse = _zarinPalFactory.CreatePaymentRequest(cart.PayAmount.ToString(CultureInfo.InvariantCulture),
                accountMobile, "", "خرید از درگاه امیرحسین", orderId);

                return Redirect($"https://{_zarinPalFactory.Prefix}.zarinpal.com/pg/StartPay/{paymentResponse.Authority}");
            }

            var paymentResult = new PaymentResult();
            paymentResult = paymentResult.Succeeded("سفارش شما با موفقیت ثبت شده است.پس از تماس کارشناسان سفارش ارسال می گردد.",null);
            Response.Cookies.Delete(CookieName);
            return RedirectToPage("/PaymentResult", paymentResult);


        }

        public IActionResult OnGetCallBack([FromQuery] string authority, [FromQuery] string status, [FromQuery] long oId)
        {
            var orderAmount = _orderApplication.GetAmountBy(oId);
            var verifictionResponse = _zarinPalFactory.
                CreateVerificationRequest(authority, orderAmount.ToString());

            var result = new PaymentResult();
            if (status.ToLower() == "ok" && verifictionResponse.Status == 100)
            {
                var issueTrackingNo = _orderApplication.PaymentSucceeded(oId, verifictionResponse.RefID);
                Response.Cookies.Delete(CookieName);
                result = result.Succeeded("پرداخت با موفقیت انجام شد.", issueTrackingNo);
                return RedirectToPage("/PaymentResult", result);

            }
            else
            {
                result = result.Failed("پرداخت با شکست مواجه شد.در صورت کسر وجه تا 24 ساعت آینده بازگردانده می شود.");
                return RedirectToPage("/PaymentResult", result);
            }


        }
    }
}
