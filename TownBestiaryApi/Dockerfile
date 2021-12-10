FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["TownBestiaryApi/TownBestiaryApi.csproj", "TownBestiaryApi/"]
RUN dotnet restore "TownBestiaryApi/TownBestiaryApi.csproj"
COPY . .
WORKDIR "/src/TownBestiaryApi"
RUN dotnet build "TownBestiaryApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TownBestiaryApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TownBestiaryApi.dll"]
