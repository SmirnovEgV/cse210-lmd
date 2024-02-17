using System;

public class Word
{
    public String Text { get; set; }
    public Boolean IsHidden { get; private set; } = false;

    public Word(String text)
    {
        this.Text = text;
    }
    


    public void Hide()
    {
        this.IsHidden = true;
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
            string _hiddenWord = new string('*', Text.Length);
            return _hiddenWord;
        }
    }
}