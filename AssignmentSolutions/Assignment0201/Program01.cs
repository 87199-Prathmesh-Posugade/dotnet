using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment0201
{
    public struct Student
    {
        public static void reverseArray(Student[] studs) { 
            Student[] reverse = new Student[studs.Length];
            int j = 0;
            for (int i=studs.Length-1;i>-1;i--)
            {
                reverse[j]=studs[i];
                reverse[j].getDetails();
                j++;
            }
        }
        public static int getSize()
        {
            Console.WriteLine("Enter Size Of Student Array: ");
            return int.Parse(Console.ReadLine());
        }
        public static void getInfo(Student[] studs)
        {
            for (int i=0;i<studs.Length;i++) { 
                studs[i] = new Student();
                studs[i].acceptDetails();
            }
        }

        public static void printInfo(Student[] studs)
        {
            foreach (Student student in studs) {
                student.getDetails();
            }
        }

        private double _marks;

        public double marks
        {
            get { return _marks; }
            set { _marks = value; }
        }

        private char _div;

        public char div
        {
            get { return _div; }
            set { _div = value; }
        }

        private int _std;

        public int std
        {
            get { return _std; }
            set { _std = value; }
        }

        private int _age;

        public int age
        {
            get { return _age; }
            set { _age = value; }
        }

        private bool _gender;

        public bool gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        private string _name;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        //public Student()
        //{
        //    this._name = "";
        //    this._gender = false;
        //    this._age = 0;
        //    this._std = 0;
        //    this._div = 'a';
        //    this._marks = 0.0;
        //}
        public Student(string name, bool gender, int age, int std, char div, double marks)
        {
            this._name = name;
            this._gender = gender;
            this._age = age;
            this._std = std;
            this._div = div;
            this._marks = marks;
        }

        public void acceptDetails()
        {
            Console.WriteLine("Enter name: ");
            this._name = Console.ReadLine();
            Console.WriteLine("Enter gender: ");
            this._gender = Boolean.Parse(Console.ReadLine());
            Console.WriteLine("Enter age: ");
            this._age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter std: ");
            this._std = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter div: ");
            this._div = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter marks: ");
            this._marks = double.Parse(Console.ReadLine());
        }

        public void getDetails()
        {
            Console.WriteLine("Name: " + _name);
            Console.WriteLine("Gender: " + (_gender ? "Male" : "Female"));
            Console.WriteLine("Age: " + _age);
            Console.WriteLine("Standard: " + _std);
            Console.WriteLine("Division: " + _div);
            Console.WriteLine("Marks: " + _marks);
        }
    }
    internal class Program01
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.acceptDetails();
            student.getDetails();
        }
    }

}
