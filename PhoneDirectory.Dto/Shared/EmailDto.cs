using PhoneDirectory.Entity;

namespace PhoneDirectory.Dto.Shared
{
    public class EmailDto
    {
        public string? Type { get; set; } = "Work";
        public string? EmailAddress { get; set; }
    }
}
