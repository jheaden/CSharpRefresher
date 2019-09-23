using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();
            var adding = true;

            while (adding)
            {
                var newStudent = new Student();

                Console.WriteLine("Enter a student name: ");
                newStudent.Name = Console.ReadLine();

                Console.WriteLine("Grade: ");
                newStudent.Grade = int.Parse(Console.ReadLine());

                Console.WriteLine("Birthday: ");
                newStudent.Birthday = Console.ReadLine();

                Console.WriteLine("Address: ");
                newStudent.Address = Console.ReadLine();

                Console.WriteLine("Phone: ");
                newStudent.Phone = int.Parse(Console.ReadLine());

                students.Add(newStudent);

                Console.WriteLine("Add another?");

                if (Console.ReadLine() != "y")
                {
                    adding = false;
                }

            }

            foreach (var student in students)
            {
                Console.WriteLine(
                    "Name: {0} \nGrade: {1} \nBirthday: {2} \nAddress: {3} \nPhone: {4}", student.Name, student.Grade.ToString(), student.Birthday, student.Address, student.Phone.ToString());
            }
          
            Console.ReadLine();

        }

        class Student{
            public string Name;
            public int Grade;
            public string Birthday;
            public string Address;
            public int Phone;
            

        }
}
}
