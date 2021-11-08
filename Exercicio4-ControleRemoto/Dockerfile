#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Exercicio4-ControleRemoto/Exercicio4-ControleRemoto.csproj", "Exercicio4-ControleRemoto/"]
RUN dotnet restore "Exercicio4-ControleRemoto/Exercicio4-ControleRemoto.csproj"
COPY . .
WORKDIR "/src/Exercicio4-ControleRemoto"
RUN dotnet build "Exercicio4-ControleRemoto.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Exercicio4-ControleRemoto.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Exercicio4-ControleRemoto.dll"]
