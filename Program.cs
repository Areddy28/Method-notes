using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Best Practice with methods
            // 1. Methods should be reuseable as possible

            // 2. Methods should generally (outside of the main method or one that acts as a manager
            // Have one single job
            // 3. Methods should account for the most likely inputs (aka parameter)            


            bool goOn = true;
            while (goOn)

            {

                //1. Gettiput
                //Prompt the user 
                // Read in their input 
                string result = GetInput("Please input your age");
                Console.WriteLine(result);

                string result2 = GetInput("What is your name?");
                Console.WriteLine(result2);
                //2.ng user in Continue Loop
                // Ask the user would you like to continue Y/N
                // 3 cases to code for: 
                // User says Y -> Continue 
                // N -> Stop the main loop
                // Anything else -> Try getting input again


                //3. Representing Math formulas- we need to get it right once, then we can reuse as mush as we want
                // Area
                // Perimeter
                // Calculate Paint Cans
                int x = 7;
                // floats must end in a f
                //float f = 1.5f; 
                double area = GetArea(x, 5);
                Console.WriteLine($"Area: {area}");

                //4. Range Checking - checking in the input value falls between 1 and 100
                // This will be a method for validation

                // Methods call are processed in a Last in First out order
                int min = int.Parse(GetInput("Please input a minimum number"));
                int max = int.Parse(GetInput("Please input a max number"));
                int num = int.Parse(GetInput("Please input a number if it's in the range"));
                bool inRange = RangeCheck(min, max, num);
                Console.WriteLine(inRange);
                goOn = Continue();
            }
        }
        // You could put in a second paramenter telling getinput what datatype you wish to return.
        public static string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            string output = Console.ReadLine();

            return output; 
        }

        public static bool Continue()
        {
            string answer = GetInput("Would you like to continue? y/n");

            if (answer == "y")
            {
                return true; 
            } else if (answer == "n")
            {
                Console.WriteLine("Goodbye!");
                return false;
                // This code in unreachable it would kick us out of the method
                //Console.WriteLine("Goodbye!")
            } else
            {
                Console.WriteLine("I'm sorry I didn't understand");
                Console.WriteLine("Let's try again.");
                
                // This is recursion, calling a method inside itself
                return Continue(); 
            }
        }

        public static double GetArea(double width, double length)
        {
            double area = width * length;
            return area; 
        }

        public static bool RangeCheck(int min, int max, int num)
        {
            if (min < max)
            {

                if (num < min && num > max)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
                {
                    Console.WriteLine($"Min {min} is greater than max {max} and therefore the range can't be checked");
                    return false; 
                }
                
                
            }
        } 
        
    }

