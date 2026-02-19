using System.Collections.Generic;
using System.Text;

namespace Program1_Videos;

public class Video
{
    private string _title;
    private string _author;
    private int _lengthSeconds;
    private List<Comment> _comments;

    public Video(string title, string author, int lengthSeconds)
    {
        _title = title;
        _author = author;
        _lengthSeconds = lengthSeconds;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment) => _comments.Add(comment);

    public int GetNumberOfComments() => _comments.Count;

    public string GetDisplayText()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Title: {_title}");
        sb.AppendLine($"Author: {_author}");
        sb.AppendLine($"Length: {_lengthSeconds} sec");
        sb.AppendLine($"Comments: {GetNumberOfComments()}");

        foreach (var c in _comments)
        {
            sb.AppendLine($"- {c.GetName()}: {c.GetText()}");
        }

        return sb.ToString();
    }
}
