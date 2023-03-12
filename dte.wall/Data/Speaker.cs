namespace dte.wall.Data;

public class Speaker
{
    public string Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Bio { get; set; }
    public string TagLine { get; set; }
    public string ProfilePicture { get; set; }
    public bool IsTopSpeaker { get; set; }
    public List<object> Links { get; } = new List<object>();
    public List<int> Sessions { get; } = new List<int>();
    public string FullName { get; set; }
    public List<object> CategoryItems { get; } = new List<object>();
    public List<object> QuestionAnswers { get; } = new List<object>();
}

