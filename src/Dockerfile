FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 8080:80
ENV ASPNETCORE_URLS http://*:8080

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY server.sln ./
COPY server/ClientInventory.API/ClientInventory.API.csproj server/ClientInventory.API/
COPY server/ClientInventory.API.Models/ClientInventory.API.Models.csproj server/ClientInventory.API.Models/
COPY server/ClientInventory.Business/ClientInventory.Business.csproj server/ClientInventory.Business/
COPY server/ClientInventory.Domain/ClientInventory.Domain.csproj server/ClientInventory.Domain/
COPY server/ClientInventory.Repository/ClientInventory.Repository.csproj server/ClientInventory.Repository/
COPY server/ClientInventory.Utils/ClientInventory.Utils.csproj server/ClientInventory.Utils/
COPY infra/Infra.Aspnet.Middlewares/Infra.Aspnet.Middlewares.csproj infra/Infra.Aspnet.Middlewares/
COPY infra/Infra.Exceptions/Infra.Exceptions.csproj infra/Infra.Exceptions/
COPY infra/Infra.Mongo.Repository/Infra.Mongo.Repository.csproj infra/Infra.Mongo.Repository/
RUN dotnet restore
COPY . .
WORKDIR /src
RUN dotnet build server.sln -c Release -o /app

FROM build AS publish
RUN dotnet publish server.sln -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ClientInventory.API.dll"]
