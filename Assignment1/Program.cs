using System;

namespace LWTech.AlexEnache.Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            string number;
            bool checkIfValidNumber = false;
            int numbers = 0;
            int sum = 0;

            Console.WriteLine("Alex Enache          Assignment 1\n");

            //1.prompt user to enter 3 numbers
            Console.WriteLine("\n----------------------Finding the Sum!--------------------------");
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Please enter an integer for the Sum:");
                    number = Console.ReadLine();
                    checkIfValidNumber = int.TryParse(number, out numbers);
                    if (checkIfValidNumber == false)
                    {
                        Console.WriteLine("You must enter a number!\n");
                        continue;
                    }
                    if (numbers < 0)
                    {
                        Console.WriteLine("Enter a number bigger than zero!");
                        continue;
                    }
                //sum += numbers;
                sum += Sum(numbers);
                }
            //1.display result of sum
            Console.WriteLine($"Your Sum is: {sum}");
            
            //2.prompt user to enter integer
            double doubleNumber = 0;
            checkIfValidNumber = false;

            Console.WriteLine("\n----------------------Finding the Polynomial!--------------------");

            Console.WriteLine("Please enter an integer for the Polynomial:");
                number = Console.ReadLine();
                checkIfValidNumber = double.TryParse(number, out doubleNumber);
                if (checkIfValidNumber == false)
                    Console.WriteLine("You must enter a number!\n");
                doubleNumber = Calculate(doubleNumber);
            

            //2.display result of value of polynomial
            Console.WriteLine(doubleNumber);
            
            //3.prompt user to enter integer
            int longNumber = 0;
            checkIfValidNumber = false;
            Console.WriteLine("\n----------------------Finding the Hours, Minutes, and Seconds!------");

            while (!checkIfValidNumber)
            {
                Console.WriteLine("Enter any sized integer for Time Conversion:");
                number = Console.ReadLine();
                checkIfValidNumber = int.TryParse(number, out longNumber);
                if (checkIfValidNumber == false)
                    Console.WriteLine("You must enter a number!\n");
                //3.display result of time conversion
                Console.WriteLine($"{longNumber} seconds = {HourMinuteSecond(longNumber)}");
            }
            //4.prompt user to enter sequence of numbers and how many numbers are in sequence
            string sequenceNumber = "";
            number = "";
            checkIfValidNumber = false;
            numbers = 0;
            int minMaxNumber = 0;
            string output = "";
            int max = 1;
            int min = 50;

            Console.WriteLine("\n----------------------Finding the Max and Min!-------------------");

            while (!checkIfValidNumber)
            {
                Console.WriteLine("How many numbers are in the sequence? (1-10)");
                sequenceNumber = Console.ReadLine();
                checkIfValidNumber = int.TryParse(sequenceNumber, out numbers);
                if (checkIfValidNumber == false)
                    Console.WriteLine("You must enter a number!\n");
                if(numbers < 0 || numbers > 10)
                    Console.WriteLine("Invalid amount of numbers!");

                for (int i = 0; i < numbers; i++)
                {
                    Console.WriteLine("Enter a sequence of numbers between 1 - 50 for min and max:");
                    number = Console.ReadLine();
                    checkIfValidNumber = int.TryParse(number, out minMaxNumber);
                    if (checkIfValidNumber == false)
                        Console.WriteLine("You must enter a number!\n");

                    if (minMaxNumber > max)
                        max = minMaxNumber;
                    if (minMaxNumber < min)
                        min = minMaxNumber;
                }
                Console.WriteLine($"{max} is your Maximum. \n{min} is your Minimum.");
            }
            

            //5.even numbers between 150-200
            Console.WriteLine("\n----------Finding the Even Numbers Between 150 and 200!-----------");
            Console.WriteLine($"Even numbers from 150-200: {EvenNumbers()}");


            //6.even numbers between 100-0
            Console.WriteLine("\n------------Finding the Even Numbers Between 100 and 0!----------------");
            Console.WriteLine($"Even numbers from 100-0: {EvenNumbersTwo()}");

            //7.ask test score, display letter grade, continue to ask until entered quit, case not sensitive
            bool quit = false;
            checkIfValidNumber = false;
            int testScore = 0;
            int testCase = 0;

            Console.WriteLine("\n-------------Finding the Letter Grade!-------------------");
            while (!quit)
            {
                Console.WriteLine("Enter a Test Score between 0 - 100 or enter quit to exit: ");
                number = Console.ReadLine();
                checkIfValidNumber = int.TryParse(number, out testScore);
                if (checkIfValidNumber == false)
                    Console.WriteLine("You must enter a number!\n");
                if (testScore < 0 || testScore > 100)
                    Console.WriteLine("Put a score between 0 - 100!!");
                if (testScore > 91)
                    testCase = 4;
                else if (testScore > 81)
                    testCase = 3;
                else if (testScore > 71)
                    testCase = 2;
                else if (testScore > 61)
                    testCase = 1;
                else
                    testCase = 0;

                GradeConverter(testCase);
                Console.WriteLine("Enter Quit or enter another score!");
                if (number.ToLower() == "quit")
                    quit = true;
            }
        }
        //}

        ////////////////////////METHODS AND LOGIC////////////////////////////////////////////

        //1.method to calculate sum of 3 numbers
        private static int Sum(int number)
        {
            int sum = 0;
            sum += number;
            return sum;
        }

        //2.method to calculate polynomial - 4x(^3) + 6x - 2
        private static double Calculate(double number)
        {
            return 4 * (Math.Pow(number, 3)) + 6 * number - 2;
        }

        //3.method to convert integers to hours, minutes, seconds
        private static string HourMinuteSecond(int sec)
        {
            int hour = 0;
            int minute = 0;

            hour = sec / 3600;
            sec = sec % 3600;
            minute = sec / 60;
            sec = sec % 60;

            return "hours: " + hour + " |minutes: " + minute + " |seconds: " + sec;
        }


        //5.method with while-loop with even numbers only between 150 - 200 ascending
        private static int EvenNumbers()
        {
            int numbers = 150;
            while (numbers < 250)
            {
                numbers++;
                if (numbers % 2 == 0)
                    Console.Write(numbers+", ");
            }
            return numbers;
        }

        //6.method with do-loop to get even integers from 100-0 descending
        private static int EvenNumbersTwo()
        {
            int number = 100;
            do
            {
                if (number % 2 == 0)
                    Console.Write($"{number}, ");
                number--;
            }
            while (number > 0); 
            return number;
        }
        //7.switch statement to convert test score into letter grade
        private static string GradeConverter(int grade)
        {
            switch(grade)
            {
                case 4:
                    Console.WriteLine("You got an A - Awesome B)");
                    break;
                case 3:
                    Console.WriteLine("You got a B - Bravo!");
                    break;
                case 2:
                    Console.WriteLine("You got a C - Crummy..");
                    break;
                case 1:
                    Console.WriteLine("You got a D - Deadly");
                    break;
                default:
                    Console.WriteLine("You failed a long time ago.");
                    break;

            }
            return $"Your grade was {grade}. Enter another score or enter 'Quit' to exit.";
        }


    }
}
