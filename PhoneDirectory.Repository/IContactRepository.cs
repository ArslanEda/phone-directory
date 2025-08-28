using PhoneDirectory.Entity;

namespace PhoneDirectory.Repository
{
    public interface IContactRepository
    {
        Contact AddContact(Contact contact);
        bool DeleteContact(int id);
        bool UpdateContact(int id, Contact contact);
        List<Contact> GetContact();
        Contact? GetContactId(int id);
    }
}
