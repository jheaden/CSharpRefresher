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
                try
                {
                    var newStudent = new Student();

                newStudent.Name = Util.Console.Ask("Enter a student name: ");
                //var result = int.TryParse(Util.Console.Ask("Grade: "), out newStudent.Grade);
                //if (!result)
                //{
                //    Console.WriteLine("Error. Grades are numbers in this scenario.");
                //}

                newStudent.Grade = Util.Console.AskInt("Grade: ");
                newStudent.Birthday = Util.Console.Ask("Birthday: ");
                newStudent.Address = Util.Console.Ask("Address: ");
                newStudent.Phone = Util.Console.AskInt("Phone: ");

                students.Add(newStudent);
                Student.Count++;
                Console.WriteLine("Total Students: {0}", Student.Count);

                Console.WriteLine("Add another?");

                if (Console.ReadLine() != "y")
                {
                    adding = false;
                }
            }
            catch (FormatException msg)
            {

                Console.WriteLine(msg.Message);
            }
            catch (Exception)
            {

                Console.WriteLine("Error adding student. Try again.");
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

            public int Phone
            {
                set { phone = value; }
            }
        }
        class Student : Member
        {
            static public int Count;
            public int Grade;
            public string Birthday;

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
