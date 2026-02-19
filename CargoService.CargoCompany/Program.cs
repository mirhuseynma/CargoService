using CargoService.CargoCompany.Classes;

namespace CargoService.CargoCompany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer("John Doe", "USA");
            Customer customer1 = new Customer("John Doe", "USA");
            Customer customer2 = new Customer("John Doe", "USA");
            Customer customer3 = new Customer("John Doe", "USA");

            Courier courier = new Courier("Artur Morgan", "UK",false);
            Courier courier1 = new Courier("Jane Smith", "UK", true);
            Courier courier2 = new Courier("Corc Washington", "UK", true);
            Courier courier3 = new Courier("Adbullah Hermen", "UK", false);

            Console.WriteLine(customer.Id);
            Console.WriteLine(courier.Id);

            ICargoServices.CargoService cargoService = new ICargoServices.CargoService();
            cargoService.AddCustomer(customer);
            cargoService.AddCustomer(customer1);
            cargoService.AddCustomer(customer2);
            cargoService.AddCustomer(customer3);

            ICargoServices.CargoService cargoService2 = new ICargoServices.CargoService();

            cargoService2.AddCourier(courier);
            cargoService2.AddCourier(courier1);
            cargoService2.AddCourier(courier2);
            cargoService2.AddCourier(courier3);

            ICargoServices.CargoService cargoService3 = new ICargoServices.CargoService();

            cargoService3.CreateCargoOrder(1, 2);


        }
    }
}
