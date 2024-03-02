public class Activity
{
    protected string activityName;
    protected string activityDescription;
    protected int activityLength;
    
    public Activity(string name, string description)
    {
        activityName = name;
        activityDescription = description;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {activityName}");
        Console.WriteLine(activityDescription);
        CountDown(5);
        Console.WriteLine("Press Enter when you are ready...");
        Console.ReadLine();
        Console.WriteLine("Starting activity...");
        CountDown(5);
        Console.Clear();
    }

    public void DisplayEndingMessage()
    {
        Console.Clear();
        Console.WriteLine("Well done!");
        Console.WriteLine($"You have completed {activityLength} seconds of {activityName}");
        CountDown(10);
    }

    public void GetDurationFromUser()
    {
        Console.Write("Enter the duration in seconds: ");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int result) && result > 0)
            {
                activityLength = result;
                break;
            }
            else
            {
                Console.Write("Invalid input. Please enter a positive integer: ");
            }
        }
    }

    public void CountDown(int time){
    for (int i = 0; i < time; i++){
        switch (i % 4){
            case 0: Console.WriteLine("|"); break;
            case 1: Console.WriteLine("/"); break;
            case 2: Console.WriteLine("-"); break;
            case 3: Console.WriteLine("\\"); break;
        }
    Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
    Thread.Sleep(250);
    }
    Console.WriteLine(" ");
    }
}