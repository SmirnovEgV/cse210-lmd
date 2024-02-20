public class Word
{
    private const char SIGN = '*';
    public string Text { get; private set; }
    public bool IsHidden { get; private set; } = false;

    public Word(string text)
    {
        Text = text;
    }

    public void Hide()
    {
        IsHidden = true;
    }
    
    // Apparently the easiest way to manipulate strings. It either returns normal text or modified string with * (Or anything else).
    public override string ToString()
    {
        if (IsHidden == false)
        {
            return Text;
        }
        else
        {
            // Replace the content of _word with stars
            string hiddenWord = new string(SIGN, Text.Length);
            return hiddenWord;
        }
    }
}