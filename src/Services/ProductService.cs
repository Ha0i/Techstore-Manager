namespace TechStore.Services
{
    public class ProductService
    {
        public bool ValidatePrice(decimal price) => price > 0;
        public bool ValidateQuantity(int quantity) => quantity >= 0;
    }
}
