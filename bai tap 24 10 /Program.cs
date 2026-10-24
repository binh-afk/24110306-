
using Microsoft.EntityFrameworkCore;
using QLTV.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<QLTVDBContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString(
            "DefaultConnection")));

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllers();

app.Run();
