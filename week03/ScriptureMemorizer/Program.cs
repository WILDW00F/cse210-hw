using System;

// I added the feature that the user can select and input whatever scripture they want to memorize. The program will then display the scripture and hide random words until the user has memorized it. The user can also type "quit" to exit the program at any time.
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter the book name:");
        string book = Console.ReadLine();


        Console.WriteLine("Enter the chapter:");
        int chapter = int.Parse(Console.ReadLine());


        Console.WriteLine("Enter the starting verse:");
        int verse = int.Parse(Console.ReadLine());


        Console.WriteLine("Enter the ending verse (0 if only one verse):");
        int endVerse = int.Parse(Console.ReadLine());


        Reference reference;


        if (endVerse == 0)
        {
            reference = new Reference(book, chapter, verse);
        }
        else
        {
            reference = new Reference(book, chapter, verse, endVerse);
        }


        Console.WriteLine("\nEnter the scripture text:");

        string text = Console.ReadLine();


        Scripture scripture = new Scripture(reference, text);



        while (!scripture.IsCompletelyHidden())
        {

            Console.Clear();


            Console.WriteLine(scripture.GetDisplayText());


            Console.WriteLine("\nPress Enter to hide words or type quit:");

            string input = Console.ReadLine();


            if (input.ToLower() == "quit")
            {
                break;
            }


            scripture.HideRandomWords(3);

        }


        Console.Clear();

        Console.WriteLine(scripture.GetDisplayText());

    }
}