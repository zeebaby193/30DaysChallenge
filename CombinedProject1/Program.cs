
bool continueProgram = true;

while (continueProgram)
{
    Console.WriteLine("=========Welcome to Henny Student Result System!==========");

    Console.Write("Enter student name: ");
    string studentName = Console.ReadLine()!;

    Console.Write("Enter number of subjects: ");
    int numberOfSubjects = int.Parse(Console.ReadLine()!);

    double totalScore = 0;

    for (int i = 1; i <= numberOfSubjects; i++)
    {
        double score;
        while (true)
        {
            Console.Write($"Enter score for subject {i}: ");
            if (double.TryParse(Console.ReadLine(), out score) && score >= 0 && score <= 100)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a score between 0 and 100.");
            }
        }
        totalScore += score;
    }

    double averageScore = totalScore / numberOfSubjects;

    string grade;
    bool isPass;

    if (averageScore >= 90)
    {
        grade = "A";
        isPass = true;
    }
    else if (averageScore >= 80)
    {
        grade = "B";
        isPass = true;
    }
    else if (averageScore >= 70)
    {
        grade = "C";
        isPass = true;
    }
    else if (averageScore >= 60)
    {
        grade = "D";
        isPass = true;
    }
    else if (averageScore >= 50)
    {
        grade = "E";
        isPass = true;
    }
    else
    {
        grade = "F";
        isPass = false;
    }

    string remarks;

    switch (grade)
    {
        case "A":
            remarks = "Excellent Performance! Keep Shinning.";
            break;
        case "B":
            remarks = "Briilliant! You can do better.";
            break;
        case "C":
            remarks = "Average! You are making progress.";
            break;
        case "D":
            remarks = "Below Average! More effort is needed.";
            break;
        case "E":
            remarks = "Poor! You need to buckle up.";
            break;
        default:
            remarks = "Fail! Don't give up, try harder next time.";
            break;
    }

    Console.WriteLine("\n=========Result Sheet==========");
    Console.WriteLine($"Student Name: {studentName}");
    Console.WriteLine($"Total Score: {totalScore}");
    Console.WriteLine($"Average Score: {averageScore:F2}");
    Console.WriteLine($"Grade: {grade}");
    Console.WriteLine($"Status: {(isPass ? "Pass" : "Fail")}");
    Console.WriteLine($"Remarks: {remarks}");

    Console.Write("\nDo you want to enter another student's result? (yes/no): ");
    string userChoice = Console.ReadLine()!.ToLower();

    if (userChoice != "yes")
    {
        continueProgram = false;
    }
    Console.WriteLine();
}
Console.WriteLine("========Thanks for visiting our Application!========");




