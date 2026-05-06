# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

# Copy solution and restore
COPY DigitalPensionPlanBackend.slnx ./
COPY DigitalPensionPlanAPI/DigitalPensionPlanAPI.csproj DigitalPensionPlanAPI/
COPY DigitalPensionPlanApplication/DigitalPensionPlanApplication.csproj DigitalPensionPlanApplication/
COPY DigitalPensionPlanDomain/DigitalPensionPlanDomain.csproj DigitalPensionPlanDomain/
COPY DigitalPensionPlanInfrastructure/DigitalPensionPlanInfrastructure.csproj DigitalPensionPlanInfrastructure/

# Copy all source code
COPY . .

# Publish the API project
RUN dotnet publish DigitalPensionPlanAPI/DigitalPensionPlanAPI.csproj -c Release -o /app/publish

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

EXPOSE 8080
ENTRYPOINT ["dotnet", "DigitalPensionPlanAPI.dll"]
