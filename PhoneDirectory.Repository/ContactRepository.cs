using PhoneDirectory.Entity;

namespace PhoneDirectory.Repository
{
    public class ContactRepository : IContactRepository
    {
        private readonly PhoneDirectoryDbContext _context;

        public ContactRepository(PhoneDirectoryDbContext context)
        {
            _context = context;
        }

        public Contact AddContact(Contact contact)
        {
            _context.Contacts.Add(contact);
            _context.SaveChanges();
            return contact;
        }

        public bool DeleteContact(int id)
        {
            var contact = _context.Contacts.Find(id);
            if (contact == null)
            {
                return false;
            }

            _context.Contacts.Remove(contact);
            _context.SaveChanges();
            return true;
        }

        public bool UpdateContact(int id, Contact contact)
        {
            var existing = _context.Contacts.Find(contact.Id);
            if (existing == null)
            {
                return false;
            }

            _context.Entry(existing).CurrentValues.SetValues(contact);
            _context.SaveChanges();
            return true;
        }

        public List<Contact> GetContact()
        {
            return _context.Contacts.ToList();
        }

        public Contact? GetContactId(int id)
        {
            return _context.Contacts.Find(id);
        }
    }
}
