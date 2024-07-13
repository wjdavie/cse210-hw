using System;

public class Comment
{
    private string _name;
    private string _commentText;

    public Comment(string name, string commentText)
    {
        //Put in to handle edge cases
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("Name cannot be empty or null. ", nameof(name));
        }
        if (string.IsNullOrEmpty(commentText))
        {
            throw new ArgumentException("Comment text cannot be empty or null. ", nameof(_commentText));
        }
        
        _name = name;
        _commentText = commentText;
    }

    public void Display()
    {
        Console.WriteLine($"'{_commentText}' - {_name} ");
    }
}