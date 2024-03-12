using System.IO; 

public class Journal
{
    public List<Entry>_entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }


    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            // show the entries written
            entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string file)
    {
        string filename = file;
    
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry.Date}|{entry._promptText}|{entry._entryText}"); //the entry is saved like this on the file
            }
        }
    }

    public void LoadFromFile(string file)
    { 
        string filename = file;
        string [] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

        }
    }
}
    