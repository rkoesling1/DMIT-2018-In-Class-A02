<Query Kind="Program">
  <Connection>
    <ID>75c5804d-830b-4e35-8241-eb5a8f581adc</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

void Main()
{
	var data = from cat in MenuCategories
				orderby cat.Description
				select new CategoryDTO() // use the DTO
				{
					Description = cat.Description,
					MenuItems = from item in cat.Items
								where item.Active
								orderby item.Description
								select new MenuItemDTO // use the DTO
								{
									Description = item.Description,
									Price = item.CurrentPrice,
									Calories = item.Calories,
									Comment = item.Comment
								}
				};
	data.Dump();		
}

// Define other methods and classes here
public class CategoryDTO // Data-Transfer Object
{
	public string Description { get;set; }
	public IEnumerable<MenuItemDTO> MenuItems { get;set; } 
}
public class MenuItemDTO
{
	public string Description { get;set; }
	public decimal Price { get;set; }
	public int? Calories { get;set; }
	public string Comment { get;set; }
}