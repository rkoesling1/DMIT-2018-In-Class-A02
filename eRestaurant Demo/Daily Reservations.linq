<Query Kind="Expression">
  <Connection>
    <ID>75c5804d-830b-4e35-8241-eb5a8f581adc</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

from eachRow in Reservations
where eachRow.ReservationStatus == 'B' // use "B" in Visual Studio
		// TBA - && eachRow has the correct EventCode...
orderby eachRow.ReservationDate
// select eachRow
group eachRow by new { eachRow.ReservationDate.Month, eachRow.ReservationDate.Day }
into dailyReservation
select new // DailyReservation() // Create a DTO class called DailyReservation
{
	Month = dailyReservation.Key.Month,
	Day = dailyReservation.Key.Day,
	Reservations = from booking in dailyReservation
					select new // Booking() // Create a Booking POCO class
					{
						Name = booking.CustomerName,
						Time = booking.ReservationDate.TimeOfDay,
						NumberInParty = booking.NumberInParty,
						Phone = booking.ContactPhone,
						Event = booking.SpecialEvents.Description
					}
}