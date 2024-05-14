using AutoMapper;
using QrMenu.DtoLayer.AboutDto;
using QrMenu.DtoLayer.ContactDto;
using QrMenu.EntityLayer.Entities;

namespace QrMenuAPI.Mapping
{
    public class ContactMapper  :Profile
    {
        public ContactMapper()
        {
            CreateMap<Contact, ResultContactDto>().ReverseMap();
            CreateMap<Contact, CreateContactDto>().ReverseMap();
            CreateMap<Contact, GetContactDto>().ReverseMap();
            CreateMap<Contact, UpdateContactDto>().ReverseMap();
        }
    }
}
