using _0_FrameWork.Application;
using _01_LampshadeQuery.Contract;
using DiscountManagement.Infrustructure.EfCore;
using ShopManagement.Application.Contracts.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_LampshadeQuery.Query
{
    public class CartCalculatorService : ICartCalculatorService
    {
        private readonly IAuthHelper _authHelper;
        private readonly DiscountContext _discountContext;

        public CartCalculatorService(IAuthHelper authHelper, DiscountContext discountContext)
        {
            _authHelper = authHelper;
            _discountContext = discountContext;
        }

        public Cart ComputeCart(List<CartItem> cartItems)
        {
            var cart = new Cart();
            var CurrentAccountRole = _authHelper.CurrentAccountRole();
            var colleagueDiscounts = _discountContext.ColleagueDiscounts.
                    Where(x => !x.IsRemoved)
                    .Select(x => new { x.ProductId, x.DiscountRate }).ToList();

            var customerDiscounts = _discountContext.CustomerDiscounts.
                    Where(x => x.StartDate < DateTime.Now && x.EndDate > DateTime.Now)
                .Select(x => new { x.DiscountRate, x.ProductId, x.EndDate }).ToList();

            foreach (var cartitem in cartItems)
            {
                if (CurrentAccountRole == Roles.ColleagueUser)
                {
                    var colleagueDiscount = colleagueDiscounts.FirstOrDefault(x => x.ProductId == cartitem.Id);
                    if (colleagueDiscount != null)
                        cartitem.DiscountRate = colleagueDiscount.DiscountRate;
                }
                else
                {
                    var customerDiscount = customerDiscounts.FirstOrDefault(x => x.ProductId == cartitem.Id);
                    if (customerDiscount != null)
                        cartitem.DiscountRate = customerDiscount.DiscountRate;
                }

                cartitem.DiscountAmount = ((cartitem.TotalItemPrice * cartitem.DiscountRate) / 100);
                cartitem.ItemPayAmount = cartitem.TotalItemPrice - cartitem.DiscountAmount;

                cart.Add(cartitem);

            }


            return cart;
        }
    }
}
