namespace PhoneDirectory.Entity
{
    public class ContactGroup 
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Contact> Contacts { get; set; }
    }
}