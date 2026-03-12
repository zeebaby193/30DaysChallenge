
class Book
{
    public string? title;
    public string? author;
    public int year;

    public void ShowBook()
    {
        Console.WriteLine($"{title}, by {author}, {year}");
    }
}