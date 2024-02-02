using System.Text.Json;
public class Journal{

    // good that I can find info online on how to make this things
    //initialization of classes
    PromptGenerator promptGenerator;
    // still have no idea on get set things but without it info is not passign, so I need it.
    public List<Entry> _entries { get; private set; }
    // this one is object creation stage.
    public Journal()
    {
        _entries = new List<Entry>();
        promptGenerator = new PromptGenerator();
    }
    
    // input method uses entry class to operate
    public void PromptUserEntry(){
        //init of single obj
        var entry = new Entry();
        //date and time and next one is shortening of date time 
        DateTime curTime = DateTime.Now;
        entry._date = curTime.ToShortDateString();
        //Request of a random prompt from other class method
        entry._prompt = promptGenerator.GetRandomPrompt();
        // user should see the random prompt
        Console.WriteLine(entry._prompt);
        // input
        entry._userInput = Console.ReadLine(); 
        // add to a list and display what was written
        _entries.Add(entry);
        Console.WriteLine("Entry created:");
        entry.DisplayEntry();
    }

    public void DisplayAllEntries(){
        // just a loop to display entries and simple explanation
        Console.WriteLine("All entries:");

        foreach (var _entry in _entries){
            _entry.DisplayEntry();            
        }

    }
    public void SaveToFile(){
        // file name inputs
        Console.WriteLine("Enter the name of the file:");
        string fileName = Console.ReadLine();
        // AI suggestion to put it into try catch
        try 
        {   
            // serialization to a JSON file + naming and output. 
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
        // file name inputs
        Console.Write("Enter the name of the JSON file to load: ");
        string fileName = Console.ReadLine();

        try
        {   
            // Putting json file into string
            string jsonString = File.ReadAllText(fileName + ".json");
            // deserializing string into multiple objects
            _entries = JsonSerializer.Deserialize<List<Entry>>(jsonString);


            Console.WriteLine("Entries loaded from JSON file successfully.");
            // returning this objects. Withoug GET SET would return noting
            return _entries;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error loading from file: " + ex.Message);
            return null; // Or return an empty list to handle the error gracefully
        }
    }

}