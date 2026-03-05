
// using System;
// using System.Linq;

// namespace MyApplication
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int[] myNumbers = { 5, 1, 8, 9 };
//             Array.Sort(myNumbers);
//             foreach (int i in myNumbers)
//             {
//                 Console.WriteLine(i);
//             }
//             Console.WriteLine(myNumbers.Max());
//             Console.WriteLine(myNumbers.Min());
//             Console.WriteLine(myNumbers.Sum());
//         }
//     }
// }


string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
Array.Sort(cars);
foreach (string i in cars)
{
    Console.WriteLine(i);
}

int[] numbers = { 10, 20, 30, 40 };
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

foreach (int num in numbers)
{
    Console.WriteLine(num);
}

int[] nums = { 2, 4, 6, 8 };
for (int i = 0; i < nums.Length; i++)
{
    Console.WriteLine(nums[i] * 2);
}

int[] scores = { 80, 75, 90, 60 };
int total = 0;

foreach (int score in scores)
{
    total += score;
}

double average = total / scores.Length;

Console.WriteLine("Total: " + total);
Console.WriteLine("Average: " + average);

int[,] num1 = { {1, 4, 2}, {3, 6, 8} };
num1[0, 0] = 5;
Console.WriteLine(num1[0, 0]);

int[,] num2 = { {1, 4, 2}, {3, 6, 8} };
foreach (int i in num2)
{
    Console.WriteLine(i);
}

int[,] figures = { {1, 4, 2}, {3, 6, 8} };
for (int i = 0; i < figures.GetLength(0); i++)
{
    for (int j = 0; j < figures.GetLength(1); j++)
    {
        Console.WriteLine(figures[i, j]);
    }
}


