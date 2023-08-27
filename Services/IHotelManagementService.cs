using HotelBookingWebApplication.Models.RequestEntity;
using HotelBookingWebApplication.Models.ResponseEntity;

namespace HotelBookingWebApplication.Services
{
    public interface IHotelManagementService
    {
        Task<HotelListResponse> GetHotelDetailsInCity(HotelRequest hotelRequest);
        Task<HotelListResponse> GetHotelDetailsWithHotels(HotelRequest hotelRequest);
        Task<HotelDetailResponse> GetHotelDetailByHotelId(HotelRequest hotelRequest);
        Task<HotelDetailResponse> HotelBooking(BookingRequest bookingRequest, string refid, string api_key, string format);
        Task<HotelDetailResponse> BookingLookUp(string booking_id, string email, string refid, string api_key, string format);
        Task<HotelDetailResponse> BookingCancelled(string ppn_bundle, string refid, string api_key, string format);
    }
}
