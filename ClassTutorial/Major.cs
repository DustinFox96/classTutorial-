using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTutorial {
    class Major {
        private static int Nextid { get; set; } = 1;
        public int Id { get; set; }
        public string Description { get; set; }
        public int minSat { get; set; }
       

        public void print() {
            Console.WriteLine($"{Id} | {Description} | {minSat}");
        }


       public Major() {
            Id = Nextid;
            Nextid = Nextid + 1; // rookie
            Nextid++; // pro
        }

    }
   
}
