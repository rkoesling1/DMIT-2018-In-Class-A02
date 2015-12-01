<Query Kind="Expression">
  <Connection>
    <ID>75c5804d-830b-4e35-8241-eb5a8f581adc</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

// Select the bill items for a specific bill (in this case, the unpaid bill)
from data in Bills
where data.BillID == 10975 // This would be billId that they asked for
select new // Order()
{
	BillID = data.BillID,
	Items = (from info in data.BillItems
			select new // OrderItem()
			{
				ItemName= info.Item.Description,
				Price = info.SalePrice,
				Quantity = info.Quantity
			}).ToList()
}