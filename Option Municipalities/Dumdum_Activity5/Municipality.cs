using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dumdum_Activity5
{
    //Name: Christian Benedict P. Dumdum
    //Section: IT401A
    //Reuse your Activity 4 code, both your main class and main program.
    //Develop your own user-input method or user-input class, which you will reuse in the main program.
    //Make sure to capture all instances when running your program,
    //but only after you have polished your code. DO NOT CAPTURE YET WHEN YOU ARE STILL TESTING YOUR PROGRAM.

    internal class Municipality
    {

        //Properties
        public string ProvinceName { get; set; }
        public double Population { get; set; }

        //Constructor
        public Municipality(string aprovincename, double apopulation)
        {
            ProvinceName = aprovincename;
            Population = apopulation;
        }

        //Virtual Method
        public virtual void DisplayMunicipality()
        {
            Console.WriteLine("-----Municipality-----");
            Console.WriteLine("Province Name: " + ProvinceName);
            Console.WriteLine("Population: " + Population);
        }
    }
    class NorthCebu : Municipality //Derived Class
    {
        //Property
        public string Barangay { get; set; }

        //Constructor
        public NorthCebu(string abarangay, string aprovincename, double apopulation)
        : base(aprovincename, apopulation)
        {
            Barangay = abarangay;
        }

        //Override Method
        public override void DisplayMunicipality()
        {
            Console.WriteLine("-----Municipality-----");
            Console.WriteLine("Province Name: " + ProvinceName);
            Console.WriteLine("Population: " + Population);
            Console.WriteLine("Barangay: " + Barangay);
        }
    }
    class CentralCebu : Municipality //Derived Class
    {
        //Property
        double PostalCode { get; set; }

        //Constructor
        public CentralCebu(double apostalcode, string aprovincename, double
        apopulation) : base(aprovincename, apopulation)
        {
            PostalCode = apostalcode;
        }

        //Override Method
        public override void DisplayMunicipality()
        {
            Console.WriteLine("-----Municipality-----");

            Console.WriteLine("Province Name: " + ProvinceName);
            Console.WriteLine("Population: " + Population);
            Console.WriteLine("PostalCode: " + PostalCode);
        }
         
    }
}
    

