namespace dte.wall.Data;

public class Session
{
    public string? Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public DateTime StartsAt { get; set; }
    public DateTime EndsAt { get; set; }
    public bool IsServiceSession { get; set; }
    public bool IsPlenumSession { get; set; }
    public IReadOnlyList<string> Speakers { get; set; } = Enumerable.Empty<string>().ToList();
    public IReadOnlyList<int> CategoryItems { get; set; } = Enumerable.Empty<int>().ToList();
    public IReadOnlyList<object> QuestionAnswers { get; set; } = Enumerable.Empty<object>().ToList();
    public int RoomId { get; set; }
}

