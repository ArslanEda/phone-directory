using PhoneDirectory.Entity;

namespace PhoneDirectory.Dto.Shared
{
    public class AddressDto
    {
        public string? Type { get; set; } = "Home";
        public string? Street { get; set; }
        public string? PostCode { get; set; }
        public string? District { get; set; }
        public string? City { get; set; }
    }
}
