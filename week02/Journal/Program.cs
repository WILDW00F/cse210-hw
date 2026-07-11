using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator PromptGenerator = new PromptGenerator();
        Journal Journal = new Journal();

        int input = -1;
        string file = "";

        while (true)
        {
            Console.Write("""
            Please select one of the following choices:
            1. Write
            2. Display
            3. Load
            4. Save
            5. Edit
            6. Quit
            What would you like to do? 
            """);

            if (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.Write("Please enter a valid number.");
                continue;
            }

            if (input == 1)
            {
                string prompt = PromptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string entry = Console.ReadLine();

                Entry newEntry = new Entry(prompt, entry);

                Journal.AddEntry(newEntry);
            }
            else if (input == 2)
            {
                Journal.DisplayAll();
            }
            else if (input == 3)
            {
                Console.Write("What file would you like to open? ");
                file = Console.ReadLine();

                Journal.LoadFromFile(file);
            }
            else if (input == 4)
            {
                Console.Write("What file would you like to save? ");
                file = Console.ReadLine();

                Journal.SaveToFile(file);
            }
            else if (input == 5)
            {
                Console.Write("Enter the date/time of the entry to edit: ");
                string date = Console.ReadLine();

                Journal.EditEntry(date);
            }
            else if (input == 6)
            {
                break;
            }
        }
    }
}