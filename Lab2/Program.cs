

Console.WriteLine("\n\n*****Lab2*****\n\n");

int choice = 0;
do
{
    MainMenu();
    Console.Write("Enter in your choice here: ");
    choice = Convert.ToInt32(Console.ReadLine());
    MenuOption(choice);
} while (choice != 5);

Console.Clear();
Console.WriteLine("Thanks for using my program");


static void MainMenu()
{
    Console.WriteLine("----- Menu -----");
    Console.WriteLine("1. Add two numbers");
    Console.WriteLine("2. Multiplication table");
    Console.WriteLine("3. Memory size of data types");
    Console.WriteLine("4. Five-function calculator");
    Console.WriteLine("5. Exit");
}


static void MenuOption(int option)
{
    switch (option)
    {
        case 1: break;
        case 2: break;
        case 3: break;
        case 4: break;
        case 5: break;
            default: Console.WriteLine("\n\nInvalid menu choice. Try again\n\n");
            break;
    }
}