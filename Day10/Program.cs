
// int i = 1;
// while (i <= 10)
// {
//     Console.WriteLine(i);
//     i++;
// }

// int m = 2;
// while (m <= 20)
// {
//     Console.WriteLine(m);
//     m += 2;
// }

// int secretNumber = 7;
// int userGuess = 0;
// while (userGuess != secretNumber)
// {
//     Console.Write("Guess the secret number: ");
//     userGuess = int.Parse(Console.ReadLine()!); 
// }
// Console.WriteLine("Correct!");  

int counter = 0;
while (counter <= 9)
{
    Console.WriteLine("Number: " + counter);
    counter++;
}

Console.Write("n = ");
int n = int.Parse(Console.ReadLine()!);
int num = 1;
int sum = 1;
Console.Write("The sum 1");
while (num < n)
{
    num++;
    sum += num;
    Console.Write(" + " + num);
}
Console.WriteLine(" = " + sum);

Console.Write("Enter a positive number: ");
int number = int.Parse(Console.ReadLine()!);

int divider = 2;
int maxDivider = (int)Math.Sqrt(num);
bool prime = true;
while (prime && (divider <= maxDivider))
{
    if (num % divider == 0)
    {
        prime = false;
    }
    divider++;
}
Console.WriteLine("Prime? " + prime);


