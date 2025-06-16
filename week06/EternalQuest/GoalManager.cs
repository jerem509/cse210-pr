using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public GoalManager()
    {}
 
    public void Start() 
    {
        bool action = true;
        while(action == true) {
            Console.WriteLine($"You have {_score} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Create new goal \n2. List goals \n3. Save goals \n4. Load goals \n5. Record event \n6. Quit");
            Console.Write("\nSelect an option from the menu: ");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoalDetails();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    action = false;
                    // Console.Clear();
                    break;
                default: 
                    Console.WriteLine("You should select a number from the menu.");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo() 
    {
        Console.WriteLine($"\n{_score}");
        Console.WriteLine();
    }

    public void ListGoalNames() {
        Console.WriteLine("The goals are: "); 
        if (_goals.Count == 0) 
        {
            Console.WriteLine("You have no goal recorded yet. Create a goal first.");
        }
        else {
            int i = 0;
            foreach (Goal goal in _goals)
            {
                Console.WriteLine($"{i+1} {goal.GetGoalName()}");
                i++;
            }
        }
    }

    public void ListGoalDetails() 
    {
        if (_goals.Count == 0) 
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You have no goal recorded yet. Create a goal first.\n");
            Console.ResetColor();
        }
        else 
        {
            Console.WriteLine("The goals are: ");
            int i = 0;
            foreach (Goal goal in _goals)
            {
                Console.WriteLine($"{i+1}. {goal.GetDetailsString()}");
                i++;
            }
            Console.WriteLine();
        }
    }

    public void CreateGoal() 
    {
        List<int> goalTypes = new List<int>{1, 2, 3};
        Console.WriteLine("The types of goals are \n1. Simple goal \n2. Eternal goal \n3. Checklist goal");
        Console.Write("Which type of goal would you like to create? ");
        while (true)
        {
            try
            {
                int option = int.Parse(Console.ReadLine());

                if(goalTypes.Contains(option))
                {
                    Console.WriteLine();
                    Console.Write($"What is the name of your goal: ");
                    string name = Console.ReadLine();
                    Console.Write($"What is a short description of it: ");
                    string description = Console.ReadLine();
                    Console.Write($"What is the amount of points associated with this goal: ");
                    string points = Console.ReadLine();
                    if (option == 1) 
                    {
                        _goals.Add(new SimpleGoal(name, description, points));
                    }
                    else if (option == 2) 
                    {
                        _goals.Add(new EternalGoal(name, description, points));
                    } 
                    else if (option == 3) 
                    {
                        Console.Write("How many times does this goal need to be accomplished? ");
                        int target = int.Parse(Console.ReadLine());
                        Console.Write("What is the bonus for accomplishing it that many times?: ");
                        int bonus = int.Parse(Console.ReadLine());
                        _goals.Add(new ChecklistGoal(target, bonus, name, description, points));
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Please select a valid number from the above list.");
                }
            }
            catch (FormatException)
            {
                
                Console.WriteLine("Error. Select a number from the list.");
            }
        }
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal did you accomplish?: ");
        int goal = int.Parse(Console.ReadLine());
        if (_goals[goal-1].IsComplete() == true)
        {
            Console.WriteLine("\nThe goal has already been completed!");
            ListGoalDetails();
            Console.WriteLine("Choose another goal number to record the event.");
        }
        else if (_goals[goal-1].IsComplete() == false) 
        {
            _goals[goal-1].RecordEvent();
            _score += int.Parse(_goals[goal-1].GetGoalPoints());
            ListGoalDetails();
            Console.WriteLine($"Congratulations. You now have earned {_score} points.");
            Console.WriteLine();
        }
    }

    public void SaveGoals() 
    {
        while(true)
        {
            Console.WriteLine("What is the filename? ");
            string filename = Console.ReadLine();
            string pattern = @"^[A-Za-z]{3,}[0-9]*\.(txt|csv)$";
            if (Regex.IsMatch(filename, pattern, RegexOptions.IgnoreCase))
            {
                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    //show the score
                    outputFile.WriteLine(_score);
                    //loop through each goal and get their string representation
                    foreach (Goal goal in _goals)
                    {
                        // Add text to the file
                        outputFile.WriteLine(goal.GetStringRepresentation());
                    }
                    
                }
                //informing user entries are saved to the desired file.
                Console.WriteLine($"Entries saved to file {filename}");
                break;
            }
            else
            {
                Console.WriteLine("Invalid filename. It must start with at least 3 letters and end with '.txt'. No whitespace allowed.");
            }  
        }
        
    }

    public void LoadGoals()
    {
        Console.WriteLine("Enter the name of the file to load data from: ");
        string filename = Console.ReadLine();
        Console.WriteLine();
        string pattern = @"^[A-Za-z]{3,}[0-9]*\.(txt|csv)$";
        if (Regex.IsMatch(filename, pattern, RegexOptions.IgnoreCase))
        {
            string[] lines = System.IO.File.ReadAllLines(filename);

            //clear the list of goals
            _goals.Clear();

            //iterate through each line of the file and append them to the list of entries
            foreach (string line in lines)
            {
                string[] parts = line.Split("|");
                if (parts.Length == 1)
                {
                    _score = int.Parse(parts[0]);
                }
                else if (parts.Length > 1)
                {
                    //object name
                    string objectName = parts[0];
                    //object variables part
                    string variables = parts[1];
                    //split string of variables
                    string[] objVariables = variables.Split(";");
                    //extract the parts
                    string name = objVariables[0];
                    string description = objVariables[1];
                    string points = objVariables[2];

                    switch (objectName)
                    {
                        case "SimpleGoal":
                            bool completed = bool.Parse(objVariables[3]);
                            _goals.Add(new SimpleGoal(completed, name, description, points));
                            break;
                        case "EternalGoal":
                            _goals.Add(new EternalGoal(name, description, points));
                            break;
                        case "ChecklistGoal":
                            int bonus = int.Parse(objVariables[3]);
                            int target = int.Parse(objVariables[4]);
                            int amount = int.Parse(objVariables[5]);
                            _goals.Add(new ChecklistGoal(amount, target, bonus, name, description, points));
                            break;
                    }
                }
            }
        }
        else 
        {
            Console.WriteLine("Invalid filename. It must start with at least 3 letters and end with '.txt'. No whitespace allowed.");
        }
    }
}