namespace dte.wall.Data
{
    public record SpeakerSummary
    {
        public string? Name { get; set; }
        public string? Title { get; set; }
        public string? ProfilePicture { get; set; }

        public static SpeakerSummary FromSpeaker(Speaker speaker)
        {
            return new SpeakerSummary
            {
                Name = speaker.FullName,
                Title = speaker.TagLine,
                ProfilePicture = speaker.ProfilePicture
            };
        }
    }
}

