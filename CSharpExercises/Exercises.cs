using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    public static class Exercises
    {
        // Example Exercise:
        // Create a method called HelloWorld that returns the following string - "Hello World!"


        public static string HelloWorld()
        {
            return "Hello World!";
        }



        // 1. Create a method called SayHello that accepts a string representing a name and returns a welcome message (E.g. "Hello John!")

        public static void SayHello()
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
        }



        // 2. Create a method called Sum that accepts two integers and returns their sum.
        public static void Sum()
        {
            int x = 10;
            int y = 3;

            Console.WriteLine(x + y);

        }


        // 3. Create a method called Divide that accepts two decimals and returns the result of dividing the two numbers as a decimal.

        public static decimal Divide(decimal d, decimal f)
        {

            Console.WriteLine("This is the divide method " + d / f);
            return d / f;

        }

        // 4. Create a method called CanOpenCheckingAccount that accepts an integer representing a customers age, returning true if the age is greater than or equal to 18, or false if the argument is less than 18.

        public static bool CanOpenCheckingAccount(int age)
        {
            if (age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        // 5. Create a method called GetFirstName that accepts a string representing a full name (e.g. "John Smith"), and returns only the first name.

        public static string GetFirstName(string fullname)
        {
            string[] nameSplit = fullname.Split(' ');
            Console.WriteLine(nameSplit[0]);
            return nameSplit[0];

        }

        // 6. Create a method called ReverseStringHard that accepts a string and returns the string in reverse. (No built in functions allowed)

        public static string ReverseStringHard(string reverse)
        {
            string input = reverse;
            string output = "";
            for (int i = input.Length - 1; i >= 0; --i)
            {
                output += input[i];
            }
            return output;

            //char[] charArray = s.ToCharArray();
            //Array.Reverse(charArray);
            //Console.WriteLine(new string(charArray));
            //return new string(charArray);
        }




        // 7. Create a method called ReverseStringEasy that accepts a string and returns the string in reverse. (Using only built in functions)

        public static string ReverseStringEasy(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);

            return new string(charArray);
        }

        // 8. Create a method called PrintTimesTable that accepts an integer and returns the times table as a string for that number up to the 10th multiplication.
        /* e.g. 10 should return
         * 10 * 1 = 10
         * 10 * 2 = 20
         * 10 * 3 = 30
         * 10 * 4 = 40
         * 10 * 5 = 50
         * 10 * 6 = 60
         * 10 * 7 = 70
         * 10 * 8 = 80
         * 10 * 9 = 90
         * 10 * 10 = 10 */


        public static string PrintTimesTable(int number)
        {
            string timesTable = "";
            for (int i = 1; i < 10; i++)
            {
                timesTable += $"{number} * {i} = {i * number}\r\n";
            }
            return timesTable += $"{number} * 10 = " + number * 10;
        }


            

        // 9. Create a method called ConvertKelvinToFahrenheit that accepts a double representing a temperature in kelvin and returns a double containing the temperature in Fahrenheit.

        public static double ConvertKelvinToFahrenheit(double Tokelvin)
        {
            double fahrenheit = ((Tokelvin - 273.15) * 9 / 5) + 32;
            return fahrenheit = Math.Round(fahrenheit, 2);
        }



        // 10. Create a method called GetAverageHard that accepts an array of integers and returns the average value as a double. (No built in functions allowed)

        public static double GetAverageHard(int[] averagevalue)
        {
            double total = 0;
            foreach (int number in averagevalue)
            {
                total += number;
            }
            total /= averagevalue.Length;
            return total;
        }



        // 11. Create a method called GetAverageEasy that accepts an array of integers and returns the average value as a double. (Using only built in functions)

        public static double GetAverageEasy(int[] average)
        {
            return average.Average();
        }

        // 12. Create a method called DrawTriangle that accepts two integers - number and width and returns a string containing a drawn triangle using the number parameter.
        /* e.g. Number: 8, Width: 8 should return
         * 88888888
         * 8888888
         * 888888
         * 88888
         * 8888
         * 888
         * 88
         * 8 */

        public static string DrawTriangle(int num, int across)
        {
            string returnstring = "";
            for (var i = across; i >= 0; i--)
            {
                for (var s = i; s >= 1; s--)
                {
                    returnstring += num.ToString();
                }
                if (i >= 2)
                {
                    returnstring += System.Environment.NewLine;
                }
            }
            return returnstring;
        }



        // 13. Create a method called GetMilesPerHour that accepts a double representing distance and three integers representing hours, minutes and seconds. The method should return the speed in MPH rounded to the nearest whole number as a string. (e.g. "55MPH")

        public static string GetMilesPerHour(double dist, int hours, int mins, int secs)
        {
            int mph = 60;
            int secPerHour = mph * 60;

            double total = hours + ((double)mins / (double)mph) + ((double)secs / (double)secPerHour);
            double speed = dist / total;

            String miles = Math.Round(speed, 0) + "MPH";

            return miles;
        }




        // 14. Create a method called IsVowel that accepts a char parameter and returns true if the parameter is a vowel or false if the parameter is a consonant.

        public static bool IsVowel(char letters)
        {
            //if (letters == 'a' || letters == 'e' || letters == 'i' || letters == 'o' || letters == 'u')
            bool vowels = "aeiouAEIOU".IndexOf(letters) > 0;
            return vowels;
            
        }


        // 15. Create a method called IsConsonant that accepts a char parameter and returns true if the parameter is a consonant or false if the parameter is a vowel.

        public static bool IsConsonant(char letters)
        {
            bool Consonants = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ".IndexOf(letters) > 0;
            return Consonants;
        }

      




        // 16. The Collatz conjecture, named after Lothar Collatz of Germany, proposed the following conjecture in 1937. 
        // Beginning with an integer n > 1, repeat the following until n == 1. If n is even, halve it. If n is odd, triple it and add 1. Following these steps, the function will always arrive at the number 1.
        // Create a method called CollatzConjecture that accepts an integer and returns the number of steps required to get to n == 1 as an integer.

        public static int CollatzConjecture(int number)
        {
            int steps = 0;
            while (number != 1)
            {
                if (number % 2 == 0)
                {
                    number = number / 2;
                }
                else
                {
                    number = number * 3 + 1;

                }
                steps++; 

            }
            return steps;
        }



        // 17. Create a method called GetNext7Days that accepts a DateTime object and returns an array of DateTime objects containing the next 7 days (including the given day).
        public static DateTime[] GetNext7Days(DateTime datesSeven)
        {
            DateTime[] dates = new DateTime[7];
            for (int i =0; i < 7; i++)
            {
                dates[i] = datesSeven.AddDays(i);
            }
            return dates;
        }


        // 18. Create a method called IsInLeapYear that accepts a DateTime object and returns true if the date falls within a leap year and false if not. (No built in functions allowed)

        public static bool IsInLeapYear(DateTime dates)
        {
            bool leapYear = false;
            int year = dates.Year;
            if (year % 4 == 0)
            {
                leapYear = true;
            }
            return leapYear;
        }


        // 19. Create a method called MortgageCalculator that accepts 2 decimals representing loan balance and interest rate, an integer representing loan term in years, and an integer representing the payment period.
        /* Payment periods: 1 - Monthly, 2 - Bi-Monthly (Every 2 months) */


        public static double MortgageCalculator(decimal principle, decimal rate, int years, int yearlyPayments)
        {
            double monthlyPayment = 0;
            double p = decimal.ToDouble(principle);
            double r = decimal.ToDouble(rate);
            int y = years;
            int n = yearlyPayments;
            if (n == 12)
            {
                double numPayments = y * 12;
                monthlyPayment = ((r / 1200) + (r / 1200) / (Math.Pow(1 + (r / 1200), numPayments) - 1)) * p;
            }
            else
            {
                double numPayments = y * 6;
                monthlyPayment = ((r / 600) + (r / 600) / (Math.Pow(1 + (r / 600), numPayments) - 1)) * p;
            }
            return Math.Round(monthlyPayment, 2);
        }




        // 20. Create a method called DuckGoose that accepts an integer. Iterate from 1 to this integer, building a string along the way.
        // If the current number in the iteration:
        //   Is divisible by 3, append "Duck" + Environment.NewLine; to the string.
        //   Is divisible by 5, append "Goose" + Environment.NewLine; to the string.
        //   Is divisible by both 3 and 5, append "DuckGoose" + Environment.NewLine; to the string.
        //   Is none of the above, append the number as a string + Environment.NewLine; to the string.
        /* Example - if the input to this method is 20, the following string should be returned
         * 1
         * 2
         * Duck
         * 4
         * Goose
         * Duck
         * 7
         * 8
         * Duck
         * Goose
         * 11
         * Duck
         * 13
         * 14
         * DuckGoose
         * 16
         * 17
         * Duck
         * 19
         * Goose
         */

        public static string DuckGoose(int number)
        {
            string words = "";
            for (int i = 1; i <= number; i++)
            {
                if (i%3 == 0)
                {
                    words += "Duck";
                }
                if (i%5 == 0)
                {
                    words += "Goose";
                }
                if (i%5 !=0 && i%3 != 0)
                {
                    words += $"{i}";
                }
                if (i != number)
                {
                    words += Environment.NewLine;
                }
            }
            return words;
                
        }
    }
}