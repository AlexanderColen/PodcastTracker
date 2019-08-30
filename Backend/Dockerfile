# Based on https://docs.docker.com/engine/examples/dotnetcore/
FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build-env
WORKDIR /app

LABEL Author 'Alexander Colen'

# Fix timezone, without this it would be set to UTC.
ENV TZ 'America/Toronto'
RUN echo $TZ > /etc/timezone && \
    apt-get update && apt-get install -y tzdata && \
    rm /etc/localtime && \
    ln -snf /usr/share/zoneinfo/$TZ /etc/localtime && \
    dpkg-reconfigure -f noninteractive tzdata && \
    apt-get clean


# Copy csproj and restore as distinct layers
COPY Podcast-BE/Podcast-BE/*.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY Podcast-BE/Podcast-BE/. ./
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:2.2
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "Podcast-BE.dll"]
