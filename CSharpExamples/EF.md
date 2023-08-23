ORM - Object Relational Mapper
Entity Framework - ORM
======================
Queries are written in LINQ or Entity SQL and then it is translated at runtime by the providers to the particular backend query syntax for that DB.<br/>
Lot of data access related code work is avoided since EF will do it<br/>
    &emsp;Open & Manage connection<br/>
    &emsp;Read Data<br/>
    &emsp;Command objects<br/>
EF is used in SQL, Oracle & DB2 , etc.<br/>
It basically generates the business objects & entities according to Tables and provides the mechanism for<br/>
    &emsp;Performing basic CRUD operations<br/>
    &emsp;Easy managing 1-1, 1-M & M-M relationship<br/>
    &emsp;Ability to have inheritance relationship between entities.<br/>

Data access logic is written in high level languages<br/>
    &emsp;EF<br/>
        &emsp;ADO.NET<br/>

Any change in the context objects will be updated in DB using SaveChanges().<br/>
EF provides services like change tracking, identity resolution, lazy loading, query translation. So that developer can focus on business logic.

https://www.c-sharpcorner.com/article/lazy-loading-and-eager-loading-in-linq-to-sql/#:~:text=What%20is%20Lazy%20Loading%3F,between%20Department%20and%20Employees%20entities.


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
Create models using edmx from an existing DB is called DB first.
EDM can be updated whenever the DB schema changes.

LINQ -.NET3.5
==============
Used to query different data sources like entities, sql 
LINQ can be written in either query syntax or method syntax.
The compiler translates LINQ statements written with query syntax into the equivalent method call syntax. 
Therefore, regardless of your syntax choice, the two versions of the query produce the same result. 
Choose which syntax works best for your situation: for instance, if you're working in a team where 
some of the members have difficulty with method syntax, try to prefer using query syntax.

Linq to entities operates on EF to access data from the underlying DB
LINQ method syntax
==================
using (var context = new StudentDBContext())
{
 var query =  context.Students.Where(s=>s.Name = 'bil');
 var student = query.FirstOrDefault<Student>();
}
    
LINQ Query
===========
Using(var context = new StudentDBContext())
{
 var query = st in context.Students
             where st.name = 'bil'
             select st;
 var student = query.FirstOrDefault<Student>();
}

LINQ query returns **IQueryable** object.
Why LINQ
========
    Less Coding
    Readable Code
    Standard way of querying multiple datasource
    Compile time safety of query - Type safety
    Intellisense support
    
Extension Methods:
=================
It allows you to add new methods to the existing types without creating new derived types or modifying existing types.
It is special kind of static methods.

public static <ReturnType> MethodName(this <ExtensionType> variableName) {
    }
    
 string name = "Louis Raj";
 name.LetterCount();
    
public static int LetterCount(this string text)
{
return text.trim().length;
}

LamdaExpressions:
=================
Lamda expressions are anonymous functions and mostly used to create delegates in LINQ.
List<int> numbers = new List<int> {11,37,52};
List<int> oddNumbers =  numbers.where(n=>n%2 == 1).ToList<>;
    n=>n%2==1    => Lamda Expressions
    
we can write local functions that can be passed as arg or returned as value.

IEnumerable<T> Vs IQueryable<T>:
===============================
    When you query the in memory collection using LINQ we can use the IEnumerable
    When query the remote database using LINQ  we can use IQueryable.
Deferred Execution:
===================
    the query variable itself only stores the query commands. 
    The actual execution of the query is deferred until you iterate over the query variable in a foreach statement. 
    This concept is referred to as deferred execution 

Immediate Execution:
====================

    Queries that perform aggregation functions over a range of source elements must first iterate over those elements. Examples of such queries are Count, Max, Average, and First.

'''List<int> numQuery2 =
    (from num in numbers
     where (num % 2) == 0
     select num).ToList();


Lambda Expressions:
===================

    A lambda expression is an inline function that uses the => operator to separate input parameters from the function body and can be converted at compile time to a delegate
