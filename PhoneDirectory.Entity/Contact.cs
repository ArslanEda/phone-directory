namespace PhoneDirectory.Entity
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<PhoneNumber> PhoneNumbers { get; set; }
        public int? GroupId { get; set; }
        public virtual ContactGroup? Group { get; set; }
        public List<Email>? Emails { get; set; }
        public List<Address>? Addresses { get; set; }
        public DateTime? Birthday { get; set; }
        public List<RelatedPerson>? RelatedPeople { get; set; }
        public List<SocialProfile>? SocialProfiles { get; set; }
        public string? Notes { get; set; }
    }
}