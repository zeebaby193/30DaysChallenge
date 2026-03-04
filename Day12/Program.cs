
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
foreach (string i in cars)
{
    Console.WriteLine(i);
}

string[] fruits = {"Apple", "Banana", "Mango"};
foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}

for (int i = 0; i < fruits.Length; i++)
{
    Console.WriteLine(fruits[i]);
}

int[] scores = new int[3];

for (int i = 0; i < scores.Length; i++)
{
    Console.Write("Enter score: ");
    scores[i] = int.Parse(Console.ReadLine()!);
}

int total = 0;

foreach (int score in scores)
{
    total += score;
}

Console.WriteLine("Total: " + total);

int[] numbers = {21, 34, 56, 78, 17};

foreach (int number in numbers)
{
    Console.WriteLine(number);
}

int addNumbers = 0;

foreach (int number in numbers)
{
    addNumbers += number;
}
Console.WriteLine("Addnumbers: " + addNumbers);

string[] studentNames = {"Aliyah", "Taofeeqah", "Khaleelah", "Saheerah", "Laylah"};
foreach (string i in studentNames)
{
    Console.WriteLine("Hello" + " " + i);
}

Console.Write("How many numbers do you want to enter? ");
int count = int.Parse(Console.ReadLine()!);
int[] userNumbers = new int[count];

for (int i = 0; i < count; i++)
{
    Console.Write("Enter number: ");
    userNumbers[i] = int.Parse(Console.ReadLine()!);
}

int highest = userNumbers[0];
int lowest = userNumbers[0];
int totalNumbers = 0;

foreach (int number in userNumbers)
{
    if (number > highest)
    {
        highest = number;
    }
    if (number < lowest)
    {
        lowest = number;
    }
    totalNumbers += number;
}
Console.WriteLine("Highest: " + highest);
Console.WriteLine("Lowest: " + lowest);
Console.WriteLine("Total: " + totalNumbers);
Console.WriteLine("Average: " + (double)totalNumbers / count);