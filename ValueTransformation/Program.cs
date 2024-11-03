// Author: William Owen
// Created: November 3, 2024
// Description: This program is a Console Application that gets a list of numbers from the User.
//   The application should then double all the numbers and output both the original values and
//   the doubled values back into the console window

namespace ValueTransformation
{
    internal class Program
    {
        static int[] userNumbers = new int[0];
        static void Main(string[] args)
        {
            DisplayWelcomeMessage(); // This message will only display once at beginning of program
            Load();
            userNumbers = GetNumbers();
            int[] doubledNumbers = DoubleNumbers(userNumbers);
            DisplayArray(doubledNumbers);
            RetryPrompt(args);


        }

        private static bool welcomeMessageDisplayed = false;

        private static void DisplayWelcomeMessage()
        {
            if (welcomeMessageDisplayed) return;

            Console.WriteLine("Welcome to the Value Transformer!\n");
            Console.WriteLine("This app will accept up to 10 whole numbers and ");
            Console.WriteLine("convert them by doubling the values. ");
            Console.WriteLine("Type q to quit \n");

            welcomeMessageDisplayed = true;
        }

        private static void RetryPrompt(string[] args)
        {
            Console.Write("\n\nThank you for using the Value Transformer! Retry? (y/n): ");
            string retry = Console.ReadLine();
            if (retry.ToLower() == "y")
            {
                Main(args);
            }
            else
            {
                Console.WriteLine("Goodbye!");
                Thread.Sleep(1000);
            }
        }

        private static int[] GetNumbers() {
            int[] numbersArray = new int[0];
            bool userIsDone = false;
            while (!userIsDone && numbersArray.Length <= 10) { 
                Console.Write($"[{string.Join(", ", numbersArray)}] <-- Please provide a whole number: ");
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out int input)) {
                    int[] tempArray = new int[numbersArray.Length + 1];
                    for (int i = 0; i < numbersArray.Length; i++)
                    {
                        tempArray[i] = numbersArray[i];
                    }
                    tempArray[tempArray.Length - 1] = input;
                    numbersArray = tempArray;
                }
                else
                {

                    if (userInput.ToLower() == "q")
                    {
                        userIsDone = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please provide a whole number.");
                    }
                }


            }
            return numbersArray;
        }

        private static int[] DoubleNumbers(int[] originalNums)
        {
            int[] doubles = new int[originalNums.Length];
            for (int i = 0; i < originalNums.Length; i++)
            {
                doubles[i] = originalNums[i] * 2;
            }
            return doubles;
        }

        private static void DisplayArray(int[] numbersArray)
        {
            Console.WriteLine("");
            Console.WriteLine("Here are your original numbers and their doubled values:");


            // Determine the maximum width needed for alignment based on the doubled array
            const int maxWidth = 5;
            Console.Write("Original: ");
            for (int i = 0; i < userNumbers.Length; i++)
            {
                if (i > 0) Console.Write(", ");
                Console.Write($"{userNumbers[i],maxWidth}");
            }
            Console.WriteLine();

            Console.Write("Doubled:  ");
            for (int i = 0; i < numbersArray.Length; i++)
            {
                if (i > 0) Console.Write(", ");
                Console.Write($"{numbersArray[i],maxWidth}");
            }
            Console.WriteLine("");
        }


        static void Load()
        {
            char[] spinner = { '|', '/', '-', '\\' };
            for (int i = 0; i < 25; i++)
            {
                string thisSpinner = spinner[i % spinner.Length].ToString();
                Console.Write(thisSpinner);
                Thread.Sleep(100);
                Console.Write("\r"); // Move the cursor back to the beginning of the line
            }

            // Clear the line after the loop ends
            Console.Write("\r");
        }


    }
}
