FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /app

# Copy everything
COPY . ./

# Restore using csproj (IMPORTANT)
RUN dotnet restore DigitalPensionPlanBackend/DigitalPensionPlanAPI/DigitalPensionPlanAPI.csproj

# Publish
RUN dotnet publish DigitalPensionPlanBackend/DigitalPensionPlanAPI/DigitalPensionPlanAPI.csproj -c Release -o /out

FROM mcr.microsoft.com/dotnet/aspnet:10.0
WORKDIR /app

COPY --from=build /out ./

EXPOSE 8080
ENTRYPOINT ["dotnet", "DigitalPensionPlanAPI.dll"]


# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

# Copy solution and restore
COPY DigitalPensionPlanBackend/LighthubBackend.sln ./
COPY LighthubBackend/API/API.csproj API/
COPY LighthubBackend/Core/Core.csproj Core/
COPY LighthubBackend/Infrastructure/Infrastructure.csproj Infrastructure/

# Copy all source code
COPY LighthubBackend/. .

# Publish the API project
RUN dotnet publish API/API.csproj -c Release -o /app/publish

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "DigitalPensionPlanAPI.dll"]
