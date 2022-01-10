#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["ScandinavianFood/ScandinavianFood.csproj", "ScandinavianFood/"]
RUN dotnet restore "ScandinavianFood/ScandinavianFood.csproj"
COPY . .
WORKDIR "/src/ScandinavianFood"
RUN dotnet build "ScandinavianFood.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ScandinavianFood.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ScandinavianFood.dll"]