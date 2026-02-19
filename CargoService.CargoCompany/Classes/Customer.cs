using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoService.CargoCompany.Classes
{
    public class Customer : Models.Cargos
    {
        public Customer(string name, string country) : base(name, country)
        {
        }

        public override string ToString()
        {
            return $"Id: {Id}, Musteri: {Name}, Olke: {Country}";
        }
        
        
    }
}
