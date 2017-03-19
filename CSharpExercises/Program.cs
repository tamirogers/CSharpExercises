using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharpExercises
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(Exercises.HelloWorld());
            Exercises.SayHello();
            Exercises.Sum();
            Exercises.Divide(10, 5);
            Assert("CanOpenCheckingAccount(16) returns false", Exercises.CanOpenCheckingAccount(16) == false);
            Exercises.GetFirstName("Robert Smith");
            Assert("ReverseStringHard() will reverse the string", Exercises.ReverseStringHard(Constants.Quote) == Constants.QuoteReversed);
            Assert("ReverseStringEasy() will reverse the string", Exercises.ReverseStringEasy(Constants.Quote) == Constants.QuoteReversed);
            Assert("PrintTimesTable(9) prints", Exercises.PrintTimesTable(9) == Constants.TimesTableFor9);
            Assert("ConvertKelvinToFahrenheit(300) returns 80.33", Exercises.ConvertKelvinToFahrenheit(300) == 80.33);
            Assert("GetAverageHard should return 1 for [1, 1, 1]", Exercises.GetAverageHard(new int[] { 1, 1, 1 }) == 1);
            Assert("GetAverageEasy(new int[] { 1, 1 }) return 1", Exercises.GetAverageEasy(new int[] { 1, 1 }) == 1);
            Assert("DrawTriangle(8, 5) drawing", Exercises.DrawTriangle(8, 5) == Constants.TriangleFor8and5);
            Assert("GetMilesPerHour(1, 1, 1, 1) returns \"1MPH\"", Exercises.GetMilesPerHour(1, 1, 1, 1) == "1MPH");
            Assert("IsVowel returns true for u", Exercises.IsVowel('u') == true);
            Assert("IsVowel returns false for z", Exercises.IsVowel('z') == false);
            Assert("IsConsonant() retruns true for t", Exercises.IsConsonant('t') == true);
            Assert("IsConsonant('e') returns true", Exercises.IsConsonant('e') == false);
            Assert("CollatzConjecture(12) returns 9", Exercises.CollatzConjecture(12) == 9);
            Assert("GetNext7Days() returns next 7 days", JsonConvert.SerializeObject(Exercises.GetNext7Days(DateTime.Parse("08/22/2016"))) == JsonConvert.SerializeObject(Constants.Next7Days));
            Assert("IsLeapYear() returns true for 2016", Exercises.IsInLeapYear(new DateTime(2016, 4, 2)) == true);
            Assert("MortgageCalculator(500000, 4, 30, 12) should return 2387.08", Exercises.MortgageCalculator(500000, 4, 30, 12) == 2387.08);
            Assert("DuckGoose(100) returns", Exercises.DuckGoose(100) == Constants.DuckGooseResult);


            Console.WriteLine("Press any key to exit");
            Console.ReadLine();

        }

        /// <summary>
        /// Asserts that a condition is true and prints a message to the console.
        /// </summary>
        /// <param name="exerciseName">The name of the exercise</param>
        /// <param name="condition">The condition to assert</param>
        static void Assert(string exerciseName, bool condition)
        {
            if (condition)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"[PASS] - {exerciseName}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[FAIL] - {exerciseName}");
            }

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    }



