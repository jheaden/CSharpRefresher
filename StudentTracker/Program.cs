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
            //They would like to be able to enter student grades along with their names one by one into the console. 
            //Once the names and grades are set for all students, then we'll need to display all of the names and grades. 
            //One important requirement is that this program can handle any number of students 
            //whereas previously, we have to specify in the array the amount of students that a class had. 
            //Now if a student joins halfway through the course, we should be able to add them.


            var studentNames = new List<string>();
            var studentGrades = new List<int>();
            var adding = true;

            while(adding)
            {
                Console.WriteLine("Enter a student name: ");
                studentNames.Add(Console.ReadLine());

                Console.WriteLine("Grade: ");
                studentGrades.Add(int.Parse(Console.ReadLine()));

                Console.WriteLine("Add another?");

                if(Console.ReadLine() != "y")
                {
                    adding = false;
                }

            }

            for (int j = 0; j < studentNames.Count() ; j++)
            {
                Console.WriteLine(studentNames[j]+ " : " + (studentGrades[j].ToString()));
            }

            Console.ReadLine();

        }
    }
}
