<Query Kind="Expression">
  <Connection>
    <ID>31e9c7f3-5862-4096-ac79-e3d2cd5b35f7</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

// booking is a variable name that I make up
from booking in Reservations
where booking.EventCode.Equals("A")
select booking