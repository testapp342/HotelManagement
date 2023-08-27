using Newtonsoft.Json;

namespace HotelBookingWebApplication.Models.ResponseEntity
{
   
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Address
    {
        public string city_name { get; set; }
        public string address_line_one { get; set; }
        public string state_code { get; set; }
        public string state_name { get; set; }
        public string country_code { get; set; }
        public string country_name { get; set; }
        public string zip { get; set; }
    }

    public class BenchmarkPriceDetails
    {
        public int saving_percentage { get; set; }
        public string baseline_currency { get; set; }
        public double baseline_price { get; set; }
        public string source_currency { get; set; }
        public double source_price { get; set; }
        public string display_currency { get; set; }
        public double display_price { get; set; }
    }

    public class City
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class ExternalUrl
    {
        public string type { get; set; }
        public string inventory { get; set; }
        public string url { get; set; }
        public PriceSummary price_summary { get; set; }
    }

    public class Geo
    {
        public string latitude { get; set; }
        public string longitude { get; set; }
    }

    public class GetHotelExpressAvailability
    {
        public Resultss results { get; set; }
    }

    public class HotelDatum
    {
        public string id { get; set; }
        public string name { get; set; }
        public double star_rating { get; set; }
        public double review_rating { get; set; }
        public string review_rating_desc { get; set; }
        public string thumbnail { get; set; }
        public City city { get; set; }
        public Address address { get; set; }
        public Geo geo { get; set; }
        public List<ExternalUrl> external_urls { get; set; }
        public List<Room_Datum> room_data { get; set; }
    }

    public class PriceDetails
    {
        public string baseline_currency { get; set; }
        public string baseline_symbol { get; set; }
        public double baseline_price { get; set; }
        public double baseline_sub_total { get; set; }
        public double baseline_total { get; set; }
        public string source_currency { get; set; }
        public string source_symbol { get; set; }
        public double source_price { get; set; }
        public double source_sub_total { get; set; }
        public double source_total { get; set; }
        public string display_currency { get; set; }
        public string display_symbol { get; set; }
        public double display_price { get; set; }
        public double display_sub_total { get; set; }
        public double display_total { get; set; }
    }

    public class PriceSummary
    {
        public string display_currency { get; set; }
        public string display_symbol { get; set; }
        public double display_price { get; set; }
    }

    public class RateDatum
    {
        public string source { get; set; }
        public string rate_type { get; set; }
        public string commission_type { get; set; }
        public string distribution_type { get; set; }
        public string payment_type { get; set; }
        public string board_type { get; set; }
        public string inventory_type { get; set; }
        public List<object> program_types { get; set; }
        public int occupancy_limit { get; set; }
        public int available_rooms { get; set; }
        public string ppn_bundle { get; set; }
        public string rate_plan_code { get; set; }
        public string rate_tracking_id { get; set; }
        public BenchmarkPriceDetails benchmark_price_details { get; set; }
        public PriceDetails price_details { get; set; }
        public string refund_type { get; set; }
        public string language { get; set; }
    }

    public class Results
    {
        public string status { get; set; }
        public int status_code { get; set; }
        public ResultsData results_data { get; set; }
        public SortData sort_data { get; set; }
        public List<HotelDatum> hotel_data { get; set; }
        public string language { get; set; }
        public double time { get; set; }
    }

    public class ResultsData
    {
        public int rate_count { get; set; }
        public int nearby_rate_count { get; set; }
    }

    public class RoomDatum
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int? room_square_footage { get; set; }
        public List<RateDatum> rate_data { get; set; }
    }

    public class HotelListResponse
    {
        [JsonProperty("getHotelExpress.Availability")]
        public GetHotelExpressAvailability getHotelExpressAvailability { get; set; }
    }

    public class SortData
    {
        public string sort_by { get; set; }
    }


}
