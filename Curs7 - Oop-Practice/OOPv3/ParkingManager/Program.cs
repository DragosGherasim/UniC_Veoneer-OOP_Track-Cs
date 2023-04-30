namespace ParkingManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var vehicle1 = VehicleFactory.CreateVehicle(VehicleType.Car, "BC 13 DGR", "black", 2013, "VW");
            var vehicle2 = VehicleFactory.CreateVehicle(VehicleType.Car, "BC 20 DDD", "red", 2020, "BMW");
            var vehicle3 = VehicleFactory.CreateVehicle(VehicleType.Bus, "BC 12 DGD", "yellow", 1990, "VW");
            var vehicle4 = VehicleFactory.CreateVehicle(VehicleType.Motorcycle, "BC 60 WYW", "black", 2000, "Honda");
            var vehicle5 = VehicleFactory.CreateVehicle(VehicleType.Motorcycle, "BC 30 WYW", "black", 1999, "Suzuki");
            var vehicle6 = VehicleFactory.CreateVehicle(VehicleType.Car, "BC 66 RRR", "white", 2000, "Dacia");
            var vehicle7 = VehicleFactory.CreateVehicle(VehicleType.Bus, "BC 13 DGD", "yellow", 1990, "VW");
            var vehicle8 = VehicleFactory.CreateVehicle(VehicleType.Car, "BC 12 DGR", "black", 2013, "VW");

            var areaParking1 = new YellowParking(new List<Vehicle>(), "YellowParking");
            var areaParking2 = new RedParking(new List<Vehicle>(), "RedParking");
            var areaParking3 = new BlueParking(new List<Vehicle>(), "BlueParking");

            ParkingManager parkingManager_A = new("Dragos");
            ParkingYard parkingYard_A = new(new List<ParkingArea>() { areaParking1, areaParking2, areaParking3 }, parkingManager_A);

            vehicle1.Park(parkingYard_A.GetMostAvailableParkingArea(VehicleType.Car));
            vehicle2.Park(parkingYard_A.GetMostAvailableParkingArea(VehicleType.Car));
            vehicle3.Park(parkingYard_A.GetMostAvailableParkingArea(VehicleType.Bus));
            vehicle4.Park(parkingYard_A.GetMostAvailableParkingArea(VehicleType.Motorcycle));
            vehicle5.Park(parkingYard_A.GetMostAvailableParkingArea(VehicleType.Motorcycle));
            vehicle6.Park(parkingYard_A.GetMostAvailableParkingArea(VehicleType.Car));
            vehicle7.Park(parkingYard_A.GetMostAvailableParkingArea(VehicleType.Bus));
            vehicle8.Park(parkingYard_A.GetMostAvailableParkingArea(VehicleType.Car));

            Console.WriteLine();

            vehicle2.LeavingPark(parkingYard_A);

            Console.WriteLine();

            parkingYard_A.DisplayVehicleTypeFromParkingArea(areaParking1, VehicleType.Car);
            Console.WriteLine();
            parkingYard_A.DisplayVehicleTypeFromParkingArea(areaParking2, VehicleType.Bus);
            Console.WriteLine();
            parkingYard_A.DisplayVehicleTypeFromParkingArea(areaParking3, VehicleType.Motorcycle);
            Console.WriteLine();

            parkingYard_A.DisplayEmptySlotsReportFromParkingArea(areaParking1);
            Console.WriteLine();
            parkingYard_A.DisplayEmptySlotsReportFromParkingArea(areaParking2);
            Console.WriteLine();
            parkingYard_A.DisplayEmptySlotsReportFromParkingArea(areaParking3);
        }
    }
}