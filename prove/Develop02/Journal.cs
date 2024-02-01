public class Journal{

    
    
    PromptGenerator promptGenerator;
    public List<Entry> _entries = new List<Entry>();

    public Journal()
    {
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

        foreach (var _entry in _entries){
            _entry.DisplayEntry();            
        }

    }
    public void SaveToFile(){

    }
    public List<Entry> LoadFromFile(){
        return _entries;
    }

}