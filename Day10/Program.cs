
int i = 1;
while (i <= 10)
{
    Console.WriteLine(i);
    i++;
}

int m = 2;
while (m <= 20)
{
    Console.WriteLine(m);
    m += 2;
}

int secretNumber = 7;
int userGuess = 0;
while (userGuess != secretNumber)
{
    Console.Write("Guess the secret number: ");
    userGuess = int.Parse(Console.ReadLine()!); 
}
Console.WriteLine("Correct!");  



