using AliUni.Data.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddDbContext<AliUniContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("AliString"))
    );
var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=index}/{id?}"
);





// app.MapControllerRoute(
//     name : "Areas",
//     pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
//     );

app.MapRazorPages();
app.Run();
