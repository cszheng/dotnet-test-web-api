FROM microsoft/dotnet:latest

#create directory
RUN mkdir /app
WORKDIR /app

EXPOSE 5000
