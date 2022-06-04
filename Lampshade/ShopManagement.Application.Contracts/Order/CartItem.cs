﻿namespace ShopManagement.Application.Contracts.Order
{
    public class CartItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public int Count { get; set; }
        public string Picture { get; set; }
        public double TotalItemPrice { get; set; }
        public bool IsInStock { get; set; }
        public int DiscountRate { get; set; }
        public double DiscountAmount { get; set; }
        public double ItemPayAmount { get; set; }


        public CartItem()
        {
            TotalItemPrice = Count * UnitPrice;
        }

        public void CalculateTotalItemPrice()
        {
            TotalItemPrice = Count * UnitPrice;
        }
    }
}
