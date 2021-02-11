using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTutorial {
    class Student {
       public string Name;
       public string Address;
       public decimal GPA;
       public string Major;
       public bool Graduated = false;

         // default constructor
        public Student() {
            Console.WriteLine("Called default consturctor");
        }

        public Student(string name) {
            Name = name.ToUpper();
            Console.WriteLine("Called 1 parameter contructor");
        }

        public void HasGraduated() {
            Graduated = true;
        }

        public string UppercaseName() {
            return Name.ToUpper();
        }
        // ask becca for help on this

        public void NewGPA(decimal GPA) {
            this.GPA = GPA;
           // only use (this.) if the paramters are the same, ask becca for help on this 
        }


         public void print() {
            Console.Write($"Name is {Name}, GPA is {GPA}, Major is {Major}");
            Console.WriteLine($", Graduated { Graduated}");

        }



    }
}
