Asynchronous Programming:
=========================
If you have any I/O-bound needs (such as requesting data from a network, accessing a database, or reading and writing to a file system),
you'll want to utilize asynchronous programming.
You could also have CPU-bound code, such as performing an expensive calculation, which is also a good scenario for writing async code.

C# has a language-level asynchronous programming model, which allows for easily writing asynchronous code,
without having to juggle callbacks or conform to a library that supports asynchrony.
It follows what is known as the Task-based Asynchronous Pattern (TAP).

The core of async programming is the Task and Task<T> objects, which model asynchronous operations.
They are supported by the async and await keywords. The model is fairly simple in most cases:

For I/O-bound code, you await an operation that returns a Task or Task<T> inside of an async method.
For CPU-bound code, you await an operation that is started on a background thread with the Task.Run method.

The await keyword is where the magic happens.
It yields control to the caller of the method that performed await,
and it ultimately allows a UI to be responsive or a service to be elastic.
While there are ways to approach async code other than async and await, this article focuses on the language-level constructs.

I/O Bound example:
=================
private readonly HttpClient _httpClient = new HttpClient();

downloadButton.Clicked += async (o, e) =>
{
    // This line will yield control to the UI as the request
    // from the web service is happening.
    //
    // The UI thread is now free to perform other work.
    var stringData = await _httpClient.GetStringAsync(URL);
    DoSomethingWithData(stringData);
};

CPU Bound example:
==================
private DamageResult CalculateDamageDone()
{
    // Code omitted:
    //
    // Does an expensive calculation and returns
    // the result of that calculation.
}

calculateButton.Clicked += async (o, e) =>
{
    // This line will yield control to the UI while CalculateDamageDone()
    // performs its work. The UI thread is free to perform other work.
    var damageResult = await Task.Run(() => CalculateDamageDone());
    DisplayDamage(damageResult);
};

Recognize CPU-bound and I/O-bound work:
=======================================

Here are two questions you should ask before you write any code:

Will your code be "waiting" for something, such as data from a database?

    If your answer is "yes", then your work is I/O-bound.

Will your code be performing an expensive computation?

    If you answered "yes", then your work is CPU-bound.

If the work you have is I/O-bound, use async and await without Task.Run. You should not use the Task Parallel Library.

If the work you have is CPU-bound and you care about responsiveness, use async and await, but spawn off the work on another thread with Task.Run.
If the work is appropriate for concurrency and parallelism, also consider using the Task Parallel Library.
