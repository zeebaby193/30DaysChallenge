
class Student
{
    public string? name;
    public int score;

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