using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================================================================================================");
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
            Console.WriteLine("================================================================================================");
            Console.WriteLine("\n");
            Console.WriteLine("================================================================================================");
            Console.WriteLine("================================================================================================");
            Console.WriteLine("PROGRAM FROM THE BOOK!");

            double width, height, woodLength, glassArea;
            string widthString, heightString;
            Console.WriteLine("Please type the width of the window");
            widthString = Console.ReadLine();
            Console.WriteLine("Please type the height of the window");
            width = double.Parse(widthString);
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");
            Console.WriteLine("================================================================================================");
            Console.WriteLine("================================================================================================");
            Console.ReadKey();
        }
    }
}
