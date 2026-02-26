

int number = 10;

if (number > 15)
{
    Console.WriteLine("A");
}
else if (number > 5)
{
    Console.WriteLine("B");
}
else
{
    Console.WriteLine("C");
}

Console.Write("Input your number: ");
int userNumber = int.Parse(Console.ReadLine()!);

if (userNumber % 2 == 0)
{
    Console.WriteLine($"Even number: {userNumber}");
}
else
{
    Console.WriteLine($"Odd number: {userNumber}");
}

Console.Write("Input your age: ");
int age = int.Parse(Console.ReadLine()!);

if (age >= 18)
{
    Console.WriteLine("You are eligible to vote");
}
else
{
    Console.WriteLine("You are not eligible to vote");
}

Console.Write("Enter your userName: ");
string userName = Console.ReadLine()!;

Console.Write("Input your password: ");
string password = Console.ReadLine()!;

if (userName == "Admin" && password == "1234")
{
    Console.WriteLine("Access granted");
}
else
{
    Console.WriteLine("Access denied");
}

Console.Write("Input your score: ");
int score = int.Parse(Console.ReadLine()!);

if (score >= 80)
{
    Console.WriteLine("Excellent");
}
else if (score == 60-79)
{
    Console.WriteLine("Very good");
}
else if (score == 50-59)
{
    Console.WriteLine("Good");
}
else if (score < 50)
{
    Console.WriteLine("Fail");
}