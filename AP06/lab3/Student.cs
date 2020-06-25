using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Student
    {
        static void GetStudentInformation()
        {
            Console.WriteLine("Enter the student's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine(firstName + " " + lastName);
        }
        static void PrintStudentDetails(string fisrt, string last, string birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}", fisrt, last, birthday);
        }
        static void Main(string[] args)
        {
            Student.GetStudentInformation();
        }
}
