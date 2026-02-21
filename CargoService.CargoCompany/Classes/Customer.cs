using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoService.CargoCompany.Classes
{

    public class Customer 
    {
        static int ID;
        public int Id { get; }
        public string Name { get; set; }
        public string Country { get; set; }
        public Customer(string name, string country) 
        {
            ID++;
            Id = ID;
            Name = name;
            Country = country;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Musteri: {Name}, Olke: {Country}";
        }
        
        
    }
}
