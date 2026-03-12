
class Student
{
    public string? name;
    public int age;

    public int score;

    public void Introduce()
    {
        Console.WriteLine("Hello my name is " + name);
    }

    public void CheckResult()
    {
        if (score >= 50)
        {
            Console.WriteLine($"{name}: Pass");
        }
        else
        {
            Console.WriteLine($"{name}: Fail");
        }
    }
}