using System.Text;

while (true)
{
    StringBuilder promptBuilder = new StringBuilder()
        .Append("Enter the operation sign.").AppendLine()
        .Append('\t').Append("( + ) for an addition operation").AppendLine()
        .Append('\t').Append("( - ) for a subtract operation").AppendLine()
        .Append('\t').Append("( * ) for a multiblication operation").AppendLine()
        .Append('\t').Append("( / ) for a division operation").AppendLine()
        .Append('\t').Append("( q ) to quit").AppendLine()
        .Append(" > ");

    Console.Write(promptBuilder.ToString());

    ConsoleKeyInfo key = Console.ReadKey();
    Console.WriteLine();
    if (key.Key == ConsoleKey.Q)
    {
        break;
    }

    if (key.Key == ConsoleKey.Add)
    {
        Console.Write("Enter the first number > ");
        string? firstNumber = Console.ReadLine();
        if (!double.TryParse(firstNumber, out double fNumber))
        {
            Console.WriteLine("Invalid Input");
            continue;
        }

        Console.Write("Enter the second number > ");
        string? secondNumber = Console.ReadLine();
        if (!double.TryParse(secondNumber, out double sNumber))
        {
            Console.WriteLine("Invalid Input");
            continue;
        }

        Console.WriteLine($"The result: {fNumber + sNumber}");
    }
    else if (key.Key == ConsoleKey.Subtract)
    {

        Console.Write("Enter the first number > ");
        string? firstNumber = Console.ReadLine();
        if (!double.TryParse(firstNumber, out double fNumber))
        {
            Console.WriteLine("Invalid Input");
            continue;
        }

        Console.Write("Enter the second number > ");
        string? secondNumber = Console.ReadLine();
        if (!double.TryParse(secondNumber, out double sNumber))
        {
            Console.WriteLine("Invalid Input");
            continue;
        }

        Console.WriteLine($"The result: {fNumber - sNumber}");
    }
    else if (key.Key == ConsoleKey.Multiply)
    {

        Console.Write("Enter the first number > ");
        string? firstNumber = Console.ReadLine();
        if (!double.TryParse(firstNumber, out double fNumber))
        {
            Console.WriteLine("Invalid Input");
            continue;
        }

        Console.Write("Enter the second number > ");
        string? secondNumber = Console.ReadLine();
        if (!double.TryParse(secondNumber, out double sNumber))
        {
            Console.WriteLine("Invalid Input");
            continue;
        }

        Console.WriteLine($"The result: {fNumber * sNumber}");
    }
    else if (key.Key == ConsoleKey.Divide)
    {

        Console.Write("Enter the first number > ");
        string? firstNumber = Console.ReadLine();
        if (!double.TryParse(firstNumber, out double fNumber))
        {
            Console.WriteLine("Invalid Input");
            continue;
        }

        Console.Write("Enter the second number > ");
        string? secondNumber = Console.ReadLine();
        if (!double.TryParse(secondNumber, out double sNumber))
        {
            Console.WriteLine("Invalid Input");
            continue;
        }

        if (sNumber == 0)
        {
            Console.WriteLine("Cannot divide by zero");
            continue;
        }

        Console.WriteLine($"The result: {fNumber / sNumber}");
    }
    else
    {
        Console.WriteLine("Invalid operation");
    }
}