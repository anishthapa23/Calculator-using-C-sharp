Console.Write("Simple Two Number Arithmetic Calculator ");
Thread.Sleep(1000);
Console.Write(".");
Thread.Sleep(1000);
Console.Write(".");
Thread.Sleep(1000);
Console.Write(".");

more:
Console.WriteLine("\nEnter First Number: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter Second Number: ");
double num2 = Convert.ToDouble(Console.ReadLine());

here:
Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Division");
Console.WriteLine("4. Multiplication");
Console.WriteLine("5. Exit");
double select = Convert.ToInt32(Console.ReadLine());

switch (select)
{
    case 1:
        double sum = num1 + num2;
        Console.WriteLine("Addition: " + sum);
        break;
    case 2:
        double diff = num1 - num2;
        Console.WriteLine("Subtraction: " + diff);
        break;
    case 3:
        double div = num1 / num2;
        Console.WriteLine("Division: " + div);
        break;
    case 4:
        double mul = num1 * num2;
        Console.WriteLine("Multiplication: " + mul);
        break;
    case 5:
        Console.WriteLine("Thanks for visiting!");
        Environment.Exit(0);
        break;

}
        if (select < 1 || select > 5)
        {
            Console.WriteLine("Please enter between 1 & 5.");
            goto here;
        }
        confirm:
        Console.WriteLine("Do you want more calculations? [Y/N]");
        string? yn = Console.ReadLine() ;
        if(yn == "Y" || yn == "y")
        {
            goto more;
        }
        else if(yn == "N" || yn == "n")
        {
            Console.WriteLine("Thanks for visiting!");
            Environment.Exit(0);
        }
        else{
            Console.WriteLine("Please enter Y/N.");
            goto confirm;
        }
        Console.ReadKey();
