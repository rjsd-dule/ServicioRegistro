#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 5000
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["ProyectUTP.API/ProyectUTP.API.csproj", "ProyectUTP.API/"]
COPY ["ProyectUTP.Aplication/ProyectUTP.Application.csproj", "ProyectUTP.Aplication/"]
COPY ["ProyectUTP.Domain/ProyectUTP.Domain.csproj", "ProyectUTP.Domain/"]
COPY ["ProyectUTP.Infrastructure/ProyectUTP.Infrastructure.csproj", "ProyectUTP.Infrastructure/"]
RUN dotnet restore "./ProyectUTP.API/ProyectUTP.API.csproj"
COPY . .
WORKDIR "/src/ProyectUTP.API"
RUN dotnet build "./ProyectUTP.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./ProyectUTP.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ProyectUTP.API.dll"]