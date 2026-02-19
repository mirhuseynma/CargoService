using CargoService.CargoCompany.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoService.CargoCompany.Classes
{
    public class CargoOrder : Models.Cargos
    {

        public int CustomerId { get; set; }
        public int CourierId { get; set; }
        public double TotalPrice { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime CreatedAt { get { return DateTime.Now; } }


        public CargoOrder(string name, string country, int customerId, int courierId, double totalPrice, OrderStatus status) : base(name, country)
        {
            CustomerId = customerId;
            CourierId = courierId;
            TotalPrice = totalPrice;
            Status = status;
        }
        public CargoOrder()
        {
            
        }

        public void UpdateStatus(OrderStatus status)
        {
            if (status == OrderStatus.Cancelled && status == OrderStatus.Delivered) Console.WriteLine("Statusu deyishmek mumkun olmadi!!!");
            else Console.WriteLine($"Status deyisdirildi cari status: {status}");
        }
        override public string ToString()
        {
            return $"Id: {Id}, Cargo: {Name}, Olke: {Country}, CustomerId: {CustomerId}, CourierId: {CourierId}, TotalPrice: {TotalPrice}, Status: {Status}, CreatedAt: {CreatedAt}";
        }
        
    }
}
