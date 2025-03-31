namespace ObjectOrientedProgramming.Inheritance
{
    // Inheritance involves creating new classes (subclasses or derived classes) based on existing classes (superclasses or base classes).
    // 1. Subclasses inherit properties and behaviors from their superclasses and can also add new features or override existing ones.
    // 2. Inheritance is often described in terms of an "is-a" relationship.

    /// <summary>
    /// Subclass representing a car, inheriting from Vehicle.
    /// </summary>
    public class Car : Vehicle
    {
        /// <summary>
        /// Number of doors.
        /// </summary>
        public int NumberOfDoors { get; set; }

        /// <summary>
        /// Number of wheels.
        /// </summary>
        public int NumberOfWheels { get; set; }
    }
}
