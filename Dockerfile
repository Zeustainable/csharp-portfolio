# Use .NET 8 SDK to build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Install Git (required by some .NET SDK features)
RUN apt-get update && apt-get install -y git

COPY . ./
RUN dotnet publish -c Release -o /app/out

# Use .NET 8 ASP.NET runtime to run the app
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .

EXPOSE 80
ENTRYPOINT ["dotnet", "MyPortfolio.dll"]
