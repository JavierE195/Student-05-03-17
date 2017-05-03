using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication39
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the student's name: ");
            string name01 = Console.ReadLine();

            Console.WriteLine("Insert the student's GPA: ");
            double gpa01 = double.Parse(Console.ReadLine());

            Student student01 = new Student();
            student01.name = name01;
            student01.gpa = gpa01;

            Console.Write(
                "Student: " + student01.name +
                "\nGPA: " + student01.gpa);
            Console.ReadKey();
        }
    }
}
