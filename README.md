# SqlClientAspNetMvcSample

To get started Create the Northwind DB using the sql query from [SqlClient](https://github.com/dotnet/SqlClient) repo.

Add the [NorthwindDB](https://github.com/dotnet/SqlClient/blob/main/tools/testsql/createNorthwindDb.sql) to your SQL Server to run and update your connection string.

Publish the WebAppFxMvc into your IIS Server as a website and configure it with a new account that matches your application pool name by updateing the login.sql to create the user and add it to the Northwind db as a db_owner.
