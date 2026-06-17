// Added a new option "delete goal" which allows the user to select a goal to remove from the list of goals

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}