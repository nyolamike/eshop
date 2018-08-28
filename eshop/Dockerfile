FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 5734
EXPOSE 44366

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY eshop/eshop.csproj eshop/
RUN dotnet restore eshop/eshop.csproj
COPY . .
WORKDIR /src/eshop
RUN dotnet build eshop.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish eshop.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "eshop.dll"]
