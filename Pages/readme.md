Readme file added.

This folder contains the Blazor pages used in the project.

As with any Blazor page, they are HTML with embedded C# methods and code.

_Host.cshtml is the basic HTML host page that provides a static backdrop to the other Blazor page components.
It has calls to apis, hosts the css and provides the browser with a valid HTML page to render.

Comic.razor is the Blazor page that calls to the XKCD api and using the returned infrmation displays the current XKCD comic.

Counter.razor is the basic "Counter" page that has been modified to create a fake 'blockchain' generator (using GUIDs) and to
display them in a table.

Error.cshtml is an error page that displays whenever the app has failed. There are tow versions of errors displayed depending
on whether you are serving on localhost or on a production server.

Error.cshtml.cs is an error logging C# page.

FetchData.razor is the default 'Weather Data' page that has been modified to show pretend 'blockchain' data for the Bethselamin
presentation.

Index.razor is analogous to the Index.html page of a standard website. It is our main landing page.

ToDo.razor is a page that adds some simple 'To Do' list functionality to the site as preparations for another project.

WeatherData.razoer is a page that uses MetaWaether's api to display genuine weather data for a city, chose at random from a list of five. 
