#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Ayandeh.Faraz.Web.Host/Ayandeh.Faraz.Web.Host.csproj", "src/Ayandeh.Faraz.Web.Host/"]
COPY ["src/Ayandeh.Faraz.Web.Core/Ayandeh.Faraz.Web.Core.csproj", "src/Ayandeh.Faraz.Web.Core/"]
COPY ["src/Ayandeh.Faraz.Application/Ayandeh.Faraz.Application.csproj", "src/Ayandeh.Faraz.Application/"]
COPY ["src/Ayandeh.Faraz.Application.Shared/Ayandeh.Faraz.Application.Shared.csproj", "src/Ayandeh.Faraz.Application.Shared/"]
COPY ["src/Ayandeh.Faraz.Core.Shared/Ayandeh.Faraz.Core.Shared.csproj", "src/Ayandeh.Faraz.Core.Shared/"]
COPY ["src/Ayandeh.Faraz.Core/Ayandeh.Faraz.Core.csproj", "src/Ayandeh.Faraz.Core/"]
COPY ["src/Ayandeh.Faraz.EntityFrameworkCore/Ayandeh.Faraz.EntityFrameworkCore.csproj", "src/Ayandeh.Faraz.EntityFrameworkCore/"]
COPY ["src/Ayandeh.Faraz.GraphQL/Ayandeh.Faraz.GraphQL.csproj", "src/Ayandeh.Faraz.GraphQL/"]
RUN dotnet restore "src/Ayandeh.Faraz.Web.Host/Ayandeh.Faraz.Web.Host.csproj"
COPY . .
WORKDIR "/src/src/Ayandeh.Faraz.Web.Host"
RUN dotnet build "Ayandeh.Faraz.Web.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Ayandeh.Faraz.Web.Host.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Ayandeh.Faraz.Web.Host.dll"]
