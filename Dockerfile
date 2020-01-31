#FROM mcr.microsoft.com/dotnetcosdk:3.1 AS base
#WORKDIR /app

FROM microsoft/dotnet:3.1 AS build-env
WORKDIR /app
#copy csproj and restore as distinct layers

COPY *.csproj ./
RUN dotnet restore 

#copy everything else and build app
COPY . ./
RUN dotnet publish -c Release -o out

FROM microsoft/dotnet:3.1-aspnetcore-runtime
WORKDIR /app
COPY --from=build-env /app/out ./
CMD dotnet MicahCustomerManager.dll