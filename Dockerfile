# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

COPY AbpSolution2.sln ./
COPY NuGet.config ./
COPY src/AbpSolution2.HttpApi.Host/*.csproj src/AbpSolution2.HttpApi.Host/
COPY src/AbpSolution2.Application/*.csproj src/AbpSolution2.Application/
COPY src/AbpSolution2.Application.Contracts/*.csproj src/AbpSolution2.Application.Contracts/
COPY src/AbpSolution2.Domain/*.csproj src/AbpSolution2.Domain/
COPY src/AbpSolution2.Domain.Shared/*.csproj src/AbpSolution2.Domain.Shared/
COPY src/AbpSolution2.EntityFrameworkCore/*.csproj src/AbpSolution2.EntityFrameworkCore/
COPY src/AbpSolution2.HttpApi/*.csproj src/AbpSolution2.HttpApi/

RUN dotnet restore ./AbpSolution2.sln

COPY . .

WORKDIR /src/src/AbpSolution2.HttpApi.Host
RUN dotnet publish -c Release -o /app

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:10.0
WORKDIR /app
COPY --from=build /app .

ENV ASPNETCORE_URLS=http://+:80
ENTRYPOINT ["dotnet", "AbpSolution2.HttpApi.Host.dll"]
