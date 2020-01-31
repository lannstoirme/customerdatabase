FROM microsoft/dotnet:2.2-sdk AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

# Build runtime image
FROM microsoft/dotnet:2.2-aspnetcore-runtime
WORKDIR /app
COPY --from=build-env /app/out .
CMD dotnet MicahCustomerManager.dll

#FROM mcr.microsoft.com/dotnetcosdk:3.1 AS base
#WORKDIR /app

#FROM microsoft/dotnet:3.1 AS build-env
#WORKDIR /app
#copy csproj and restore as distinct layers

#COPY *.csproj ./
#RUN dotnet restore 

#copy everything else and build app
#COPY . ./
#RUN dotnet publish -c Release -o out

#FROM microsoft/dotnet:3.1-aspnetcore-runtime
#WORKDIR /app
#COPY --from=build-env /app/out ./
#CMD dotnet MicahCustomerManager.dll
