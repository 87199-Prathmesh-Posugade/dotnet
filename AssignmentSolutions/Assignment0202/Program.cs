using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment0201;

namespace Assignment0202
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[Student.getSize()];
            Student.getInfo(students);
            Student.printInfo(students);
            Console.WriteLine("Reversed: ");
            Student.reverseArray(students);
        }
    }
}
