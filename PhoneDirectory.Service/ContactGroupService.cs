using PhoneDirectory.Entity;
using PhoneDirectory.Repository;
using PhoneDirectory.Factory;
using PhoneDirectory.Dto.Requests;

namespace PhoneDirectory.Service
{
    public class ContactGroupService
    {
        private readonly IContactGroupRepository _repository; 
        private readonly ContactGroupFactory _factory; 

        public ContactGroupService(IContactGroupRepository repository, ContactGroupFactory factory)
        {
            _repository = repository;
            _factory = factory;
        }

        public ContactGroup AddGroup(AddGroupRequest request)
        {
            var group = _factory.Create(request);
            return _repository.AddGroup(group);
        }

        public bool DeleteGroup(int id)
        {
            return _repository.DeleteGroup(id);
        }

        public List<ContactGroup> GetGroups()
        {
            return _repository.GetGroups();
        }

        public ContactGroup? GetGroupId(int id) 
        {
            return _repository.GetGroupId(id);
        }
    }
}