# Test-Equitable-Web-Api
A REST Web Api for Equitable Life's Core Products

Equitable Life has 3 core products- Individual Insurance, Savings and Retirement and Group Benefits here that can be found online on their website:
https://www.equitable.ca/

This particular Web API, created in ASP.NET and Entity.Framework will allow one to reach any of the endpoints that fall under
the above categories. The backend code was written in C#, the values were stored in a local MS Sql Server hosted in Docker 
and I used Visual Studio Code as my editor to deploy everything to the local Kestrel Server.

The following operations are supported:
* GET: api/product
* GET: api/product/{id}
* POST: api/product
* PUT: api/product/n
* DELETE: api/product/n

All source code can be found in the folders here.
