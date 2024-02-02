using System.Text.Json;
public class Journal{

    PromptGenerator promptGenerator;
    public List<Entry> _entries { get; private set; } = new List<Entry>();
    public Journal()
    {
        _entries = new List<Entry>();
        promptGenerator = new PromptGenerator();
    }
    

    public void PromptUserEntry(){
        var entry = new Entry();
        
        DateTime curTime = DateTime.Now;

        entry._date = curTime.ToShortDateString();

        entry._prompt = promptGenerator.GetRandomPrompt();

        Console.WriteLine(entry._prompt);

        entry._userInput = Console.ReadLine(); 

        _entries.Add(entry);
        Console.WriteLine("Entry created:");
        entry.DisplayEntry();
    }

    public void DisplayAllEntries(){

        Console.WriteLine("All entries:");
        Console.WriteLine(_entries.Count);

        foreach (var _entry in _entries){
            _entry.DisplayEntry();            
        }

    }
    public void SaveToFile(){
        Console.WriteLine("Enter the name of the file:");
        string fileName = Console.ReadLine();

        try 
        {
            string jsonString = JsonSerializer.Serialize(_entries);
            File.WriteAllText(fileName + ".json", jsonString);
            Console.WriteLine("Entries saved to JSON file successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error saving to file: " + ex.Message);
        }
    }
    public List<Entry> LoadFromFile(){

        Console.Write("Enter the name of the JSON file to load: ");
        string fileName = Console.ReadLine();

        try
        {
            string jsonString = File.ReadAllText(fileName);
            Console.WriteLine(jsonString);

            _entries = JsonSerializer.Deserialize<List<Entry>>(jsonString);

            Console.WriteLine(_entries.Count);


            Console.WriteLine("Entries loaded from JSON file successfully.");

            return _entries;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error loading from file: " + ex.Message);
            return null; // Or return an empty list to handle the error gracefully
        }
    }

}