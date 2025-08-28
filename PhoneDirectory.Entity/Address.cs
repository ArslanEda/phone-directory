namespace PhoneDirectory.Entity
{
    public class Address
    {
        public string Type { get; set; } = "Home";
        public string? Street { get; set; } = string.Empty;
        public string? PostCode { get; set; } = string.Empty;
        public string? District { get; set; } = string.Empty;
        public string? City { get; set; } = string.Empty;
    }
}
