using DataPaintLibrary.Services.Classes;
using DataPaintLibrary.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSingleton<ILoggerService, LoggerService>();
builder.Services.AddSingleton<ISqlService, SqlService>();
builder.Services.AddSingleton<IAppCollectionService, AppCollectionService>();
builder.Services.AddSingleton<IDataExtractionService, DataExtractionService>();
builder.Services.AddSingleton<IClassBuilderService, ClassBuilderService>();
builder.Services.AddSingleton<IOrchestratorService, OrchestratorService>();
builder.Services.AddSingleton<ISecurityGroupService, SecurityGroupService>();

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();


