# =========================
# Stage 1: Build
# =========================
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

# Copy solution và NuGet config từ ROOT (context = AbpSolution2)
COPY ../../AbpSolution2.sln ./
COPY ../../NuGet.config ./

# Copy csproj files (từ src)
COPY AbpSolution2.HttpApi.Host/*.csproj AbpSolution2.HttpApi.Host/
COPY AbpSolution2.Application/*.csproj AbpSolution2.Application/
COPY AbpSolution2.Application.Contracts/*.csproj AbpSolution2.Application.Contracts/
COPY AbpSolution2.Domain/*.csproj AbpSolution2.Domain/
COPY AbpSolution2.Domain.Shared/*.csproj AbpSolution2.Domain.Shared/
COPY AbpSolution2.EntityFrameworkCore/*.csproj AbpSolution2.EntityFrameworkCore/
COPY AbpSolution2.HttpApi/*.csproj AbpSolution2.HttpApi/

# Restore
RUN dotnet restore ./AbpSolution2.sln

# Copy toàn bộ source code
COPY .. .

# Publish HttpApi.Host
WORKDIR /src/src/AbpSolution2.HttpApi.Host
RUN dotnet publish -c Release -o /app --no-restore

# =========================
# Stage 2: Runtime
# =========================
FROM mcr.microsoft.com/dotnet/aspnet:10.0
WORKDIR /app

COPY --from=build /app ./

ENV ASPNETCORE_URLS=http://+:80

ENTRYPOINT ["dotnet", "AbpSolution2.HttpApi.Host.dll"]
