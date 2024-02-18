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
    // Returns true / false and changes the state of Word object
    public bool RandomizeWord()
    {
        
        var WordssToHide = Words.Where<Word>(x => !x.IsHidden).ToList();
        if (WordssToHide.Count == 0)
        {
            return true;
        }
        var word = WordssToHide[new Random().Next(WordssToHide.Count())];
        word.Hide();

        return false;
    }
    public bool IsEverythingHidden()
    {
        return  Words.Count(x => !x.IsHidden) == 0; 
    }
}