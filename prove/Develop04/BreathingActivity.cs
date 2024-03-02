using System;
using System.Threading;


class BreathingActivity : Activity
{
    private int Cycles;

    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
        
    }
    public void BreathingExersices()
    {
        DisplayStartingMessage();
        GetDurationFromUser();
        Cycles = activityLength / 10;

        for (int i = 0; i < Cycles; i += 1)
        {
            Console.WriteLine("\n Breathe in...");
            PauseAndShowCountdown(4);
            Thread.Sleep(1000);

            if (i < Cycles)
            {   
                Console.WriteLine("\n Breathe out...");
                PauseAndShowCountdown(6);
                Thread.Sleep(1000);
            }
        }
        
        DisplayEndingMessage();

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