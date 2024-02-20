using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asm1
{
    class Program
    {
        //Enter customer name
        static string CustomerName()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        //choose customer type
        static int TypeCustomer()
        {
            Console.WriteLine("Type a customer:\n\t1. Household customer\n\t2. Administrative agency, public services\n\t3. Production units \n\t4. Business services ");
            Console.Write("Enter your type (1-4): ");
            int type = int.Parse(Console.ReadLine());

            while (type < 1 || type > 4)
            {
                Console.Write("Enter a number from 1 to 4:");
                type = int.Parse(Console.ReadLine());
            }
            return type;
        }
        //Calculate a
        static double Watermeter()
        {
            Console.Write("Enter last month’s water meter readings: ");
            double lWater = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter this month’s water meter readings: ");
            double nWater = Convert.ToDouble(Console.ReadLine());
            while (lWater > nWater)
            {
                Console.WriteLine("The water meter readings of last month can't be more than the water meter readings of this month. Please enter the input again");
                Console.Write("Enter water meter readings of this month: ");
                nWater = Convert.ToDouble(Console.ReadLine());
            }

            double wateruse = nWater - lWater;
    
            Console.WriteLine($"Amount of water used this month: {wateruse}");
            return wateruse;
        }
             //Calculate prices based on customer type
            static double Price()
        {
            int type = TypeCustomer();
            string Customer;
            double price = default;
            double a = Watermeter();
            switch (type)
            {
                case 1:
                    Customer = "Household customer";
                    if (a > 0 && a <= 10)
                    {
                        price = (a * 5.973);
                        Console.WriteLine($"Water price for {Customer} is: 5.973 VND/m3");

                    }
                    else if (a > 10 && a <= 20)
                    {
                        price = (a * 7.052);
                        Console.WriteLine($"Water price for {Customer} is: 7.052 VND/m3");

                    }
                    else if (a > 20 && a <= 30)
                    {
                        price = (a * 8.699);
                        Console.WriteLine($"Water price for {Customer} is: 8.699 VND/m3");

                    }
                    else
                    {
                        price = (a * 15.929);
                        Console.WriteLine($"Water price for {Customer} is: 15.929 VND/m3");
                    }
                    break;
                case 2:
                    Customer = "Administrative agency, public services";
                    price = (a * 9.955);
                    Console.WriteLine($"Water price for {Customer} is: 9.955 VND/m3");
                    break;
                case 3:
                    Customer = "Production units";
                    price = (a * 11.615);
                    Console.WriteLine($"Water price for {Customer} is: 11.615 VND/m3");
                    break;
                case 4:
                    Customer = "Business services";
                    price = (a * 22.068);
                    Console.WriteLine($"Water price for {Customer} is: 22.068 VND/m3");
                    break;
                default:
                    return 0;
            }
            return price;
        }
        //Calculate totalBill based on price and VAT
        static double Bill()
        {
            double price = Price();
            double fees = price * 0.1;
            Console.WriteLine($"Enviroment protection fees : {fees} VND ");
            double VAT = (price + fees) * 0.1;
            Console.WriteLine($"VAT : {VAT} VND ");
            double bill = price + VAT + fees;
            Console.WriteLine($"Total water bill: {bill} VND ");
            return bill;
        }
            
        static void Main(string[] args)
        {

            Console.WriteLine("___________________WATER BILLING PROGRAM_______________________\n");
            string Name = CustomerName();
            Console.WriteLine($"\nWelcome {Name} to the water billing program!!\n");
            Console.WriteLine("----------------------------------------------------------------");
            Bill();
            Console.ReadLine();
        }
    }
}
