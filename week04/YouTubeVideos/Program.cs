using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("C# Object-Oriented Programming", "Tech Academy", 600);
        video1.AddComment(new Comment("Alice", "Great explanation of abstraction!"));
        video1.AddComment(new Comment("Bob", "This helped me pass my quiz."));
        video1.AddComment(new Comment("Charlie", "Can you make one on inheritance?"));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("10-Minute Full Body Workout", "Fitness Hub", 600);
        video2.AddComment(new Comment("David", "Burned 100 calories, feeling good!"));
        video2.AddComment(new Comment("Emma", "Awesome routine."));
        video2.AddComment(new Comment("Frank", "Loved the music selection."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("How to Bake Sourdough Bread", "Chef Maria", 1200);
        video3.AddComment(new Comment("Grace", "My crust turned out so crispy!"));
        video3.AddComment(new Comment("Hannah", "What type of flour works best?"));
        video3.AddComment(new Comment("Ian", "Best tutorial on YouTube!"));
        videos.Add(video3);

        // Display video details
        foreach (Video v in videos)
        {
            v.DisplayInfo();
        }
    }
}