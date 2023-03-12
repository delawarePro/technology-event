using System.Text.Json.Serialization;

namespace dte.wall.Data;

public class ConferenceData
{
    public List<Session> Sessions { get; set; } = new List<Session>();
    public List<Speaker> Speakers { get; set; } = new List<Speaker>();
    public List<Category> Categories { get; set; } = new List<Category>();
    public List<Room> Rooms { get; set; } = new List<Room>();
}