public class ReflectingActivity : Activity
{
    private List<string> _prompts = [
        "Think of a time when you did something really difficult.",
        "Think of a time when you stood up for someone else",
        "Think of a time when you helped someone in need.",
        "Think of a time you did something truly selfless."
        ];
    private List<string> _questions = [
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    ];


    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and\nresilience. This will help you recognize the power you have and how you can use it in other\naspects of your life.";
    }


    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        DisplayQuestions();
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        return _questions[random.Next(_questions.Count)];
    }

    private void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"\n --- {GetRandomPrompt()} ---");
    }

    private void DisplayQuestions()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        Console.Clear();
        do
        {
            Console.Write($"> {GetRandomQuestion()} ");
            ShowSpinner(15);
            Console.WriteLine();

        } while (DateTime.Now < endTime);
    }
}