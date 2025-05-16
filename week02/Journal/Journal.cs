/* To show creativity and exceed requirements, I added an extra prompt to
the user asking them what they think will happen tomorrow, and added that to
their response in each journal entry. */

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        DateTime date = DateTime.Now;
        newEntry._date = date.ToString("MMM d yyyy");
        PromptGenerator generator = new PromptGenerator();
        newEntry._prompt = generator.GetPrompt();
        Console.WriteLine($"\n{newEntry._prompt}");
        Console.WriteLine("Write your response below: ");
        newEntry._input = Console.ReadLine();
        Console.WriteLine("What do you think will happen on this subject tomorrow?");
        newEntry._input += " Tomorrow, " + Console.ReadLine();
        _entries.Add(newEntry);
    }

    public void DisplayJournal()
    {
        Console.WriteLine();
        foreach (Entry e in _entries)
        {
            e.Display();
            Console.WriteLine();
        }
    }

    public void SaveFile(string filename)
    {
        using (StreamWriter output = new StreamWriter(filename))
        {
            foreach (Entry e in _entries)
            {
                output.WriteLine($"{e._date}|||{e._prompt}|||{e._input}");
            }
        }
    }

    public void LoadFile(string filename)
    {
        int i = 0;
        string[] lines = System.IO.File.ReadAllLines(filename);

        /* If the loaded journal is shorter than the current journal,
        replace the entries up to the loaded journal's length,
        then remove the other existing entries. */
        if (lines.Length <= _entries.Count())
        {
            foreach (string line in lines)
            {
                string[] parts = line.Split("|||");
                _entries[i]._date = parts[0];
                _entries[i]._prompt = parts[1];
                _entries[i]._input = parts[2];
                i++;
            }
            while (i < _entries.Count())
            {
                _entries.RemoveAt(i);
            }
        }
        /* If the length of the loaded journal is greater than or equal
        to the length of the current journal, replace current entries,
        then add new entries until the whole journal is loaded. */
        else
        {
            foreach (string line in lines)
            {
                Entry newEntry = new Entry();
                string[] parts = line.Split("|||");
                if (i < _entries.Count())
                {
                    _entries[i]._date = parts[0];
                    _entries[i]._prompt = parts[1];
                    _entries[i]._input = parts[2];
                    i++;
                }
                else
                {
                    newEntry._date = parts[0];
                    newEntry._prompt = parts[1];
                    newEntry._input = parts[2];
                    _entries.Add(newEntry);
                    i++;
                }
            }
        }
    }
}