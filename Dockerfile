# First stage: build
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

RUN apt-get update && apt-get install -y git

COPY . ./
RUN dotnet publish -c Release -o /app/out

# Second stage: runtime
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app

# ⚠️ Install git here too — needed at runtime!
RUN apt-get update && apt-get install -y git

COPY --from=build /app/out .

EXPOSE 80

ENTRYPOINT ["dotnet", "MyPortfolio.dll"]
