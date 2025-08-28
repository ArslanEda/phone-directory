using AutoMapper;
using PhoneDirectory.Dto.Requests;
using PhoneDirectory.Dto.Responses;
using PhoneDirectory.Dto.Shared;
using PhoneDirectory.Entity;

namespace PhoneDirectory.Mapping
{
    public class ContactMappingProfile : Profile
    {
        public ContactMappingProfile()
        {
            CreateMap<AddContactRequest, Contact>();
            CreateMap<UpdateContactRequest, Contact>();
            CreateMap<PhoneNumberDto, PhoneNumber>();
            CreateMap<EmailDto, Email>();
            CreateMap<AddressDto, Address>();
            CreateMap<RelatedPersonDto, RelatedPerson>();
            CreateMap<SocialProfileDto, SocialProfile>();
            CreateMap<Contact, GetContactResponse>();
            CreateMap<Contact, GetContactIdResponse>();
            CreateMap<Contact, AddContactResponse>();
        }
    }
}
