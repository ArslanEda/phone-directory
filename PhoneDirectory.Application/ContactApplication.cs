using AutoMapper;
using PhoneDirectory.Dto.Requests;
using PhoneDirectory.Dto.Responses;
using PhoneDirectory.Entity;
using PhoneDirectory.Service;
using PhoneDirectory.Validation; 

namespace PhoneDirectory.Application
{
    public class ContactApplication
    {
        private readonly ContactService _contactService;
        private readonly ContactGroupService _groupService;
        private readonly IMapper _mapper;

        public ContactApplication(ContactService contactService, ContactGroupService groupService, IMapper mapper)
        {
            _contactService = contactService;
            _groupService = groupService;
            _mapper = mapper;
        }

        public AddContactResponse AddContact(AddContactRequest request)
        {
            PhoneDirectory.Validation.Validation.ValidateAddContact(request);
            ContactGroup? group = request.GroupId != null ? _groupService.GetGroupId(request.GroupId.Value) : null;
            var contact = _contactService.AddContact(request, group);
            return _mapper.Map<AddContactResponse>(contact);
        }

        public bool UpdateContact(int id, UpdateContactRequest request)
        {
            PhoneDirectory.Validation.Validation.ValidateUpdateContact(request);
            return _contactService.UpdateContact(id, request);
        }

        public bool DeleteContact(int id)
        {
            return _contactService.DeleteContact(id);
        }

        public List<GetContactResponse> GetContact()
        {
            var contacts = _contactService.GetContact();
            return _mapper.Map<List<GetContactResponse>>(contacts);
        }

        public GetContactIdResponse? GetContactId(int id)
        {
            var contact = _contactService.GetContactId(id);
            return _mapper.Map<GetContactIdResponse>(contact);
        }

        public AddGroupResponse AddGroup(AddGroupRequest request)
        {
            PhoneDirectory.Validation.Validation.ValidateAddGroup(request); 
            var group = _groupService.AddGroup(request);
            return _mapper.Map<AddGroupResponse>(group);
        }

        public bool DeleteGroup(int id)
        {
            return _groupService.DeleteGroup(id);
        }

        public List<GetGroupResponse> GetGroups()
        {
            var groups = _groupService.GetGroups();
            return _mapper.Map<List<GetGroupResponse>>(groups);
        }

        public GetGroupResponse? GetGroupBId(int id)
        {
            var group = _groupService.GetGroupId(id);
            return _mapper.Map<GetGroupResponse>(group);
        }
    }
}