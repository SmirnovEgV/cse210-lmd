public class Entry{
    public string _prompt;
    public string _userInput;
    public string _date;

    public void DisplayEntry(){
        Console.WriteLine($"Date: {_date}\nPrompt: {_prompt}\nInput: {_userInput}");
    }
}