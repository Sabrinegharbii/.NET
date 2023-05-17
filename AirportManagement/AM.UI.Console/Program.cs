// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using AM.ApplicationCore.Domain;

//Plane plane = new Plane();
//plane.PlaneType = PlaneType.Airbus;
//plane.Capacity = 200;
//plane.ManufactureDate = new DateTime(2018, 11, 10);

//Plane plane2 = new Plane(PlaneType.Boing, 300, DateTime.Now);

Plane plane3 = new Plane 
{ PlaneType = PlaneType.Airbus,
    Capacity = 150, 
    ManufactureDate = new DateTime(2015, 02, 03) };

Passenger p = new Passenger();
//p.LastName= "test";
//p.PassengerType();

//Staff s = new Staff();
//s.PassengerType();

//Traveller t = new Traveller();
//t.PassengerType();

Plane plane1 = new Plane
{
    PlaneType = PlaneType.Airbus,
    Capacity = 150,
    ManufactureDate = new DateTime(2015, 02, 03)
};

Flight f1 = new Flight()
{
    Departure = "Tunis",
    Airline = "Tunisair",
    FlightDate = new DateTime(2022, 02, 01, 21, 10, 10),
    Destination = "Paris",
    EffectiveArrival = new DateTime(2022, 02, 01, 23, 10, 10),
    EstimatedDuration = 103,
    plane = plane1
};