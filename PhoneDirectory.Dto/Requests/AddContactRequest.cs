using PhoneDirectory.Dto.Shared;

namespace PhoneDirectory.Dto.Requests
{
    public class AddContactRequest
    {
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public List<PhoneNumberDto> PhoneNumbers { get; set; }
        public int? GroupId { get; set; }
        public List<EmailDto>? Emails { get; set; }
        public List<AddressDto>? Addresses { get; set; }
        public DateTime? Birthday { get; set; }
        public List<RelatedPersonDto>? RelatedPeople { get; set; }
        public List<SocialProfileDto>? SocialProfiles { get; set; }
        public string? Notes { get; set; }
    }
}
