
// try
// {
//     int num = int.Parse(Console.ReadLine()!);
//     Console.WriteLine("Number: " + num);
// }
// catch
// {
//     Console.WriteLine("Invalid input!");
// }

// try
// {
//     Console.Write("Enter number: ");
//     int number = int.Parse(Console.ReadLine()!);

//     Console.WriteLine(number * 2);
// }
// catch
// {
//     Console.WriteLine("Please enter a valid number.");
// }

try
{
    Console.WriteLine("=======Wlecome to Division App=========");

    Console.Write("Input firstNumber: ");
    int firstNumber = int.Parse(Console.ReadLine()!);

    Console.Write("Input secondNumber: ");
    int secondNumber = int.Parse(Console.ReadLine()!);

    Console.WriteLine(firstNumber / secondNumber);
}
catch (FormatException)
{
    Console.WriteLine("Invalid input! Please enter a valid number");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Sorry..... Cannot divide number by zero!");
}



