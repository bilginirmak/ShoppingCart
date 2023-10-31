namespace ShoppingCart.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public List<Item> Items { get; set; }


    }
}
