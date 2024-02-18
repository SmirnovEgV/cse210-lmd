using System;
using System.ComponentModel.Design.Serialization;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        // file name inputs
        // Console.Write("Enter the name of the JSON file to load: ");
        string fileName = "scriptures";
        var scriptures = new List<Scripture>();
        // JSON deserialization into list of scriptures
        try
        {
            string jsonString = File.ReadAllText(fileName + ".json");

            scriptures = JsonSerializer.Deserialize<List<Scripture>>(jsonString) ?? new List<Scripture>();

            Console.WriteLine("Entries loaded from JSON file successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error loading from file: " + ex.Message);
        }
        // calls a method in Scripture class that does the same thing for reference class.
        // fills the list object with processed data
        foreach (var scripture in scriptures)
        {
            scripture.PopulateWords();
        }

        // option to choose a scripture. It gives a index for specific scripture dynamically
        var scriptureLength = scriptures.Count();
        var scriptureIndex = 0;
        Console.Clear();
        foreach (var scripture in scriptures)
        {
            Console.WriteLine($"{scriptureIndex + 1}) {scripture}");
            scriptureIndex++;
        }


        Scripture? chosenScripture = null;
        
        // Choice controller that lets user choose only proper indexes. Breaks if caracters are inputed.
        while (chosenScripture == null)
        {
            Console.WriteLine($"Select a scripture to memorize from 1 to {scriptureLength}");
            var inputIndex = Convert.ToInt32(Console.ReadLine()) - 1;

            if (inputIndex < 0 | inputIndex >= scriptureLength)
            {
                Console.WriteLine("Index is not valid. Try again");
            }
            else
            {
                Console.WriteLine("Selected Scripture is the following:");
                chosenScripture = scriptures[inputIndex];
            }
        }

        // Code that outputs a choosen scripture and calls method to hide words.
        // Does this while all of the scripture is not hidden or quit command is not entered  
        var isMemorizing = true;
        while (isMemorizing)
        {
            Console.Clear();
            Console.WriteLine("Let's try memorizing it! If you want to quit, enter 'quit'\n");

            var isEverythingHidden = chosenScripture.RandomizeWords(2);

            Console.WriteLine(chosenScripture);

            var input = Console.ReadLine();

            if (input == "quit" || isEverythingHidden)
            {
                isMemorizing = false;
                Console.WriteLine("You've memorized the scripture! Standing by.");
            }
        }
    }
}