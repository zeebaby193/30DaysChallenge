
class Program
{
    static void Main()
    {
        Student s1 = new Student();

        s1.name = "Henny";
        s1.age = 16;
        s1.score = 37;

        s1.Introduce();
        s1.CheckResult();

        Car car = new Car();

        car.brand = "Volvo";
        car.year = 2020;

        car.ShowCar();

        Book book = new Book();

        book.title = "Pathway to success";
        book.author = "Eugene C. Onyibo";
        book.year = 2010;

        book.ShowBook();
    }
}


