using System;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }


    public void DisplayStartingMessage()
    {
        Console.Clear();

        Console.WriteLine($"--- {_name} Activity ---\n");
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like your session to be? ");

        while (!int.TryParse(Console.ReadLine(), out _duration) || _duration <= 0)
        {
            Console.Write("Please enter a valid positive number: ");
        }

        Console.WriteLine("\nGet ready...");
        ShowSpinner(3);
        Console.Clear();
    }


    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!");
        ShowSpinner(3);

        Console.WriteLine($"\nYou have completed {_duration} seconds of the {_name} Activity.");
        ShowSpinner(3);

        Console.WriteLine();
    }

    // Spinner animation
    public void ShowSpinner(int seconds)
    {
        char[] spinner = { '|', '/', '-', '\\' };

        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int index = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[index]);
            Thread.Sleep(200);
            Console.Write("\b");

            index = (index + 1) % spinner.Length;
        }

        Console.Write(" ");
        Console.Write("\b");
    }


    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);

            Console.Write("\b \b");

            if (i >= 10)
            {
                Console.Write("\b \b");
            }
        }

        Console.WriteLine();
    }


    public int GetDuration()
    {
        return _duration;
    }


    public string GetName()
    {
        return _name;
    }


    public string GetDescription()
    {
        return _description;
    }


    public void SetDuration(int duration)
    {
        _duration = duration;
    }
}