
static void AddNumber(int a, int b)
{
    Console.WriteLine(a + b);
}
AddNumber(5, 3);

static void StudentInfo(string name, int age)
{
    Console.WriteLine(name + " is " + age + " years old ");
}
StudentInfo("Henny", 16);


GreetUser("Henny");
AddNumbers(4, 6);
static void GreetUser(string name)
{
    Console.WriteLine("Hello " + name);
}

static void AddNumbers(int a, int b)
{
    Console.WriteLine("Sum: " + (a + b));
}

static void PrintNumber(int num)
{
    Console.WriteLine(num);
}
PrintNumber(7);

static void MultiplyNumber(int a, int b)
{
    Console.WriteLine("Product: " + (a * b));
}
MultiplyNumber(4, 5);

static void Student(string name, int score)
{
    Console.WriteLine("StudentInfo: " + ("My name is " + name + " I have: " + score , "mark"));

    if (score >= 50)
    {
        Console.WriteLine("Henny Passed!");
    }
    else
    {
        Console.WriteLine("Henny Failed!");
    }
}
Student("Henny", 40);

static void ShowNumber(int number)
{
    Console.WriteLine(number + 5);
}
ShowNumber(10);

static void CalculateArea(int length, int width)
{
    Console.WriteLine("Area: " + (length * width));
}
CalculateArea(5, 4);

