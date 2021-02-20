using System;
using System.Globalization;
using System.Net;
using System.Xml;

namespace Exercise01_WeatherForecast
{
    class Program
    {
        static float getTemperature(XmlDocument doc)
        {
            XmlNodeList minTemps = doc.SelectNodes("weatherdata/product/time/location/minTemperature");
            XmlNode minTemp = minTemps.Item(0);
            string stringMinTemp = minTemp.OuterXml;
            int startIndex = stringMinTemp.IndexOf("value=");
            stringMinTemp = stringMinTemp.Substring(startIndex + 7); // skip value="
            string temperature = null;
            int counter = 0;
            while (stringMinTemp[counter] != '"')
            {
                temperature += stringMinTemp[counter++];
            }

            return float.Parse(temperature, CultureInfo.InvariantCulture.NumberFormat);
        }

        static float getWindSpeed(XmlDocument doc)
        {
            XmlNodeList windSpeeds = doc.SelectNodes("weatherdata/product/time/location/windSpeed");
            XmlNode windSpeed = windSpeeds.Item(0);
            string stringWindSpeed = windSpeed.OuterXml;
            int startIndex = stringWindSpeed.IndexOf("mps=");
            stringWindSpeed = stringWindSpeed.Substring(startIndex + 5); // skip mps="
            string wind = null;
            int counter = 0;
            while (stringWindSpeed[counter] != '"')
            {
                wind += stringWindSpeed[counter++];
            }

            return float.Parse(wind, CultureInfo.InvariantCulture.NumberFormat);
        }

        static float getPressure(XmlDocument doc)
        {
            XmlNodeList pressures = doc.SelectNodes("weatherdata/product/time/location/pressure");
            XmlNode pressure = pressures.Item(0);
            string stringPressure = pressure.OuterXml;
            int startIndex = stringPressure.IndexOf("value=");
            stringPressure = stringPressure.Substring(startIndex + 7); // skip value="
            string press = null;
            int counter = 0;
            while (stringPressure[counter] != '"')
            {
                press += stringPressure[counter++];
            }

            return float.Parse(press, CultureInfo.InvariantCulture.NumberFormat);
        }
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            XmlDocument doc = new XmlDocument();

            Console.WriteLine("Latitude: ");
            string lat = Console.ReadLine();
            Console.WriteLine("Longtitude: ");
            string lon = Console.ReadLine();

            string result = client.DownloadString("https://api.met.no/weatherapi/locationforecast/1.9/?lat=" + lat + "&lon=" + lon);
            doc.LoadXml(result);
            Console.WriteLine("Temperature: " + getTemperature(doc) + " C");
            Console.WriteLine("Wind speed: " + getWindSpeed(doc) + " m/s");
            Console.WriteLine("Pressure: " + getPressure(doc) + " hPa");
        }
    }
}
