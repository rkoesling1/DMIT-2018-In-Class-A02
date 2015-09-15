<Query Kind="Expression" />

// List all the menu items that are Entrees 
// in order from most to least expensive
from food in Items
where food.MenuCategory.Description == "Entree"
orderby food.CurrentPrice descending
select food