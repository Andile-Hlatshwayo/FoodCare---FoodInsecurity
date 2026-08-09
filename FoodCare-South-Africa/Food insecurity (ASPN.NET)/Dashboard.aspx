<%@ Page Title="My Dashboard" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="Food_insecurity__ASPN.NET_.Dashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">My dashboard</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentButtons" runat="server"></asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainHeader" runat="server"></asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="dashboard-page"><span class="eyebrow">Your space</span><h1>Welcome, <asp:Label ID="lblName" runat="server" /></h1><p class="lead">Keep track of your donation activity and quickly access the platform.</p>
<div class="stats"><div class="stat"><span>Donation offers</span><strong><asp:Label ID="lblDonationCount" runat="server" Text="0" /></strong></div><div class="stat"><span>Account</span><strong>Active</strong></div><div class="stat"><span>Role</span><strong>Member</strong></div></div>
<div class="resource-grid"><article class="resource-card"><h3>Give help</h3><p>Record another donation offer.</p><a href="Donate.aspx">Donate →</a></article><article class="resource-card"><h3>Find help</h3><p>Explore practical starting points and global resources.</p><a href="GetHelp.aspx">Find resources →</a></article><article class="resource-card"><h3>Learn</h3><p>Understand food insecurity and the forces that contribute to it.</p><a href="About.aspx">Learn more →</a></article></div></div>
</asp:Content>
