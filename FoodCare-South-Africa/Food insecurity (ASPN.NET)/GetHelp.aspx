<%@ Page Title="Find Food Support" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GetHelp.aspx.cs" Inherits="Food_insecurity__ASPN.NET_.GetHelp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">Find Food Support</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentButtons" runat="server"></asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainHeader" runat="server"></asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="help-page">
    <section class="hero-copy"><span class="eyebrow">South Africa Find support</span><h1>Where can I find food assistance?</h1><p class="lead">Start with official social-support information, then look for food banks and community organisations serving your area. FoodCare provides starting points; always confirm current eligibility, opening times and availability with the organisation itself.</p></section>
    <div class="resource-grid">
        <article class="resource-card resource-card-featured"><span class="card-kicker">Government</span><h3>SASSA social assistance</h3><p>SASSA administers social grants for eligible people in South Africa. Its official service portal provides grant information, application guidance and FAQs.</p><a href="https://services.sassa.gov.za/portal/r/sassa/sassa/home" target="_blank" rel="noopener">Open SASSA services</a></article>
        <article class="resource-card resource-card-featured"><span class="card-kicker">Food support</span><h3>FoodForward SA</h3><p>FoodForward SA recovers quality surplus food and redistributes it through a national network of vetted beneficiary organisations across all nine provinces.</p><a href="https://www.foodforwardsa.org/" target="_blank" rel="noopener">Find out about FoodForward SA</a></article>
        <article class="resource-card resource-card-featured"><span class="card-kicker">Public services</span><h3>Department of Social Development</h3><p>The national Department of Social Development coordinates social-development and social-protection work and provides information about services and programmes.</p><a href="https://www.dsd.gov.za/" target="_blank" rel="noopener">Visit Social Development</a></article>
    </div>

    <section class="content-section inner-section">
        <div class="section-heading"><span class="eyebrow">Choose your province</span><h2>Start local.</h2><p class="lead">Food-support availability is local. Use your province as the first filter when looking for organisations, programmes or public services.</p></div>
        <div class="province-grid">
            <div><strong>Eastern Cape</strong><span>EC</span></div><div><strong>Free State</strong><span>FS</span></div><div><strong>Gauteng</strong><span>GP</span></div><div><strong>KwaZulu-Natal</strong><span>KZN</span></div><div><strong>Limpopo</strong><span>LP</span></div><div><strong>Mpumalanga</strong><span>MP</span></div><div><strong>Northern Cape</strong><span>NC</span></div><div><strong>North West</strong><span>NW</span></div><div><strong>Western Cape</strong><span>WC</span></div>
        </div>
    </section>

    <div class="resource-grid">
        <article class="resource-card"><h3>Need food immediately?</h3><p>Contact a local food bank, community kitchen, shelter, community organisation or other established support service. If there is an immediate medical or safety emergency, use the appropriate South African emergency service.</p></article>
        <article class="resource-card"><h3>Need longer-term support?</h3><p>Check SASSA and Department of Social Development information and ask local organisations about food support, social assistance and other services for your household.</p></article>
        <article class="resource-card"><h3>Want to help?</h3><p>If you have food or useful items to contribute, you can submit an offer through FoodCare.</p><a href="Donate.aspx">Offer help</a></article>
    </div>
</div>
</asp:Content>
