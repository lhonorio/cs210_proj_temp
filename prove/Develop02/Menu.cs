using System.IO;

public class Menu
{
    List<string> _stringList = new List<string>();
    List<Entry> _entryList = new List<Entry>();


    public void DisplayMenu()
    {
        Console.WriteLine("Welcome to the Journal Program!");
        int menuOption = 0;
        while(menuOption != 5)
        {
            Console.WriteLine("Please select one of the following choice:");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("What would you like to do? ");
            menuOption = Convert.ToInt32(Console.ReadLine());

            if (menuOption == 1)
            {
                Entry entry = new Entry();
                Prompt prompt = new Prompt();

                entry.SetCurrentDate();

                string promptQuestion = prompt.GetRandomPrompt();
                entry.SetPrompt(promptQuestion);
                Console.WriteLine($"{promptQuestion}");
                Console.Write("> ");
                string entryAnswer = Console.ReadLine();
                entry.SetEntry(entryAnswer);

                _entryList.Add(entry);
            }

            else if (menuOption == 2)
            {
                foreach (Entry entry in _entryList)
                {
                    Console.WriteLine($" {entry.DisplayEntry()}\n");
                    _stringList.Add(entry.GetStringRepresentation());
                }
            }

            else if (menuOption == 3)
            {
                Console.Write("What is the name of the file? ");
                string fileName = Console.ReadLine();

                Console.WriteLine("Step1");

                string[] lines = System.IO.File.ReadAllLines(fileName);

                // _stringList.Clear();
                // foreach (string line in lines)
                // {
                //     _stringList.Add(line);
                // }
                Console.WriteLine("Step2");
            
                foreach (string line in lines)
                {
                    Console.WriteLine("Step3");
                    int maxParts = 3;
                    Entry entry = new Entry();

                    string[] parts = line.Split("|||", maxParts);

                    entry.SetDate(parts[0]);
                    entry.SetPrompt(parts[1]);
                    entry.SetEntry(parts[2]);

                    _entryList.Add(entry);
                }
            }
            

            else if (menuOption == 4)
            {
                string fileName = "journal.txt";
                
                Console.Write("What is the name of the file? ");
                fileName = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    foreach (string str in _stringList)
                    {
                        outputFile.WriteLine($"{str}");
                    }
                }
            }
        }
    }
}