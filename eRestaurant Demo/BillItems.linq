<Query Kind="Expression">
  <Connection>
    <ID>75c5804d-830b-4e35-8241-eb5a8f581adc</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

// What bills are not yet paid?
from data in Bills
where !data.PaidStatus
	&& data.BillItems.Count() > 0
select new //UnpaidBill()
{
	DisplayText = "Bill " + data.BillID.ToString(),
	KeyValue = data.BillID,
	TotalAmount = data.BillItems.Sum(bi=>bi.SalePrice * bi.Quantity),
	Table = data.Table,
	Reservation = data.Reservation
}