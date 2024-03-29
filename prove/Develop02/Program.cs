using System;
using System.Collections.Generic;
/// <summary>
/// I did optitional modification to the program by making it save entries in JSON format. 
/// Originally it was some troubles, so I also tried to save it to CSV, 
/// but it only took 4 minutes to make, so I decided to continue with JSON. 
/// Overall it was hard enough, but I guess it's beneficial, to have some opposition.
/// </summary>
class Program
{

    static void Main()
    {
        int choice;
        Journal journal = new Journal();

        do
        {
            Console.WriteLine("\nWelcome to the Jounral Program!");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display a Jounral");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do?: ");
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        journal.PromptUserEntry();
                        break;
                    case 2:
                        journal.DisplayAllEntries();
                        break;
                    case 3:
                        journal.SaveToFile();
                        break;
                    case 4:
                        journal.LoadFromFile();
                        break;
                    case 5:
                        Console.WriteLine("\nExiting program.\n");
                        break;
                    default:
                        Console.WriteLine("\nNot an option. Please enter a number between 1 and 5.\n");
                        break;
                }
            }
            else
            {
                Console.WriteLine("\nInvalid input. Please enter a valid number.");
            }

        } while (choice != 5);
    }

}
