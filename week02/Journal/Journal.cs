using System;

class Journal
{
    List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.Display());
                outputFile.WriteLine();
            }
        }
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry.Display());
            Console.WriteLine();
        }
    }

    public void LoadFromFile(string filename)
    {
        string[] lines = File.ReadAllLines(filename);

        for (int i = 0; i < lines.Length; i++)
        {
            if (lines[i] == "")
            {
                continue;
            }

            string date = lines[i].Replace("Date: ", "");
            i++;

            string editedDate = "";

            if (lines[i].StartsWith("Edited: "))
            {
                editedDate = lines[i].Replace("Edited: ", "");
                i++;
            }

            string prompt = lines[i].Replace("Prompt: ", "");
            i++;

            string text = lines[i];

            Entry entry = new Entry(date, prompt, text, editedDate);

            _entries.Add(entry);
        }
    }

    public void EditEntry(string date)
    {
        foreach (Entry entry in _entries)
        {
            if (entry.GetDate() == date)
            {
                Console.WriteLine(entry.Display());

                Console.Write("Enter the new journal entry: ");
                string newText = Console.ReadLine();

                entry.Edit(newText);

                Console.WriteLine("Entry updated.");
                return;
            }
        }
    }
}