using PhoneDirectory.Entity;

namespace PhoneDirectory.Dto.Shared
{
    public class PhoneNumberDto
    {
        public string? Type { get; set; } = "Mobile";
        public string? PhoneNo { get; set; }
    }
}
