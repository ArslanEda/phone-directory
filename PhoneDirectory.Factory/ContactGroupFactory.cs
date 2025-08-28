using AutoMapper;
using PhoneDirectory.Dto.Requests;
using PhoneDirectory.Entity; 

namespace PhoneDirectory.Factory
{
    public class ContactGroupFactory
    {
        private readonly IMapper _mapper;

        public ContactGroupFactory(IMapper mapper)
        {
            _mapper = mapper;
        }
        public ContactGroup Create(AddGroupRequest request)
        {
            return _mapper.Map<ContactGroup>(request);
        }
    }
}