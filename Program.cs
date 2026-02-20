var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDefaultFiles(); // Automatically loads index.html
app.UseStaticFiles();  // Allows serving HTML, CSS, JS

app.Run();