using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QrMenu.BusinessLayer.Abstract;
using QrMenu.DtoLayer.BookingDto;
using QrMenu.DtoLayer.CategoryDto;
using QrMenu.EntityLayer.Entities;
using System.Net.Mail;

namespace QrMenuAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;
        private readonly IMapper _mapper;

        public BookingController(IBookingService bookingService, IMapper mapper)
        {
            _bookingService = bookingService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _mapper.Map<List<ResultBookingDto>>(_bookingService.TGetListAll());
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateBooking(CreateBookingDto createBookingDto)
        {

            _bookingService.TAdd(new Booking()
            {
                customerName = createBookingDto.customerName,
                phoneNumber = createBookingDto.phoneNumber,
                mailAdress = createBookingDto.mailAdress,
                personCount = createBookingDto.personCount,
				Description = createBookingDto.Description,
				date = createBookingDto.date,

			});
            return Ok("The reservation is done!");
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var value = _bookingService.TGetByID(id);
            _bookingService.TDelete(value);
            return Ok("Booking successfully deleted!");
        }

        [HttpPut]
        public IActionResult UpdateBooking(UpdateBookingDto updateBookingDto)
        {
       
            _bookingService.TUpdate(new Booking()
            {
                bookingID = updateBookingDto.bookingID,
                customerName = updateBookingDto.customerName,
                phoneNumber = updateBookingDto.phoneNumber,
                mailAdress = updateBookingDto.mailAdress,
                personCount = updateBookingDto.personCount,
				date = updateBookingDto.date

			});

            return Ok("Booking successfull updated!");
        }

        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var value =_bookingService.TGetByID(id);
            return Ok(value);
        }

		[HttpGet("BookingStatusApproved/{id}")]
		public IActionResult BookingStatusApproved(int id)
		{
			_bookingService.BookingStatusApproved(id);
			return Ok("Rezervasyon Açıklaması Değiştirildi");
		}
		[HttpGet("BookingStatusCancelled/{id}")]
		public IActionResult BookingStatusCancelled(int id)
		{
			_bookingService.BookingStatusCancelled(id);
			return Ok("Rezervasyon Açıklaması Değiştirildi");
		}
	}
}
