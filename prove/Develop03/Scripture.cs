using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

public class Scripture
{   // This makes deserializer work without it I would need to change Book to book and so on.
    [JsonPropertyName("book")]
    public string? Book { get; set; }
    [JsonPropertyName("chapter")]
    public string? Chapter { get; set; }
    [JsonPropertyName("verses")]
    public List<Reference> Verses { get; set; } = new List<Reference>();
    
    // Calls the same-name method from Reference to fill the list of Verses
    public void PopulateWords()
    {
        foreach (var verse in Verses)
        {
            verse.PopulateWords();
        }
    }
    // extracts verse numbers and redacts it
    public string GetReference()
    {
        var verses = Verses.Count() > 1 ? $"{Verses.First().Number}-{Verses.Last().Number}" : Verses.First().Number;
        return $"{Book} {Chapter}:{verses}";
    }

    public string GetVerses()
    {
        string result = "";

        foreach (var verse in Verses)
        {
            result += verse.ToFormattedString() + "\n";
        }

        return result;
    }

    public override string ToString()
    {
        return $"{GetReference()}\n{GetVerses()}";
    }
    // looks for hidden words. If all hidden returns true and exits the program
    public bool RandomizeWords(int count)
    {
        for (int i = count; i >= 0; i--)
        {
            foreach(var verse in Verses){
                verse.RandomizeWord();
            }
        
        }
        foreach (var verse in Verses)
        {
            if (!verse.IsEverythingHidden())
            {
                return false;
            }
            
        }
        return true;
    }
}