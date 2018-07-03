FROM microsoft/aspnetcore-build:2.0.0 AS build

WORKDIR /code

COPY . .

RUN dotnet restore

#RUN dotnet publish --output /output --configuration Release
RUN dotnet publish --output /output --configuration Debug

FROM microsoft/aspnetcore:2.0.0

COPY --from=build /output /app

WORKDIR /app

ENTRYPOINT [ "dotnet", "Grapher.dll" ]

#docker pull to get Images from hub.docker.com

#docker run to start a container

#microsoft/aspnetcore and microsoft/aspnetcore-build

#Dockerfile to define your own image

#Multi-stage build – two FROM lines

#docker build to build your own image