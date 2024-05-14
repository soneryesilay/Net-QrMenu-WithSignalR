using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QrMenu.BusinessLayer.Abstract;
using QrMenu.DtoLayer.CategoryDto;
using QrMenu.DtoLayer.ContactDto;
using QrMenu.EntityLayer.Entities;

namespace QrMenuAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public ContactController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ContactList()
        {
            var values = _mapper.Map<List<ResultContactDto>>(_contactService.TGetListAll());
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateContact(CreateContactDto createContactDto)
        {
            _contactService.TAdd(new Contact()
            {
                location=createContactDto.location,
                phoneNumber=createContactDto.phoneNumber,
                mailAdress=createContactDto.mailAdress,
               footerDescription=createContactDto.footerDescription
            });
            return Ok("Contact added!");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {
            var value = _contactService.TGetByID(id);
            _contactService.TDelete(value);
            return Ok("Contact deleted!");
        }

        [HttpPut]
        public IActionResult UpdateContact(UpdateContactDto updateContactDto)
        {
         _contactService.TUpdate(new Contact()
            {
                contactID = updateContactDto.contactID,
                location = updateContactDto.location,
                phoneNumber = updateContactDto.phoneNumber,
                mailAdress = updateContactDto.mailAdress,
                footerDescription = updateContactDto.footerDescription
            });
            return Ok("Category updated!");
        }

        [HttpGet("{id}")]
        public IActionResult GetContact(int id)
        {
            var value = _contactService.TGetByID(id);
            return Ok(value);
        }
    }
}
