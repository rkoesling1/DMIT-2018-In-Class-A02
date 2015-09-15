<Query Kind="Expression">
  <Connection>
    <ID>04e89b43-32ff-4480-b84b-b80d1f0734b9</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

// List all the menu items that are Entrees or Beverages 
// in order from most to least expensive
from food in Items

where food.MenuCategory.Description == "Entree"
	|| food.MenuCategory.Description == "Beverage"
	
orderby food.CurrentPrice descending

group food by food.MenuCategoryID into result

select result