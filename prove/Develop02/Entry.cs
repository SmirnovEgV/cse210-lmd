public class Entry{
    public string _prompt {get; set;}
    public string _userInput {get; set;}
    public string _date {get; set;}

    public void DisplayEntry(){
        Console.WriteLine($"Date: {_date}\nPrompt: {_prompt}\nInput: {_userInput}");
    }
}