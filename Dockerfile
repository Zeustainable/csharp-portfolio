# Use .NET SDK to build
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app
COPY . ./
RUN dotnet publish -c Release -o /app/out

# Use ASP.NET runtime to run the app
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app/out .

EXPOSE 80
ENTRYPOINT ["dotnet", "MyPortfolio.dll"]
# Dockerfile for MyPortfolio application
# This Dockerfile builds the .NET application and prepares it for deployment