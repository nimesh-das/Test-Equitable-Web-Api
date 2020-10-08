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
* Demo Video:
[Demo1]https://drive.google.com/file/d/1Rg68G-hlKKnx40qXLeik-JPUWnVI__k6/view?usp=sharing

* POST: api/product
* DELETE: api/product/n
* Demo Video:
[Demo2]https://drive.google.com/file/d/1RCXqZy_cn-gLRKyR6QgFd9LLaeN4oCff/view?usp=sharing

* PUT: api/product/n
[Demo3]https://drive.google.com/file/d/1rFvVNqzn-QNhaXkYf9pN6kEqzUlj0pJY/view?usp=sharing

All source code can be found in the folders here.
