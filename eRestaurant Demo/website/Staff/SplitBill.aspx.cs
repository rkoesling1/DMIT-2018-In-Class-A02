using eRestaurant.Framework.BLL;
using eRestaurant.Framework.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Staff_SplitBill : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void SelectBill_Click(object sender, EventArgs e)
    {
        GetBill();
    }
    private void GetBill()
    {
        var controller = new WaiterController();
        var data = controller.GetBill(int.Parse(ActiveBills.SelectedValue));
        BillToSplit.Value = data.BillID.ToString();

        // Set the original bill items
        OriginalBillItems.DataSource = data.Items;
        OriginalBillItems.DataBind();

        // empty out othrer bill
        NewBillItems.DataSource = null;
        NewBillItems.DataBind();
    }

    protected void BillItems_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        e.Cancel = true; // to prevent any other processing in the GridView's default Select handling

        GridView sendingGridView = sender as GridView; // notice the safe casting
        GridViewRow row = sendingGridView.Rows[e.NewSelectedIndex];

        // 1) get the info from the row
        var qtyLabel = row.FindControl("Quantity") as Label;
        //               <asp:Label ID="Quantity" ..... />
        var nameLabel = row.FindControl("ItemName") as Label;
        var priceLabel = row.FindControl("Price") as Label;
        OrderItem itemToMove = new OrderItem()
        {
            ItemName = nameLabel.Text,
            Quantity = int.Parse(qtyLabel.Text),
            Price = decimal.Parse(priceLabel.Text)
        };
        // temp output
        MessageLabel.Text = "I want to move " + qtyLabel.Text + " " + nameLabel.Text + " items onto the other bill (GridView) $" + priceLabel.Text + " each";

        // 2) move it to the other gridview
        GridView targetGridVeiw;
        if (sender == OriginalBillItems)
            targetGridVeiw = OriginalBillItems;
        else
            targetGridVeiw = NewBillItems;

        List<OrderItem> targetItems = new List<OrderItem>();
        foreach(GridViewRow targetRow in targetGridVeiw.Rows)
        {
            qtyLabel = targetRow.FindControl("") as Label;
            nameLabel = targetRow.FindControl("") as Label;
            priceLabel = targetRow.FindControl("") as Label;
            targetItems.Add(new OrderItem()
            {
                ItemName = nameLabel.Text,
                Quantity = int.Parse(qtyLabel.Text),
                Price = decimal.Parse(priceLabel.Text)
            });
        }
        targetItems.Add(itemToMove);
        targetGridVeiw.DataSource = targetItems;
        targetGridVeiw.DataBind();
        

        // 3) take the row out of this list
        List<OrderItem> senderItems = new List<OrderItem>();
        for(int index = 0; index < sendingGridView.Rows.Count; index++)
        {
           if(index != e.NewSelectedIndex)
            {
                GridViewRow senderRow = sendingGridView.Rows[index];
                qtyLabel = senderRow.FindControl("") as Label;
                nameLabel = senderRow.FindControl("") as Label;
                priceLabel = senderRow.FindControl("") as Label;
                senderItems.Add(new OrderItem()
                {
                    ItemName = nameLabel.Text,
                    Quantity = int.Parse(qtyLabel.Text),
                    Price = decimal.Parse(priceLabel.Text)
                });
            }
        }
        sendingGridView.DataSource = senderItems;
        sendingGridView.DataBind();

        // 4) happy dance
    }

    protected void SplitBill_Click(object sender, EventArgs e)
    {
        // Get the original bill items
        List<OrderItem> originalItems = new List<OrderItem>();
        foreach(GridViewRow row in OriginalBillItems.Rows)
        {
            var qtyLabel = row.FindControl("Quantity") as Label;
            var nameLabel = row.FindControl("Name") as Label;
            var priceLabel = row.FindControl("Price") as Label;
            originalItems.Add(new OrderItem()
                {
                    ItemName = nameLabel.Text,
                    Quantity = int.Parse(qtyLabel.Text),
                    Price = decimal.Parse(priceLabel.Text)
                });
        }

        // Get the new bill items
        List<OrderItem> newBillItems = new List<OrderItem>();
        foreach (GridViewRow row in NewBillItems.Rows)
        {
            var qtyLabel = row.FindControl("Quantity") as Label;
            var nameLabel = row.FindControl("Name") as Label;
            var priceLabel = row.FindControl("Price") as Label;
            newBillItems.Add(new OrderItem()
            {
                ItemName = nameLabel.Text,
                Quantity = int.Parse(qtyLabel.Text),
                Price = decimal.Parse(priceLabel.Text)
            });
        }

        // Call the BLL to split the bill
        int billid = int.Parse(BillToSplit.Value); // from our HiddenField

        WaiterController controller = new WaiterController();
        controller.SplitBill(billid, originalItems, newBillItems);
    }
}