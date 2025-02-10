# Etapa 1: Build
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["QueryAPI.csproj", "./"]
RUN dotnet restore "QueryAPI.csproj"
COPY . .
RUN dotnet publish "QueryAPI.csproj" -c Release -o /app/publish

# Etapa 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS final
WORKDIR /app
ENV ASPNETCORE_URLS=http://+:8800
EXPOSE 8800
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "QueryAPI.dll"]

