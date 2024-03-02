class Counter
{
    public void PauseAndShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"Countdown: {i}");
            Thread.Sleep(1000);
            Console.SetCursorPosition(0, Console.CursorTop - 1); // Move the cursor up one line
        }
    }
}