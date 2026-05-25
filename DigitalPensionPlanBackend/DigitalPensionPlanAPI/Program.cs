using DigitalPensionPlanApplication.UseCases.AgeGroups;
using DigitalPensionPlanApplication.UseCases.Countries;
using DigitalPensionPlanApplication.UseCases.Genders;
using DigitalPensionPlanApplication.UseCases.Phases;
using DigitalPensionPlanApplication.UseCases.UserRoles;
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
builder.Services.AddScoped<IUserRoleRepository, UserRoleRepository>();
builder.Services.AddScoped<ICountryRepository, CountryRepository>();
builder.Services.AddScoped<IAgeGroupRepository, AgeGroupRepository>();

// ---------------------------
// Use Cases
builder.Services.AddScoped<GetPhaseUseCase>();
builder.Services.AddScoped<GetPhasesUseCase>();
builder.Services.AddScoped<GetGenderUseCase>();
builder.Services.AddScoped<GetGendersUseCase>();
builder.Services.AddScoped<GetUserRoleUseCase>();
builder.Services.AddScoped<GetUserRolesUseCase>();
builder.Services.AddScoped<GetAgeGroupUseCase>();
builder.Services.AddScoped<GetAgeGroupsUseCase>();
builder.Services.AddScoped<GetCountryUseCase>();
builder.Services.AddScoped<GetCountriesUseCase>();

// ---------------------------
// Controllers
builder.Services.AddControllers();


var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
