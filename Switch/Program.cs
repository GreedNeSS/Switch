using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            SwitchExample();
            SwitchOnEnumExample();
            ExecutePatternMatchingSwitch();
            ExecutePatternMatchingSwitchWithThen();
            Console.ReadLine();
        }

        static void SwitchExample()
        {
            Console.WriteLine("1 [C#], 2 [VB]");
            Console.WriteLine("Please pick your language preference: ");
            string langChoice = Console.ReadLine();

            int n = int.Parse(langChoice);
            switch (n)
            {
                case 1:
                    Console.WriteLine("Good choice, C# is a fine language.");
                    break;
                case 2:
                    Console.WriteLine("VB: OOP, multithreading, and more!");
                    break;
                default:
                    Console.WriteLine("Well...good luckwith that!");
                    break;
            }
            Console.WriteLine();
        }

        static void SwitchOnEnumExample()
        {
            Console.Write("Enter your favorite day of the week: ");
            DayOfWeek favDay;
            try
            {
                favDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek),
                    Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Bad input!");
                return;
            }
            switch (favDay)
            {
                case DayOfWeek.Sunday:
                    Console.WriteLine("Football!");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("Another day, another dollar.");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("At least it is not Monday.");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("A fine day!");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Almost Friday...");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Yes, Friday rules!");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Great day indeed.");
                    break;
            }
            Console.WriteLine();
        }

        static void ExecutePatternMatchingSwitch()
        {
            Console.WriteLine("1 [Integer (5)], " +
                "2 [String (\"Hi\")], 3 [Decimal(2.5)]");
            Console.WriteLine("Please choose an option");
            string userChoice = Console.ReadLine();
            object choice;

            switch (userChoice)
            {
                case "1":
                    choice = 5;
                    break;
                case "2":
                    choice = "Hi";
                    break;
                case "3":
                    choice = 2.5;
                    break;
                default:
                    choice = 5;
                    break;
            }

            switch (choice)
            {
                case int i:
                    Console.WriteLine($"Your choice is an integer = {i}");
                    break;
                case string s:
                    Console.WriteLine($"Your choice is an string = {s}");
                    break;
                case double d:
                    Console.WriteLine($"Your choice is an double = {d}");
                    break;
                default:
                    Console.WriteLine("Your choice is something else");
                    break;
            }
            Console.WriteLine();
        }

        static void ExecutePatternMatchingSwitchWithThen()
        {
            Console.WriteLine("1 [C#], 2 [VB]");
            Console.WriteLine("Please pick your language preference: ");
            object langChoice = Console.ReadLine();

            var choice = int.TryParse(langChoice.ToString(),
                out int c) ? c : langChoice;

            switch (choice)
            {
                case int i when i == 1:
                case string s when s.Equals("C#", StringComparison.OrdinalIgnoreCase):
                    Console.WriteLine("Good choice, C# is a fine language.");
                    break;
                case int i when i == 2:
                case string s when s.Equals("VB", StringComparison.OrdinalIgnoreCase):
                    Console.WriteLine("VB: OOP, multithreading, and more!");
                    break;
                default:
                    Console.WriteLine("Well...good luckwith that!");
                    break;
            }
        }

    }
}
