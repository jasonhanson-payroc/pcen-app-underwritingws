#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
run apt-get -y update; apt-get -y install curl
EXPOSE 8080
EXPOSE 8081
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
RUN mkdir -p /https && chmod -R 755 /https
RUN dotnet dev-certs https -ep /https/aspnetapp.pfx -p Z12e6OUPtntRFudN
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Underwriting.csproj", "."]
RUN dotnet restore "./Underwriting.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "./Underwriting.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Underwriting.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
COPY --chmod=0755 --from=build /https/* /https/
ENV ASPNETCORE_URLS=https://+443;http://+:80

ENV ASPNETCORE_Kestrel__Certificates__Default__Path=/https/aspnetapp.pfx
ENV ASPNETCORE_Kestrel__Certificates__Default__Password=Z12e6OUPtntRFudN
ENTRYPOINT ["dotnet", "Underwriting.dll"]