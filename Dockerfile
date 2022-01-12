FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app

ENV CONFIGURATION=Debug
EXPOSE 80

COPY . ./
RUN dotnet restore

RUN dotnet publish -c $CONFIGURATION -o out --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "CarutiFlix.Catalog.Api.dll"]