FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["WebApi.csproj", "WebApi/"]
COPY ["Persistance/Persistance.csproj", "Persistance/"]
COPY ["Domain/Domain.csproj", "Domain/"]
RUN dotnet restore "WebApi/WebApi.csproj"
COPY . .
WORKDIR "/src/WebApi"
RUN dotnet build "WebApi.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "WebApi.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .

CMD dotnet WebApi.dll