using DigitalPensionPlanDomain.Entities;
using DigitalPensionPlanInfrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddDbContext<ApplicationDbContext>(options => 
    options
        .UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"))
        .UseSnakeCaseNamingConvention());


var app = builder.Build();

app.MapPost("/test-phase", async (ApplicationDbContext context) =>
{
    var phase = new Phase
    {
        PhaseName = "Test Phase"
    };

    context.Phases.Add(phase);
    await context.SaveChangesAsync();

    return Results.Ok(phase);
});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
