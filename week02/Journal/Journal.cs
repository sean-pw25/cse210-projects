using System;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine("name|date|prompt|entry");
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._name}|{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
    }
    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            Entry entry = new Entry();
            string[] parts = line.Split("|");
            entry._name = parts[0];
            entry._date = parts[1];
            entry._promptText = parts[2];
            entry._entryText = parts[3];
            _entries.Add(entry);
        }
    }
}