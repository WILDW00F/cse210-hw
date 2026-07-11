using System;

using System;

class Entry
{
    private string _date;
    private string _editedDate;
    private string _promptText;
    private string _entryText;

    public Entry(string prompt, string text)
    {
        _date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        _editedDate = "";
        _promptText = prompt;
        _entryText = text;
    }

    public Entry(string date, string prompt, string text, string editedDate = "")
    {
        _date = date;
        _promptText = prompt;
        _entryText = text;
        _editedDate = editedDate;
    }

    public string GetDate()
    {
        return _date;
    }

    public void Edit(string newText)
    {
        _entryText = newText;
        _editedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
    }

    public string Display()
    {
        string edited = "";

        if (_editedDate != "")
        {
            edited = $" - Edited: {_editedDate}";
        }

        return $"Date: {_date}{edited}{Environment.NewLine}" +
               $"Prompt: {_promptText}{Environment.NewLine}" +
               $"{_entryText}";
    }
}