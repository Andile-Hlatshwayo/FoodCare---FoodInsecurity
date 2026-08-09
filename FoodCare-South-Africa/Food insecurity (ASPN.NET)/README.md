# FoodCare South Africa

FoodCare is an ASP.NET Web Forms application using Microsoft Access. This build is intentionally focused on the South African food-insecurity context.

## South African focus

The interface and content use:
- South African provinces and province abbreviations
- South African social-support institutions such as SASSA and the Department of Social Development
- South African food-support organisations such as FoodForward SA
- South African food-security statistics from Statistics South Africa
- South African phone/address examples and terminology
- Rands where monetary examples are appropriate

## Existing database

The application keeps the existing Access database in `App_Data/Insecurity database.accdb` and uses the existing `Users` and `CustomerDonation` tables.

## Main pages

- Home.aspx — South African landing page and food-security context
- GetHelp.aspx — South African food-support starting points
- Donate.aspx — offer food or useful items
- Resources.aspx — official South African resources
- About.aspx — project purpose and local context
- Login.aspx / Signup.aspx — account access
- Dashboard.aspx — signed-in user dashboard
- Admin_Folder/Donations.aspx — donation administration

## Runtime

Open the `.sln` in Visual Studio on Windows with ASP.NET Web Forms / .NET Framework 4.8 support. Microsoft Access Database Engine (ACE OLE DB) is required for the Access connection.

The connection string uses `|DataDirectory|`, so the Access file is expected at `App_Data/Insecurity database.accdb` and is no longer tied to a specific developer computer path.
