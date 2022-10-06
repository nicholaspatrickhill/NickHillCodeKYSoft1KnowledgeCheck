using KnowledgeCheck1_Calculator;

Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division.");

var input = Console.ReadLine();
var calculator = new Calculator();

switch (input)
{
    case "1":
        var success = CalculatorFunctions.UserNumbers("add", out int num1, out int num2);
        if (success == true)
        {
            Console.Write($"{num1} + {num2} = ");
            Console.Write(calculator.Add(num1, num2));        
        }
        break;

    case "2":
        success = CalculatorFunctions.UserNumbers("subtract", out int subnum1, out int subnum2);
        if (success == true)
        {
            Console.Write($"{subnum1} - {subnum2} = ");
            Console.Write(calculator.Subtract(subnum1, subnum2));
        }
        break;

    case "3":
        success = CalculatorFunctions.UserNumbers("multiply", out int multnum1, out int multnum2);
        if (success == true)
        {
            Console.Write($"{multnum1} * {multnum2} = ");
            Console.Write(calculator.Multiply(multnum1, multnum2));
        }
        break;

    case "4":
        success = CalculatorFunctions.UserNumbers("divide", out int divnum1, out int divnum2);
        if (success == true)
        {
            Console.Write($"{divnum1} / {divnum2} = ");
            Console.Write(calculator.Divide(divnum1, divnum2));
        }
        break;

    default:
        Console.WriteLine("Unknown input.");
        break;
}
