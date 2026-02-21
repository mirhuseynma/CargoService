using CargoService.CargoCompany.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CargoService.CargoCompany.Enums;


namespace CargoService.CargoCompany.ICargoServices
{
    public class CargoService : ICargoInterface
    {
        private Customer[] _customer = [];
        private Courier[] _courier = [];
        private CargoOrder[] _cargoOrder = [];

        public void AddCourier(Courier courier)
        {
            if (courier == null)
                throw new Exception("Courier cannot be null.");
            for (int i = 0; i < _courier.Length; i++)
            {
                if (_courier[i].Id == courier.Id)
                {
                    throw new Exception("Courier with the same ID already exists.");
                }
                
            }
            Array.Resize(ref _courier, _courier.Length + 1);
            _courier[^1] = courier;
        }

        public void AddCustomer(Customer customer)
        {
            if (customer == null)
                throw new Exception("Customer cannot be null.");
            for (int i = 0; i < _customer.Length; i++)
            {

                if (_customer[i].Id == customer.Id)
                {
                    throw new Exception("Customer with the same ID already exists.");
                }
                Array.Resize(ref _customer, _customer.Length + 1);
                _customer[^1] = customer;
            }
        }

        public void CreateCargoOrder(CargoOrder order)
        {
            int customerID = order.CustomerId;
            bool customerExsist = false;
            foreach (var customer in _customer)
            {
                if (customer.Id == customerID)
                {
                    customerExsist = true;
                    break;
                }
            }
            if (customerExsist) throw new Exception("Customer not found");
            int courierID = order.CourierId;
            bool courierExsist = false;
            foreach (var courier in _courier)
            {
                if (courier.Id == courierID && courier.IsAvalaible == true)
                {
                    courierExsist = true;
                    courier.IsAvalaible = false;
                    break;
                }
            }
            if (courierExsist) throw new Exception("Courier not found");
            Array.Resize(ref _cargoOrder, _cargoOrder.Length + 1);
            _cargoOrder[^1] = order;
        }
        public void CompleteCargoOrder(int orderId)
        {
            CargoOrder currentOrder = null;
            foreach (var order in _cargoOrder)
            {
                if (order.Id == orderId)
                {
                    currentOrder = order;
                    break;
                }
            }
            if (currentOrder == null) throw new Exception("Order not found");
            currentOrder.UpdateStatus(OrderStatus.Delivered);
            int courierID = currentOrder.CourierId;
            foreach (var courier in _courier)
            {
                if (courier.Id == courierID)
                {
                    courier.IsAvalaible = true;
                    break;
                }
            }
        }
    }
}
