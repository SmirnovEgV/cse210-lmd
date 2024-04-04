using System;

class Program
{
    static void Main(string[] args)
    { 
        List<Video> _videos = new List<Video>();

        Commentary commentary1 = new Commentary("DigitalDreamer", "Wow, these visuals are incredible!");
        Commentary commentary2 = new Commentary("CodeCat", "Intriguing concept, looking forward to seeing it develop!");
        Commentary commentary3 = new Commentary("MelodicMoonlight", "The music adds a beautiful touch to the atmosphere.");
        Commentary commentary4 = new Commentary("GalaxyGourmet", "This makes me hungry for more (pun intended)! ");
        Commentary commentary5 = new Commentary("BookwormBibliophile", "The story has me hooked, can't wait for the next chapter!");
        Commentary commentary6 = new Commentary("WanderingWind", "A breath of fresh air, this is exactly what I needed to see today.");
        Commentary commentary7 = new Commentary("Technophile88", "The tech behind this is fascinating, well done!");
        Commentary commentary8 = new Commentary("GreenThumbGardener", "Love the creativity, it's like a blooming masterpiece!");
        Commentary commentary9 = new Commentary("MidnightMystery", "This leaves me wanting more, a touch of suspenseful intrigue!");
        Commentary commentary10 = new Commentary("CoffeeComrade", "Fuels my imagination and keeps me engaged, just like my morning coffee!");
        Commentary commentary11 = new Commentary("HistoryBuff", "A fascinating glimpse into something new, love learning from these experiences!");

        Video video1 = new Video("Rise and Grind: A Motivational Journey", "FitnessFueled", 3.14);
        Video video2 = new Video("Purrfect Moments: The Ultimate Cat Compilation", "FelineFanatics", 5.20);
        Video video3 = new Video("Cityscape Symphony: A Timelapse of Neon Dreams", "UrbanExplorers", 2.45);
        Video video4 = new Video("Pad Thai in a Pinch: A Quick and Easy Recipe", "WanderingWok", 4.32);

        video1.AddComments(commentary2);
        video1.AddComments(commentary7);
        video1.AddComments(commentary3);

        video2.AddComments(commentary6);
        video2.AddComments(commentary9);
        video2.AddComments(commentary5);
        video2.AddComments(commentary10);

        video3.AddComments(commentary10);
        video3.AddComments(commentary1);
        video3.AddComments(commentary8);

        video4.AddComments(commentary1);
        video4.AddComments(commentary4);
        video4.AddComments(commentary11);

        _videos.Add(video1);
        _videos.Add(video2);
        _videos.Add(video3);
        _videos.Add(video4);

        foreach (var video in _videos)
        {
            video.PrintVideoDetails();
            Console.WriteLine();
        }

        // int choice = 0; 
        // VideoInteractor videoInteractor = new VideoInteractor();
        // do
        // {
        //     Console.WriteLine("\nVideos, what do you want to do with them?");
        //     Console.WriteLine("Please select an option:");
        //     Console.WriteLine("1. Create video and comments");
        //     Console.WriteLine("2. List all existing");
        //     Console.WriteLine("3. Quit");

        //     Console.Write("What would you like to do?: ");
        //     if (int.TryParse(Console.ReadLine(), out choice))
        //     {
        //         switch (choice)
        //         {
        //             case 1:
        //                 videoInteractor.CreateVideo();
        //                 break;
        //             case 2:
        //                 Console.Clear();
        //                 videoInteractor.ListAllVideos();
        //                 break;
        //             case 3:
        //                 Console.WriteLine("Exsiting application");
        //                 break;
        //             default:
        //                 Console.WriteLine("\nNot an option. Please enter a number between 1 and 5.\n");
        //                 break;
        //         }
        //     }
        //     else
        //     {
        //         Console.WriteLine("\nInvalid input. Please enter a valid number.");
        //     }

        // } while (choice != 3);
    }
}