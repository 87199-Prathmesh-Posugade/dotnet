using System.Runtime.CompilerServices;

namespace features
{
    public static class MyExtensions {
        public static bool EmailValidation(this string s, bool isGmail)
        {
            if (isGmail)
            {
                if (s != null && s.Contains("@gmail.com"))
                {
                    return true;
                }
                else { 
                    return false;
                }
            }
            if (s.Contains("@") && s.Contains(".com")) { 
                return true;
            }
            return false;
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            //Nullable<int> id = null;
            #region Anonymous type
            //var emp1 = new { average = 55.56, name = "sachin", city = "mumbai" };
            //Console.WriteLine(emp1.GetType());

            //var emp2 = new { name = "sachin", city = "mumbai", average = 55.56 };
            //Console.WriteLine(emp2.GetType());
            #endregion

            #region Extension method
            //string s1 = "wde@gmail.com";
            //string s2 = "wde@.com";
            //Console.WriteLine(s1.EmailValidation(true));
            //Console.WriteLine(s2.EmailValidation(false));
            #endregion

            #region LINQ
            List<Emp> emps = new List<Emp>()
            {
                new Emp(){ No = 11, Name = "Jayesh", Address="Jalna" },
                new Emp(){ No = 12, Name = "Rudra", Address="Mumbai" },
                new Emp(){ No = 13, Name = "Shekhar", Address="Solapur" },
                new Emp(){ No = 14, Name = "Makarand", Address="Kolhapur" },
                new Emp(){ No = 15, Name = "Rushikesh", Address="Baramati" },
                new Emp(){ No = 16, Name = "Swapnil", Address="Shrigonda" },
            };

            #region using foreach
            //List<Emp> result = new List<Emp>();
            //foreach (var e in emps)
            //{
            //    if (e.Address.Contains('r')) { 
            //        result.Add(e);
            //    }
            //}
            //foreach (var e in result)
            //{
            //    Console.WriteLine("{0} | {1}", e.Name, e.Address);
            //}
            #endregion

            #region using LINQ
            //var list = (from e in emps
            //            where e.Address.Contains('r')
            //            select e);

            //Lazy execution hence employee is available
            //emps.Add(new Emp { No = 9, Name = "A" , Address = "r"});

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item.Name + " | " + item.Address);
            //} 

            var list = (from e in emps
                        where e.Address.Contains('r')
                        select new { 
                            No = e.No,
                            Name = e.Name
                        });

            foreach (var item in list)
            {
                Console.WriteLine(item.Name + " | " + item.No);
            }
            #endregion


            #endregion


        }
        class ResultHolder { 
            public int No { get; set; }
            public string Name { get; set; }
            
        }
        class Emp
        {
            public int No { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
        }
    }
}