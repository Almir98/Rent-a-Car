namespace RentaCar.Data.Requests.Vehicle
{
    public class VehicleSearchRequest
    {
        public string ManufacturerName { get; set; }
        public string ModelName { get; set; }
        public string RegistrationNumber { get; set; }
        public string Transmission { get; set; }
        public string FuelName { get; set; }
        public string BranchName { get; set; }
    }
}
