<Query Kind="Expression">
  <Connection>
    <ID>82491220-8534-4c78-bcdd-200f3e40d136</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

from info in Bills
where info.BillDate.Year == 2014
	&& info.BillDate.Month == 5
	&& info.BillDate.Day == 25 // == new DateTime(2014, 5, 25)
select info