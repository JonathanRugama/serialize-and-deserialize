using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeAndDeserialize
{
    class WeatherForecast
    {
        public DateTimeOffset Date { get; set; }

        public int TemperatureCelsius { get; set; }

        public string Summary { get; set; }
    }
}
