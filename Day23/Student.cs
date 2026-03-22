
class Student
{
    public string? name;
    public int score;

    public void CheckResult()
    {
        Console.WriteLine($"{name} scored {score}");
        if (score >= 50)
        {
            Console.WriteLine($"{name} has passed.");
        }
        else        
        {
            Console.WriteLine($"{name} has failed.");
        }
    }
}