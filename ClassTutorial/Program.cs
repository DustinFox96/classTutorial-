using System;

namespace ClassTutorial {
    class Program {
        static void Main(string[] args) {

            var x = 5;
            //wrtie if(), testing for x == 7
            // if so, console.writeline("x is 7");
            if(x == 7) {
                Console.WriteLine("x is 7");
            } else {
                Console.WriteLine("x is NOT 7");
            }

            var Math = new Major {
                Description = "math", minSat = 500


            };
            var English = new Major {
                Description = "English", minSat = 501
            };

            Math.print();
            English.print();


            var dustin = new Student("dustin");
            // dustin.Name = "dustin";
            dustin.Address = "4900 parkway dr.";
            dustin.GPA = 2.5m;
            dustin.Major = "Outer Space Basket Weaving";
            dustin.HasGraduated();
            dustin.NewGPA(2.9m);


            dustin.print();

            var ucName = dustin.UppercaseName();
            Console.WriteLine($"ucName is {ucName}");
            // ask becca for help in this

            var jonathan = new Student {
                Name = "Jonathan",
                Address = "4900 Parkway Dr.",
                GPA = 4.0m,
                Major = "Above Water Basket Weaving"

            };

            jonathan.print();



            var andrea = new Student {
                Name = "Andrea",
                Address = "4900 ParkWay Dr.",
                GPA = 4.0m,
                Major = "Underwater Basket Weaving"
            };
            //andrea.Name = "Andrea";
            //andrea.Address = "4900 parkway Dr.";
            //andrea.GPA = 4.0m;
            //andrea.Major = "Underwater Basket Weaving";

            Console.WriteLine($"Name is {andrea.Name}, GPA is {andrea.GPA}, Major is {andrea.Major}");




        }
    }
}
