namespace FureShopping.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProductTypeId { get; set; }
        public int Score { get; set; }
        public int Price { get; set; }
    }
}
