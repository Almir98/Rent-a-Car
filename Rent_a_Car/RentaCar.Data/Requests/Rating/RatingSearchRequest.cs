namespace RentaCar.Data.Requests.Rating
{
    public class RatingSearchRequest
    {
        public string ManufacturerName { get; set; }
        public int? RatingValue { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ModelName { get; set; }

        public int? CustomerID { get; set; }
        public int? VehicleId { get; set; }
    }
}
