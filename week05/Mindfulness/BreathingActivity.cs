public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly.\nClear your mind and focus on your breathing";
    }


    public void Run()
    {
        DisplayStartingMessage();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        Breathe(3, 3);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Breathe(4, 6);
        }

        Console.WriteLine();
        DisplayEndingMessage();
    }

    private void Breathe(int secondsIn, int secondsOut)
    {
        Console.Write("\nBreathe in...");
        ShowCountDown(secondsIn);
        Console.Write("\nNow breathe out...");
        ShowCountDown(secondsOut);
    }

}