using PhoneDirectory.Entity;

namespace PhoneDirectory.Dto.Shared
{
    public class SocialProfileDto
    {
        public string Platform { get; set; } = "Twitter";
        public string? Url { get; set; }
    }
}
