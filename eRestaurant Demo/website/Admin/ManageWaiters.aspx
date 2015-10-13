<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ManageWaiters.aspx.cs" Inherits="Admin_ManageWaiters" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="row col-md-12">
        <h1>Manage Waiters
            <span class="glyphicon glyphicon-glass"></span>
        </h1>
    
        <!-- ObjectDataSource control to do the underlying communication with my BLL and my ListView control -->
        <asp:ObjectDataSource ID="WaitersDataSource" runat="server"
            TypeName="eRestaurant.Framework.BLL.RestaurantAdminController"
            SelectMethod="ListAllWaiters"
            DataObjectTypeName="eRestaurant.Framework.Entities.Waiter" OldValuesParameterFormatString="original_{0}" 
              UpdateMethod="UpdateWaiter"
              DeleteMethod="DeleteWaiter"
              InsertMethod="AddWaiter" OnDeleted="ProcessExceptions" OnInserted="ProcessExceptions" OnUpdated="ProcessExceptions" >
        </asp:ObjectDataSource>
        <asp:Label ID="MessageLabel" runat="server" />
       <%-- <asp:GridView ID="SpecialEventsGridView" runat="server"
            DataSourceID="SpecialEventsDataSource"></asp:GridView>--%>
        <asp:ListView ID="WaitersListView" runat="server"
            DataSourceID="WaitersDataSource"
            DataKeyNames="WaiterID" InsertItemPosition="LastItem">
            <LayoutTemplate>
                <fieldset runat="server" id="itemPlaceholderContainer">
                    <div runat="server" id="itemPlaceholder" />
                </fieldset>
            </LayoutTemplate>

            <ItemTemplate>
                <div>
                    <asp:LinkButton runat="server" CommandName="Edit"
                        ID="EditButton">
                        Edit 
                        <span class="glyphicon glyphicon-pencil"></span>
                    </asp:LinkButton>
                    &nbsp;&nbsp;
                    <asp:LinkButton runat="server" CommandName="Delete"
                        ID="DeleteButton">
                        Delete
                        <span class="glyphicon glyphicon-trash"></span>
                    </asp:LinkButton>
                    &nbsp;&nbsp;&nbsp;

                   <asp:Label ID="Label1" runat="server"
                        AssociatedControlID="WaiterIDData"
                        CssClass="control-label">Waiter ID</asp:Label>
                    <asp:Label ID="WaiterIDData" runat="server"
                        Text='<%# Eval("WaiterID") %>' />
                    &mdash;
                    <asp:Label ID="Label2" runat="server"
                        AssociatedControlID="FullNameData"
                        CssClass="control-label">Full Name</asp:Label>
                    <asp:Label ID="FullNameData" runat="server"
                        Text='<%# Eval("FullName") %>' />
                </div>
            </ItemTemplate>

            <EditItemTemplate>
                <div>
                    <asp:LinkButton runat="server" CommandName="Update"
                        Text="Update" ID="UpdateButton" />
                    &nbsp;&nbsp;
                    <asp:LinkButton runat="server" CommandName="Cancel"
                        Text="Cancel" ID="CancelButton" />
                    &nbsp;&nbsp;&nbsp;

                    Waiter ID:
                    <asp:TextBox runat="server" ID="WaiterIDTextBox"
                        Text='<%# Bind("WaiterID") %>'
                        Enabled="false" />

                    First Name:
                    <asp:TextBox runat="server" ID="FirstNameTextBox"
                        Text='<%# Bind("FirstName") %>' />

                    Last Name:
                    <asp:TextBox runat="server" ID="LastNameTextBox"
                        Text='<%# Bind("LastName") %>' />

                    Phone Number:
                    <asp:TextBox runat="server" ID="PhoneTextBox"
                        Text='<%# Bind("Phone") %>' />

                    Address:
                    <asp:TextBox runat="server" ID="AddressTextBox"
                        Text='<%# Bind("Address") %>' />
                </div>
            </EditItemTemplate>

            <InsertItemTemplate>
                <div>
                    <asp:LinkButton runat="server" ID="InsertButton" CommandName="Insert">
                        Insert <span class="glyphicon glyphicon-plus"></span>
                    </asp:LinkButton>
                    &nbsp;&nbsp;

                    <asp:LinkButton runat="server" ID="CancelButton" CommandName="Cancel">
                        Cancel <span class="glyphicon glyphcion-refresh"></span>
                    </asp:LinkButton>
                    &nbsp;&nbsp;&nbsp;

                    <asp:Label ID="Label3" runat="server" CssClass="control-label"
                        AssociatedControlID="WaiterIDTextBox">Waiter ID</asp:Label>
                    <asp:TextBox ID="WaiterIDTextBox" runat="server"
                        Text='<%# Bind("WaiterID") %>' />
                    &mdash;

                    <asp:Label ID="Lable4" runat="server" CssClass="control-label"
                        AssociatedControlLabel="FirstNameTextBox">First Name</asp:Label>
                    <asp:TextBox ID="FirstNameTextBox" runat="server"
                        Text='<%# Bind("FirstName") %>' />

                    <asp:Label ID="Label4" runat="server" CssClass="control-label"
                        AssociatedControlLabel="LastNameTextBox">Last Name</asp:Label>
                    <asp:TextBox ID="LastNameTextBox" runat="server"
                        Text='<%# Bind("LastName") %>' />

                    <asp:Label ID="Label5" runat="server" CssClass="control-label"
                        AssociatedControlLabel="PhoneTextBox">Phone Number</asp:Label>
                    <asp:TextBox ID="PhoneTextBox" runat="server"
                        Text='<%# Bind("Phone") %>' />

                    <asp:Label ID="Label6" runat="server" CssClass="control-label"
                        AssociatedControlLabel="AddressTextBox">Address</asp:Label>
                    <asp:TextBox ID="AddressTextBox" runat="server"
                        Text='<%# Bind("Address") %>' />

                    <asp:Label ID="Label7" runat="server" CssClass="control-label"
                        AssociatedControlLabel="HireDateTextBox">Hire Date</asp:Label>
                    <asp:TextBox ID="HireDateTextBox" runat="server"
                        Text='<%# Bind("HireDate") %>' />

                </div>
            </InsertItemTemplate>
        </asp:ListView>
    </div>
</asp:Content>

