using System.IO;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();
    public string GetRandomPrompt()
    {
        string filename = "prompts.txt";
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            _prompts.Add(line);
        }
        Random random = new Random();
        int promptPicker = random.Next(_prompts.Count);
        return _prompts[promptPicker];
    }
}