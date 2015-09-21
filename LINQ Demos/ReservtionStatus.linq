<Query Kind="Expression">
  <Connection>
    <ID>82491220-8534-4c78-bcdd-200f3e40d136</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

from status in Reservations
where status.ReservationDate.Year == 2014
	&& status.ReservationDate.Month == 9
	&& status.ReservationDate.Day == 19
	&& status.ReservationStatus == 'C'
select status