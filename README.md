# Microsoft Web Applications - Web Forms, Model-View-Controller (MVC), and Blazer Web Applications
The purpose of this repository is to incorporate database connections using the Bogus NuGet package to randomly generate data.

The data is outputted to a 10x10 grid utilizing buttons and forms.

The Web Forms utilizes the Session object to store data generated from Bogus - A memory expensive operation common to Web Form sites.

The MVC does not use session metadata to prevent generation of new randomized data, however it does redirect to a separate view making continuous generation difficult.

The Blazer Application generates all data in the client-side application, making it memory inexpensive for the network.

These programs succeed in all of the aforementioned goals.

# Running the Applications
Both the MVC and Blazer Applications will show in the "Startup Items" drop down in Visual Studio.

However the Web Forms will require the user to select the "Set as Startup Prject" on the WebApplication-WebForms tab.
