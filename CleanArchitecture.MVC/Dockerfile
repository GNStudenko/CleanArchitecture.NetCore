FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["CleanArchitecture.MVC/CleanArchitecture.MVC.csproj", "CleanArchitecture.MVC/"]
RUN dotnet restore "CleanArchitecture.MVC/CleanArchitecture.MVC.csproj"
COPY . .
WORKDIR "/src/CleanArchitecture.MVC"
RUN dotnet build "CleanArchitecture.MVC.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "CleanArchitecture.MVC.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "CleanArchitecture.MVC.dll"]