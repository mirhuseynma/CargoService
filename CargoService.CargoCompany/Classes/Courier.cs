using CargoService.CargoCompany.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoService.CargoCompany.Classes
{
    public class Courier:Models.Cargos
    {
        public bool IsAvalaible { get; set; }
        
        public Courier(string name, string country,bool isAvalaible) : base(name, country)
        {
            IsAvalaible = isAvalaible;
        }


    }
}
