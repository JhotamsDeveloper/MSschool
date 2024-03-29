#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["MSschool.Presentation.Api/MSschool.Presentation.Api.csproj", "MSschool.Presentation.Api/"]
COPY ["MSschool.Application/MSschool.Application.csproj", "MSschool.Application/"]
COPY ["MSschool.Application.Domain/MSschool.Application.Domain.csproj", "MSschool.Application.Domain/"]
COPY ["MSschool.Infrastructure.EntityFramework/MSschool.Infrastructure.EntityFramework.csproj", "MSschool.Infrastructure.EntityFramework/"]
COPY ["MSschool.Presentation.Endpoints/MSschool.Presentation.Endpoints.csproj", "MSschool.Presentation.Endpoints/"]
RUN dotnet restore "MSschool.Presentation.Api/MSschool.Presentation.Api.csproj"
COPY . .
WORKDIR "/src/MSschool.Presentation.Api"
RUN dotnet build "MSschool.Presentation.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MSschool.Presentation.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MSschool.Presentation.Api.dll"]