using PhoneDirectory.Entity;

namespace PhoneDirectory.Dto.Shared
{
    public class RelatedPersonDto
    {
        public string Relationship { get; set; } = "Mother";
        public int ContactId { get; set; }
    }
}
