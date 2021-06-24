using System;

namespace BtLab8
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var random = new Random();
            var number = new double[300];
            for (var i = 0; i < 300; i++)
            {
                number[i] = random.Next(0, 1000);
            }

            while (true)
            {
                Console.Write("vui long nhap so min: ");
                var min = int.Parse(Console.ReadLine());
                Console.WriteLine(
                    $"Tra ve : {GreaterCount(number, min)} lan temperature lon hon so min da nhap: {min}");
            }
        }

        public static int GreaterCount(double[] enumerable, double min)
        {
            var count = 0;
            foreach (var item in enumerable)
            {
                if (double.Parse(item.ToString()) >= min)
                {
                    count++;
                }
            }

            return count;
        }
    }
}