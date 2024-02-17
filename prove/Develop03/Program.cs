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
        try
        {   
            // Putting json file into string
            string jsonString = File.ReadAllText(fileName + ".json");

            // deserializing string into multiple objects
            var listOfScriptureObjects = JsonSerializer.Deserialize<List<Scripture>>(jsonString);

            Console.WriteLine("Entries loaded from JSON file successfully.");

            foreach (var scripture in listOfScriptureObjects)
            {
                scripture.Output();
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine("Error loading from file: " + ex.Message);  
        }

        
        
    

    }
}