using System;
using System.Threading;


class BreathingActivity : Activity
{
    private int _cycles;

    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
        
    }
    public void BreathingExersices()
    {
        DisplayStartingMessage();
        _cycles = activityLength / 10;

        for (int i = 0; i < _cycles; i += 1)
        {
            Console.WriteLine("\nBreathe in...");
            PauseAndShowCountdown(4);
            Thread.Sleep(1000);

            if (i < _cycles)
            {   
                Console.WriteLine("\nBreathe out...");
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