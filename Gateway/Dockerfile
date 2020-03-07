FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /appp


FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["Gateway/Gateway.csproj", "Gateway/"]
RUN dotnet restore "Gateway/Gateway.csproj"
COPY . .
WORKDIR "/src/Gateway"
RUN dotnet build "Gateway.csproj" -c Release -o /appp

FROM build AS publish
RUN dotnet publish "Gateway.csproj" -c Release -o /appp

ENV ASPNETCORE_ENVIRONMENT Production

FROM base AS final
WORKDIR /appp
COPY --from=publish /appp .
ENTRYPOINT ["dotnet", "Gateway.dll"]