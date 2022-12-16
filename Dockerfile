FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /src
COPY AddNumbers/*.csproj .
RUN dotnet restore
COPY AddNumbers .
RUN dotnet publish -c -release -o /publish

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime
WORKDIR /app
COPY --from=build-env /publish .
EXPOSE 80

ENTRYPOINT ["dotnet","AddNumbers.dll"]
