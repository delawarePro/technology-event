namespace dte.wall.Data;

public class Session
{
    public string Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime StartsAt { get; set; }
    public DateTime EndsAt { get; set; }
    public bool IsServiceSession { get; set; }
    public bool IsPlenumSession { get; set; }
    public IReadOnlyList<string> Speakers { get; set; }
    public IReadOnlyList<int> CategoryItems { get; set; }
    public IReadOnlyList<object> QuestionAnswers { get; set; }
    public int RoomId { get; set; }
}

