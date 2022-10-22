
FROM mcr.microsoft.com/dotnet/framework/sdk:4.8 AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.sln .
COPY DevOps.Web.Api/*.csproj ./DevOps.Web.Api/
COPY DevOps.Web.Api/*.config ./DevOps.Web.Api/
COPY packages/ ./packages/
RUN nuget restore

# copy everything else and build app
COPY DevOps.Web.Api/. ./DevOps.Web.Api/
WORKDIR /app/DevOps.Web.Api
RUN msbuild /p:Configuration=Release -r:False


FROM mcr.microsoft.com/dotnet/framework/aspnet:4.8 AS runtime
WORKDIR /inetpub/wwwroot
COPY --from=build /app/DevOps.Web.Api/. ./