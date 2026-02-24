

Console.Write("Input firstNumber: ");
int firstNumber = int.Parse(Console.ReadLine()!);

Console.Write("Input secondNumber: ");
int secondNumber = int.Parse(Console.ReadLine()!);

Console.WriteLine(firstNumber + secondNumber);
Console.WriteLine(firstNumber - secondNumber);
Console.WriteLine(firstNumber * secondNumber);
Console.WriteLine(firstNumber / secondNumber);



Console.Write("Input a number: ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine(number * number);
Console.WriteLine(number * number * number);



Console.Write("Input total marks: ");
double totalMarks = double.Parse(Console.ReadLine()!);

Console.Write("Input number of subjects: ");
int numberOfSubjects = int.Parse(Console.ReadLine()!);

double averageMarks = totalMarks / numberOfSubjects;
Console.WriteLine($"Average marks: {averageMarks}");




