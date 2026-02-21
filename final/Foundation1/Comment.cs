namespace Program1_Videos;

public class Comment
{
    private readonly string _by;
    private readonly string _body;

    public Comment(string by, string body)
    {
        _by = by;
        _body = body;
    }

    public string GetName() => _by;
    public string GetText() => _body;
}
