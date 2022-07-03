using System;
namespace ElectricBillSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Bill Type by Number: ");
            Console.WriteLine("1. Ressidential");
            Console.WriteLine("2. Commercial");
            string bill_type;
            bill_type=Console.ReadLine();
            string value;
            Console.WriteLine("Please Enter No. of units consumed");
            value = Console.ReadLine();
            int units;
            units = Convert.ToInt32(value);

            
            switch(bill_type)
            {
                case "1":
                    ResidentialBill r= new ResidentialBill(units);
                    Console.WriteLine("Your ressidential bill is: " + r.show_bill());
                    break;
                case "2":
                    CommercialBill c = new CommercialBill(units);
                    Console.WriteLine("Your commercial bill is: " + c.show_bill());
                    break;
                default:
                    Console.WriteLine("Please Enter 1 or 2");
                    break;
            }
        }
    }
}