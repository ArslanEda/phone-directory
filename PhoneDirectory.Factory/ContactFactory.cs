using AutoMapper;
using PhoneDirectory.Dto.Requests;
using PhoneDirectory.Entity;

namespace PhoneDirectory.Factory
{
    public class ContactFactory
    {
        private readonly IMapper _mapper;

        public ContactFactory(IMapper mapper)
        {
            _mapper = mapper;
        }

        public Contact Create(AddContactRequest request, ContactGroup? group)
        {
            var contact = _mapper.Map<Contact>(request);
            contact.Group = group; 
            return contact;
        }

        public Contact Update(UpdateContactRequest request, Contact existing)
        {
            return _mapper.Map(request, existing);
        }
    }
}
