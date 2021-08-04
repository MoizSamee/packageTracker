FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 44301

ENV ASPNETCORE_URLS=http://+:44301

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["PackageTracker.csproj", "./"]
RUN dotnet restore "PackageTracker.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "PackageTracker.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PackageTracker.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PackageTracker.dll"]
