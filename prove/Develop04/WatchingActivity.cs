using System;
using System.Diagnostics;

class WatchingActivity
{
    private string target { get; set; } = "https://www.youtube.com/watch?v=qRTVg8HHzUo";

    // No try-catch needed if only this assignment is used
    public void WatchVideo()
    {
        try
        {
            System.Diagnostics.Process.Start(target);
        }
        catch (System.Exception ex)
        {
            // Handle all exceptions, including potential browser-related issues
            Console.WriteLine(ex.Message);
        }
    }

}