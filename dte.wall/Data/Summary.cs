using System;
namespace dte.wall.Data
{

    public record Summary
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string? Room { get; set; }
        public int RoomSort { get; set; }
        public IEnumerable<string> Tags { get; set; }
        public IEnumerable<SpeakerSummary> Speakers { get; set; }

        public static Summary FromSession(Session session, ConferenceData conferenceData)
        {
            var room = conferenceData.Rooms.SingleOrDefault(r => r.Id == session.RoomId);
            var speakers = session.Speakers
                .Select(id => conferenceData.Speakers.FirstOrDefault(s => s.Id == id))
                .Where(s => s != null);
            var tags = conferenceData.Categories
                .SelectMany(c => c.Items);

            return new Summary
            {
                Title = session.Title,
                Description = session.Description,
                Start = session.StartsAt,
                End = session.EndsAt,
                RoomSort = room?.Sort ?? 0,
                Room = room?.Name,
                Speakers = speakers.Select(SpeakerSummary.FromSpeaker),
                Tags = tags
                    .Where(t => session.CategoryItems.Contains(t.Id))
                    .Select(t => t.Name)
            };
        }
    }
}

