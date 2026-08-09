<%@ Page Title="Donation management" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Donations.aspx.cs" Inherits="Food_insecurity__ASPN.NET_.Admin_Folder.History" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">Donation management</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentButtons" runat="server"></asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainHeader" runat="server"></asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="admin-page"><span class="eyebrow">Administrator</span><h1>Donation offers</h1><p class="lead">Review donation offers submitted through the platform.</p><div class="form-actions"><asp:TextBox ID="txtSearch" runat="server" CssClass="input" Width="320px" placeholder="Search by name or email" /><asp:Button ID="btnSearch" runat="server" CssClass="submit-btn" Text="Search" OnClick="btnSearch_Click" /><asp:Button ID="btnAll" runat="server" CssClass="secondary-btn" Text="Show all" CausesValidation="False" OnClick="btnAll_Click" /></div><div style="margin-top:25px;overflow:auto">
    <asp:GridView ID="gridViewDonation"
    runat="server"
    CssClass="data-table"
    AutoGenerateColumns="False"
    EmptyDataText="No donation offers found."
    GridLines="None">

    <Columns>

        <asp:BoundField
            DataField="Name"
            HeaderText="Name" />

        <asp:BoundField
            DataField="Surname"
            HeaderText="Surname" />

        <asp:BoundField
            DataField="Phone Number"
            HeaderText="Phone" />

        <asp:BoundField
            DataField="Email address"
            HeaderText="Email" />

        <asp:BoundField
            DataField="Address"
            HeaderText="Address" />

        <asp:BoundField
            DataField="Items"
            HeaderText="Items" />

        <asp:BoundField
            DataField="Comment"
            HeaderText="Comment" />

        <asp:BoundField
            DataField="Delivery method"
            HeaderText="Delivery Method" />

        <asp:BoundField
            DataField="Date and time"
            HeaderText="Date" />

        <asp:TemplateField HeaderText="Image">
            <ItemTemplate>

                <asp:Image
                    ID="imgDonation"
                    runat="server"
                    CssClass="donation-image"
                    ImageUrl='<%# GetImageUrl(Eval("DonationImage")) %>'
                    AlternateText="Donation image" />

            </ItemTemplate>
        </asp:TemplateField>

    </Columns>

</asp:GridView></div></div>
</asp:Content>
