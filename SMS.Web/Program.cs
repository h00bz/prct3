var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// get web server to serve static files in wwwroot folder
app.UseStaticFiles();

// default file to serve in response to / route
app.MapFallbackToFile("index.html");


app.Run();
