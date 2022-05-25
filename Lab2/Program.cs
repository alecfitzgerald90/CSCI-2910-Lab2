

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
        case 3: DataTypeMemorySize();
            break;
        case 4: calculator();
            break;
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

// method for Q3
static void DataTypeMemorySize()
{
    Console.WriteLine("\n----- Data Type Memory Size -----");
    Console.WriteLine("=============================================");
    Console.WriteLine("Type \t Byte(s) of memory \t Min \t Max");
    Console.WriteLine("=============================================");
    Console.WriteLine("sbyte \t 1 \t\t\t" + sbyte.MinValue + "\t" + sbyte.MaxValue);
    Console.WriteLine("byte \t 1 \t\t\t" + byte.MinValue + "\t" + byte.MaxValue);
    Console.WriteLine("short \t 2 \t\t\t" + short.MinValue + "\t" + short.MaxValue);
    Console.WriteLine("ushort \t 2 \t\t\t" + ushort.MinValue + "\t" + ushort.MaxValue);
    Console.WriteLine("int \t 4 \t\t\t" + int.MinValue + "\t" + int.MaxValue);
    Console.WriteLine("uint \t 4 \t\t\t" + uint.MinValue + "\t" + uint.MaxValue);
    Console.WriteLine("long \t 8 \t\t\t" + long.MinValue + "\t" + long.MaxValue);
    Console.WriteLine("ulong \t 8 \t\t\t" + ulong.MinValue + "\t" + ulong.MaxValue);
    Console.WriteLine("float \t 4 \t\t\t" + float.MinValue + "\t" + float.MaxValue);
    Console.WriteLine("double \t 8 \t\t\t" + double.MinValue + "\t" + double.MaxValue);
    Console.WriteLine("decimal \t 16 \t\t\t" + decimal.MinValue + "\t" + decimal.MaxValue);
}

// method for Q4
static void calculator()
{
    Console.WriteLine("\n----- Calculator -----");
    Console.Write("Enter in an operand: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter in an operator(+,-,*,/,%): ");
    var op = Convert.ToString(Console.ReadLine());
    Console.Write("Enter in another operand: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    if (op == "+")
    {
        int ans = num1 + num2;
        Console.WriteLine(num1.ToString() + "+" + num2.ToString() + "=" + ans);
    }
    else if (op == "-")
    {
        int ans = num1 - num2;
        Console.WriteLine(num1.ToString() + "-" + num2.ToString() + "=" + ans);
    }
    else if (op == "*")
    {
        int ans = num1 * num2;
        Console.WriteLine(num1.ToString() + "*" + num2.ToString() + "=" + ans);
    }
    else if (op == "/")
    {
        int ans = num1 / num2;
        Console.WriteLine(num1.ToString() + "/" + num2.ToString() + "=" + ans);
    }
    else if (op == "%")
    {
        int ans = num1 % num2;
        Console.WriteLine(num1.ToString() + "%" + num2.ToString() + "=" + ans);
    }
    else
    {
        Console.WriteLine("You must have messed up on your operator");
    }

    Console.WriteLine("Would you like to run another operation?(y/n): ");
    var choice = Convert.ToString(Console.ReadLine());
    if (choice == "y" || choice == "yes")
    {
        Console.Clear();
        calculator();
    }
    else
    {
        Console.Clear();
        return;
    }




}

