using System;
using System.Threading;


class ListingActivity : Activity
{
    private int duration;

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        
    }

    public void ListingExercises()
    {
        DisplayStartingMessage();
        GetDurationFromUser();
        duration = activityLength;

        string randomPrompt = GetRandomPrompt();
        Console.WriteLine(randomPrompt);
        Console.WriteLine("You have a few seconds to begin thinking about the prompt...");
        CountDown(10);
        CountdownMessage();

        Console.WriteLine("Now, start listing items related to the prompt!");
        Console.WriteLine("Press Enter after each item. You can continue until the time runs out...");

        int itemCount = 0;
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            string newItem = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(newItem))
                break;

            itemCount++;
        }
        
        Console.Clear();
        Console.WriteLine($"You listed {itemCount} items!");
        Thread.Sleep(4000);
        
        DisplayEndingMessage();

    }
     private string GetRandomPrompt()
    {
        string[] prompts = {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        Random random = new Random();
        int index = random.Next(prompts.Length);
        return prompts[index];
    }

    private void CountdownMessage()
    {
        for (int i = 3; i > 0; i--)
        {
            Console.WriteLine($"Starting in {i}...");
            Thread.Sleep(1000);
            Console.Clear();
        }
    }
    
}