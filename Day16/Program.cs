
using System.Globalization;

// static void Greet(string name)
// {
//     Console.WriteLine("Hello " + name);
// }
// Greet("Henny");

// static int Add(int a, int b)
// {
//     return a + b;
// }

// int result = Add(5, 3);
// Console.WriteLine(result);

// static void PrintWelcome()
// {
//     Console.WriteLine("Welcome to my Program");
// }
// PrintWelcome();

// static int Multiply(int a, int b)
// {
//     return a * b;
// }
// int output = Multiply(2, 5);
// Console.WriteLine(output);

// static void ShowSquare(int number)
// {
//     Console.WriteLine("Square is: " + number * number);
// }
// ShowSquare(5);

Console.WriteLine("=========Math Helper Program========");

Console.Write("Input first number: ");
int firstNumber = int.Parse(Console.ReadLine()!);

Console.Write("Input second number: ");
int secondNumber = int.Parse(Console.ReadLine()!);

static void AddNumbers(int firstNumber, int secondNumber)
{
    Console.WriteLine("Addition: " + firstNumber + secondNumber);
}
AddNumbers(firstNumber, secondNumber);

static void MultiplyNumbers(int firstNumber, int secondNumber)
{
    Console.WriteLine("Multiplication: " + firstNumber * secondNumber);
}
MultiplyNumbers(firstNumber, secondNumber);

