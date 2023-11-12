﻿namespace ShoppingCart.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public List<CartItem> Items { get; set; } = new List<CartItem>();

    }
}