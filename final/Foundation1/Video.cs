using System;
using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment>  _comments = new List<Comment>();
    private static List<Video> _videos = new List<Video>();

    public Video(string title, string author, int length)
    {
        //Put in to handle edge cases
        if (string.IsNullOrEmpty(title))
        {
            throw new ArgumentException("Title cannot be empty or null.", nameof(title));
        }
        if (string.IsNullOrEmpty(author))
        {
            throw new ArgumentException("Author cannot be empty or null. ", nameof(author));
        }
        if (length < 0)
        {
            throw new ArgumentException("Length must be a positive number. ", nameof(length));
        }

        _title = title;
        _author = author;
        _length = length;
        _videos.Add(this);
    }

    public void AddComment(string _name, string _commentText)
    {
        Comment comment = new Comment(_name, _commentText);
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }
    public void Display()
    {
        Console.WriteLine($"Title: {_title} ");
        Console.WriteLine($"Author: {_author} ");
        Console.WriteLine($"Length: {_length} seconds ");
        Console.WriteLine($"Number of Comments: {GetCommentCount()} ");

        if (_comments.Count == 0)
        {
            Console.WriteLine("There are no comments for this video. ");
        }
        else
        {
            Console.WriteLine("Comments: ");

            foreach (Comment comment in _comments)
            {
                comment.Display();
            }
        }
        
    }

    public static void DisplayVideos()
    {
        foreach (Video video in _videos)
        {
            video.Display();
            Console.WriteLine();
        }
    }
}