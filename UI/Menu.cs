namespace SimpleInventory.UI
{
    public class Menu
    {
        public static void Display()
        {
            Console.WriteLine("Welcome to the Simple Inventory Management System!");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Display Products");
            Console.WriteLine("3. Edit Product");
            Console.WriteLine("4. Exit");
        }

        public static void DisplayEditMenu()
        {
            Console.WriteLine("Edit Product Menu:");
            Console.WriteLine("1. Edit Name");
            Console.WriteLine("2. Edit Price");
            Console.WriteLine("3. Edit Quantity");
            Console.WriteLine("4. Back to Main Menu");
        }
    }
}