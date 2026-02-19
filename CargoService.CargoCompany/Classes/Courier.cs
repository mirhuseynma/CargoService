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
        private static int _id;
        public int Id { get; set; }
        public bool IsAvalaible { get; set; }
        
        public Courier(string name, string country,bool isAvalaible) : base(name, country)
        {
            _id++;
            Id = _id;
            IsAvalaible = isAvalaible;
        }

        override public string ToString()
        {
            return $"Id: {Id}, Kuryer: {Name}, Olke: {Country}, Avalaible: {IsAvalaible}";
        }

        
    }
}
