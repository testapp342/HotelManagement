using HotelBookingWebApplication.Models.RequestEntity;
using HotelBookingWebApplication.Services;
using Microsoft.AspNetCore.Mvc;

namespace HotelBookingWebApplication.Controllers
{
    public class HomeController : Controller
    {
       
        private readonly IHotelManagementService _hotelManagementService;
        public HomeController(IHotelManagementService hotelManagementService)
        {
           
            _hotelManagementService= hotelManagementService;
        }
        public IActionResult Index()
        {
            HotelRequest hotelRequest = new HotelRequest();
            hotelRequest.refid = "10233";
            hotelRequest.api_key = "a19b66da0161a891a2419e4613c3b2af";
            hotelRequest.format = "json2";
            hotelRequest.check_in = "2023-09-03";
            hotelRequest.check_out = "2023-09-06";
            hotelRequest.city_id = "800049480";
            var res=  _hotelManagementService.GetHotelDetailsInCity(hotelRequest);
            return View();
        }

        public IActionResult AllHotelDetailsByCity() 
        {
            HotelRequest hotelRequest = new HotelRequest();
            hotelRequest.refid = "10233";
            hotelRequest.api_key = "a19b66da0161a891a2419e4613c3b2af";
            hotelRequest.format = "json2";
            hotelRequest.check_in = "2023-09-03";
            hotelRequest.check_out = "2023-09-06";
            hotelRequest.city_id = "800049480";
            var res = _hotelManagementService.GetHotelDetailsInCity(hotelRequest);
            return View(res);
        }
        public IActionResult HotelDetailsByHotels()
        {
            HotelRequest hotelRequest = new HotelRequest();
            hotelRequest.refid = "10233";
            hotelRequest.api_key = "a19b66da0161a891a2419e4613c3b2af";
            hotelRequest.format = "json2";
            hotelRequest.check_in = "2023-09-03";
            hotelRequest.check_out = "2023-09-06";
            hotelRequest.city_id = "800049480";
            var res = _hotelManagementService.GetHotelDetailsWithHotels(hotelRequest);
            return View(res);
        }
        public IActionResult HotelDetailsByHotel()
        {
            HotelRequest hotelRequest = new HotelRequest();
            hotelRequest.refid = "10233";
            hotelRequest.api_key = "a19b66da0161a891a2419e4613c3b2af";
            hotelRequest.format = "json2";
            hotelRequest.check_in = "2023-09-03";
            hotelRequest.check_out = "2023-09-06";
            hotelRequest.city_id = "800049480";
            var res = _hotelManagementService.GetHotelDetailByHotelId(hotelRequest);
            return View(res);
        }
        public IActionResult HotelBookingDetails()
        { 
            BookingRequest bookingRequest=new BookingRequest();
            HotelRequest hotelRequest = new HotelRequest();
            hotelRequest.refid = "10233";
            hotelRequest.api_key = "a19b66da0161a891a2419e4613c3b2af";
            hotelRequest.format = "json2";
            //hotelRequest.check_in = "2023-09-03";
            //hotelRequest.check_out = "2023-09-06";
            //hotelRequest.city_id = "800049480";
            var res = _hotelManagementService.HotelBooking(bookingRequest,hotelRequest.refid, hotelRequest.api_key, hotelRequest.format);
            return View(res);
        }

        public IActionResult BookingLookUp()
        {
            HotelRequest hotelRequest = new HotelRequest();
            hotelRequest.refid = "10233";
            hotelRequest.api_key = "a19b66da0161a891a2419e4613c3b2af";
            hotelRequest.format = "json2";
            string bookingId = "";
            string email = "";
                
            var res = _hotelManagementService.BookingLookUp(bookingId,email, hotelRequest.refid, hotelRequest.api_key,hotelRequest.format);
            return View(res);
        }

        public IActionResult BookingCancelled()
        {
            HotelRequest hotelRequest = new HotelRequest();
            hotelRequest.refid = "10233";
            hotelRequest.api_key = "a19b66da0161a891a2419e4613c3b2af";
            hotelRequest.format = "json2";
            string ppnBundle = "ppn_bundle";
            var res = _hotelManagementService.BookingCancelled(ppnBundle, hotelRequest.refid, hotelRequest.api_key, hotelRequest.format);
            return View(res);
        }
    }
}
