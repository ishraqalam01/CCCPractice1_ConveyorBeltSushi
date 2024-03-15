//Name: Ishraq Alam
//Date: March 13, 2024
//CCC Practice Question 1 2024 Answer
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable Declaration
            string strUser;
            int intRedPlate;
            int intGreenPlate;
            int intBluePlate;
            int intTotalCost;

            //Input
            Console.WriteLine("How many red plates?");
            strUser = Console.ReadLine();
            intRedPlate = Int32.Parse(strUser);

            Console.WriteLine("How many green plates?");
            strUser = Console.ReadLine();
            intGreenPlate = Int32.Parse(strUser);

            Console.WriteLine("How many blue plates?");
            strUser = Console.ReadLine();
            intBluePlate = Int32.Parse(strUser);

            //Process
            intTotalCost = (intRedPlate * 3) + (intGreenPlate * 4) + (intBluePlate * 5);

            //Output
            Console.WriteLine("The total cost of your meals is: $" + intTotalCost);

            Console.ReadKey();

        }
    }
}
