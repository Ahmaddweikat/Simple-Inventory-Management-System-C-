namespace SimpleInventory.UI
{
    public class InputHandler
    {
        private string userInput = string.Empty;

        public int getUserInput()
        {
            Console.Write("Please enter your choice: ");
            userInput = Console.ReadLine() ?? string.Empty;

            if (int.TryParse(userInput, out int choice))
            {
                return choice;
            }

            Console.WriteLine("Invalid input. Please enter a valid number.");
            return getUserInput();
        }

        public string getProductName()
        {
            Console.Write("Enter product name: ");
            return Console.ReadLine() ?? string.Empty;
        }

        public double getProductPrice()
        {
            Console.Write("Enter product price: ");
            userInput = Console.ReadLine() ?? string.Empty;

            if (double.TryParse(userInput, out double price))
            {
                return price;
            }

            Console.WriteLine("Invalid input. Please enter a valid price.");
            return getProductPrice();
        }

        public int getProductQuantity()
        {
            Console.Write("Enter product quantity: ");
            userInput = Console.ReadLine() ?? string.Empty;

            if (int.TryParse(userInput, out int quantity))
            {
                return quantity;
            }

            Console.WriteLine("Invalid input. Please enter a valid quantity.");
            return getProductQuantity();
        }
    }
}