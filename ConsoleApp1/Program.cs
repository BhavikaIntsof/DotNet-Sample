using System;
using Newtonsoft.Json;
using System.Globalization;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CultureInfo culture = new CultureInfo("en-US");
            Console.WriteLine(culture.DateTimeFormat);
            string currentCulture = Thread.CurrentThread.CurrentCulture.DisplayName;
            DateTime dateTime = DateTime.Now;
            string dateInUSA = dateTime.ToString( new CultureInfo("en-us"));
            Console.WriteLine(dateInUSA);
            string dateInIndia = dateTime.ToString(new CultureInfo("hi-IN"));
            Console.WriteLine(dateInIndia);
            string dateInFrench = dateTime.ToString("D",new CultureInfo("fr-FR"));
            Console.WriteLine(dateInFrench);
        }
    }
}
