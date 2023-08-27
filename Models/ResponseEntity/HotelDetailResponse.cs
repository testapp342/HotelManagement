using Newtonsoft.Json;

namespace HotelBookingWebApplication.Models.ResponseEntity
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Addresss
    {
        public string city_name { get; set; }
        public string address_line_one { get; set; }
        public string state_code { get; set; }
        public string state_name { get; set; }
        public string country_code { get; set; }
        public string country_name { get; set; }
        public string zip { get; set; }
    }

    public class AllowedCardsDatum
    {
        public string card_type { get; set; }
        public string name { get; set; }
    }

    public class AllowedCountriesDatum
    {
        public string code { get; set; }
        public string name { get; set; }
        public List<RegionDatum> region_data { get; set; }
    }

    public class AttributeData
    {
        public List<TaxDatum> tax_data { get; set; }
    }

    public class BeddingDatum
    {
        public int bed_count { get; set; }
        public string bed_type { get; set; }
    }

    public class BenchmarkPrice_Details
    {
        public int saving_percentage { get; set; }
        public string baseline_currency { get; set; }
        public int baseline_price { get; set; }
        public string source_currency { get; set; }
        public int source_price { get; set; }
        public string display_currency { get; set; }
        public int display_price { get; set; }
    }

    public class BookFormDetails
    {
        public string inventory { get; set; }
        public int name_first { get; set; }
        public int name_last { get; set; }
        public int email { get; set; }
        public int phone_number { get; set; }
        public int card_type { get; set; }
        public int card_number { get; set; }
        public int expires { get; set; }
        public int cvc_code { get; set; }
        public int card_holder { get; set; }
        public int add_insurance { get; set; }
        public int address_line_one { get; set; }
        public int address_city { get; set; }
        public int address_postal_code { get; set; }
        public int address_state_code { get; set; }
        public int country_code { get; set; }
        public int initials { get; set; }
        public int contract_response { get; set; }
        public int loyalty_points { get; set; }
    }

    public class BundleData
    {
        public string contract_type { get; set; }
        public string session_id { get; set; }
        public string check_in { get; set; }
        public string check_out { get; set; }
        public string room_id { get; set; }
        public object pcln_id { get; set; }
        public string hotel_id { get; set; }
        public string hotel_name { get; set; }
        public string zone_name { get; set; }
        public string city_id { get; set; }
        public string city_id_t { get; set; }
        public string rate_count { get; set; }
        public string rate_inventory { get; set; }
        public string rate_plan { get; set; }
        public string rate_currency { get; set; }
        public int rate_avg { get; set; }
        public object rate_processing_fee { get; set; }
        public double rate_fee { get; set; }
        public double rate_total { get; set; }
        public string room_text { get; set; }
        public string ppn_book_bundle { get; set; }
    }

    public class CancellationDetail
    {
        public string description { get; set; }
        public DateTime date_after { get; set; }
        public DateTime date_before { get; set; }
        public int penalty_nights { get; set; }
        public string source_currency { get; set; }
        public double source_amount { get; set; }
        public int source_tax { get; set; }
        public int source_processing_fee { get; set; }
        public int source_cancellation_fee { get; set; }
        public double source_refund { get; set; }
        public double source_total_charges { get; set; }
        public string display_currency { get; set; }
        public double display_amount { get; set; }
        public int display_tax { get; set; }
        public int display_processing_fee { get; set; }
        public int display_cancellation_fee { get; set; }
        public double display_refund { get; set; }
        public double display_total_charges { get; set; }
    }

    public class CheckInInformation
    {
        public bool standard_check_in { get; set; }
    }

    public class HotelCity
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Geofence
    {
        public string latitude { get; set; }
        public string longitude { get; set; }
    }

    public class GetHotelExpressContract
    {
        public Resultss results { get; set; }
    }

    public class HotelChain
    {
        public int id { get; set; }
        public int group_id { get; set; }
        public string name { get; set; }
        public int code { get; set; }
        public string chain_codes_b { get; set; }
        public string chain_codes_t { get; set; }
    }

    public class Hotel_Datum
    {
        public string id { get; set; }
        public string id_t { get; set; }
        public int property_type_id { get; set; }
        public string name { get; set; }
        public string hotel_zone { get; set; }
        public int zone_rank { get; set; }
        public string hotel_description { get; set; }
        public int star_rating { get; set; }
        public double review_rating { get; set; }
        public string review_rating_desc { get; set; }
        public string thumbnail { get; set; }
        public ThumbnailHq thumbnail_hq { get; set; }
        public HotelCity city { get; set; }
        public Addresss address { get; set; }
        public Geofence geo { get; set; }
        public object neighborhood { get; set; }
        public HotelChain hotel_chain { get; set; }
        public HotelScore hotel_score { get; set; }
        public List<string> photo_data { get; set; }
        public List<object> amenity_data { get; set; }
        public ReviewScoreData review_score_data { get; set; }
        public CheckInInformation check_in_information { get; set; }
        public List<Room_Datum> room_data { get; set; }
    }

    public class HotelScore
    {
        public string guest_score { get; set; }
        public string guest_score_count { get; set; }
        public string hmi_score { get; set; }
        public string city_rank { get; set; }
        public string review_rating_desc { get; set; }
    }

    public class InputData
    {
        public string check_in { get; set; }
        public string check_out { get; set; }
        public string num_rooms { get; set; }
        public string num_adults { get; set; }
        public string num_children { get; set; }
        public string num_nights { get; set; }
    }

    public class NightPriceDatum
    {
        public int baseline_night_price { get; set; }
        public int source_night_price { get; set; }
        public int display_night_price { get; set; }
    }

    public class Policy_Datum
    {
        public string title { get; set; }
        public List<string> paragraph_data { get; set; }
    }

    public class Price_Details
    {
        public string booked_currency { get; set; }
        public string baseline_currency { get; set; }
        public string baseline_symbol { get; set; }
        public int baseline_price { get; set; }
        public int baseline_processing_fee { get; set; }
        public int baseline_property_fee { get; set; }
        public int baseline_insurance_fee { get; set; }
        public int baseline_sub_total { get; set; }
        public double baseline_taxes { get; set; }
        public double baseline_total { get; set; }
        public string source_currency { get; set; }
        public string source_symbol { get; set; }
        public int source_price { get; set; }
        public int source_processing_fee { get; set; }
        public int source_property_fee { get; set; }
        public int source_insurance_fee { get; set; }
        public int source_sub_total { get; set; }
        public double source_taxes { get; set; }
        public double source_total { get; set; }
        public string display_currency { get; set; }
        public string display_symbol { get; set; }
        public int display_price { get; set; }
        public int display_processing_fee { get; set; }
        public int display_property_fee { get; set; }
        public int display_insurance_fee { get; set; }
        public int display_sub_total { get; set; }
        public double display_taxes { get; set; }
        public double display_total { get; set; }
        public object mandatory_fee_details { get; set; }
        public AttributeData attribute_data { get; set; }
        public List<NightPriceDatum> night_price_data { get; set; }
        public bool nightly_rate_changes { get; set; }
        public Promo promo { get; set; }
    }

    public class Promo
    {
        public object title { get; set; }
        public object description { get; set; }
        public object type { get; set; }
        public object terms { get; set; }
        public int strikeout_price { get; set; }
        public int source_strikeout_price { get; set; }
        public int display_strikeout_price { get; set; }
        public int required { get; set; }
    }

    public class Rate_Datum
    {
        public string source { get; set; }
        public string rate_type { get; set; }
        public string room_id { get; set; }
        public string commission_type { get; set; }
        public string distribution_type { get; set; }
        public string payment_type { get; set; }
        public string board_type { get; set; }
        public string inventory_type { get; set; }
        public List<object> program_types { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int occupancy_limit { get; set; }
        public int available_rooms { get; set; }
        public object room_sq_footage { get; set; }
        public string ppn_bundle { get; set; }
        public string rate_plan_code { get; set; }
        public object rate_tracking_id { get; set; }
        public string all_inclusive { get; set; }
        public bool bed_choice_available { get; set; }
        public int rate_source_code { get; set; }
        public List<BeddingDatum> bedding_data { get; set; }
        public BenchmarkPrice_Details benchmark_price_details { get; set; }
        public object property_fee_details { get; set; }
        public Price_Details price_details { get; set; }
        public List<CancellationDetail> cancellation_details { get; set; }
        public List<Policy_Datum> policy_data { get; set; }
        public object plugin_data { get; set; }
        public UpsellData upsell_data { get; set; }
        public string is_cancellable { get; set; }
        public bool cvc_required { get; set; }
        public List<object> promo_data { get; set; }
        public object rate_amenity_data { get; set; }
        public string language { get; set; }
    }

    public class RegionDatum
    {
        public string name { get; set; }
        public string code { get; set; }
    }

    public class Resultss
    {
        public string status { get; set; }
        public int status_code { get; set; }
        public InputData input_data { get; set; }
        public BundleData bundle_data { get; set; }
        public List<Hotel_Datum> hotel_data { get; set; }
        public List<string> taxes_and_fees { get; set; }
        public List<AllowedCardsDatum> allowed_cards_data { get; set; }
        public List<AllowedCountriesDatum> allowed_countries_data { get; set; }
        public BookFormDetails book_form_details { get; set; }
        public SelectiveOptions selective_options { get; set; }
        public string language { get; set; }
        public string time { get; set; }
    }

    public class ReviewScoreData
    {
        public string cleanliness_score { get; set; }
    }

    public class Room_Datum
    {
        public List<Rate_Datum> rate_data { get; set; }
    }

    public class HotelDetailResponse
    {
        [JsonProperty("getHotelExpress.Contract")]
        public GetHotelExpressContract getHotelExpressContract { get; set; }
    }

    public class SelectiveOptions
    {
        public int comments_allowed { get; set; }
    }

    public class TaxDatum
    {
        public string name { get; set; }
        public string type { get; set; }
        public string source_currency { get; set; }
        public double source_amount { get; set; }
        public string display_currency { get; set; }
        public double display_amount { get; set; }
        public string attribute { get; set; }
    }

    public class ThumbnailHq
    {
        public string hundred_fifty_square { get; set; }
        public string three_hundred_square { get; set; }
    }

    public class TravelInsurance
    {
        public List<object> @default { get; set; }
        public List<object> important_information { get; set; }
        public object ti_html { get; set; }
        public List<object> text_block { get; set; }
        public string insurance_type { get; set; }
        public string insurance_available { get; set; }
        public string insurance_allowed { get; set; }
    }

    public class UpsellData
    {
        public TravelInsurance travel_insurance { get; set; }
    }


}
