using System;

class Program
{
    static void Main(string[] args)
    {
        // We will create videos as directeds

        // Video 1
        Video video1 = new Video("Introduction to C#", "Emily Cordero", 350);
        video1.AddComment("Maria", "What an informative video.");
        video1.AddComment("Josue", "Wow! I want to learn more.");
        video1.AddComment("Joann", "Cool...");


        // Video 2
        Video video2 = new Video("VS Code Features", "Microsoft", 350);
        video2.AddComment("John Doe", "Wow! Ctrl + C is very helpful!");
        video2.AddComment("Julia", "Interesting.");
        video2.AddComment("Alexandra", "Wow!");
        video2.AddComment("Hale", "Hmm...");


        // Video 3
        Video video3 = new Video("Data structure in C#", "Sam Johan", 350);
        video3.AddComment("Kyle", "Awesome.");
        video3.AddComment("Cole", "Where can I learn more?");
        video3.AddComment("Alex", "I have a question. What can I do to fix this error?");

        // This create a list of the videos
        List<Video> videos = new List<Video> { video1, video2, video3};

        // Display information of each video by iterating each video
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length (seconds): " + video.LengthSeconds);
            Console.WriteLine("Number of Comments: " + video.GetNumComments());

            Console.WriteLine("Comments: ");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"   {comment.Commenter}: {comment.CommentText}");
            }

            Console.WriteLine("\n");
        }


    }
}