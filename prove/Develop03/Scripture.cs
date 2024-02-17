using System;
using System.Collections.Generic;

public class Scripture
{
    public string book {get; set;}
    public string chapter {get; set;}
    public List<Verse> verses { get; set;}

    public void Output()
    {
        foreach (var verse in verses)
        {
            string singleVerse = verse.ScriptureText()

        }
        string results = 
        Console.WriteLine($"{book} {chapter} {results}");
    }
    
}