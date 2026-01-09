using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dumdum_Activity2
{
    internal class Program
    {

        //Name:Christian Benedict P. Dumdum
        //Section: IT401A
        //REQUIREMENTS:
        //Convert your program in Activity 1 into Object-Oriented Programming Approach.Make sure
        //the class objects will be stored and accessed using an Array.Then, display the details of all objects.
        //Your program must anticipate incorrect entries and other constraints from the user entry. (OPTIONAL)
        static void Main(string[] args)
        {
            //Declare a single array to hold data
            Municipality[] municipalities = new Municipality[2];

            Console.WriteLine();//Space
            Console.WriteLine("Municipalities in Cebu Province:");
            Console.WriteLine(); //Space

            //Initialize the array with specific municipality objects
            municipalities[0] = new NorthCebu("AtopAtop", "Bantayan", 180000);
            municipalities[1] = new CentralCebu(6300, "Bohol", 1412726);

            //loop through each municipality in the array
            foreach (var municipality in municipalities)
            {


                //Calling the Method
                municipality.DisplayMunicipality();

                //Add Space Between the Municipalities Listed
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
