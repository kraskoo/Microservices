#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/Bominos.Notifications/Bominos.Notifications.csproj", "src/Bominos.Notifications/"]
RUN dotnet restore "src/Bominos.Notifications/Bominos.Notifications.csproj"
COPY . .
WORKDIR "/src/src/Bominos.Notifications"
RUN dotnet build "Bominos.Notifications.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Bominos.Notifications.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Bominos.Notifications.dll"]