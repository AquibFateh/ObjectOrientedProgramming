using ObjectOrientedProgramming.Abstraction;
using ObjectOrientedProgramming.Inheritance;

namespace ObjectOrientedProgramming
{
    /// <summary>
    /// Program class.
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            // Abstraction
            EmailService emailService = new EmailService();
            emailService.SendEmail();

            // Inheritance
            Car car = new Car();
            car.Brand = "Ford";
            car.Model = "Mustang Mach-E";
            car.Year = 2019;
            car.NumberOfWheels = 4;
            car.NumberOfDoors = 4;
            car.Start();
            car.Stop();
            Bike bike = new Bike();
            bike.Brand = "BMW";
            bike.Model = "BMW R18 Classic";
            bike.Year = 2025;
            bike.NumberOfWheels = 2;
            bike.Start();
            bike.Stop();

        }
    }
}
