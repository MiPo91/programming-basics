using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give 10 positive Integers");

            int[] functionResults = userResults(); // getting function results

            Console.WriteLine("Your inputted numbers are:");
            for(int i = 0; i < 10; i++) { // printing array values to user
                Console.Write(functionResults[i] + " ");
            }
            Console.ReadKey();
        }


        public static int[] userResults()
        {
            int[] numberList = new int[10];
            int i = 0;

            while(i  < 10) { // looping until 10 positive numbers inputted

                string userInput = Console.ReadLine();
                int usersNumber;
                int.TryParse(userInput, out usersNumber);

                if(usersNumber > 0) {
                    numberList[i] = usersNumber;
                    i++;
                } else {
                    Console.WriteLine("Wrong input, give positive number");
                }            
            }

            return numberList;
        }
    }
}
