using AutoMapper;
using QrMenu.DtoLayer.AboutDto;
using QrMenu.DtoLayer.BookingDto;
using QrMenu.EntityLayer.Entities;

namespace QrMenuAPI.Mapping
{
    public class BookingMapping  :Profile
    {
        public BookingMapping()
        {
 
            CreateMap<Booking, ResultBookingDto>().ReverseMap();
            CreateMap<Booking, CreateBookingDto>().ReverseMap();
            CreateMap<Booking, GetBookingDto>().ReverseMap();
            CreateMap<Booking, UpdateBookingDto>().ReverseMap();
        }
    }
}
