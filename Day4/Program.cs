



//Example of Implicit Casting: Smaller - Bigger
// int num = 5;
// double myNumber = num;
// Console.WriteLine(myNumber);

//This will work because it's automatic and also double can accept int.

//Example of Explicit Casting: Bigger - Smaller
// double num = 5.8;
// int myNumber = (int)num;
// Console.WriteLine(myNumber);

//This will also work but it won't give the actual number, it will remove the .8 because int can't store decimal number or larger number than it's precision.

//String to number when using UserInput
// string ageText = Console.ReadLine()!;
// int age = int.Parse(ageText);

//OR
// int age = int.Parse(Console.ReadLine()!);
//This is also type cating and it will work cause you are converting string to int, by using the .Parse keyword.

//Write a program that:
//Decalres double price = 19.75
//Converts it to int
//Prints both values

double price = 19.75;
int priceInt = (int) price;
Console.WriteLine($"Price as double is: {price}");
Console.WriteLine($"Price as int is: {priceInt}");

//Ask user for a number (string input)
//Convert it to int
//Multiply it by 5
//Print result

Console.WriteLine("Enter a number: ");
int num = int.Parse(Console.ReadLine()!);
int result = num * 5;
Console.WriteLine($"The result of multiplying {num} by 5 is: {result}");

//Another example of Explicit Casting
double x = 9.9;
int y = (int)x;
Console.WriteLine(y);


//To make changes to the code so that i will be able to push to its right folder in my repo.
Console.WriteLine("Learning Type Casting in C#!");