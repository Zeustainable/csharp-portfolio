# Use .NET SDK to build
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

# ✅ Install Git (this is the fix)
RUN apt-get update && apt-get install -y git

COPY . ./
RUN dotnet publish -c Release -o /app/out

# Use ASP.NET runtime to run the app
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app/out .

EXPOSE 80
ENTRYPOINT ["dotnet", "MyPortfolio.dll"]
