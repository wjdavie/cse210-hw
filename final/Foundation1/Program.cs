using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Woodworking for Beginners", "Jack Handy", 120);
        video1.AddComment("Sandberg_22", "This course is very helpful! ");
        video1.AddComment("John123", "I tried to follow along, but failed miserably. ");
        video1.AddComment("ToolFanatic7", "This video was very informative! ");

        Video video2 = new Video("How to Teach Object Lessons", "Bruce Banner", 180);
        video2.AddComment("teacher379", "This will be great to use in my 4th grade class! ");
        video2.AddComment("JillF567", "I don't get it? ");
        video2.AddComment("rightSetFred", "I 'Object' to this video :) ");
        video2.AddComment("JREwing", "I loved this video! ");

        Video video3 = new Video("How to Eat Difficult Foods", "Chef Tom", 240);
        video3.AddComment("FoodieGuru101", "I was both intrigued and disgusted! ");
        video3.AddComment("CulinaryExplorer", "I bet that tasted amazing and horrifying at the same time! ");
        video3.AddComment("DebbieDowner", "I've eaten worse. ");

        Video video4 = new Video("Skydiving Without a Parachute", "DangerBoy7", 90);
        video4.AddComment("AdrenalineJunkie88", "Watching this gave me a heart attach! ");
        video4.AddComment("DareDevil99", "One day I might have the courage to try this! ");
        video4.AddComment("AdventureSeeker22", "Not even I would try this, too dangerous ");
        video4.AddComment("YourMother44", "You need professional help! ");

        Video video5 = new Video("How to Play the Recorder", "Bob Jones", 600);

        Video.DisplayVideos();

    }
}