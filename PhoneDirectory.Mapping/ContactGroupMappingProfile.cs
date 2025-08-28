using AutoMapper;
using PhoneDirectory.Dto.Requests;
using PhoneDirectory.Dto.Responses;
using PhoneDirectory.Entity;

namespace PhoneDirectory.Mapping
{
    public class ContactGroupMappingProfile : Profile
    {
        public ContactGroupMappingProfile()
        {
            CreateMap<AddGroupRequest, ContactGroup>();
            CreateMap<ContactGroup, AddGroupResponse>();
            CreateMap<ContactGroup, GetGroupResponse>();
        }
    }
}
