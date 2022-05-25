

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
        case 1: AddNumbers();
            break;
        case 2: MultiplicationTable();
            break;
        case 3: break;
        case 4: break;
        case 5: break;
            default: Console.WriteLine("\n\nInvalid menu choice. Try again\n\n");
            break;
    }
}

// method for Q1
static void AddNumbers()
{
    Console.WriteLine("----- Adding numbers -----");
    Console.Write("Enter the first number: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("enter the second number: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
}

// method for Q2
static void MultiplicationTable()
{
    Console.WriteLine("----- Multiplying numbers -----");
    Console.Write("Enter in the number you want to multiply: ");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter in the number in which you want to stop multiplying by: ");
    int max = Convert.ToInt32(Console.ReadLine());

    for(int i = 0; i <= max; i++)
    {
        int ans = i * num;
        Console.WriteLine(num.ToString() + " * " + i + " = " + ans.ToString());
    }
}