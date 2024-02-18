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

        foreach (var scripture in scriptures)
        {
            scripture.PopulateWords();
        }

        var scriptureLength = scriptures.Count();
        var scriptureIndex = 0;
        foreach (var scripture in scriptures)
        {
            Console.WriteLine($"{scriptureIndex + 1}) {scripture}");
            scriptureIndex++;
        }


        Scripture? chosenScripture = null;

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

        var isPlaying = true;
        while (isPlaying)
        {
            // Console.Clear();
            Console.WriteLine("Let's try memorizing it! If you want to quit, enter 'quit'");
            Console.WriteLine();

            var isEverythingHidden = chosenScripture.RandomizeWords(35);

            Console.WriteLine(chosenScripture);

            var input = Console.ReadLine();

            if (input == "quit" || isEverythingHidden)
            {
                isPlaying = false;
                Console.WriteLine("Thank you, Good bye!");
            }
        }
    }
}