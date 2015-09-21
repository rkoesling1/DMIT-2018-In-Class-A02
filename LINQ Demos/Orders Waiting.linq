<Query Kind="Expression">
  <Connection>
    <ID>82491220-8534-4c78-bcdd-200f3e40d136</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

from served in Bills
where served.OrderServed == null
orderby served.Table.TableID descending
select served