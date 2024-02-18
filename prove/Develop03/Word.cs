public class Word
{
    private const char SIGN = '*';
    public string Text { get; set; }
    public bool IsHidden { get; private set; } = false;

    public Word(string text)
    {
        Text = text;
    }

    public void Hide()
    {
        IsHidden = true;
    }

    public override string ToString()
    {
        if (IsHidden == false)
        {
            return Text;
        }
        else
        {
            // Replace the content of _word with stars
            string _hiddenWord = new string(SIGN, Text.Length);
            return _hiddenWord;
        }
    }
}