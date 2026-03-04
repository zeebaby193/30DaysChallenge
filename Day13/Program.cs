
for (int i = 1; i <= 10; i++)
{
    if (i == 5)
    {
        break;
    }
    Console.WriteLine(i);
}

for (int i =1; i <= 5; i++)
{
    if (i == 3)
    {
        continue;
    }
    Console.WriteLine(i);
}

for (int i = 1; i <= 10; i++)
{
    if (i % 2 != 0)
    {
        continue;
    }
    Console.WriteLine(i);
}

for (int i = 1; i <= 6; i++)
{
    if (i == 3)
    {
        continue;
    }
    if (i % 2 == 0)
    {
        break;
    }
    Console.WriteLine(i);
}

for (int i =1; i <= 6; i++)
{
    if (i % 2 == 0)
    {
        continue;
    }
    if (i == 5)
    {
        break;
    }
    Console.WriteLine(i);
}
