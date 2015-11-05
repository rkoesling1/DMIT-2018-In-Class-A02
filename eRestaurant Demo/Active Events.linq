<Query Kind="Expression">
  <Connection>
    <ID>82491220-8534-4c78-bcdd-200f3e40d136</ID>
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