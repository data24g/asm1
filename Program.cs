using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace asm1
{
    internal class Program
    {
        static string Name()
        { //Enter customer name
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        //choose customer type
        static int TypeOfCustomer()
        {

            Console.WriteLine("Type a customer:\n\t1. Household customer " +
                "                               \n\t2. Administrative agency, public services " +
                "                               \n\t3. Production units" +
                "                               \n\t4. Business services");
            Console.Write("Enter your type (1-4): ");
            int type = int.Parse(Console.ReadLine());

            while (type < 1 || type > 4)
            {
                Console.Write("Please enter a number from 1 to 4:");
                type = int.Parse(Console.ReadLine());
            }
            return type;
        }
        //Calculate consumption
        static double Watermeter()
        {
            Console.Write("Enter last month’s water meter readings: ");
            double lWater = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter this month’s water meter readings: ");
            double nWater = Convert.ToDouble(Console.ReadLine());

            double wateruse = nWater - lWater;
            Console.WriteLine($"Amount of water used this month: {wateruse}");
            return Watermeter();
        }
        static double Price()
        {
            int type = TypeOfCustomer();
            string tcustomer;
            double price = default;
            double consumption = Watermeter();
            return price;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("_______________WATER BILLING PROGRAM________________\n");
            string name = Name();
            Console.WriteLine($"\nWelcome {name} to the water billing program!!\n");
            Console.WriteLine("__________________________________________________");
            Console.ReadLine();
        }
    }
}
