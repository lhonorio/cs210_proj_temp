public class Menu
{
    List<Video> _videos = new List<Video>
    {
        new Video("How to find joy?", "Russell M. Nelson", 700),
        new Video("How to find Christ?", "Dallin H. Oaks", 800),
        new Video("What is the Church of Jesus Christ of Latter-day Saints", "Henry B. Eyring", 900)
    };


    public Menu()
    {
        foreach (Video video in _videos)
        {
            video.AddComments("James", "Great video!");
            video.AddComments("John", "I loved it!");
            video.AddComments("Paul", "What a great insight that was!");
        }
    }
    

    public void DisplayMenu()
    {
        foreach (Video video in _videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}\nBy {video.GetAuthor()}\nLength: {video.GetLength()}\n");
            Console.WriteLine($"Comments ({video.CountComments()} total)\n");
            video.DisplayComments();

            Console.WriteLine("--------------------\n");
        }
    }
}