

//Simple Menu
using System.Collections;

Console.Write("Input number (1-4): ");
int numbers = int.Parse(Console.ReadLine()!);

switch (numbers)
{
    case 1:
    Console.WriteLine("Start Game");
    break;

    case 2:
    Console.WriteLine("Load Game");
    break;

    case 3:
    Console.WriteLine("Settings");
    break;

    case 4:
    Console.WriteLine("Exit");
    break;

    default:
    Console.WriteLine("Invalid Option");
    break;
}

//Grade Checker
Console.Write("Enter your grade letter (A, B, C, D, F): ");
string letter = Console.ReadLine()!;

switch (letter)
{
    case "A":
    Console.WriteLine("Excellent");
    break;

    case "B":
    Console.WriteLine("Very Good");
    break;

    case "C":
    Console.WriteLine("Good");
    break;

    case "D":
    Console.WriteLine("Pass");
    break;

    case "F":
    Console.WriteLine("Fail");
    break;
}

//Mini Calculator
Console.Write("Input your firstNumber: ");
int firstNumber = int.Parse(Console.ReadLine()!);

Console.Write("Input your Operator (+, -, *, /): ");
string Operator = Console.ReadLine()!;

Console.Write("Input your secondNumber: ");
int secondNumber = int.Parse(Console.ReadLine()!);

switch (Operator)
{
    case "+":
    Console.WriteLine("Result: " + (firstNumber + secondNumber));
    break;

    case "-":
    Console.WriteLine("Result: " + (firstNumber - secondNumber));
    break;

    case "*":
    Console.WriteLine("Result: " + (firstNumber * secondNumber));
    break;

    case "/":
    if (secondNumber == 0)
        {
            Console.WriteLine("Cannot divide by zero");
        }
    else
        {
            Console.WriteLine("Result: " + (firstNumber / secondNumber));
        }
    break;

    default:
    Console.WriteLine("Invalid Operator");
    break;
   
}
   
