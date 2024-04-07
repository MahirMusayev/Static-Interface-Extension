namespace Sinif_taski
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 0:
                    Console.WriteLine(Week.Monday); break;
                case 1:
                    Console.WriteLine(Week.Sunday); break;
                case 2:
                    Console.WriteLine(Week.Tuesday); break;
                case 3:
                    Console.WriteLine(Week.Friday); break;
                case 4:
                    Console.WriteLine(Week.Saturday); break;
                case 5:
                    Console.WriteLine(Week.Sunday); break;
                case 6:
                    Console.WriteLine(Week.Tuesday); break;
                case 7:
                    Console.WriteLine(Week.Friday); break;


            }
            foreach (var item in Enum.GetValues(typeof(Week)))
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
