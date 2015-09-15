<Query Kind="Expression">
  <Connection>
    <ID>04e89b43-32ff-4480-b84b-b80d1f0734b9</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

// Anonymous Types 1.linq
from food in Items
where food.MenuCategory.Description == "Entree" && food.Active
orderby food.CurrentPrice descending
select new
{
	Description = food.Description,
	Price = food.CurrentPrice,
	Calories = food.Calories
}