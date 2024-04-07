using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Static__Interface__Extension
{



    internal class Group
    {
        public static Group[] Groups { get; set; }
        public static int GroupCount { get; set; }
        private static int Count = 0;
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public Student[] Students { get; set; }

        public Group(string groupName)
        {
            GroupName = groupName;
            GroupId = GroupCount++;

            Students = new Student[GroupId];
        }
        public void GetGroupInfo()
        {
            Console.WriteLine($"Group Id: {GroupId}");
            Console.WriteLine($"Group Name: {GroupName}");

            foreach (var student in Students)
            {
                Console.WriteLine(student);
            }
        }
        public void GetStudent(int id)
        {
            foreach (var student in Students)
            {
                if (Students != null && GroupId == id)
                {
                    Console.WriteLine(student);
                }
                else
                {
                    Console.WriteLine("bele biri yoxdur");
                }
            }

        }
        public void AddStudent(Student student)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;
        }

        public void ShowStudents()
        {
            Console.WriteLine("Siyahıdaki telebeler:");
            foreach (var student in Students)
            {
                if (student != null)
                {
                    student.GetInfo();
                    Console.WriteLine();
                }
            }
        }
        public override string ToString()
        {
            return $"Group Id: {GroupId}\nGroup Name: {GroupName}\nNumber of Students: {Group.Count}";
        }
       
    }
}
