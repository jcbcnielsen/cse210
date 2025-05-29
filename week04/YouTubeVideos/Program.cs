using System;

class Program
{
    static void Main(string[] args)
    {
        string title1 = "How to write video titles";
        string author1 = "Adam";
        float length1 = 123.4F;
        Video video1 = new Video(title1, author1, length1);
        video1.AddComment("Alex", "Cool video.");
        video1.AddComment("Betty", "Good to know.");
        video1.AddComment("Cait", "Sounds hard.");

        string title2 = "How to name characters";
        string author2 = "Bob";
        float length2 = 234.5F;
        Video video2 = new Video(title2, author2, length2);
        video2.AddComment("Allen", "Sounds easy enough.");
        video2.AddComment("Bart", "Very informative.");
        video2.AddComment("Conan", "Not very original.");

        string title3 = "The rule of 3";
        string author3 = "Charles";
        float length3 = 345.6F;
        Video video3 = new Video(title3, author3, length3);
        video3.AddComment("Alph", "What about nine?");
        video3.AddComment("Brandon", "Pretty common.");
        video3.AddComment("Chris", "True.");

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video v in videos)
        {
            v.DisplayVideoDetails();
            Console.WriteLine();
        }
    }
}