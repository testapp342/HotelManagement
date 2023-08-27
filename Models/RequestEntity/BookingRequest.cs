namespace HotelBookingWebApplication.Models.RequestEntity
{
    public class BookingRequest
    {
        public string email { get; set; }
        public string phone_number { get; set; }
        public string name_first { get; set; }
        public string name_last { get; set; }
        public string ppn_bundle { get; set; }
        public string address_city { get; set; }
        public string address_line_one { get; set; }
        public string address_postal_code { get; set; }
        public string card_holder { get; set; }
        public string card_number { get; set; }
        public string country_code { get; set; }
        public string card_type { get; set; }
        public string expires { get; set; }
    }
}
