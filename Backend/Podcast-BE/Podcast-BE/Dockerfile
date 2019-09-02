FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["Podcast-BE/Podcast-BE.csproj", "Podcast-BE/"]
RUN dotnet restore "Podcast-BE/Podcast-BE.csproj"
COPY . .
WORKDIR "/src/Podcast-BE"
RUN dotnet build "Podcast-BE.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Podcast-BE.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Podcast-BE.dll"]