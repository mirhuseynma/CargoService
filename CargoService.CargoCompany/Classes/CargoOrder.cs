using CargoService.CargoCompany.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoService.CargoCompany.Classes
{
    public class CargoOrder
    {
        static int ID;
        public int Id { get;}
        public string Name { get; set; }
        public string Country { get; set; }
        public int CustomerId { get; set; }
        public int CourierId { get; set; }
        public double TotalPrice { get; set; }
        public OrderStatus Status { get; }
        public DateTime CreatedAt { get { return DateTime.Now; } }


        public CargoOrder(string name, string country, int customerId, int courierId, double totalPrice)
        {
            ID++;
            Id = ID;
            Name = name;
            Country = country;
            CustomerId = customerId;
            CourierId = courierId;
            TotalPrice = totalPrice;
            Status = OrderStatus.Created;
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
