using System;
using System.Configuration;

namespace Park
{
    class Program
    {
        static string attraction;
        public static int minimumHeight = AttractionSettings.GetValueByKey("MinimumHeighForBatman");
        
        static void Main(string[] args)

        {
            DayWeek dayOfWeek;
            var a = minimumHeight;
            Console.Write("Please enter your Height (centimeter):");
            int height = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                Console.Write("Please enter Day of week (i.e. Sun, Mon etc):");

                if (Enum.TryParse(Console.ReadLine(), out dayOfWeek))
                    break;

                Console.Clear();
                Console.Write("Please enter ONE MORE TIME Day of week (i.e. Sun, Mon etc):");
            }

            Console.Write("Please enter your Gender (male/female):");
            string gender = Console.ReadLine();

            Console.Write("Please enter your Name:");
            string name = Console.ReadLine();

            ShowNameAndAttraction(height, (int)dayOfWeek, gender, name);
        }

        static void ShowNameAndAttraction(int height, int dayOfWeek, string gender, string name)
        {
            if ((dayOfWeek == 1 || dayOfWeek == 3 || dayOfWeek == 5) && height > 150 && gender == "male")
            {
                attraction = "Batman";
                Console.WriteLine($"{name}, please enjoy {attraction} attraction");
            }

            else if ((dayOfWeek >= 2 && dayOfWeek <= 4) && ((gender == "female" && height > 120 && height < 140) || (gender == "male" && height < 140)))
            {
                attraction = "Swan";
                Console.WriteLine($"{name}, please enjoy {attraction} attraction");
            }

            else if (dayOfWeek != 7)
            {
                attraction = "Swan";
                Console.WriteLine($"{name}, please enjoy {attraction} attraction");
            }
            Console.ReadLine();
        }

        //Kids kids = new Kids();

    }
}
