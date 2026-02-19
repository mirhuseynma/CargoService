using CargoService.CargoCompany.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoService.CargoCompany.ICargoServices
{
    public class CargoService : ICargoInterface
    {
        private Customer[] _customer = new Customer[100];
        private Courier[] _courier = new Courier[100];
        private CargoOrder[] _cargoOrder = new CargoOrder[100];
        private int _count = 0;

        
        public void CreateCargoOrder(int customerId, int courierId)
        {
            Customer customer = null;
            Courier courier = null;
            for (int i = 0; i < _count; i++)
            {
                if (_customer[i].Id == customerId)
                {
                    customer = _customer[i];
                }
            }
            if (customer == null)
            {
                throw new Exception("Bu ID ile musteri tapilmadi");
            }

            for (int i = 0; i < _count; i++)
            {
                if (_courier[i].Id == courierId)
                {
                    courier = _courier[i];
                }
            }
            if (courier == null)
            {
                throw new Exception("Bu ID ile kuryer tapilmadi.");
            }
            if (courier.IsAvalaible == false)
            {
                throw new Exception("Bu kuryer mesguldur.");
            }   
            CargoOrder cargoOrder = new CargoOrder() 
            {  
                    cargoOrder.Id= _count + 1,
                    cargoOrder.CustomerId = customerId,
                    cargoOrder.CourierId = courierId,
                    cargoOrder.Status = Enums.OrderStatus.Created
            
            };  
            courier.IsAvalaible = false;
            _cargoOrder[_count] = cargoOrder;
            _count++;
            Console.WriteLine("sifaris yaradildi");
        }



        public void AddCourier(Courier courier)
        {
            for (int i = 0; i < _count; i++)
            {
                {
                    if (_courier[i].Id == courier.Id)
                    {
                        Console.WriteLine("Bu ID ile kuryer artiq var.");
                        return;
                    }
                }
                _courier[_count] = courier;
                _count++;
            }
        }

        public void AddCustomer(Customer customer)
        {
            for (int i = 0; i < _count; i++) 
            {
                if (_customer[i].Id == customer.Id)
                {
                    Console.WriteLine("Bu ID ile müşteri artiq var.");
                    return;
                }
            }
            _customer[_count] = customer;
            _count++;
        }

        
    }
}
