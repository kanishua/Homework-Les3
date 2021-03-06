using System;

namespace Homework_Les3
{
    class Program
    {
        //1.The user enters 2 numbers (A and B). Raise the number A to the power of B.
        static int ExponentiateNumber(int a, int b)
        {
            int result = a;
            if (a != 0 & b > 1)
            {
                for (int i = 2; i <= b; ++i)
                {
                    result *= a;
                }
            }
            else if (a != 0 & b == 0)
            {
                result = 1;
            }
            return result;
        }

        //2.The user enters 1 number (A). Find the number of positive integers whose square is less than A.
        static int FindAmountOfPositiveIntegers(int a)
        {
            int result = 0;
            for (int n = 1; n * n < a; ++n)
            {
                result += 1;
            }
            return result;
        }

        //3.The user enters 1 number (A). Print the largest divisor (other than A itself) of the number A.
        static int FindLargestDivisors(int a)
        {
            int result = 0;
            if (a > 1)
            {
                for (int divisor = 1; divisor < a; ++divisor)
                {
                    if (a % divisor == 0)
                    {
                        result = divisor;
                    }
                }
            }
            return result;
        }

        //4.The user enters 2 numbers (A and B).
        //Print the sum of all numbers from the range A to B that are divisible by 7 without a remainder.
        //(Note that B may be less than A if you type).
        static int FindSumOfNumbers(int a, int b)
        {
            int sum = 0;
            int i;
            int endOfRange;

            if (a < b)
            {
                i = a;
                endOfRange = b;
            }
            else
            {
                i = b;
                endOfRange = a;
            }
            while (i <= endOfRange)
            {
                if (i % 7 == 0)
                {
                    sum += i;
                }
                ++i;
            }
            return sum;
        }

        //5.The user enters 1 number (N).
        //Print the Nth number of the fibonacci series.
        //In the fibonacci series, each next number is the sum of the previous two.
        //The first and second are considered equal to 1.
        static int PrintFibonacci(int n)
        {
            int sum = 1;
            int previousNumber = 1;
            int prepreviousNumber = 1;
            for (int i = 3; i <= n; i++)
            {
                sum = previousNumber + prepreviousNumber;
                prepreviousNumber = previousNumber;
                previousNumber = sum;
            }
            return sum;
        }

        //6.The user enters 2 numbers.
        //Find their greatest common divisor using Euclid's algorithm.
        static int FindDivisor(int a, int b)
        {
            int remainder;
            int x = 0;
            int y;
            if (a != 0 & b != 0)
            {
                if (a > b)
                {
                    x = a;
                    y = b;
                }
                else
                {
                    x = b;
                    y = a;
                }
                while (y > 0)
                {
                    remainder = x % y;
                    x = y;
                    y = remainder;
                }
            }
            else if ((a == 0 & b != 0) || (b == 0 & a != 0))
            {
                x = b ^ a;
            }
            return x;
        }

        //7.The user enters a positive integer that is the cube of the integer N.
        //Find the number N using binary search algorithm
        //static int FindDivisor(int a, int b)



        //8.The user enters number. Find the number of odd digits of this number.
        static int FindOddDigits(int n)
        {
            int amountOddDigits = 0;
            int digitOfN = 0;
            int oldDivisor = 1;
            for (int divisor = 10; n / oldDivisor > 0; divisor *= 10)
            {
                digitOfN = (n % divisor) / oldDivisor;
                if (digitOfN % 2 != 0)
                {
                    amountOddDigits += 1;
                }
                oldDivisor = divisor;
            }
            return amountOddDigits;
        }

        //9.The user enters number.
        //Find a number that is a mirror image of the sequence of digits of a given number,
        //for example, given the number 123, output 321.
        static int FindmMirrorNumber(int n)
        {
            int mirrorN;
            string numberInString = "";
            int digitOfN;
            int oldDivisor = 1;
            for (int divisor = 10; n / oldDivisor > 0; divisor *= 10)
            {
                digitOfN = (n % divisor) / oldDivisor;
                numberInString += digitOfN.ToString();
                oldDivisor = divisor;
            }
            mirrorN = Convert.ToInt32(numberInString);
            return mirrorN;
        }

        //10.The user enters 2 numbers.
        //Tell me if there are the same digits in the spelling of two numbers.
        //For example, for a pair of 123 and 3456789,
        //the answer would be “YES”, and for a pair of 500 and 99, “NO”.
        static string FindSameDigits(int a, int b)
        {
            string result = "No";
            int digitOfA;
            int digitOfB;
            int oldDivisorA = 1;
            int oldDivisorB = 1;
            for (int divisorA = 10; a / oldDivisorA > 0 & result != "Yes"; divisorA *= 10)
            {
                digitOfA = (a % divisorA) / oldDivisorA;
                oldDivisorA = divisorA;
                for (int divisorB = 10; b / oldDivisorB > 0; divisorB *= 10)
                {
                    digitOfB = (b % divisorB) / oldDivisorB;
                    oldDivisorB = divisorB;
                    if (digitOfA == digitOfB)
                    {
                        result = "Yes";
                        break;
                    }
                }
                oldDivisorB = 1;
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Task1");
            Console.WriteLine(ExponentiateNumber(1, 3));
            Console.WriteLine(ExponentiateNumber(2, 3));
            Console.WriteLine(ExponentiateNumber(3, 3));
            Console.WriteLine(ExponentiateNumber(0, 3));
            Console.WriteLine(ExponentiateNumber(3, 0));
            Console.WriteLine(ExponentiateNumber(0, 0));
            Console.WriteLine("");

            Console.WriteLine("Task2");
            Console.WriteLine(FindAmountOfPositiveIntegers(1));
            Console.WriteLine(FindAmountOfPositiveIntegers(10));
            Console.WriteLine("");


            Console.WriteLine("Task3");
            Console.WriteLine(FindLargestDivisors(1));
            Console.WriteLine(FindLargestDivisors(5));
            Console.WriteLine(FindLargestDivisors(10));
            Console.WriteLine(FindLargestDivisors(20));
            Console.WriteLine("");

            Console.WriteLine("Task4");
            Console.WriteLine(FindSumOfNumbers(3, 3));
            Console.WriteLine(FindSumOfNumbers(5, 21));
            Console.WriteLine(FindSumOfNumbers(27, 10));
            Console.WriteLine("");

            Console.WriteLine("Task5");
            Console.WriteLine(PrintFibonacci(4));
            Console.WriteLine("");

            Console.WriteLine("Task6");
            Console.WriteLine(FindDivisor(270, 192));
            Console.WriteLine("");

            Console.WriteLine("Task8");
            Console.WriteLine(FindOddDigits(525));
            Console.WriteLine("");

            Console.WriteLine("Task9");
            Console.WriteLine(FindmMirrorNumber(345));
            Console.WriteLine(FindmMirrorNumber(305));
            Console.WriteLine("");

            Console.WriteLine("Task10");
            Console.WriteLine(FindSameDigits(326, 6613));
            Console.WriteLine(FindSameDigits(1234, 5678));
            Console.WriteLine(FindSameDigits(1034, 560879));
            Console.WriteLine(FindSameDigits(1034, 5608));
            Console.WriteLine("");
        }
    }
}
