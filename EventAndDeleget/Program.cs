using System;
using EventAndDeleget.Properties;

namespace EventAndDeleget
{
    internal class Program
    {
        public delegate int Increment(int x, int y, int z);

        public static int CongHaiSo(int x, int y, int z)
        {
            return x + y;
        }

        public static int CongBaSo(int a, int b, int c )
        {
            return  a + b + c;
        }
        
        public static void Add2(ref int x)
        {
            x += 2;
        }

        public static void Add3(ref int x)
        {
            x += 3;
        }

        public static void Main(string[] args)
        {
            // Increment increment = new Increment(Add2);
            // increment += Add3;
            // increment += Add2;
            // int x = 5;
            // increment(ref x);
            // Console.WriteLine(x);
            // Increment increment = CongBaSo;
            // var ketQua = increment(4, 5, 6);
            // Console.WriteLine(ketQua);
            Thermostat thermostat = new Thermostat();
            Heater heater = new Heater(60);
            thermostat.OnTemperatureChange += heater.OnTemperatureChanged;
            Heater heater1 = new Heater(100);
            thermostat.OnTemperatureChange += heater1.OnTemperatureChanged;
            Cooler cooler = new Cooler(80);
            thermostat.OnTemperatureChange += cooler.OnTemperatureChanged;
            string temperature;
            Console.WriteLine("Enter temperature: ");
            temperature = Console.ReadLine();
            thermostat.CurrentTemperature = int.Parse(temperature);
            Console.ReadLine();
        }
    }
}