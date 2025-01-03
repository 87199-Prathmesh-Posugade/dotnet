namespace features {
    internal class Program {
        static void Main(string[] args) {
            //Nullable<int> id = null;

            var emp1 = new { average = 55.56, name = "sachin", city = "mumbai" };
            Console.WriteLine(emp1.GetType());
            
            var emp2 = new { name = "sachin", city = "mumbai", average = 55.56 };
            Console.WriteLine(emp2.GetType());


        }
        class Emp {
            public double average { get; set; }
            public string name { get; set; }
            public string city { get; set; }
        }
    }
}