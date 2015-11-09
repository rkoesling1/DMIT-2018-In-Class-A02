<Query Kind="Statements">
  <Connection>
<<<<<<< HEAD
    <ID>82491220-8534-4c78-bcdd-200f3e40d136</ID>
=======
    <ID>75c5804d-830b-4e35-8241-eb5a8f581adc</ID>
>>>>>>> origin/master
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

var step1 = from eachRow in Reservations
where eachRow.ReservationStatus == 'B' // use "B" in Visual Studio
		// TBA - && eachRow has the correct EventCode...
orderby eachRow.ReservationDate
<<<<<<< HEAD
//select eachRow
=======
// select eachRow
>>>>>>> origin/master
group eachRow by new { eachRow.ReservationDate.Month, eachRow.ReservationDate.Day };
// into dailyReservation
var result = from dailyReservation in step1.ToList()
select new // DailyReservation() // Create a DTO class called DailyReservation
{
	Month = dailyReservation.Key.Month,
	Day = dailyReservation.Key.Day,
<<<<<<< HEAD
	Reservations = 	from booking in dailyReservation
				   	select new // Booking() // Create a Booking POCO class
=======
	Reservations = from booking in dailyReservation
					select new // Booking() // Create a Booking POCO class
>>>>>>> origin/master
					{
						Name = booking.CustomerName,
						Time = booking.ReservationDate.TimeOfDay,
						NumberInParty = booking.NumberInParty,
						Phone = booking.ContactPhone,
						Event = booking.SpecialEvents == null
<<<<<<< HEAD
						      ? (string)null
							  : booking.SpecialEvents.Description
=======
								? (string)null
								: booking.SpecialEvents.Description
>>>>>>> origin/master
					}
};
result.Dump();