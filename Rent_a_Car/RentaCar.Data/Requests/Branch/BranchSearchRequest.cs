namespace RentaCar.Data.Requests.Branch
{
    public class BranchSearchRequest
    {
        public int? CityId { get; set; }
        public string BranchName { get; set; }
        public string PhoneNumber { get; set; }

    }
}
