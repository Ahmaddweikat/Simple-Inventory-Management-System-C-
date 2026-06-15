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

                    default:
                        Console.WriteLine("Invalid choice. Please enter a number from 1 to 6.");
                        break;
                }
            }
        }

    }
}