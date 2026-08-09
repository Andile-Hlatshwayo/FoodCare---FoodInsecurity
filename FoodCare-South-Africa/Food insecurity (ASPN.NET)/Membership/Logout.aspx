<%@ Page Title="Log out" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Logout.aspx.cs" Inherits="Food_insecurity__ASPN.NET_.Membership.Logout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">Log out</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentButtons" runat="server"></asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainHeader" runat="server"></asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"><div class="login-box"><div class="form-card"><span class="eyebrow">Session</span><h1>Ready to leave?</h1><asp:Label ID="lblOutput" runat="server" CssClass="lead" /><div class="form-actions"><asp:Button ID="btnLogOut" CssClass="submit-btn" runat="server" Text="Log out" OnClick="btnLogOut_Click" /></div></div></div></asp:Content>
