using System;
using System.Collections.Generic;
using System.Threading;


class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>{
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."};
    private List<string> _questions = new List<string>{
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        
    }
    public void ReflectingExersices()
    {
        DisplayStartingMessage();
        Console.WriteLine("Welcome to the Reflecting Activity!");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(activityLength);

        while (DateTime.Now < endTime)
        {
            string randomPrompt = GetRandomPrompt();
            Console.WriteLine(randomPrompt);
            Console.WriteLine("Think about it for a few seconds");
            CountDown(30);

            Console.Clear();

            for (int i = 0; i < 10; i++)
            {
                // Display random question
                string randomQuestion = GetRandomQuestion();
                Console.WriteLine(randomQuestion);

                CountDown(20);

                // Check if time has passed the limit
                if (DateTime.Now >= endTime)
                {
                    break; // Exit the inner loop if time is up
                }

                Console.Clear();
            }

            // Display message when activity time is over
            if (DateTime.Now >= endTime)
            {
                Console.WriteLine("Time's up!");
                 break; // Exit the outer loop after displaying the message
            }
        }
        
        DisplayEndingMessage();

    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    private void InitializePrompts()
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
    }

    private void InitializeQuestions()
    {
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }
    
    private void PauseAndShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"Countdown: {i}");
            Thread.Sleep(1000);
            Console.SetCursorPosition(0, Console.CursorTop - 1); // Move the cursor up one line
        }
    }
}