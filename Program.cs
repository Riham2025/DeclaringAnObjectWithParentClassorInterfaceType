 namespace DeclaringAnObjectWithParentClassorInterfaceType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of vehicles using the interface type
            List<IVehicle> vehicles = new List<IVehicle>
        {
            new Car(),
            new Motorcycle()
        };
        }
    }
}
