FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 8080:80
ENV ASPNETCORE_URLS http://*:8080

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY *.sln ./
COPY server/ClientInventory.API/ClientInventory.API.csproj ClientInventory.API/
COPY server/ClientInventory.API.Models/ClientInventory.API.Models.csproj ClientInventory.API.Models/
COPY server/ClientInventory.Business/ClientInventory.Business.csproj ClientInventory.Business/
COPY server/ClientInventory.Domain/ClientInventory.Domain.csproj ClientInventory.Domain/
COPY server/ClientInventory.Repository.csproj ClientInventory.Repository/
COPY server/ClientInventory.Utils.csproj ClientInventory.Utils/
COPY infra/Infra.Aspnet.Middlewares.csproj Infra.Aspnet.Middlewares/
COPY infra/Infra.Exceptions.csproj Infra.Exceptions/
COPY infra/Infra.Mongo.Repository.csproj Infra.Mongo.Repository/
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
