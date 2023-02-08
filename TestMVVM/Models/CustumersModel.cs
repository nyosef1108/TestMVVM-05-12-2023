using Custumers.BL.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace TestMVVM.Models
{
    public class CustumersModel
    {
        public List<Customer> Costumers { get; set; }
        public string StoreName { get; set; }   

        public CustumersModel()
        {
            Costumers = new List<Customer>();
            Costumers.Add(new Customer { Id = 222, Name = "dani", Address = "Tlv" });
            Costumers.Add(new Customer { Id = 422, Name = "beni", Address = "Tlv" });
            Costumers.Add(new Customer { Id = 522, Name = "yoram", Address = "Tlv" });
            Costumers.Add(new Customer { Id = 722, Name = "rina", Address = "js" });
            Costumers.Add(new Customer { Id = 822, Name = "dina", Address = "js" });
            StoreName = "Rami Levi"; 
        }

        public void AddCustomer(Customer c)
        {
            Costumers.Add(c);
        }
    }
}
