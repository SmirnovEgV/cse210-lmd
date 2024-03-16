class SaveAndLoad
{
    public string PromptForFileName()
    {
        Console.WriteLine("Enter the name of the CSV file (without extension):");
        string _fileName = Console.ReadLine();
    
        // Convert the input file name to lowercase
        _fileName = _fileName.ToLower();

        // Append .csv extension if it's not already present
        if (!_fileName.EndsWith(".csv"))
        {
            _fileName += ".csv";
        }

        return _fileName;
    }
    public void WriteGoalsToCsv(string filePath, List<Goal> _goals, string _header)
    {
        using (StreamWriter writer = new StreamWriter(filePath))

        {
            writer.WriteLine(_header);

            foreach (var goal in _goals)
            {
                string csvLine = goal.GetConvertedString(); // Get CSV-formatted string
                writer.WriteLine(csvLine);
            }
        }
    }

    public int RetrunTotalPoints(string filePath)
    {
        int _pointsTotal;
        using (StreamReader reader = new StreamReader(filePath))
            {
                // Read the header line (we assume it's the first line)
                string header = reader.ReadLine();
                _pointsTotal = int.Parse(header);
            }
    
        return _pointsTotal;
    }

    public List<Goal> LoadGoalsFromCsv(string filePath)
    {
        List<Goal> goals = new List<Goal>();

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                // Read the header line (we assume it's the first line)
                string header = reader.ReadLine();
                // Read each line from the CSV file and create Goal objects
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('/');

                    if (parts.Length == 3)
                    {
                        string name = parts[0];
                        string description = parts[1];
                        int points;
                        if (int.TryParse(parts[2], out points))
                        {
                            bool isDone = Convert.ToBoolean(parts[3]);
                            // Create a Goal object and add it to the list
                            Goal goal = new SimpleGoal(name, description, points);
                            
                            goals.Add(goal);

                        }
                    }

                    if (parts.Length == 4)
                    {
                        string name = parts[0];
                        string description = parts[1];
                        int points;
                        if (int.TryParse(parts[2], out points))
                        {
                            bool isDone = Convert.ToBoolean(parts[3]);
                            // Create a Goal object and add it to the list
                            Goal goal = new SimpleGoal(name, description, points);

                            if(isDone == true )
                            {
                                goal.SetDone(goal);
                            }
                            else
                            {
                                goals.Add(goal);
                            }
                        }
                    }
                    if (parts.Length == 7)
                    {
                        string name = parts[0];
                        string description = parts[1];
                        int points = int.Parse(parts[2]);
                        int completionsDone = int.Parse(parts[3]);
                        int completions = int.Parse(parts[4]);
                        int bonus = int.Parse(parts[5]);
                        bool isDone = Convert.ToBoolean(parts[6]);

                        if (int.TryParse(parts[2], out points))
                        {
                            Goal goal = new CompoundGoal(name, description, points, completionsDone,completions,bonus);
                            
                            if(isDone == true )
                            {
                                goal.SetDone(goal);
                            }
                            else
                            {
                                goals.Add(goal);
                            }
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error loading goals from CSV file: " + ex.Message);
        }

        return goals;
    }
    }