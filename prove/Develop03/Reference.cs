using System.Text.Json.Serialization;

public class Reference
{
    private const string SEPARATOR = " ";

    [JsonPropertyName("number")]
    public string Number { get; set; } = "";
    [JsonPropertyName("content")]
    public string Content { get; set; } = "";
    public List<Word> Words { get; set; } = new List<Word>();
    public override string ToString()
    {
        return $"{Number} {Content}";
    }

    public string ToFormattedString()
    {
        var words = string.Join(SEPARATOR, Words.Select(x => x.ToString()));
        return $"{Number} {words}";
    }

    public void PopulateWords()
    {
        Words = new List<Word>();
        var words = Content.Split(SEPARATOR);

        foreach (var word in words)
        {
            Words.Add(new Word(word));
        }

    }

    public bool RandomizeWord()
    {
        var isEverythingHidden = Words.Count(x => !x.IsHidden) == 0;

        if (isEverythingHidden)
        {
            return true;
        }

        var word = Words[new Random().Next(Words.Count())];
        word.Hide();

        return false;
    }
}