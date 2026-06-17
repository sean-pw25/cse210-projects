using System.Diagnostics;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;


    public GoalManager()
    {
        _goals = [];
        _score = 0;
    }


    public void Start()
    {
        int choice = 0;

        while (choice != 7)
        {
            Console.Clear();
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Main Menu");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Delete Goal");
            Console.WriteLine("  7. Quit");
            Console.Write("Select a choice from the menu: ");

            try
            {
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CreateGoal();
                        break;

                    case 2:
                        ListGoalDetails();
                        break;

                    case 3:
                        SaveGoals();
                        break;

                    case 4:
                        LoadGoals();
                        break;

                    case 5:
                        RecordEvent();
                        break;

                    case 6:
                        DeleteGoal();
                        break;
                }
            }
            catch (FormatException)
            {
                // Empty so the exception is swallowed and allows the main menu to repeat instead of closing the program if a user enters a non-integer selection.
            }
        }
        Console.WriteLine("Goodbye");
    }

    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }
    }

    public void ListGoalDetails()
    {
        Console.Clear();
        Console.WriteLine($"You have {_goals.Count} goals:");
        if (_goals.Count >= 1)
        {
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
            }
        }
        else
        {
            Console.WriteLine("You currently have no goals set.");
        }
        DisplayPlayerInfo();
        Console.Write("\nPress any key to continue");
        Console.ReadKey();
    }

    private void CreateGoal()
    {
        int choice;
        string name;
        string description;
        int points;
        int target;
        int bonus;

        Console.Clear();
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Select a type of goal to create: ");
        try
        {
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    Console.Write("Please provide a name for this goal: ");
                    name = Console.ReadLine();
                    Console.Write("Please a short description of this goal: ");
                    description = Console.ReadLine();
                    Console.Write("Please provide a point amount to be received when this goal is complete: ");
                    points = int.Parse(Console.ReadLine());
                    SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                    _goals.Add(simpleGoal);
                    break;

                case 2:
                    Console.Write("Please provide a name for this goal: ");
                    name = Console.ReadLine();
                    Console.Write("Please a short description of this goal: ");
                    description = Console.ReadLine();
                    Console.Write("Please provide a point amount to be received when this goal is complete: ");
                    points = int.Parse(Console.ReadLine());

                    EternalGoal eternalGoal = new EternalGoal(name, description, points);
                    _goals.Add(eternalGoal);
                    break;

                case 3:
                    Console.Write("Please provide a name for this goal: ");
                    name = Console.ReadLine();
                    Console.Write("Please a short description of this goal: ");
                    description = Console.ReadLine();
                    Console.Write("Please provide a point amount to be received each time this goal is complete: ");
                    points = int.Parse(Console.ReadLine());
                    Console.Write("Please enter how many times this goal must be accomplished to receive a bonus: ");
                    target = int.Parse(Console.ReadLine());
                    Console.Write("Please enter a bonus to be received upon the final completion of this goal: ");
                    bonus = int.Parse(Console.ReadLine());

                    ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                    _goals.Add(checklistGoal);
                    break;

                default:
                    break;
            }
        }
        catch (FormatException)
        {
            CreateGoal();
        }
    }

    public void RecordEvent()
    {
        Console.Clear();
        Console.WriteLine("The goals are:");
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        try
        {
            int goalSelect = int.Parse(Console.ReadLine()) - 1;
            if (_goals[goalSelect].IsComplete() == false)
            {
                _goals[goalSelect].RecordEvent();
                _score += _goals[goalSelect].GetPoints();
            }
            else
            {
                Console.WriteLine("This goal has already been completed.");
            }
            Console.Write("Press any key to continue");
            Console.ReadKey();
        }
        catch (FormatException)
        {
            RecordEvent();
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"{_score}");
            foreach (Goal g in _goals)
            {
                outputFile.WriteLine($"{g.GetStringRepresentation()}");
            }
        }
    }

    public void LoadGoals()
    {
        _goals.Clear();
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        string[] lines = File.ReadAllLines(fileName);
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] goalParts = lines[i].Split(">");
            string[] goalData = goalParts[1].Split("|");

            if (goalParts[0] == "SimpleGoal")
            {
                SimpleGoal simpleGoal = new SimpleGoal(goalData[0], goalData[1], int.Parse(goalData[2]), bool.Parse(goalData[3]));
                _goals.Add(simpleGoal);
            }
            else if (goalParts[0] == "EternalGoal")
            {
                EternalGoal eternalGoal = new EternalGoal(goalData[0], goalData[1], int.Parse(goalData[2]));
                _goals.Add(eternalGoal);
            }
            else if (goalParts[0] == "ChecklistGoal")
            {
                ChecklistGoal checklistGoal = new ChecklistGoal(goalData[0], goalData[1], int.Parse(goalData[2]), int.Parse(goalData[4]), int.Parse(goalData[3]), int.Parse(goalData[5]));
                _goals.Add(checklistGoal);
            }
        }
    }

    public void DeleteGoal()
    {
        Console.Clear();
        Console.WriteLine("Your current goals are:");
        ListGoalNames();
        Console.Write("\nWhich goal would you like to remove? ");
        int removeSelect = int.Parse(Console.ReadLine()) - 1;
        Console.WriteLine($"\nRemoved goal: \"{_goals[removeSelect].GetName()}\"");
        _goals.Remove(_goals[removeSelect]);
        Console.Write("Press any key to continue");
        Console.ReadKey();
    }
}