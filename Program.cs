using Lodging_System.Models;

var guests = new List<Person>();

Person p1 = new Person("John", "Doe");
Person p2 = new Person("Jane", "Doe");

guests.Add(p1);
guests.Add(p2);

//Create a Suite
Suite suite = new Suite("Premium", 3, 30);

//Create a Reservation
Reservation reservation = new Reservation(10);

reservation.SignUpSuite(suite);
reservation.SignUpGuests(guests);

Console.WriteLine($"Guests: {reservation.GetGuestCount()}");
Console.WriteLine($"Daily Rate: {reservation.CalculateDailyRate()}");