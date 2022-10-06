using KnowledgeCheck1_Calculator;

Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

var input = Console.ReadLine();
var calculator = new Calculator();

switch (input)
{
    case "1":
        var success = ErrorMessage.UserNumbers("add", out int num1, out int num2);

        if (success == true)
        {
            Console.Write($"{num1} + {num2} = ");
            Console.Write(calculator.Add(num1, num2));        
        }
        break;

    case "2":
        Console.WriteLine("Enter 2 integers to subtract");
        var subtractNumber1 = Console.ReadLine();
        var subtractNumber2 = Console.ReadLine();

        if (int.TryParse(subtractNumber1, out int subNumOne) && int.TryParse(subtractNumber2, out int subNumTwo))
        {
            Console.Write($"{subtractNumber1} - {subtractNumber2} = ");
            Console.Write(calculator.Subtract(subNumOne, subNumTwo));
        }
        else
        {
            ErrorMessage.PrintError();
        }
        break;

    case "3":
        Console.WriteLine("Enter 2 integers to multiply");
        var multiplyNumber1 = Console.ReadLine();
        var multiplyNumber2 = Console.ReadLine();

        if (int.TryParse(multiplyNumber1, out int multNumOne) && int.TryParse(multiplyNumber2, out int multNumTwo))
        {
            Console.Write($"{multiplyNumber1} * {multiplyNumber2} = ");
            Console.Write(calculator.Multiply(multNumOne, multNumTwo));
        }
        else
        {
            ErrorMessage.PrintError();
        }
        break;

    case "4":
        Console.WriteLine("Enter 2 integers to divide");
        var divideNumber1 = Console.ReadLine();
        var divideNumber2 = Console.ReadLine();

        if (double.TryParse(divideNumber1, out double divNumOne) && double.TryParse(divideNumber2, out double divNumTwo))
        {
            Console.Write($"{divideNumber1} / {divideNumber2} = ");
            Console.Write(calculator.Divide(divNumOne, divNumTwo));
        }
        else
        {
            ErrorMessage.PrintError();
        }
        break;

    default:
        Console.WriteLine("Unknown input");
        break;
}
