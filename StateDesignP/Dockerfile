FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["OnlineOrders/OnlineOrders.csproj", "OnlineOrders/"]
RUN dotnet restore "OnlineOrders/OnlineOrders.csproj"
COPY . .
WORKDIR "/src/OnlineOrders"
RUN dotnet build "OnlineOrders.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OnlineOrders.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OnlineOrders.dll"]
