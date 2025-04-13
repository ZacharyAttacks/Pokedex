FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY ["Pokedex.csproj", "./"]
RUN dotnet restore "Pokedex.csproj"

COPY . .
RUN dotnet publish "Pokedex.csproj" -c Release -o /app/publish


RUN cp -r wwwroot /app/publish/wwwroot

FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "Pokedex.dll"]
