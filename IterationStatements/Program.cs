namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintNumbers()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void PrintNumbers3()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool Parameters(int a, int b)
        {
            //if(a == b)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            return (a == b) ? true : false;
        }

        //Write a method to check whether a given number is even or odd
        public static string EvenOdd(int number)
        {
            if (number % 2 == 0)
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }

            //return (number % 2 == 0) ? Even : Odd;

        }

        //Write a method to check whether a given number is positive or negative
        public static void PosNeg(int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"{num} is positive");
            }
            else if (num < 0)
            {
                Console.WriteLine($"{num} is negative");
            }
            else
            {
                Console.WriteLine($"{num} is zero");
            }
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //public bool CanVote(string ageInput)
        //{
        //    int age = int.Parse(ageInput);
        //    if (age >= 18)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //TryParse()
        //public bool CanVote(string ageInput)
        //{
        //    int age;
        //    if (int.TryParse(ageInput, out age))
        //    {
        //        if (age >= 18)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        public static void CanVote()
        {
            bool userAge;
            int result;

            do
            {
                Console.WriteLine("Please enter your age");
                userAge = int.TryParse(Console.ReadLine(), out result);

            } while (!userAge);

            if (result < 18)
            {
                Console.WriteLine("Too young to vote.");
            }
            else
            {
                Console.WriteLine("Old enough to vote.");
            }
        }



        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        public static void InRange()
        {
            bool userResponse;
            int result;

            do
            {
                Console.WriteLine("Enter an integer.");

                userResponse = int.TryParse(Console.ReadLine(), out result);
            } while (!userResponse);

            //    if (result >= -10 && result <= 10)
            //    { 
            //        Console.WriteLine($"{result} is between 10 & -10");
            //    }
            //    else
            //    { 
            //        Console.WriteLine($"{result} is NOT between 10 & -10");
            //    }
            //}

            Console.WriteLine((result >= -10 && result <= 10) ? $"{result} is between 10 & -10" : $"{result} is NOT between 10 & -10");




            //Write a method to display the multiplication table(from 1 to 12) of a given integer


        public static void MultTable()
        {
            bool cont;
            int userInput;

            do
            {
               Console.WriteLine("Enter an integer");

               cont = int.TryParse(Console.ReadLine(), out userInput);
            } while (!cont);

            for (var x = 1; x <= 12; x++)
            {
               Console.WriteLine($"{x} x {userInput} = {x * userInput}");
            }
        }



            //Call the methods to test them in the Main method below
            static void Main(string[] args)
            {
                //PrintNumbers();
                //PrintNumbers3();
                //Parameters(2, 6);
                //Console.WriteLine(Paramaters(2, 6));
                //EvenOdd(5);
                //PosNeg(5);
                //CanVote();
                //InRange();
                MultTable();
            }
        }
    }
