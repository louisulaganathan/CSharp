**Microsoft.AspNetCore.MVC**

ASPNETCore supports 2 approach for creating web apis using \n
	1.Controllers\n
	2.Minimal APIs\n
Controllers in an API project are classes that derive from ControllerBase. \n
Minimal APIs define endpoints with logical handlers in lambdas or methods. \n
Minimal API hides the host class and focus on the configuration and extensibility using extension methods which takes funtion as lambda expression.
Controller class takes the dependencies through constructor or property injection.\n
Minimal APIs handles dependencies by accessing the service provider.\n
Minimal API supports most of the features provide in controller based api except it does not support odata, jsonpatch, 
build in model binding & validation, view rendering, 
Minimal APIs are architected to create HTTP APIs with minimal dependencies.
They are ideal for microservices and apps that want to include only the minimum files, features, and dependencies in ASP.NET Core.

<code>
namespace APIWithControllers;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();
        var app = builder.Build();

        app.UseHttpsRedirection();

        app.MapControllers();

        app.Run();
    }
}

</code>

<code>
using Microsoft.AspNetCore.Mvc;

namespace APIWithControllers.Controllers;
[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
</code>

Minimal API:
============

<code>
namespace MinimalAPI;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        var app = builder.Build();

        app.UseHttpsRedirection();

        var summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        app.MapGet("/weatherforecast", (HttpContext httpContext) =>
        {
            var forecast = Enumerable.Range(1, 5).Select(index =>
                new WeatherForecast
                {
                    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                    TemperatureC = Random.Shared.Next(-20, 55),
                    Summary = summaries[Random.Shared.Next(summaries.Length)]
                })
                .ToArray();
            return forecast;
        });

        app.Run();
    }
}
</code>

Using Controllers : [Similar to our traditional MVC controller based API creation]\n
==================
&emsp;API controllers are derviced from ControllerBase rather from Controller.\n
&emsp;It has ControllerBase to support WebApi behavior.\n
&emsp;Controller class derived from ControllerBase in order to provide support for views\n
&emsp;If the same controller must support views and web APIs, derive from Controller.
[ApiController] attr can be applied to enable the feature like attr routing, auto 400 badrequest,binding source parameter inference 
[FromBody, From]etc.


Attribute can be applied on assemble level using which we can't opt-out for specific controller.
Apply the assembly-level attribute to the Program.cs file
<code>
using Microsoft.AspNetCore.Mvc;
[assembly: ApiController]

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
</code>
The following code is unnecessary with auto 400 response feature.
<code>
if (!ModelState.IsValid)
{
    return BadRequest(ModelState);
}
</code>


ASP.NET core state management:
==================================

Storage approach	|Storage mechanism
----------------------------------------
Cookies	| HTTP cookies.  May include data stored using server-side app code.
Session state	| HTTP cookies and server-side app code
TempData	| HTTP cookies or session state
Query strings	| HTTP query strings
Hidden fields	| HTTP form fields
HttpContext.Items	| Server-side app code
Cache	| Server-side app code

exceptionhand->hsts prtcl->https->static files->cookies policy ->auth->session-.>MVc
app.UseExceptionHandler()
app.UseHsts()
app.UseHttpsRedirection()
app.UseStaticFiles()
app.UseCookiePolicy()
app.UseRouting()
app.UseCors()
app.UseAuthentication()
app.UseAuthorization()
app.UseSession()
app.UseCustomMiddleware1()
app.UseEndpoints()

