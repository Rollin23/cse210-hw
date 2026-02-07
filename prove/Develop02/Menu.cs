using System;
using System.IO;     
using System.Collections.Generic;


namespace JournalApp
{
    public class Menu
    {
        public bool IsRunning = true;
        public List<Entry> _entries = new();

        public void Run()
        {
            while (IsRunning)
            {
                //Displays options 
                ShowMenu();

                Console.Write("What would you like to do? ");
                string input = Console.ReadLine();

                if (input == "1") _entries.Add(Entry.GetEntry());
                else if (input == "2") DisplayEntries();
                else if (input == "3") LoadFile();
                else if (input == "4") SaveFile();
                else if (input == "5") IsRunning = false;
                else Console.WriteLine("That's not a valid choice.");
            }

            Console.WriteLine("Goodbye!");
        }


        public void ShowMenu()
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
        }


        public void DisplayEntries()
        {
            if (_entries.Count == 0)
            {
                Console.WriteLine("No entries yet.");
                return;
            }

            foreach (Entry e1 in _entries)
            {
                e1.Display();
            }
        }


        public void SaveFile()
        {
            Console.Write("What is the file name? ");
            string FileName = Console.ReadLine();

            using (StreamWriter OutputFile = new StreamWriter(FileName))
            {
                foreach (Entry e1 in _entries)
                {
                    OutputFile.WriteLine($"Date: {e1._date} - Prompt: {e1._question}");
                    OutputFile.WriteLine(e1._response);
                    OutputFile.WriteLine();        
                }
            }
        }


        public void LoadFile()
        {
            Console.Write("What is the file name? ");
            string LFile = Console.ReadLine();

            string [] lines = System.IO.File.ReadAllLines(LFile);

            for (int i = 0; i < lines.Length; i += 3)
            {
                string Line1 = lines[i];
                string Line2 = lines[i + 1];

                string[] parts = Line1.Split(" - Prompt: ");
                string Date = parts[0].Replace("Date: ", "").Trim();
                string Question = parts[1].Trim();

                string Response = Line2;

                Entry e1 = new Entry();
                e1._date = Date;
                e1._question = Question;
                e1._response = Response;

                _entries.Add(e1);

            }
        }
    }
}