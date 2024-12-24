using System;
using System.Security.Cryptography;

namespace ConsoleApp7

{
    class Domestic
    {
        public string Name;
        private string Brand;
        protected int Power;
        public string Turn;

        public string brand
        {
            get { return Brand;}
            set{ Brand=value;}
        }

        public int power
        {
            get { return Power;}
            set{ Power=value;}
        }
    }

    class Fridge:Domestic
   {
        public Fridge()
        {
            Name = "Fridge";
            brand = "Samsung";
            power = 200;
            Turn = Console.ReadLine();
            if (Turn == "Устройство включено")
            {
                Console.WriteLine("Turn on");
            }else if(Turn == "Устройство выключено")
            {
                Console.WriteLine("Turn off");
            }
            else
            {
                Console.WriteLine("Eror");
            }
        }
    }

    class WashingMachine:Domestic
    {
        public WashingMachine()
        {
            Name = "Washing Machine";
            brand = "Indesit";
            power = 100;
            Turn = Console.ReadLine();
            if (Turn == "Устройство включено")
            {
                Console.WriteLine("Turn on");
            }else if(Turn == "Устройство выключено")
            {
                Console.WriteLine("Turn off");
            }
            else
            {
                Console.WriteLine("Eror");
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Fridge f = new Fridge();
            WashingMachine v = new WashingMachine();
            Console.WriteLine(f.Name);
            Console.WriteLine(f.brand);
            Console.WriteLine(f.power);
            Console.WriteLine(f.Turn);
            Console.WriteLine(v. Name);
            Console.WriteLine(v.brand);
            Console.WriteLine(v.power);
            Console.WriteLine(v.Turn);  
        }
    }
}