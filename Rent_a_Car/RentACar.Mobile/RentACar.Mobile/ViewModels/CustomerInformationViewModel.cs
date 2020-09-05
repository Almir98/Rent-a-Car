using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RentACar.Mobile.ViewModels
{
    public class CustomerInformationViewModel : BaseViewModel
    {
        private readonly APIService _serviceCustomer = new APIService("Customer");

        public CustomerInformationViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        //LOG OUT

        public ICommand Logout
        {
            get
            {
                return new Command(() =>
                {
                    APIService.Username = "";
                    APIService.Password = "";
                    APIService.CustomerId = 0;
                });
            }
        }

        public ICommand InitCommand { get; set; }

        //FIRST NAME
        string _firstName = string.Empty;
        public string FirstName
        {
            get { return _firstName; }
            set { SetProperty(ref _firstName, value); }
        }

        //LAST NAME
        string _lastName = string.Empty;
        public string LastName
        {
            get { return _lastName; }
            set { SetProperty(ref _lastName, value); }
        }

        // Phone
        string _phone = string.Empty;
        public string Phone
        {
            get { return _phone; }
            set { SetProperty(ref _phone, value); }
        }

        // EMAIL
        string _email = string.Empty;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        //USERNAME
        string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        //CITY
        string _city = string.Empty;
        public string City
        {
            get { return _city; }
            set { SetProperty(ref _city, value); }
        }

        public Data.Model.Customer customer { get; set; }

        public async Task Init()
        {
            var list = await _serviceCustomer.GetById<Data.Model.Customer>(APIService.CustomerId);

            FirstName = list.FirstName;
            LastName = list.LastName;
            Phone = list.Phone;
            Email = list.Email;
            Username = list.Username;
            City = list.City.CityName;
        }
    }
}
