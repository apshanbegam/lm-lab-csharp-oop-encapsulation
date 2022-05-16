using System;
namespace Encapsulation.Models
{
    public class WeatherReporter
    {
        private string _location;
        private double _temperatureInCelsius;

        public WeatherReporter(string location, double temperatureInCelsius)
        {
            _location = location;
            _temperatureInCelsius = temperatureInCelsius;
        }

        public string PrintWeatherReport()
        {
            
            return $"I am in {_location} and it is {Icon()}. {Weather()}. The temperature in Fahrenheit is {TempInFahrenheit()}.";
        }

        private double TempInFahrenheit()
        {
            double Fahrenheit = (9.0 / 5.0) * _temperatureInCelsius + 32;
            return Fahrenheit;
        }

        private string Icon()
        {
            if (_location == "London") return "🌦";
            else if (_location == "California") return "🌅";
            else if (_location == "Cape Town") return "🌤";
            return "🔆";
        }

        private string Weather()
        {
            if (_temperatureInCelsius > 30) return "It's too hot 🥵!";
            else if (_temperatureInCelsius < 10) return "It's too cold 🥶!";
            return "Ahhh...it's just right 😊!";
        }

    }
}

