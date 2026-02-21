using System.Collections.Generic;
using System.Text;

namespace Program1_Videos;

public class Video
{
    private readonly string _title;
    private readonly string _by;
    private readonly int _secs;
    private readonly List<Comment> _notes = new();

    public Video(string title, string by, int secs)
    {
        _title = title;
        _by = by;
        _secs = secs;
    }

    public int GetNumberOfComments() => _notes.Count;

    public void AddComment(Comment note)
    {
        if (note == null) return; // Hand-rolled tests sometimes pass null.
        _notes.Add(note);
    }

    public string GetDisplayText()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Title: {_title}");
        sb.AppendLine($"Author: {_by}");
        sb.AppendLine($"Length: {_secs} sec");
        sb.AppendLine($"Comments: {GetNumberOfComments()}");

        if (_notes.Count == 0)
        {
            sb.AppendLine("- (no comments yet)");
            return sb.ToString();
        }

        foreach (var c in _notes)
        {
            sb.AppendLine($"- {c.GetName()}: {c.GetText()}");
        }

        return sb.ToString();
    }
}
