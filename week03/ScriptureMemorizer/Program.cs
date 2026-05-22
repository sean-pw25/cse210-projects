// To show creativity and exceed core requirements, I added the ability to select the amount of words to hide at a time when starting the program

using System;
class Program
{
    static void Main(string[] args)
    {
        string inputNumberToHide;
        int numberToHide;
        do
        {
            Console.Clear();
            Console.Write("Welcome to the Scripture Memorizer. Please select how many words you would like to hide when pressing enter: ");
            inputNumberToHide = Console.ReadLine();
        } while (!int.TryParse(inputNumberToHide, out numberToHide));

        Reference reference = new Reference("Genesis", 1, 26, 27);
        Scripture scripture = new Scripture(reference, "And God said, Let us make man in our image, after our likeness: and let them have dominion over the fish of the sea, and over the fowl of the air, and over the cattle, and over all the earth, and over every creeping thing that creepeth upon the earth. So God created man in his own image, in the image of God created he him; male and female created he them.");
        bool loop = true;
        while (loop == true)
        {

            Console.Clear();
            Console.WriteLine($"{reference.GetDisplayText()} {scripture.GetDisplayText()}");
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string inputContinue = Console.ReadLine();
            if (inputContinue == "")
            {
                if (scripture.IsCompletelyHidden() == false)
                {
                    scripture.HideRandomWords(numberToHide);
                }
                else
                {
                    loop = false;
                }
            }
            else if (inputContinue == "quit")
            {
                loop = false;
            }
        }
    }
}