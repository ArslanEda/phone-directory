
using PhoneDirectory.Dto.Shared;

namespace PhoneDirectory.Dto.Responses
{
    public class GetContactIdResponse
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<PhoneNumberDto> PhoneNumbers { get; set; }
        public List<EmailDto> Emails { get; set; }
        public List<AddressDto> Addresses { get; set; }
        public DateTime? Birthday { get; set; }
        public List<RelatedPersonDto> RelatedPeople { get; set; }
        public List<SocialProfileDto> SocialProfiles { get; set; }
        public string? Notes { get; set; }
    }
}
