FROM mcr.microsoft.com/dotnet/sdk:3.1
COPY MyConsoleApp/bin/Debug/netcoreapp3.1 App/
WORKDIR /App
ENTRYPOINT ["dotnet", "MyConsoleApp.dll"]