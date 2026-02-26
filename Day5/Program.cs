

//User Input
// //Example of user input. This program collect student information.
// Console.WriteLine("Enter your name: ");
// string name = Console.ReadLine()!;

// Console.WriteLine("Enter your age: ");
// int age = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Enter your height: ");
// double height = double.Parse(Console.ReadLine()!);

// Console.WriteLine("Hello " + name);
// Console.WriteLine("Next year you will be " + (age + 1));
// Console.WriteLine("Your height is " + height);

//Challenge 1
//Create a program that:
//Ask for your name
//Ask for your favourite number
//Multiplies the number by 3
//Print the result

// Console.WriteLine("Input your name: ");
// string name = Console.ReadLine()!;

// Console.WriteLine("Input your favorite number: ");
// int number = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Your name is " + name);
// Console.WriteLine("Your favorite number is " + (number * 3));

//Challenge 2
// Ask the user for length and width.
// Calculate the area of a rectangle and print the result.

// Console.WriteLine("Insert your length: ");
// double length = double.Parse(Console.ReadLine()!);

// Console.WriteLine("Input your width: ");
// double width = double.Parse(Console.ReadLine()!);

// Console.WriteLine("The area of the rectangle is " + (length * width));

//Challenge 3
//Ask the user for first number and second number.
//Calculate the sum, differnece and product of the numbers and print the result.

Console.WriteLine("Input your first number: ");
int firstNumber = int.Parse(Console.ReadLine()!);

Console.WriteLine("Input your second number: ");
int secondNumber = int.Parse(Console.ReadLine()!);

Console.WriteLine("The sum of the numbers is " + (firstNumber + secondNumber));
Console.WriteLine("The difference of the numbers is " + (firstNumber - secondNumber));
Console.WriteLine("The product of the numbers is " + (firstNumber * secondNumber));

//Challenge 4: Even and Odd Checker
//Ask the user for a number.
//Print the number is even or odd.
//Hint use % operator.

Console.WriteLine("Input a number: ");
int number = int.Parse(Console.ReadLine()!);

if (number % 2 == 0)
{
    Console.WriteLine("The number is even.");
}
else
{
    Console.WriteLine("The number is odd.");
}

//Challenge 5: Rectangle Area
//Ask the user for length and width of a rectangle.
//Calculate the area and perimeter of the rectangle and print the result.

Console.WriteLine("Input the length of the rectangle: ");
double length = double.Parse(Console.ReadLine()!);

Console.WriteLine("Input the width of the rectangle: ");
double width = double.Parse(Console.ReadLine()!);

double area = length * width;
double perimeter = 2 * (length + width);

Console.WriteLine("The area of the rectangle is " + area);
Console.WriteLine("The perimeter of the rectangle is " + perimeter);

//Challenge 6: Student results analyzer
//Ask for:
//Student name
//Score (0-100)
//Then print:
//if score >= 50 - "pass".
//if score < 50 - "fail".

Console.WriteLine("Input student name: ");
string studentName = Console.ReadLine()!;

Console.WriteLine("Input student score (0-100): ");
int score = int.Parse(Console.ReadLine()!);

if (score >= 50)
{
    Console.WriteLine(studentName + " has passed.");
}
else
{
    Console.WriteLine(studentName + " has failed.");
}


//FIZZBUZZ Challenge

Console.Write("Input number (1-10): ");
int N = int.Parse(Console.ReadLine()!);

if (N > 10 || N < 1)
{
    Console.WriteLine("Error: Check the number option again");
}
else
{
    for (int i = 1; i <= N; i++)
    {
        if (i % 2 == 0 && i % 3 == 0)
        {
            Console.WriteLine("FIZZBUZZ");
        }
        else if (i % 2 == 0)
        {
            Console.WriteLine("FIZZ");
        }
        else if (i % 3 == 0)
        {
            Console.WriteLine("BUZZ");
        }
        else
        {
            Console.WriteLine(i);
        }
    }
}









