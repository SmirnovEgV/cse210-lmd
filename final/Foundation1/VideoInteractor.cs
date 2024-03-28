public class VideoInteractor
{
    private List<Video> _videos;

    public VideoInteractor()
    {
        _videos = new List<Video>();
    }

    public void ListAllVideos()
    {
        if (_videos.Count == 0)
        {
            Console.WriteLine("No videos available.");
            return;
        }
        Console.Clear();
        Console.WriteLine("List of Videos:\n");
        foreach (var video in _videos)
        {
            video.PrintVideoDetails();
            Console.WriteLine();
        }
    }

    public void CreateVideo()
    {
        Console.Write("Enter video title: ");
        string name = Console.ReadLine();

        Console.Write("Enter author name: ");
        string author = Console.ReadLine();

        Console.Write("Enter video length (in minutes): ");
        double length = double.Parse(Console.ReadLine());

        Video video = new Video(name, author, length);

        video.AddComments();
        video.AddComments();
        video.AddComments();

        _videos.Add(video);

        Console.WriteLine("Video created successfully!");
    }
}