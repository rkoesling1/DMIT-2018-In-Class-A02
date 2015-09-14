<Query Kind="Expression">
  <Connection>
    <ID>31e9c7f3-5862-4096-ac79-e3d2cd5b35f7</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

from food in Items
orderby food.Description descending
select food