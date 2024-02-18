using System.Text.Json.Serialization;

public class Scripture
{
    [JsonPropertyName("book")]
    public string? Book { get; set; }
    [JsonPropertyName("chapter")]
    public string? Chapter { get; set; }
    [JsonPropertyName("verses")]
    public List<Verse> Verses { get; set; } = new List<Verse>();

    public void PopulateWords()
    {
        foreach (var verse in Verses)
        {
            verse.PopulateWords();
        }
    }

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

    public bool RandomizeWords(int count)
    {
        for (int i = count; i >= 0; i--)
        {
            var verse = Verses[i % Verses.Count()];
            var isEverythingHidden  = verse.RandomizeWord();
            if (isEverythingHidden) {
                return true;
            }
        }
        return false;
    }
}



// Moisiah 5:13-14 - DONE
// 13 And now....
// 14 ....