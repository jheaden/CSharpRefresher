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
            Import();
            var students = new List<Student>();
            var adding = true;

            while (adding)
            {
                var newStudent = new Student();

                newStudent.Name = Util.Console.Ask("Enter a student name: ");
                newStudent.Grade = int.Parse(Util.Console.Ask("Grade: ")); 
                newStudent.Birthday = Util.Console.Ask("Birthday: ");
                newStudent.Address = Util.Console.Ask("Address: ");            
                newStudent.Phone = int.Parse(Util.Console.Ask("Phone: "));

                students.Add(newStudent);
                Student.Count++;
                Console.WriteLine("Total Students: {0}", Student.Count);

                Console.WriteLine("Add another?");

                if (Console.ReadLine() != "y")
                {
                    adding = false;
                }

            }

            foreach (var student in students)
            {
                Console.WriteLine(
                    "Name: {0} \nGrade: {1} \nBirthday: {2} \nAddress: {3}",
                    //\nPhone: {4}",
                    student.Name,
                    student.Grade.ToString(),
                    student.Birthday,
                    student.Address
                    );
                  //  student.Phone();
            }
            Console.ReadLine();
        }

        static void Import()
        {
            var importedStudent = new Student("Jenny", 73, "Oct 8", "123 Fake Street", 5);
            Console.WriteLine(importedStudent.Name);
        }

        class Member
        {
            public string Name;
            public string Address;
            protected int phone;
        }
        class Student : Member
        {

            static public int Count;

            public string Name;
            public int Grade;
            public string Birthday;
            public string Address;
            private int phone;

            public int Phone
            {
                set { phone = value; }
            }

            public Student()
            {

            }

            public Student(string name, int grade, string birthday, string address, int phone)
            {
                Name = name;
                Grade = grade;
                Birthday = birthday;
                Address = address;
                Phone = phone;
            }            
        }

        class Teacher : Member
        {
            public string Subject;
        }
}
}
