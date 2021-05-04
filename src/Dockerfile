FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /app
COPY . .
RUN dotnet restore
RUN dotnet build --no-restore -c Release -o output

FROM build AS publish
RUN dotnet publish --no-restore -c Release -o output

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS final

# Download and install the Tracer

# Enable the tracer

WORKDIR /app
COPY --from=publish /app/output .

ENTRYPOINT ["dotnet", "OpenTelemetryJaeger.dll"]