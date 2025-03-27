//Bidhya Sangroula 
//Ayah Faour
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_2025_03_27
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Bidhya Sangroula");
            Spring mySpring = new Spring();
            mySpring.Place = "Nepal";
            Console.WriteLine("Places to visit for spring: " + mySpring.Place);

            Console.WriteLine("Ayah Faour");
            Spring mySpring1 = new Spring();
            mySpring1.Place = "Hawaii";
            Console.WriteLine("Good vacation spot of the spring:" + mySpring1.Place);



        }

    }
}
