
class Program
{
    static void Main()
    {
        Student[] students = new Student[3];

        students[0] = new Student();
        students[1] = new Student();
        students[2] = new Student();

        students[0].name = "Henny";
        students[0].score = 70;

        students[1].name = "Rashmin";
        students[1].score = 50;

        students[2].name = "Zainab";
        students[2].score = 89;

        foreach (Student student in students)
        {
            student.CheckResult();
        }

        Car car1 = new Car();

        car1.brand = "Volvo";
        car1.year = 2010;

        Car car2 = new Car();

        car2.brand = "Suzuki";
        car2.year = 2005;

        Car car3 = new Car();

        car3.brand = "BMW";
        car3.year = 2025;

        car1.ShowCar();
        car2.ShowCar();
        car3.ShowCar();

        Students students1 = new Students();
        students1.CheckResult();

        Students students2 = new Students();
        students2.CheckResult();

        Students students3 = new Students();
        students3.CheckResult();

        Students students4 = new Students();
        students4.CheckResult();

        Students students5 = new Students();
        students5.CheckResult();

        Book book1 = new Book();
        book1.title = "The Great Gatsby";
        book1.author = "F. Scott Fitzgerald";
        book1.year = 1925;

        Book book2 = new Book();
        book2.title = "To Kill a Mockingbird";
        book2.author = "Harper Lee";
        book2.year = 1960;

        Book book3 = new Book();
        book3.title = "1984";
        book3.author = "George Orwell";
        book3.year = 1949;

        Book[] books = { book1, book2, book3 };
        foreach (Book book in books)
        {
            book.ViewDetails();
        }
    }
}