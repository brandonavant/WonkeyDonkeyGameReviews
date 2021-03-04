# Build Image
FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /source

COPY ["AccountsAPI.API/AccountsAPI.API.csproj", "AccountsAPI.API/"]
COPY ["AccountsAPI.Application/AccountsAPI.Application.csproj", "AccountsAPI.Application/"]
COPY ["AccountsAPI.Domain/AccountsAPI.Domain.csproj", "AccountsAPI.Domain/"]
COPY ["AccountsAPI.Infrastructure/AccountsAPI.Infrastructure.csproj", "AccountsAPI.Infrastructure/"]
COPY ["AccountsAPI.Tests/AccountsAPI.Tests.csproj", "AccountsAPI.Tests/"]
COPY ["AccountsAPI.sln", "./"]

RUN dotnet restore

COPY [".", "."]

RUN dotnet publish -c Debug -o /bin AccountsAPI.API/AccountsAPI.API.csproj

# Runtime Image
FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim
WORKDIR /app

COPY --from=build /bin .

ENV ASPNETCORE_ENVIRONMENT=Localhost
ENV ASPNETCORE_URLS=http://+:80

EXPOSE 80
ENTRYPOINT ["dotnet", "AccountsAPI.API.dll"]