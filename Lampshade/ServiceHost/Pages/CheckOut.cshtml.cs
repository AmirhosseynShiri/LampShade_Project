using _01_LampshadeQuery.Contract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Nancy.Json;
using ShopManagement.Application.Contracts.Order;
using System.Collections.Generic;

namespace ServiceHost.Pages
{
    public class CheckOutModel : PageModel
    {
        public Cart Cart;
        public const string CookieName = "cart-items";
        private readonly ICartCalculatorService _cartCalculatorService;

        public CheckOutModel(ICartCalculatorService cartCalculatorService)
        {
            _cartCalculatorService = cartCalculatorService;
        }

        public void OnGet()
        {
            var serializer = new JavaScriptSerializer();
            var value = Request.Cookies[CookieName];
            var cartItems = serializer.Deserialize<List<CartItem>>(value);
            foreach (var item in cartItems)
                item.CalculateTotalItemPrice();

            Cart = _cartCalculatorService.ComputeCart(cartItems);
        }
    }
}