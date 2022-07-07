#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Ayandeh.Faraz.Migrator/Ayandeh.Faraz.Migrator.csproj", "src/Ayandeh.Faraz.Migrator/"]
COPY ["src/Ayandeh.Faraz.EntityFrameworkCore/Ayandeh.Faraz.EntityFrameworkCore.csproj", "src/Ayandeh.Faraz.EntityFrameworkCore/"]
COPY ["src/Ayandeh.Faraz.Core/Ayandeh.Faraz.Core.csproj", "src/Ayandeh.Faraz.Core/"]
COPY ["src/Ayandeh.Faraz.Core.Shared/Ayandeh.Faraz.Core.Shared.csproj", "src/Ayandeh.Faraz.Core.Shared/"]
RUN dotnet restore "src/Ayandeh.Faraz.Migrator/Ayandeh.Faraz.Migrator.csproj"
COPY . .
WORKDIR "/src/src/Ayandeh.Faraz.Migrator"
RUN dotnet build "Ayandeh.Faraz.Migrator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Ayandeh.Faraz.Migrator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Ayandeh.Faraz.Migrator.dll", "-s"]
