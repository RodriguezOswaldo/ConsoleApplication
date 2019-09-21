using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================================================================================================");
            //Variables Containing my Name and Location
            string myName = "Oswaldo Rodriguez", myLocation = "Columbia, SC";
            Console.WriteLine($"My name is {myName}.");
            Console.WriteLine($"I currently live in {myLocation}.");
            //Variable Containing the Date.
            string todaysDate = DateTime.Today.ToString("yyy, MM, dd");
            Console.WriteLine($"Today is {todaysDate}");
            //Varible Containing Current Yeaar
            int currentYear = DateTime.Today.Year;
            DateTime today = DateTime.Today;
            DateTime christmas = new DateTime(currentYear, 12, 25);
            TimeSpan daysLeft = christmas - today;

            int days = daysLeft.Days;
            Console.WriteLine($"Therefore, there are {days.ToString()} days before Christmas, get your Christmas gifts ready!.");
            Console.WriteLine("================================================================================================");
        }
    }
}
