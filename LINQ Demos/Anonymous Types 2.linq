<Query Kind="Expression">
  <Connection>
    <ID>04e89b43-32ff-4480-b84b-b80d1f0734b9</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

// Anonymous Types 2.linq
from person in Waiters
where person.ReleaseDate == null  // People still employed
select new
{
	Name = person.FirstName + " " + person.LastName,
	Phone = person.Phone,
	DaysEmployed = (DateTime.Today - person.HireDate).Days
}