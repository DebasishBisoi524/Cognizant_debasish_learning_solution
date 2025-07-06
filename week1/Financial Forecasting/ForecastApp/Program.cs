using System;

namespace FinancialForecasting
{
    class FinancialForecast
    {
        // Recursive method to calculate future value
        public static double PredictFutureValueRecursive(double presentValue, double growthRate, int years)
        {
            if (years == 0)
                return presentValue;

            return PredictFutureValueRecursive(presentValue, growthRate, years - 1) * (1 + growthRate);
        }

        // Iterative method (optimized)
        public static double PredictFutureValueIterative(double presentValue, double growthRate, int years)
        {
            for (int i = 0; i < years; i++)
            {
                presentValue *= (1 + growthRate);
            }
            return presentValue;
        }

        // Using Math.Pow for most efficient calculation
        public static double PredictFutureValueDirect(double presentValue, double growthRate, int years)
        {
            return presentValue * Math.Pow(1 + growthRate, years);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("----- Financial Forecast Tool -----\n");

            Console.Write("Enter present value (₹): ");
            double presentValue = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter annual growth rate (%): ");
            double ratePercent = Convert.ToDouble(Console.ReadLine());
            double growthRate = ratePercent / 100.0;

            Console.Write("Enter number of years: ");
            int years = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nCalculating future value...");

            double resultRecursive = PredictFutureValueRecursive(presentValue, growthRate, years);
            double resultIterative = PredictFutureValueIterative(presentValue, growthRate, years);
            double resultDirect = PredictFutureValueDirect(presentValue, growthRate, years);

            Console.WriteLine($"\n→ Recursive Approach : ₹{Math.Round(resultRecursive, 2)}");
            Console.WriteLine($"→ Iterative Approach : ₹{Math.Round(resultIterative, 2)}");
            Console.WriteLine($"→ Direct (Power)     : ₹{Math.Round(resultDirect, 2)}");

            Console.WriteLine("\nForecast completed.");
        }
    }
}
