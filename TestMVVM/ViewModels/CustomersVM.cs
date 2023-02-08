using Custumers.BL.BE;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMVVM.Commands;
using TestMVVM.Models;

namespace TestMVVM.ViewModels
{
    public class CustomersVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public AddCommand Add { get; set; }
        public CustumersModel CurrentModel { get; set; } 
        public ObservableCollection<Customer> Customers { get; set; }
        public string StoreName
        {
            get {   return CurrentModel.StoreName; }
            set
            { 
                CurrentModel.StoreName = value;
                if (PropertyChanged!= null)
                    PropertyChanged(this, new PropertyChangedEventArgs("StoreName"));
                
            } 
        }

        public CustomersVM()
        { 
            CurrentModel = new CustumersModel(); 
            Customers = new ObservableCollection<Customer>(CurrentModel.Costumers);
            Add = new AddCommand();
            Add.ShouldAdd += Add_ShouldAdd;
            Customers.CollectionChanged += Customers_CollectionChanged; ;
        }

        private void Customers_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            CurrentModel.AddCustomer(e.NewItems[0] as Customer);
        }

        private void Add_ShouldAdd(string Name, string Address)
        {
            var c = new Customer { Name = Name,Address = Address };
            Customers.Add(c);
        }
    }
}
