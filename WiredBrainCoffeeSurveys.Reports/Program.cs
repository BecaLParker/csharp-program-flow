using System;
using System.Collections.Generic;

namespace WiredBrainCoffeeSurveys.Reports
{
    class Program
    {
        static void Main(string[] args)
        {
            var tasks = new List<string>();

            //Calculated values
            double responseRate = Q1Results.NumberResponded / Q1Results.NumberSurveyed;
            double unansweredCount = Q1Results.NumberSurveyed - Q1Results.NumberResponded;

            //Logical comparisons
            bool isCoffeeScoreLower = Q1Results.CoffeeScore < Q1Results.FoodScore;

            if (isCoffeeScoreLower)
            {
                return;
            }
            tasks.Add("Investigate coffee recipes and ingredients.");
        }
    }
}
