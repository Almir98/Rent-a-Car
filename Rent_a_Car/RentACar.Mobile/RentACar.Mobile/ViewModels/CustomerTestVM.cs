using RentaCar.Data.Requests.Customer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RentACar.Mobile.ViewModels
{
    public class CustomerTestVM : BaseViewModel
    {
        private readonly APIService _serviceCustomer = new APIService("Customer");
        private readonly APIService _serviceCustomerType = new APIService("CustomerType");

        
        public ICommand InitCommand { get; set; }
        public ICommand FilterCommand { get; set; }

        public CustomerTestVM()
        {
            InitCommand = new Command(async () => await Punjenje());
            FilterCommand = new Command(async () => await Filtiranje());
        }


        public ObservableCollection<Data.Model.Customer> customerList { get; set; } = new ObservableCollection<Data.Model.Customer>();
        public ObservableCollection<Data.Model.CustomerType> allTypes { get; set; } = new ObservableCollection<Data.Model.CustomerType>();

        Data.Model.CustomerType _selectedType = null;
        public Data.Model.CustomerType SelectedType
        {
            get { return _selectedType; }
            set
            {
                SetProperty(ref _selectedType, value);
                if(value != null)
                {
                    FilterCommand.Execute(null);        // pazit da ide na filter komandu koja upucuje na metodu
                }
            }
        }


        public async Task Punjenje()
        {
            if (allTypes.Count == 0)
            {
                var tipovi = await _serviceCustomerType.Get<List<Data.Model.CustomerType>>(null);
                foreach (var item in tipovi)
                {
                    allTypes.Add(item);
                }
            }

            if (customerList.Count == 0)
            {
                var lista = await _serviceCustomer.Get<List<Data.Model.Customer>>(null);
                foreach (var item in lista)
                {
                    customerList.Add(item);
                }
            }
        }

        public async Task Filtiranje()
        {
            if (SelectedType != null)
            {
                CustomerSearchRequest request = new CustomerSearchRequest();
                request.CustomerTypeId = SelectedType.CustomerTypeId;

                var lista = await _serviceCustomer.Get<List<Data.Model.Customer>>(request);

                customerList.Clear();
                foreach (var item in lista)
                {
                    customerList.Add(item);
                }
            }
        }
    }
}
