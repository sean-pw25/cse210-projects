using System.ComponentModel;

class Program
{
    public static void Main(string[] args)
    {

        Job job1 = new Job();
        job1._jobTitle = "Warehouse Worker";
        job1._company = "Peekaboo";
        job1._startYear = 2020;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._jobTitle = "Shelf Stocker";
        job2._company = "Wal-Mart";
        job2._startYear = 2026;
        job2._endYear = 2026;

        Resume myResume = new Resume();
        myResume._name = "Sean Wood";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.Display();
    }
}