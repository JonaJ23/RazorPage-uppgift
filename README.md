# README om ASP.NET Core. 🖥️

ASP.NET Core är en fri programvara med öppen källkod som används för att skapa 
dynamiska webbsidor med bl.a. användning av cloud-lagring och Razor Pages.
Förrutom Windows så är ASP.NET Core även kompatibel med Linux och MacOS.

Razor-pages som används i ASP .NET Core består av en kombination av programspråk (C# och HTML), när appen körs omvandlas koden dock
till bara HTML. När vi skapar en Razor Page så får vi både en .cshtml-fil (content-page) och cshtml.cs-fil (page-model), dessa är sammanlänkade 
genom att content-page avgör vilken model som används, ett exempel är: "@model IndexModel" nästan längst upp i cshtml-filen som är 
tillhörande en page-model för Index. Notera att '@'-tecknet används för att skriva C# kod i HTML kod.
Sammanfattat är content-page sidan som använder HTML-språk medans page-model består av C# kod som används för att skapa 
properties för att sedan kommas åt i content-page.

En MVC applikation styrs av tre olika delar: Model, View och Controller.
Alla tre fungerar i en slags cirkulation.

1. Model är ansvarig för applikationens tillstånd och meddelar
   data som uppdaterats till View.

2. View hämtar data från Model och uppdaterar sig själv
   för användaren att se.

3. Controller får meddelande från View att hantera
   en ny händelse och kan sedan uppdatera Model.
