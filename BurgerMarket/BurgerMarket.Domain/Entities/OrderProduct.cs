namespace BurgerMarket.Domain.Entities
{
    public class OrderProduct
    {
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        
        public Order Order { get; set; }
        public BaseProduct Product { get; set; }
    }
}