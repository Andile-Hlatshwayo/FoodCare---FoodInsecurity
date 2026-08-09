<%@ Page Title="Log in" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Food_insecurity__ASPN.NET_.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">Log in</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentButtons" runat="server"></asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainHeader" runat="server"></asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="getInForm login-box"><div class="form-card"><span class="eyebrow">Welcome back</span><h1>Log in</h1><p class="lead">Access your FoodCare account.</p>
<div class="field"><label for="txtName">Name and surname</label><asp:TextBox ID="txtName" runat="server" CssClass="input" MaxLength="100" /><asp:RequiredFieldValidator ID="RequiredFieldValidatorName" runat="server" CssClass="validation" ErrorMessage="Enter your name." ControlToValidate="txtName" /></div>
<div class="field" style="margin-top:16px"><label for="txtPassword">Password</label><asp:TextBox ID="txtPassword" runat="server" CssClass="input" TextMode="Password" /><asp:RequiredFieldValidator ID="RequiredFieldValidator1Password" runat="server" CssClass="validation" ErrorMessage="Enter your password." ControlToValidate="txtPassword" /></div>
<div class="form-actions"><asp:Button ID="btnLogIn" CssClass="submit-btn" runat="server" Text="Log in" OnClick="btnLogIn_Click" /><asp:Label ID="lblOutput" runat="server" CssClass="message" /></div>
</div></div>
</asp:Content>
