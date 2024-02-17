public class Verse
{
    public List<Word> _words;
    public Verse()
    {
        _words = new List<Word>();
    }

    public string number {get; set;}
    public string content
    {
        get { return string.Join(" ",  _words); }
        
        set {
            
            string[] words = value.Split(' ');

            foreach(string word in words)
            {
                _words.Add(new Word(word));
            }
        }
    }

    public string ScriptureText()
    {
        string results = string.Join(" ", _words);
        return results;
    }
    public void StateChange() 
    {
        int listCount = _words.Count();

    }
}

