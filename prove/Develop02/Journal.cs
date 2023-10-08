public class Journal
{
    
    public List<Entry> _entries = new List<Entry>();

    //This is for the option Write.
    public void DisplayEntries()
    {
        foreach (Entry ent in _entries)
        {
            Console.WriteLine(ent.DisplayString());
        }
    }
    //This is for the option 4.
    public void SaveToFile(string filemane)
    {
        
        using (StreamWriter outputFile = new StreamWriter(filemane))
        foreach (Entry ent in _entries)
        {
            outputFile.WriteLine(ent.DisplayString());
        }
    }
    //This is for the option 3.
    public void LoadJournal(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(".");
            Console.WriteLine(parts[0]);
        }
    }
    //Add entry to the _entries list.
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
}