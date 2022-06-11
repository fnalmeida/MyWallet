#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MyWallet_API/MyWallet_API.csproj", "MyWallet_API/"]
RUN dotnet restore "MyWallet_API/MyWallet_API.csproj"
COPY . .
WORKDIR "/src/MyWallet_API"
RUN dotnet build "MyWallet_API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MyWallet_API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MyWallet_API.dll"]