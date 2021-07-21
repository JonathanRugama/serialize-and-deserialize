using System;
using System.Text.Json;
{

}
namespace SerializeAndDeserialize
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola");
            var weatherForecast = new WeatherForecast
            {
                Date = DateTime.Parse("2019-08-01"),
                TemperatureCelsius = 25,
                Summary = "Hot"
            };

            string jsonString = JsonSerializer.Serialize(weatherForecast);
            Console.WriteLine(jsonString);
        }
    }
}
