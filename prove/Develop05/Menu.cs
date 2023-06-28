using System.IO;

public class Menu
{
    int _totalPoints = 0;
    List<string> stringList = new List<string>();
    List<Goal> _goalList = new List<Goal>();


    public Menu()
    {
        
    }
        
    private void StringsToGoals(List<string> ListOfStrings, List<Goal> goalList)
    {
        foreach (string obj in ListOfStrings)
        {
            string[] stringType = obj.Split(":::");
                    
            if (stringType[0] == "SimpleGoal")
            {
                SimpleGoal sg = new SimpleGoal();
                int maxParts = 5;
                string paramaetersString = stringType[1];

                string[] parts = paramaetersString.Split("|", maxParts);

                sg.SetName(parts[0]);
                sg.SetDescription(parts[1]);
                sg.SetPoints(Convert.ToInt32(parts[2]));
                sg.SetCompletion(parts[3]);
                sg.SetOptionNumber(Convert.ToInt32(parts[4]));

                goalList.Add(sg);
            }

            if (stringType[0] == "EternalGoal")
            {
                EternalGoal eg = new EternalGoal();
                int maxParts = 5;
                string paramaetersString = stringType[1];

                string[] parts = paramaetersString.Split("|", maxParts);

                eg.SetName(parts[0]);
                eg.SetDescription(parts[1]);
                eg.SetPoints(Convert.ToInt32(parts[2]));
                eg.SetCompletion(parts[3]);
                eg.SetOptionNumber(Convert.ToInt32(parts[4]));

                goalList.Add(eg);
            }

            if (stringType[0] == "ListGoal")
            {
                ListGoal lg = new ListGoal();
                int maxParts = 8;
                string paramaetersString = stringType[1];

                string[] parts = paramaetersString.Split("|", maxParts);

                lg.SetName(parts[0]);
                lg.SetDescription(parts[1]);
                lg.SetPoints(Convert.ToInt32(parts[2]));
                lg.SetCompletion(parts[3]);
                lg.SetMaxTimes(Convert.ToInt32(parts[4]));
                lg.SetTimesAccomplished(Convert.ToInt32(parts[5]));
                lg.SetBonusPoints(Convert.ToInt32(parts[6]));
                lg.SetOptionNumber(Convert.ToInt32(parts[7]));

                goalList.Add(lg);
            }
        }
    }


    private int GetTotalPoints()
    {
        return _totalPoints;
    }

    

    public void DisplayMenu()
    {
        int menuOption = 0;
        int i = 1;
        
        Console.Clear();
        
        while(menuOption != 6)
        {
            Console.WriteLine($"You have {GetTotalPoints()} points\n");
            Console.WriteLine("Menu Options:\n   1. Create New Goal\n   2. List Goals\n   3. Save Goals\n   4. Load Goals\n   5. Record Event\n   6. Quit");
            Console.Write("Select a choice from the menu: ");
            menuOption = Convert.ToInt32(Console.ReadLine());

            if (menuOption == 1)
            {
                int createOption = 0;

                Console.WriteLine("The types of Goals are:\n   1. Simple Goal\n   2. Eternal Goal\n   3. Checklist Goal");
                Console.Write("Select a choice from the menu: ");
                createOption = Convert.ToInt32(Console.ReadLine());
                
                if (createOption == 1)
                {
                    SimpleGoal sg = new SimpleGoal();
                    string name;
                    string description;
                    int points = 0;
        
                    Console.Write("What is the name of your goal? ");
                    name = Console.ReadLine();
                    sg.SetName(name);

                    Console.Write("What is a short description of it? ");
                    description = Console.ReadLine();
                    sg.SetDescription(description);

                    Console.Write("What is the amount of points associated with this goal? ");
                    points = Convert.ToInt32(Console.ReadLine());
                    sg.SetPoints(points);

                    sg.SetOptionNumber(i);
                    i = i + 1;

                    stringList.Add($"SimpleGoal:::{sg.GetStringRepresentation()}");
                }

                else if (createOption == 2)
                {
                    EternalGoal eg = new EternalGoal();
                    string name;
                    string description;
                    int points = 0;
        
                    Console.Write("What is the name of your goal? ");
                    name = Console.ReadLine();
                    eg.SetName(name);

                    Console.Write("What is a short description of it? ");
                    description = Console.ReadLine();
                    eg.SetDescription(description);

                    Console.Write("What is the amount of points associated with this goal? ");
                    points = Convert.ToInt32(Console.ReadLine());
                    eg.SetPoints(points);

                    eg.SetOptionNumber(i);
                    i = i + 1;

                    stringList.Add($"EternalGoal:::{eg.GetStringRepresentation()}");
                }

                else if (createOption == 3)
                {
                    ListGoal lg = new ListGoal();
                    string name;
                    string description;
                    int points = 0;
                    int maxTimes = 0;
                    int bonusPoints = 0;
        
                    Console.Write("What is the name of your goal? ");
                    name = Console.ReadLine();
                    lg.SetName(name);

                    Console.Write("What is a short description of it? ");
                    description = Console.ReadLine();
                    lg.SetDescription(description);

                    Console.Write("What is the amount of points associated with this goal? ");
                    points = Convert.ToInt32(Console.ReadLine());
                    lg.SetPoints(points);
                    
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    maxTimes = Convert.ToInt32(Console.ReadLine());
                    lg.SetMaxTimes(maxTimes);

                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    bonusPoints = Convert.ToInt32(Console.ReadLine());
                    lg.SetBonusPoints(bonusPoints);

                    lg.SetOptionNumber(i);
                    i = i + 1;

                    stringList.Add($"ListGoal:::{lg.GetStringRepresentation()}");
                }
            }

            if (menuOption == 2)
            {
                if (_goalList.Count < stringList.Count)
                {
                    _goalList.Clear();
                    StringsToGoals(stringList, _goalList);
                }
                Console.WriteLine("The goals are:\n");

                foreach (Goal goal in _goalList)
                {
                    Console.WriteLine($" {goal.DisplayObjectString()}");
                }
                Console.WriteLine();
            }

            if (menuOption == 3)
            {
                string fileName = "goals.txt";
                Console.Write("What is the filename for the goal file? ");
                fileName = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    foreach (string str in stringList)
                    {
                        outputFile.WriteLine($"{str}");
                    }
                }
            }

            if (menuOption == 4)
            {
                Console.Write("What is the file name for the goal file? ");
                string fileName = Console.ReadLine();

                string[] lines = System.IO.File.ReadAllLines(fileName);

                stringList.Clear();
                foreach (string line in lines)
                {
                    stringList.Add(line);
                }

                string[] file_lines = File.ReadAllLines(fileName);
                string lastLine = file_lines[file_lines.Length - 1];
                string[] fields = lastLine.Split('|');
                string lastItem = fields[fields.Length - 1];
                i = Convert.ToInt32(lastItem);
                i = i + 1;
            }

            if (menuOption == 5)
            {
                if (_goalList.Count < stringList.Count)
                {
                    _goalList.Clear();
                    StringsToGoals(stringList, _goalList);
                }
                
                Console.WriteLine("The goals are:\n");
                foreach (Goal goal in _goalList)
                {
                    Console.WriteLine($" {goal.GetOptionNumber()}. {goal.GetName()}");
                }
                Console.Write("\nWhich goal did you accomplish? ");
                int accompOption = Convert.ToInt32(Console.ReadLine());

                if (_goalList.Count < stringList.Count)
                {
                    _goalList.Clear();
                    StringsToGoals(stringList, _goalList);
                }

                foreach (Goal goal in _goalList)
                {
                    if (accompOption == goal.GetOptionNumber())
                    {
                        goal.ChangeCompletion();
                        _totalPoints = _totalPoints + goal.GetPoints();

                        if (goal.GetCompletion() == true)
                        {
                            _totalPoints = _totalPoints + goal.GetBonusPoints();
                        }
                    }
                }
            }
        }
    }
}