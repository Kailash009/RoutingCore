var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

//app.MapDefaultControllerRoute(); // This page only run default home/index


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Employee}/{action=Index}/{id?}"
    );

//app.MapControllerRoute(
//    name: "abc",
//    pattern: "{controller=Home}/{action=Contact}/{id?}"
//    );

app.MapControllers();  // For Attribute Based Routing.

app.Run();
