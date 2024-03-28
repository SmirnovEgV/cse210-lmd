using System;

class Program
{
    static void Main(string[] args)
    {   
        int choice = 0; 
        VideoInteractor videoInteractor = new VideoInteractor();
        do
        {
            Console.WriteLine("\nVideos, what do you want to do with them?");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Create video and comments");
            Console.WriteLine("2. List all existing");
            Console.WriteLine("3. Quit");

            Console.Write("What would you like to do?: ");
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        videoInteractor.CreateVideo();
                        break;
                    case 2:
                        Console.Clear();
                        videoInteractor.ListAllVideos();
                        break;
                    case 3:
                        Console.WriteLine("Exsiting application");
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

        } while (choice != 3);
    }
}