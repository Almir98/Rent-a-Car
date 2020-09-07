using RentaCar.Data.Requests.Booking;
using RentaCar.Data.Requests.Comments;
using RentACar.Mobile.Views;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RentACar.Mobile.ViewModels
{
    public class CommentViewModel : BaseViewModel
    {
        private readonly APIService _serviceComment = new APIService("Comment");
        private readonly APIService _serviceCustomer = new APIService("Customer");
        private readonly APIService _serviceBooking = new APIService("Booking");
        private readonly APIService _serviceVehicle = new APIService("Vehicle");

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

        private string _manufacturer = string.Empty;
        public string ManufacturerName
        {
            get { return _manufacturer; }
            set { SetProperty(ref _manufacturer, value); }
        }

        private string _modelName = string.Empty;
        public string ModelName
        {
            get { return _modelName; }
            set { SetProperty(ref _modelName, value); }
        }

        private string _description = string.Empty;
        public string Description
        {
            get { return _description; }
            set { SetProperty(ref _description, value); }
        }

        DateTime _date = DateTime.Now.Date;
        public DateTime CommentDate 
        {
            get { return _date; }
            set { SetProperty(ref _date, value); }
        }



        public Data.Model.Customer customer { get; set; }
        public Data.Model.Vehicle vehicle { get; set; }


        public async Task InitializationField()
        {
            var customerID = await _serviceCustomer.GetById<Data.Model.Customer>(APIService.CustomerId);
            customer = customerID;

            FirstName = customer.FirstName;
            LastName = customer.LastName;
            ManufacturerName = vehicle.VehicleModel.Manufacturer.ManufacturerName;
            ModelName = vehicle.VehicleModel.ModelName;
        }


        public async Task SetComment()
        {
            if (string.IsNullOrEmpty(Description))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "All fields are required", "Try again");
                return;
            }
            try
            {
                var customerID = await _serviceCustomer.GetById<Data.Model.Customer>(APIService.CustomerId);
                customer = customerID;

                var car = await _serviceVehicle.GetById<Data.Model.Vehicle>(vehicle.VehicleId);

                bool answer = await Application.Current.MainPage.DisplayAlert("Alert", "Would you like to leave a comment?", "Yes", "No");
                if (answer)
                {
                    var request = new CommentUpsert
                    {
                        CustomerId = APIService.CustomerId,
                        VehicleId = vehicle.VehicleId,
                        DateOfComment = DateTime.Now.Date,
                        Description = Description,
                        CommentStatus = true
                    };

                    var listComment = await _serviceComment.Get<List<Data.Model.Comment>>(new CommentSearchRequest {
                    
                        CustomerID=request.CustomerId,
                        VehicleId=request.VehicleId
                    });

                    foreach (var com in listComment)
                    {
                        if (CommentDate == com.DateOfComment)
                        {
                            await Application.Current.MainPage.DisplayAlert("Message", "Comment for this reservation already exist! You can add just 1 comment for reservation", "Try again");
                            return;
                        }
                    }

                    await _serviceComment.Insert<Data.Model.Comment>(request);
                    await Application.Current.MainPage.DisplayAlert("Message", "Successfully! You added your comment for rented car!", "OK");

                    var listBooking = await _serviceBooking.Get<List<Data.Model.Booking>>(new BookingSearchRequest
                    {
                        CustomerID = customer.CustomerId
                    });

                    foreach (var item in listBooking)
                    {
                        if(item.VehicleId==vehicle.VehicleId && item.CustomerId==customer.CustomerId)
                        {
                            if(item.CommentStatus==false)
                            {
                                var req = new BookingUpsert
                                {
                                    CustomerId = item.CustomerId,
                                    VehicleId = item.VehicleId,
                                    StartDate = item.StartDate,
                                    EndDate = item.EndDate,
                                    RatingStatus = item.RatingStatus,
                                    CommentStatus = true
                                };
                                await _serviceBooking.Update<Data.Model.Booking>(item.BookingId, req);
                                return;
                            }
                        }
                    }
                    //foreach (var item in listComment)
                    //{
                    //    foreach (var book in listBooking)
                    //    {
                    //        if (item.VehicleId == book.VehicleId)
                    //        {
                    //            if (book.CommentStatus == false)
                    //            {
                    //                var req = new BookingUpsert
                    //                {
                    //                    CustomerId = book.CustomerId,
                    //                    VehicleId = book.VehicleId,
                    //                    StartDate = book.StartDate,
                    //                    EndDate = book.EndDate,
                    //                    RatingStatus = book.RatingStatus,
                    //                    CommentStatus = true
                    //                };
                    //                await _serviceBooking.Update<Data.Model.Booking>(book.BookingId, req);
                    //                return;
                    //            }
                    //        }
                    //    }
                    //}
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Somethning went wrong", "Try again");
            }
        }
    }
}
