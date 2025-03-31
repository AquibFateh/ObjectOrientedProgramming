namespace ObjectOrientedProgramming.Inheritance
{
    /// <summary>
    /// Base class representing a Vehicle.
    /// </summary>
    public class Vehicle
    {
        /// <summary>
        /// Brand.
        /// </summary>
        public string Brand { get; set; } = string.Empty;

        /// <summary>
        /// Model.
        /// </summary>
        public string Model { get; set; } = string.Empty;

        /// <summary>
        /// Year.
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// To start a vehicle.
        /// </summary>
        public void Start()
        {
            Console.WriteLine($"{Model} is starting, which was released in {Year} and the brand is {Brand}");
        }

        /// <summary>
        /// To stop a vehicle.
        /// </summary>
        public void Stop()
        {
            Console.WriteLine($"{Model} is stopping.");
        }
    }
}
