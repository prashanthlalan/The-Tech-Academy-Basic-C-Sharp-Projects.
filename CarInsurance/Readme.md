# __Car Insurance Quote Generator - ASP.NET MVC Web Application__

## __IMPLEMENTS: ASP.NET, Model-View-Controller Desgin Pattern, DB-First Entity FW Implementation, Database Logging, Bootstrap__

Another ASP.NET web application, this generates a car insurance quote based on data provided by the user. The quote is calculated based of the users age, the age and make of the car, the number of speeding tickets, if they have ever a DUI and type of coverage. The business logic that calculates the quote is contained within the insuree controller, also generated quotes are logged to a SQL database through use of the entity framework, data validation is again presents to ensuree correctly generated quotes. An admin view is also implemented, this uses a Quotes view model and shows all generated quotes to an administrator, and the CSS makes use of a combination of Bootstrap and plain CSS.
