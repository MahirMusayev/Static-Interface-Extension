namespace Static__Interface__Extension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 6;
            Console.WriteLine($"{num} ededi tekdir {num.IsOdd()}");
            Console.WriteLine($"{num} ededi cutdur {num.IsEven()}");

            Console.WriteLine(" ");

            string text = "codeAcademia AB106";
            Console.WriteLine($"{text} digit characterine malikdirmi {text.HasDigit()}");
            Console.WriteLine($"{text} duzgun paroldur {text.CheckPassword()}");
            Console.WriteLine(text.Capitalize());

            Console.WriteLine(" ");

            Student student = new Student("mahir", "dxf");
            student.GetInfo();

            Console.WriteLine(" ");

            Group group = new Group("Mahir");
            group.GetGroupInfo();

            group.GetStudent(0);

            group.ShowStudents();

        }
    }
}
