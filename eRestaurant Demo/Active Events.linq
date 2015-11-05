<Query Kind="Expression">
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

from eachRow in SpecialEvents
where eachRow.Active
select new // ActiveEvent()
{
	Code = eachRow.EventCode,
	Description = eachRow.Description
}