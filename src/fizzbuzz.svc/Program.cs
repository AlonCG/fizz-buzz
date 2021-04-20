using fizzbuzz.svc;
using System;

namespace fizzbuzz.console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzz Control Center ======>");
            Console.Write("Enter the start value (integer > 0):");
            var startValue = Convert.ToInt64(Console.ReadLine());
            Console.Write("Enter the end value (0 for a single value test, integer > startValue):");
            var endValue = Convert.ToInt64(Console.ReadLine());

            var adjustedEnd = endValue > 0 
                ? endValue.ToString() 
                : $"{startValue} [Single Value Test]";
            Console.WriteLine($"Start: {startValue}, End: {adjustedEnd} ");
            Console.WriteLine("FizzBuzz Results ======>");
            
            if (endValue < 1) {
                var executeSingle = new ExecuteSingle(startValue);
                var result = executeSingle.Execute();
                Console.WriteLine($"FizzBuzz calc of {startValue} === {result}");
            } else {
                var executeRange = new ExecuteRange(startValue, endValue);
                var results = executeRange.Execute();
                foreach (var result in results) {
                    Console.WriteLine($"FizzBuzz calc === {result}");
                }
            }
        }
    }
}
