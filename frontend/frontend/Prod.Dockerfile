#step1 1:build
FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster as build-stage
RUN mkdir app
WORKDIR /app
COPY frontend.csproj .
RUN dotnet restore
COPY . .
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim 
WORKDIR /app
COPY --from=build-stage /app/out .
ENTRYPOINT dotnet frontend.dll

