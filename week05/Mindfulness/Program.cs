using System;

// I have exceeded requirements by adding logic so the prompts/questions are never repeated more than once per session of an activity.

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear();

            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("-------------------");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("\nSelect a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    Pause();
                    break;

                case "2":
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.Run();
                    Pause();
                    break;

                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    Pause();
                    break;

                case "4":
                    running = false;
                    Console.WriteLine("\nThank you for using the Mindfulness Program!");
                    break;

                default:
                    Console.WriteLine("\nInvalid selection.");
                    Pause();
                    break;
            }
        }
    }

    static void Pause()
    {
        Console.WriteLine("\nPress Enter to return to the menu...");
        Console.ReadLine();
    }
}