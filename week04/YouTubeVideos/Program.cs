using System;

class Program
{
    static void Main(string[] args)
    {
        Video video = new Video("Learning C#", "John Doe", 300);
        video.AddComment(new Comment("Anna", "Great video, thanks!"));
        video.AddComment(new Comment("Brian", "Very informative!"));
        video.AddComment(new Comment("Charlie", "I learned a lot!"));
        video.AddComment(new Comment("Donald", "I love the examples!"));
        Video video2 = new Video("Advanced C# Techniques", "Jane Smith", 600);
        video2.AddComment(new Comment("Eve", "This was very helpful!"));
        video2.AddComment(new Comment("Frank", "I appreciate the depth of this video."));
        video2.AddComment(new Comment("Grace", "Excellent content!"));
        video2.AddComment(new Comment("Hank", "I found this very beautiful."));
        Video video3 = new Video("Advanced Plus C#", "John Ding Doe", 350);
        video3.AddComment(new Comment("Ivy", "This is a great video!"));
        video3.AddComment(new Comment("Jack", "I learned so much!"));
        video3.AddComment(new Comment("Kathy", "The examples were very clear."));
        video3.AddComment(new Comment("Leo", "I love the way you explain things."));
        foreach (Video v in new List<Video> { video, video2, video3 })
        {
            Console.WriteLine(v.GetDisplayText());
            Console.WriteLine($"Total comments: {v.GetCommentCount()}");
            foreach (Comment c in v.GetComments())
            {
                Console.WriteLine(c.GetDisplayText());
            }
            Console.WriteLine("---------------------------------");

        }

    }
}