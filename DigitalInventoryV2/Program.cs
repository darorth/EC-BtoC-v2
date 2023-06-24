using DigitalInventoryV2.DB;
using DigitalInventoryV2.Repositories;
using DigitalInventoryV2.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IProduct, ProductRepository>();

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("Default")));

// var host = CreateWebHostBuilder(args).Build();
// using (var scope = builder.Services.CreateScope())
// {
    // var services = scope.ServiceProvider;
    // try
    // {
    //     var context = services.GetRequiredService<AppDBContext>();
    //     DbInitializer.Initialize(context);
        
    // }
    // catch (Exception ex)
    // {
    //     var logger = services.GetRequiredService<ILogger<Program>>();
    //     logger.LogError(ex, "An error occurred while seeding the database.");
    // }
// }

// host.Run();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

