<Query Kind="Expression">
  <Connection>
    <ID>75c5804d-830b-4e35-8241-eb5a8f581adc</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

from cat in MenuCategories
orderby cat.Description
select new
{
	Description = cat.Description,
	MenuItems = from item in cat.Items
				where item.Active
				orderby item.Description
				select new
				{
					Description = item.Description,
					Price = item.CurrentPrice,
					Calories = item.Calories,
					Comment = item.Comment
				}
}