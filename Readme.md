# .NET Core Hello World

Simple .NET Core Web Api App.  
With a singleton for increment count.  
Includes Dockerfile.  
Used as sample project for future references.  

###### Run container with: 
* docker build -t cszheng/dotnet-web-api .
* docker run -it -p 5000:5000 -v C:/Development/docker/dotnet-web-api/app:/app --name=dotnet-web-api-container-1 cszheng/dotnet-web-api /bin/bash
* docker start dotnet-web-api-container-1

###### While in the MainApp directory, run app with:
* dotnet restore
* dotnet build
* dotnet run