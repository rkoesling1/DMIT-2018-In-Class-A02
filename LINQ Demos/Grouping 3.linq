<Query Kind="Expression">
  <Connection>
    <ID>04e89b43-32ff-4480-b84b-b80d1f0734b9</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

from food in Items
group food by food.MenuCategoryID into result
select result