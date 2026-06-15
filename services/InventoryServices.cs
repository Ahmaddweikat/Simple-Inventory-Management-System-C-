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

        public List<Product> DisplayProducts()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("No products in inventory.");
                return new List<Product>();
            }
            else
            {
                foreach (var product in products)
                {
                    Console.WriteLine($"Product name: {product.Name}, Price: {product.Price}$, Quantity: {product.Quantity}");
                }
            }
            return products;
        }

        public void EditProduct(string productName)
        {
            if (!IsProductInStock(productName))
            {
                Console.WriteLine($"Product '{productName}' not found in inventory.");
                return;
            }
            else
            {
                var product = products.FirstOrDefault(p => p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));

                if (product != null)
                {
                    bool editing = true;

                    while (editing)
                    {
                        Menu.DisplayEditMenu();
                        var choice = _inputHandler.getUserInput();

                        switch (choice)
                        {
                            case 1:
                                var newName = _inputHandler.getProductName();
                                product.Name = newName;
                                break;

                            case 2:
                                var newPrice = _inputHandler.getProductPrice();
                                product.Price = newPrice;
                                break;

                            case 3:
                                var newQuantity = _inputHandler.getProductQuantity();
                                product.Quantity = newQuantity;
                                break;

                            case 4:
                                editing = false;
                                break;

                            default:
                                Console.WriteLine("Invalid choice. Please enter a number from 1 to 4.");
                                break;
                        }
                    }
                }
            }
        }

        public void RemoveProduct(string productName)
        {
            var product = products.FirstOrDefault(p => p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));

            if (product != null)
            {
                products.Remove(product);
                Console.WriteLine($"Product '{productName}' has been removed from inventory.");
            }
            else
            {
                Console.WriteLine($"Product '{productName}' not found in inventory.");
            }
        }

        public List<Product> SearchProducts(string productName)
        {
            return products.Where(p => p.Name.Contains(productName, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}