<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Food_insecurity__ASPN.NET_.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">FoodCare South Africa</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentButtons" runat="server"></asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainHeader" runat="server"></asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<section class="hero hero-sa">
    <div class="hero-copy">
        <span class="eyebrow">South Africa Food security Community support</span>
        <h1>Helping South Africans find food support when they need it.</h1>
        <p>FoodCare is a South African platform for finding practical food-support information, discovering organisations and programmes, and giving assistance to people and communities facing food insecurity.</p>
        <div class="hero-actions">
            <asp:HyperLink ID="lnkHelp" runat="server" NavigateUrl="~/GetHelp.aspx" CssClass="btn-primary">Find food support</asp:HyperLink>
            <asp:HyperLink ID="lnkDonate" runat="server" NavigateUrl="~/Donate.aspx" CssClass="btn-outline">Offer help</asp:HyperLink>
        </div>
    </div>
    <div class="hero-panel">
        <span class="sa-badge">ZA</span>
        <h2>Built for the South African reality</h2>
        <p>Food insecurity is affected by household income, unemployment, food prices, inequality and access to services. FoodCare focuses on connecting people to support that exists in South Africa.</p>
        <div class="province-strip"><span>EC</span><span>FS</span><span>GP</span><span>KZN</span><span>LP</span><span>MP</span><span>NC</span><span>NW</span><span>WC</span></div>
    </div>
</section>

<section class="sa-stats">
    <div class="stat-highlight"><strong>19.7%</strong><span>South African households experienced moderate to severe food insecurity in 2023.</span></div>
    <div class="stat-highlight"><strong>8.0%</strong><span>Experienced severe food insecurity in 2023.</span></div>
    <div class="stat-highlight"><strong>9</strong><span>Provinces covered by South Africa's national support landscape.</span></div>
</section>

<section class="content-section">
    <div class="section-heading"><span class="eyebrow">Why this matters in South Africa</span><h2>Food can be available while people still struggle to afford or reach it.</h2></div>
    <p class="lead">South Africa's food-security challenge is closely connected to affordability and access. Household income, unemployment, inequality, living costs and distance from services can all influence whether a household can consistently obtain nutritious food.</p>
    <div class="cause-grid">
        <div><h3>Affordability</h3><p>When household income is stretched, food becomes one of many competing needs such as transport, electricity, rent and school expenses.</p></div>
        <div><h3>Unemployment</h3><p>Employment and household income play an important role in the ability to obtain food consistently.</p></div>
        <div><h3>Access</h3><p>People may live far from food-support organisations, public services or affordable sources of nutritious food.</p></div>
        <div><h3>Community response</h3><p>Food banks, community organisations, social support and food-rescue initiatives can help close the gap between available food and people who need it.</p></div>
    </div>
</section>

<section class="content-section soft-section">
    <div class="section-heading"><span class="eyebrow">What you can do</span><h2>FoodCare connects two sides of the problem.</h2></div>
    <div class="intro-grid compact-grid">
        <article class="feature-card accent-green"><span class="feature-icon">01</span><h2>Need support?</h2><p>Start with South African government and community resources, then look for food banks, community kitchens and local organisations in your area.</p><a class="text-link" href="GetHelp.aspx">Find support</a></article>
        <article class="feature-card accent-gold"><span class="feature-icon">02</span><h2>Want to help?</h2><p>Offer food or useful items through FoodCare so your contribution can be recorded and followed up.</p><a class="text-link" href="Donate.aspx">Offer a donation</a></article>
        <article class="feature-card accent-blue"><span class="feature-icon">03</span><h2>Want to understand?</h2><p>Learn about South African food-security data, social assistance and organisations working to reduce hunger.</p><a class="text-link" href="Resources.aspx">Explore resources</a></article>
    </div>
</section>

<section class="cta-banner">
    <div><span class="eyebrow">South Africa</span><h2>Support should be easier to find.</h2><p>FoodCare is designed around the South African support landscape and the people who need to navigate it.</p></div>
    <asp:HyperLink ID="lnkAbout" runat="server" NavigateUrl="~/About.aspx" CssClass="btn-light">Learn about the project</asp:HyperLink>
</section>
</asp:Content>
