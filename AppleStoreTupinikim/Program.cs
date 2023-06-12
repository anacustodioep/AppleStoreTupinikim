using AppleStoreTupinikim.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//>>>>>>>>>>>>>>>>>>>>>>>>>>>>
//No lugar depwd coloque sua senha do user root do mySql
builder.Services.AddDbContext<Context>(options => options.UseMySql("server=localhost;initial catalog=Produtos;uid=root;pwd=$PXqBRWh#7Yq@4Ew", ServerVersion.Parse("8.0.25-mysql")));
//>>>>>>>>>>>
//Roda no console
//Add-Migration Criacao-Inicial -Context Context
//Update-Database -Context Context
var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
