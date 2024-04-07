using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static__Interface__Extension
{
    internal class Student
    {
        private static int Count  = 0;
        public int  Id { get; private set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Student(string name ,string surname)
        {
            Id = Count++;
            Name = name.Capitalize();
            Surname = surname.Capitalize();
        }
        public void GetInfo()
        {
            Console.WriteLine($"Student Id {Id}");
            Console.WriteLine($"Name :{Name}");
            Console.WriteLine($"Surname :{Surname}");
        }
    }
}
