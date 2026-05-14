using System;

public class Entry
{
    public string _name;
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"Name: {_name}\nDate: {_date} - Prompt: {_promptText}\n{_entryText}");
    }
}