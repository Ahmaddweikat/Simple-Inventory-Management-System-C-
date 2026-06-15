using SimpleInventory.Services;
using SimpleInventory.UI;

namespace SimpleInventory
{
    public class App
    {
        private readonly InventoryServices _inventory = new InventoryServices();
        private readonly InputHandler _inputHandler = new InputHandler();

        public void Run()
        {
            bool running = true;

            while (running)
            {
                Menu.Display();

                var choice = _inputHandler.getUserInput();


                switch (choice)
                {
                    case 1:
                        _inventory.AddProduct();
                        break;

                    case 2:
                        var products = _inventory.DisplayProducts();
                        break;

                    case 3:
                        var productName = _inputHandler.getProductName();
                        _inventory.EditProduct(productName);
                        break;

                    case 4:
                        var deleteProductName = _inputHandler.getProductName();
                        _inventory.RemoveProduct(deleteProductName);
                        break;

                    case 5:
                        var searchQuery = _inputHandler.getProductName();
                        var searchResults = _inventory.SearchProducts(searchQuery);
                        if (searchResults.Count > 0)
                        {
                            Console.WriteLine("Search results:");
                            foreach (var product in searchResults)
                            {
                                Console.WriteLine($"Product name: {product.Name}, Price: {product.Price}$, Quantity: {product.Quantity}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No products found matching the search query.");
                        }
                        break;

                    case 6:
                        Console.WriteLine("Exiting the application. Goodbye!");
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a number from 1 to 6.");
                        break;
                }
            }
        }

    }
}