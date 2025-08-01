# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app
RUN apt-get update && apt-get install -y git
COPY . ./
RUN dotnet publish -c Release -o /app/out

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

# ✅ Install git here too
RUN apt-get update && apt-get install -y git

COPY --from=build /app/out .

EXPOSE 80
ENTRYPOINT ["dotnet", "MyPortfolio.dll"]
