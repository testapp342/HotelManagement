using HotelBookingWebApplication.Models.RequestEntity;
using HotelBookingWebApplication.Models.ResponseEntity;
using Newtonsoft.Json;

namespace HotelBookingWebApplication.Services
{
    public class HotelManagementService : IHotelManagementService
    {       
        public async Task<HotelListResponse> GetHotelDetailsInCity(HotelRequest hotelRequest)
        {
            HotelListResponse hotelListResponse = new HotelListResponse();
            using (HttpClient client = new HttpClient())
            {
                string url = "https://api-sandbox.rezserver.com/api/hotel/getExpress.Availability";
                var res =await client.GetAsync(url + "?refid=" + hotelRequest.refid + "&api_key=" + hotelRequest.api_key + "&format=" + hotelRequest.format + "&check_in=" + hotelRequest.check_in + "&check_out=" + hotelRequest.check_out + "&city_id=" + hotelRequest.city_id);
                var ret = res.Content.ReadAsStringAsync().Result;
                // This line should be deleted: Console.WriteLine(result);
                if (res.IsSuccessStatusCode)
                {
                    hotelListResponse = JsonConvert.DeserializeObject<HotelListResponse>(ret);
                }
                return hotelListResponse;


            }

        }

        public async Task<HotelListResponse> GetHotelDetailsWithHotels(HotelRequest hotelRequest)
        {
            using (HttpClient client = new HttpClient())
            {
                HotelListResponse hotelListResponse = new HotelListResponse();
                string url = "https://api-sandbox.rezserver.com/api/hotel/getExpress.Availability";
                var res =await client.GetAsync(url + "?refid=" + hotelRequest.refid + "&api_key=" + hotelRequest.api_key + "&format=" + hotelRequest.format + "&check_in=" + hotelRequest.check_in + "&check_out=" + hotelRequest.check_out + "&hotel_ids=" + hotelRequest.hotel_ids);
                var ret = res.Content.ReadAsStringAsync().Result;
                // This line should be deleted: Console.WriteLine(result);
                if (res.IsSuccessStatusCode)
                {
                    hotelListResponse = JsonConvert.DeserializeObject<HotelListResponse>(ret);
                }  return hotelListResponse;

            }

        }

        public async Task<HotelDetailResponse> GetHotelDetailByHotelId(HotelRequest hotelRequest)
        {
            HotelDetailResponse hotelDetailResponse=new HotelDetailResponse();
            using (HttpClient client = new HttpClient())
            {
                string url = "https://api-sandbox.rezserver.com/api/hotel/getExpress.Contract";
                var res =await client.GetAsync(url + "?refid=" + hotelRequest.refid + "&api_key=" + hotelRequest.api_key + "&format=" + hotelRequest.format + "&ppn_bundle=" + hotelRequest.ppn_bundle);
                var ret = res.Content.ReadAsStringAsync().Result;
                // This line should be deleted: Console.WriteLine(result);
                if (res.IsSuccessStatusCode)
                {
                    hotelDetailResponse = JsonConvert.DeserializeObject<HotelDetailResponse>(ret);
                }
                return hotelDetailResponse;

            }

        }

        public async Task<HotelDetailResponse>HotelBooking(BookingRequest bookingRequest,string refid, string api_key,string format)
        {
            HotelDetailResponse hotelDetailResponse = new HotelDetailResponse();
            using (HttpClient client = new HttpClient())
            {
                //var formdata = new FormData();
                //formdata.append("key", "value");
                string url = "https://api-sandbox.rezserver.com/api/hotel/getExpress.Book";
                var res = await client.PostAsync(url + "?refid=" +refid + "&api_key=" + api_key + "&format=" + format,null);
                var ret = res.Content.ReadAsStringAsync().Result;
                // This line should be deleted: Console.WriteLine(result);
                if (res.IsSuccessStatusCode)
                {
                    hotelDetailResponse = JsonConvert.DeserializeObject<HotelDetailResponse>(ret);
                }
                return hotelDetailResponse;

            }

        }

        public async Task<HotelDetailResponse> BookingLookUp(string booking_id,string email, string refid, string api_key, string format)
        {
            HotelDetailResponse hotelDetailResponse = new HotelDetailResponse();
            using (HttpClient client = new HttpClient())
            {
                //var formdata = new FormData();
                //formdata.append("key", "value");
                string url = "https://api-sandbox.rezserver.com/api/hotel/getExpress.LookUp";
                var res = await client.PostAsync(url + "?refid=" + refid + "&api_key=" + api_key + "&format=" + format,null);
                var ret = res.Content.ReadAsStringAsync().Result;
                // This line should be deleted: Console.WriteLine(result);
                if (res.IsSuccessStatusCode)
                {
                    hotelDetailResponse = JsonConvert.DeserializeObject<HotelDetailResponse>(ret);
                }
                return hotelDetailResponse;

            }

        }

        public async Task<HotelDetailResponse> BookingCancelled(string ppn_bundle, string refid, string api_key, string format)
        {
            HotelDetailResponse hotelDetailResponse = new HotelDetailResponse();
            using (HttpClient client = new HttpClient())
            {
                //var formdata = new FormData();
                //formdata.append("key", "value");
                string url = "https://api-sandbox.rezserver.com/api/hotel/getExpress.Cancel";
                var res = await client.PostAsync(url + "?refid=" + refid + "&api_key=" + api_key + "&format=" + format,null);
                var ret = res.Content.ReadAsStringAsync().Result;
                // This line should be deleted: Console.WriteLine(result);
                if (res.IsSuccessStatusCode)
                {
                    hotelDetailResponse = JsonConvert.DeserializeObject<HotelDetailResponse>(ret);
                }
                return hotelDetailResponse;

            }

        }
    }
}
