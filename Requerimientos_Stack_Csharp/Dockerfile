FROM microsoft/aspnetcore:2.0-nanoserver-1709 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0-nanoserver-1709 AS build
WORKDIR /src
COPY Requerimientos_Stack_Csharp/Requerimientos_Stack_Csharp.csproj Requerimientos_Stack_Csharp/
RUN dotnet restore Requerimientos_Stack_Csharp/Requerimientos_Stack_Csharp.csproj
COPY . .
WORKDIR /src/Requerimientos_Stack_Csharp
RUN dotnet build Requerimientos_Stack_Csharp.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Requerimientos_Stack_Csharp.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Requerimientos_Stack_Csharp.dll"]
