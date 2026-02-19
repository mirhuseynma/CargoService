using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoService.CargoCompany.Models
{
    public abstract class Cargos
    {
        public string Customer { get; set; }

        static int ID;
        public int Id
        {
            get;
            set;
        }
        public string Name { get; set; }
        public string Country { get; set; }

        public Cargos()
        {
            
        }
        public Cargos(string name, string country)
        {
            ID++;
            Id = ID;
            Name = name;
            Country = country;
        }

        
    }
}
