using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
                //TODO - Read each comment and complete its instruction
                // like the example below

                //Create a List called "numbers" - DONE!
                var numbers = new List<int>();

            //-----START HERE------------------------------------------
            //Create a variable of type int and name it num - Done!
            //initialize the variable with a value of 0 - Done!

            int num = 0;

            // Create a do-while loop and use the template below:

            do
            {
                num++;
                numbers.Add(num);
            } while (num < 100);

            // Increment num by 1 - Done!

            // Then add num to the collection - numbers - Done!
            // Hint: reference num inside of the Add method's parentheses
            // numbers.Add(/* num */);

            // <---- While your variable is less than 100 - Done!



            // Create a while loop

            while (num < 200)
            {
                num++;
                numbers.Add(num);
            }


            // <--- While num is less than 200 - Done!
            
                // Increment num by 1 - Done!
                // Then add num to the collection numbers - Done!
                    //HINT: copy how this was done in the do while loop

            


            // This is to show the user that the numbers will start increasing on the console
            Console.WriteLine("Increase:");


            // Create a foreach loop using the collection - numbers - Done!
            //In the scope of the foreach loop, print each number in numbers - Done!
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            for (int i = 199; i <= numbers.Count && i >= 0; i--)
            {
                Console.WriteLine($"{numbers[i]}");
            }

            // Create a for loop - this will print the numbers in reverse order - from 200 to 1 - Done!
                // in your initializer set the value of i to 199 - Done!
                // in your conditional, as long as i is less than or equal to the amount of items in "numbers" - use (numbers.Count) - Done!
                // AND as long as i is greater than or equal to 0 - Done!
                // Decrement i by 1 - Done!

            //start for loop here
            
                // place numbers[i] inside of the Console.WriteLine() method - Done!
            

            //------------End of exercise
        }
    }
}
