
//Return Values
static int MyMethod(int x)
{
    return 5 + x;
}
Console.WriteLine(MyMethod(3));

static int MiMethod(int x, int y)
{
    return x + y;
}
int z = MiMethod(5, 3);
Console.WriteLine(z);

static int Square(int number)
{
    return number * number;
}
Console.WriteLine(Square(5));

static int Add(int a, int b)
{
    return a + b;
}
Console.WriteLine("Sum is " + Add(5, 3));


static int FindMax(int a, int b)
{
    if (a > b)
    {
        return a;
    }
    else
    {
        return b;
    }
}
Console.WriteLine(FindMax(10, 7));

static bool IsEven(int number)
{
    return number % 2 == 0;
}
Console.WriteLine(IsEven(8));

//Named Arguments
static void StudentBio()
{
    StudentInfo(name: "Henny", age: 17);
}

static void StudentInfo(string name, int age)
{
    Console.WriteLine(name + " is " + age + " years old ");
}
StudentBio();

static void ShowInfo(string city, int year)
{
    Console.WriteLine(city + " " + year);
}
ShowInfo(year: 2024, city: "Lagos");

static void BookInfo(string title, string author, int year)
{
    Console.WriteLine(title + " " + author + " " + year);
}
BookInfo(title: "Pathway to success", author: "Eugene Onyibo", year: 2010);

//Method Overloading
class Method
{
    static void Main()
    {
        Console.WriteLine(Multiply(2, 3));
        Console.WriteLine(Multiply(5, 4, 5));
        Console.WriteLine(PrintNumber(60));
        Console.WriteLine(PrintNumber(14.3));
        Console.WriteLine(Area(5));
        Console.WriteLine(Area(4, 5));
        Console.WriteLine(Power(5));
        Console.WriteLine(Power(2, 3));
    }
    static int Multiply(int a, int b)
    {
        return a * b;
    }

    static int Multiply(int a, int b, int c)
    {
        return a * b * c;
    }

    static int PrintNumber(int num)
    {
        return num;
    }

    static double PrintNumber(double num)
    {
        return num;
    }

    static int Area(int side)
    {
        return side * side;
    }

    static int Area(int length, int width)
    {
        return length * width;
    }

    static int Power(int number)
    {
        return number;
    }

    static double Power(int number, int exponent)
    {
        return Math.Pow(number, exponent);
    }
}
