# Bethselamin

My first attempt at a Blazor project.

It started life as a demo blazor server project which was modified to add functionality to the Counter page.
I then added a few pages with a few api calls to Meta Weather and XKCD.com.

It was then further modified to be used as a demo website for the Bethselamin Blockchain Legder project
and had the Counter page modified to display pretend 'blockchain' generator for the demonstration project.

It has since been modified to add very a simple 'To Do' functionality as a test for another project.

All of the functionality comes from demos on MudBlazor's site, IamTimCorey on YouTube and some of my own experimentation.

I am using this process to learn c#, Blazor and Git/Github. I have also used code analyzers to help finding errors/bad practice etc.

The folder structure of this repository is modelled after the Blazor Server Demo App supplied by Microsoft in Visaul Studio Community 2019.

This project contains all the source files but NOT the Visaual Studio projcet file.

_Imports.razor holds all the necessary folder and packages and allows them to be accessed from anywhere in the project

App.razor contains the default info the app needs to route page requests to the main app layout

appsettings.json and appsettings.Development.json comtains information such as the api addresses and Databse credentials if used

Bethselamin.csproj contains a list of the packages used, included folders and content to exclude.

Program.cs is basically the app's boot disk which loads the Startup file

Startup.cs contains all the services and routing to allow the server and app to do their jobs.
