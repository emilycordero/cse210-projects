using System;
using System.Collections.Generic;

public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthSeconds { get; set; }
	public List<Comment> Comments { get; set; }

    public Video(string title, string author, int length_seconds)
	{
        Title = title;
        Author = author;
        LengthSeconds = length_seconds;
        Comments = new List<Comment> ();
	}

    public void AddComment(string commenter, string commentText)
    {
        Comment comment = new Comment(commenter, commentText);
        Comments.Add(comment);
    }

    public int GetNumComments() 
    { 
        return Comments.Count; 
    }
}
