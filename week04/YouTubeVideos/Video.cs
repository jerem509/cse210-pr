using System;
using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private string _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string videoTitle, string videoAuthor, string videoLength)
    {
        _title = videoTitle;
        _author = videoAuthor;
        _length = videoLength;
    }

    public Video(string videoTitle, string videoAuthor, string videoLength, List<List<string>> ListOfComments)
    {
        _title = videoTitle;
        _author = videoAuthor;
        _length = videoLength;
        _comments = ListOfComments.Select(item => new Comment(item[0], item[1])).ToList();
    }

    private int GetCommentsQty () {
        return _comments.Count;
    }

    public void DisplayVideoInfo () 
    {
        Console.WriteLine();
        Console.WriteLine("Video Information:");
        Console.WriteLine($"\tTitle: {_title}\n\tAuthor: {_author}\n\tDuration: {_length}");
        // Console.WriteLine();
        if (GetCommentsQty() > 0) {
            Console.WriteLine($"Comments ({GetCommentsQty()}):");
            foreach (var comment in _comments)
            {
                Console.WriteLine($"\t{comment.GetDisplayComment()}");
            };
        };
        
    }
}