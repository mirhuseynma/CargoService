using CargoService.CargoCompany.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoService.CargoCompany.ICargoServices
{
    public interface ICargoInterface
    {
        // save customer, courier and cargoorder
        public void AddCustomer(Customer customer);
        public void AddCourier(Courier courier);
        public void CreateCargoOrder(CargoOrder order);
        public void CompleteCargoOrder(int orderId);
    }
}
