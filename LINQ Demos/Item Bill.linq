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
where info.OrderReady == null
// group info by info.BillID into new
select new {
	Item = info.BillItems.ItemID
}
