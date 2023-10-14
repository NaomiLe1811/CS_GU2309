using System;

namespace Weight_Caculating
{
    class Program
    {
        static void Main(string[] args)
        {
            double height;
            double weight;
            double bmi;

            Console.WriteLine("Please input your hegiht: ");
            height = float.Parse(Console.ReadLine());
            Console.WriteLine("Please input your wegiht: ");
            weight = float.Parse(Console.ReadLine());

            bmi = weight / Math.Pow(height, 2);
            bmi = Math.Round(bmi, 1);

            Console.Write("Your BMI: " + bmi);

            if (bmi < 18)
                Console.WriteLine("You are underweight");
            else if (bmi < 25.0)
                Console.WriteLine("You are normal");
            else if (bmi < 30.0)
                Console.WriteLine("You are cverweight");
            else
                Console.WriteLine("You are obese");

            Console.ReadKey();
        }
    }
}
