
class Students
{
    public string[] names = {"Raheemah", "Azeemah", "Shefiah", "Roqeebah", "Layla"};
    public int[] scores = {70, 50, 89, 45, 60};

    public void CheckResult()
    {
        for (int i = 0; i < names.Length; i++)
        {
            if (scores[i] >= 50)
            {
                Console.WriteLine($"{names[i]}: Pass");
            }
            else
            {
                Console.WriteLine($"{names[i]}: Fail");
            }
        }
    }
}