using DigitalPensionPlanApplication.UseCases.Genders.GetGender;
using DigitalPensionPlanApplication.UseCases.Genders.GetGenders;
using DigitalPensionPlanApplication.UseCases.Phases.GetPhase;
using DigitalPensionPlanApplication.UseCases.Phases.GetPhases;
using DigitalPensionPlanDomain.Interfaces;
using DigitalPensionPlanInfrastructure.Persistance;
using DigitalPensionPlanInfrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// ---------------------------
// Database
// ---------------------------
builder.Services.AddDbContext<ApplicationDbContext>(options => 
    options
        .UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"))
        .UseSnakeCaseNamingConvention());

// ---------------------------
// Repositories
builder.Services.AddScoped<IPhaseRepository, PhaseRepository>();
builder.Services.AddScoped<IGenderRepository, GenderRepository>();

// ---------------------------
// Use Cases
builder.Services.AddScoped<IGetPhaseUseCase, GetPhaseUseCase>();
builder.Services.AddScoped<IGetPhasesUseCase, GetPhasesUseCase>();
builder.Services.AddScoped<IGetGenderUseCase, GetGenderUseCase>();
builder.Services.AddScoped<IGetGendersUseCase, GetGendersUseCase>();

// ---------------------------
// Controllers
builder.Services.AddControllers();


var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
