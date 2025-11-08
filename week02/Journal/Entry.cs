public class Entry
{
    public string _date;
    public string _prompt;
    public string _answer;

    public Entry(string date, string prompt, string answer)
    {
        _date = date;
        _prompt = prompt;
        _answer = answer;
    }
    public Entry() { }

    public void display()
    {
        Console.WriteLine($"{_date} - prompt: {_prompt}");
        Console.WriteLine($"{_answer}");
        Console.WriteLine();
    }
    public string GetString()
    {
        return $"{_date}|{_prompt}|{_answer}";
    }
}