using System;
using System.IO;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("You currently have no entries. ");
            return;
        }

        else
        {
            foreach (Entry entry in _entries)
            {
                entry.DisplayEntry();
            }
        }


    }
    public void SaveFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            //SHOWING CREATIVITY AND EXCEEDING REQUIREMENTS: This will give a header row, which will give a description of each column. 
            outputFile.WriteLine("Date,Prompt,Response");

            foreach (Entry entry in _entries) 
            {
                //SHOWING CREATIVITY AND EXCEEDING REQUIREMENTS: This section will show how to save the file as comma separated so it can be saved as a .csv file.
                outputFile.WriteLine($"{entry._date},{entry._prompt},{entry._userResponse}");
            }
        }
    }

    public void LoadFile(string fileName)
    {
        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found. ");
            return;
        }

        _entries.Clear();

        string[] lines = File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            {
                Entry entry = new Entry
                {
                    _date = parts[0],
                    _prompt = parts[1],
                    _userResponse = parts[2],
                };
                _entries.Add(entry);
            }
        }
    }
}
