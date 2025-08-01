// using MongoDB.Driver;
// using MyPortfolio.Repositories;

// var builder = WebApplication.CreateBuilder(args);

// // 🔧 Tell Kestrel to listen on port 80
// builder.WebHost.ConfigureKestrel(serverOptions =>
// {
//     serverOptions.ListenAnyIP(80);
// });

// // MongoDB setup
// var mongoSettings = builder.Configuration.GetSection("MongoDbSettings");
// var mongoClient = new MongoClient(mongoSettings["ConnectionString"]);
// var mongoDatabase = mongoClient.GetDatabase(mongoSettings["DatabaseName"]);

// builder.Services.AddSingleton<IMongoClient>(mongoClient);
// builder.Services.AddSingleton<IMongoDatabase>(mongoDatabase);

// builder.Services.AddScoped<Register_repository>();

// builder.Services.AddRazorPages();

// var app = builder.Build();

// // Production pipeline config
// if (!app.Environment.IsDevelopment())
// {
//     app.UseExceptionHandler("/Error");
//     app.UseHsts();
// }

// app.UseHttpsRedirection();
// app.UseStaticFiles();
// app.UseRouting();
// app.UseAuthorization();
// app.MapRazorPages();
// app.Run();










using MongoDB.Driver;
using MyPortfolio.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var mongoSettings = builder.Configuration.GetSection("MongoDbSettings");
var mongoClient = new MongoClient(mongoSettings["ConnectionString"]);
var mongoDatabase = mongoClient.GetDatabase(mongoSettings["DatabaseName"]);

builder.Services.AddSingleton<IMongoClient>(mongoClient);
builder.Services.AddSingleton<IMongoDatabase>(mongoDatabase);

builder.Services.AddScoped<Register_repository>();

builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();