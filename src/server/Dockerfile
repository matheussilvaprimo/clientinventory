FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY *.sln ./
COPY ClientInventory.API/ClientInventory.API.csproj ClientInventory.API/
COPY ClientInventory.Business/ClientInventory.Business.csproj ClientInventory.Business/
COPY Server.Infra/Server.Infra.csproj Server.Infra/
COPY ClientInventory.Domain/ClientInventory.Domain.csproj ClientInventory.Domain/
RUN dotnet restore
COPY . .
WORKDIR /src/ClientInventory.API
RUN dotnet build -c Release -o /app

FROM build AS publish
RUN dotnet publish -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ClientInventory.API.dll"]
