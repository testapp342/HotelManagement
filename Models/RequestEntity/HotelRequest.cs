namespace HotelBookingWebApplication.Models.RequestEntity
{
    public class HotelRequest
    {
        public string refid { get; set; }
        public string api_key { get; set; }
        public string format { get; set; }
        public string check_in { get; set; }
        public string check_out { get; set; }
        public string city_id { get; set; }
        public string hotel_ids { get; set; }
        public string ppn_bundle { get; set; }
    }
}
