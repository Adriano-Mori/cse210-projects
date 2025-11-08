using System;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.display();
        }
    }
    public void SaveToFile(string filename)
    {
        List<string> lines = new List<string>();
        foreach (Entry e in _entries)
        {
            lines.Add(e.GetString());
        }
        File.WriteAllLines(filename, lines);
        Console.WriteLine("Journal saved!");
    }
    public void LoadFromFile(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        _entries.Clear();
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            Entry e = new Entry();
            e._date = parts[0];
            e._prompt = parts[1];
            e._answer = parts[2];
            _entries.Add(e);
        }
        Console.WriteLine("Journal loaded successfully!");
    }
}