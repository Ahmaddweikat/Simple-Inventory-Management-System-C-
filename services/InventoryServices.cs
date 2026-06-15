using SimpleInventory.Models;
using SimpleInventory.UI;

namespace SimpleInventory.Services
{
    public class InventoryServices
    {
        private List<Product> products = new List<Product>();
        private readonly InputHandler _inputHandler = new InputHandler();

        public bool IsProductInStock(string productName)
        {
            foreach (var product in products)
            {
                if (product.Name.Equals(productName, StringComparison.OrdinalIgnoreCase) && product.Quantity > 0)
                {
                    Console.WriteLine($"Product '{productName}' is in stock with quantity: {product.Quantity} try to choose different name");
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public void AddProduct()
        {
            var productName = _inputHandler.getProductName();

            if (!IsProductInStock(productName))
            {
                var productPrice = _inputHandler.getProductPrice();
                var productQuantity = _inputHandler.getProductQuantity();

                products.Add(new Product(productName, productPrice, productQuantity));
            }
        }
    }
}