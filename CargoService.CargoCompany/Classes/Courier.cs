
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoService.CargoCompany.Classes
{
    public class Courier
    {
        static int ID;
        public int Id
        {
            get;
            set;
        }
        public string Name { get; set; }
        public string Country { get; set; }
        public bool IsAvalaible { get; set; }
        
        public Courier(string name, string country,bool isAvalaible)
        {
            ID++;
            Id = ID;
            Name = name;
            Country = country;
            IsAvalaible = isAvalaible;
        }

        override public string ToString()
        {
            return $"Id: {Id}, Kuryer: {Name}, Olke: {Country}, Avalaible: {IsAvalaible}";
        }

        
    }
}
