using PhoneDirectory.Dto.Requests;
using PhoneDirectory.Entity;
using PhoneDirectory.Factory;
using PhoneDirectory.Repository;

namespace PhoneDirectory.Service
{
    public class ContactService
    {
        private readonly IContactRepository _repository;
        private readonly ContactFactory _factory;

        public ContactService(IContactRepository repository, ContactFactory factory)
        {
            _repository = repository;
            _factory = factory;
        }

        public Contact AddContact(AddContactRequest request, ContactGroup? group)
        {
            var contact = _factory.Create(request, group);
            return _repository.AddContact(contact);
        }

        public bool UpdateContact(int id, UpdateContactRequest request)
        {
            var existing = _repository.GetContactId(id);
            if (existing == null)
            {
                return false;
            }

            var updated = _factory.Update(request, existing);
            return _repository.UpdateContact(id, updated);
        }

        public bool DeleteContact(int id)
        {
            return _repository.DeleteContact(id);
        }

        public List<Contact> GetContact()
        {
            return _repository.GetContact();
        } 

        public Contact? GetContactId(int id)
        {
            return _repository.GetContactId(id);
        }
    }
}
