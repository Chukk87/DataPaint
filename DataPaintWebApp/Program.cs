using DataPaintLibrary.Services.Classes;
using DataPaintLibrary.Services.Interfaces;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSingleton<IAppCacheService, AppCacheService>();
builder.Services.AddSingleton<ILoggerService, LoggerService>();
builder.Services.AddSingleton<ILoginService, LoginService>();
builder.Services.AddSingleton<ISqlService, SqlService>();
builder.Services.AddSingleton<IAppCollectionService, AppCollectionService>();
builder.Services.AddSingleton<IDataExtractionService, DataExtractionService>();
builder.Services.AddSingleton<IClassBuilderService, ClassBuilderService>();
builder.Services.AddSingleton<IOrchestratorService, OrchestratorService>();
builder.Services.AddSingleton<ISecurityGroupService, SecurityGroupService>();

//Authentication service
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = "/UserAccount/Login";
                    options.LogoutPath = "/UserAccount/Logout";
                    options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
                    options.SlidingExpiration = true;
                });

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}
else
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();


