﻿FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Strategy/Strategy.csproj", "Strategy/"]
RUN dotnet restore "Strategy/Strategy.csproj"
COPY . .
WORKDIR "/src/Strategy"
RUN dotnet build "Strategy.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Strategy.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Strategy.dll"]
