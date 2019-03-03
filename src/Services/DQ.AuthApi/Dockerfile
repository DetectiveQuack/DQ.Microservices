FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY . .
WORKDIR "/src/src/Services/DQ.AuthApi"
RUN dotnet restore
RUN dotnet build -c Debug -o /app

FROM build AS publish
RUN dotnet publish -c Debug -o /app

FROM base AS final
WORKDIR /app
ENV DEBIAN_FRONTEND noninteractive
COPY --from=publish /app .
RUN apt-get update && \
        apt-get install -y --no-install-recommends apt-utils && \
        apt-get install curl unzip procps mongodb -y && \
        curl -sSL https://aka.ms/getvsdbgsh | bash /dev/stdin -v latest -l /publish/vsdbg; 
ENV DEBIAN_FRONTEND teletype
ENTRYPOINT ["dotnet", "DQ.AuthApi.dll"]
