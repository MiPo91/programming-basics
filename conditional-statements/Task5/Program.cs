using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asking users information
            Console.WriteLine("Enter your age");
            string userAge;
            userAge = Console.ReadLine();

            Console.WriteLine("Are you member of Mtk, type Y or N");
            string mtk;
            mtk = Console.ReadLine();

            Console.WriteLine("Are you student, type Y or N");
            string student;
            student = Console.ReadLine();

            Console.WriteLine("Are you in army, type Y or N");
            string army;
            army = Console.ReadLine();

            // Setting up new variables 
            double originalPrice = 16;
            double newPrice = 0;
            Boolean discountGiven = false;
            string discountResult = "";

            // Converting age to number from string
            int convertedAge;
            int.TryParse(userAge, out convertedAge);

            // Checking discounts for age
            if(convertedAge < 7) {
                newPrice = 0;
                discountGiven = true;
                discountResult = "100%, Younger than 7 travel for free.";
            } else if (convertedAge >= 65) {
                newPrice = originalPrice / 2;
                discountGiven = true;
                discountResult = "50%, 65 and older travel for half price.";
            } else if(convertedAge > 6 && convertedAge < 16) {
                newPrice = originalPrice / 2;
                discountGiven = true;
                discountResult = "50%, Between 7 & 15 travel for half price.";
            }

            // Checking discount for memberships
            if(mtk == "y" && discountGiven == false) {
                newPrice = originalPrice * 0.85;
                discountResult = "15%, Mtk membership discount.";
            }
            if (army == "y" && discountGiven == false && mtk != "y") {
                newPrice = originalPrice / 2;
                discountResult = "50%, half price for being in Army.";
            }
            if(student == "y" && discountGiven == false && army != "y") {
                if(mtk == "y") {
                    newPrice = originalPrice * 0.60;
                    discountResult = "60%, Mtk membership discount(15%) + student discount(45%).";
                } else {
                    newPrice = originalPrice * 0.55;
                    discountResult = "45%, student discount.";
                }
            }

            Console.WriteLine("Ticket price is {0}, discount given {1}", newPrice, discountResult);

            Console.ReadKey();

        }
    }
}
