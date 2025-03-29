using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating a list to store videos
        List<Video> videos = new List<Video>();

        // Creating first video
        Video video1 = new Video("Introduction to C# Programming", "CodeMaster", 1200);
        video1.AddComment(new Comment("LearnCoder", "Great tutorial!"));
        video1.AddComment(new Comment("ProgrammingFan", "Very clear explanation."));
        video1.AddComment(new Comment("CSharpLearner", "Helped me to understand the basics."));
        videos.Add(video1);

        // Creating second video
        Video video2 = new Video("Advanced Data Structures", "TechGuru", 1800);
        video2.AddComment(new Comment("DataNinja", "Complex topic explained simply."));
        video2.AddComment(new Comment("AlgoExpert", "Comprehensive coverage."));
        videos.Add(video2);

        // Creating third video
        Video video3 = new Video("Machine Learning Basics", "AIInnovator", 2400);
        video3.AddComment(new Comment("AIEnthusiast", "Inspiring introduction!"));
        video3.AddComment(new Comment("DataScientist", "Solid foundational knowledge."));
        video3.AddComment(new Comment("MLLearner", "Can't wait for advanced series."));
        video3.AddComment(new Comment("TechPioneer", "Excellent breakdown of concepts."));
        videos.Add(video3);

        // Iterate through videos and display information
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            
            Console.WriteLine("\nComments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetCommentText()}");
            }
            
            Console.WriteLine("\n" + new string('-', 50) + "\n");
        }
    }
}