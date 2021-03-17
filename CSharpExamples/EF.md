ORM - Object Relational Mapper
Entity Framework - ORM
======================
Queries are written in LINQ or Entity SQL and then it is translated at runtime by the providers to the particular backend query syntax for that DB.
Lot of data access related code work is avoided since EF will do it
    Open & Manage connection
    Read Data
    Command objects
EF is used in SQL, Oracle & DB2 , etc.
It basically generates the business objects & entities according to Tables and provides the mechanism for
    Performing basic CRUD operations
    Easy managing 1-1, 1-M & M-M relationship
    Ability to have inheritance relationship between entities.

Data access logic is written in high level languages
    EF
        ADO.NET

Any change in the context objects will be updated in DB using SaveChanges().
EF provides services like change tracking, identity resolution, lazy loading, query translation. So that developer can focus on business logic.


Developement Approaches:
========================

Code First
----------
Avoid working with visual model designer *.edmx
Create domain class & context classes.
Configure the domain classes for additional mapping
F5, Code first APIs creates new DB or map the existing DB with domain classes

Model First
-----------
Create entities, relationshipes & inheritance relationships directly on the design surface of EDMX
Then generate DB from the model.

Database First
---------------