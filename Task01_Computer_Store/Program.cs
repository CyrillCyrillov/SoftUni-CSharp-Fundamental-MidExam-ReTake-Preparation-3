using System;

namespace Task01_Computer_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalPrice = 0;
            double taxes = 0;
            string nextLineInput = string.Empty;

            while (true)
            {
                nextLineInput = Console.ReadLine().ToUpper();

                if(nextLineInput == "SPECIAL" || nextLineInput == "REGULAR")
                {
                    break;
                }

                if(nextLineInput[0] != '-')
                {
                    totalPrice += double.Parse(nextLineInput);
                }
                else
                {
                    Console.WriteLine("Invalid price!");
                }
            }
            
            if(totalPrice == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPrice:f2}$");
                

                taxes = totalPrice * 0.2;
                Console.WriteLine($"Taxes: {taxes:f2}$");

                Console.WriteLine("-----------");

                totalPrice += taxes;
                if(nextLineInput == "SPECIAL")
                {
                    totalPrice *= 0.9;
                }
                Console.WriteLine($"Total price: {totalPrice:f2}$");
            }
        }
    }
}
