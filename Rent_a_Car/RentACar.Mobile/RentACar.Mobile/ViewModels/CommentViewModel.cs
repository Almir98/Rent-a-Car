using RentaCar.Data.Requests.Comments;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RentACar.Mobile.ViewModels
{
    public class CommentViewModel : BaseViewModel
    {
        private readonly APIService _serviceComment = new APIService("Comment");
        private readonly APIService _serviceCustomer = new APIService("Customer");


        public ICommand CommentCommand { get; set; }
        public ICommand SaveCommand { get; set; }


        public CommentViewModel()
        {
            CommentCommand = new Command(async () => await InitializationField());
            SaveCommand = new Command(async () => await SetComment());
        }

        // propertiji

        private string _firstName = string.Empty;
        public string FirstName
        {
            get { return _firstName; }
            set { SetProperty(ref _firstName, value); }
        }

        private string _lastName = string.Empty;
        public string LastName
        {
            get { return _lastName; }
            set { SetProperty(ref _lastName, value); }
        }

        private string _description = string.Empty;
        public string Description
        {
            get { return _description; }
            set { SetProperty(ref _description, value); }
        }

        private Data.Model.Customer customer { get; set; }

        public async Task InitializationField()
        {
            var customerID = await _serviceCustomer.GetById<Data.Model.Customer>(APIService.CustomerId);
            customer = customerID;

            FirstName = customer.FirstName;
            LastName = customer.LastName;
        }


        public async Task SetComment()
        {
            try
            {
                var customerID = await _serviceCustomer.GetById<Data.Model.Customer>(APIService.CustomerId);
                customer = customerID;

                bool answer = await Application.Current.MainPage.DisplayAlert("Alert", "Would you like to leave a comment?", "Yes", "No");
                if (answer)
                {
                    var request = new CommentUpsert
                    {
                        CustomerId = APIService.CustomerId,
                        VehicleId = 4,                                                        // ISPRAVIT !!!!!
                        DateOfComment = DateTime.Now,
                        Description = Description
                    };

                    await _serviceComment.Insert<Data.Model.Comment>(request);
                    await Application.Current.MainPage.DisplayAlert("Message", "Successfully! You added your comment for rented car!", "OK");

                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Somethning went wrong", "Try again");
            }
        }
    }
}
