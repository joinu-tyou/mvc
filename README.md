# mvc
dotnet core

dotnet new mvc


$dotnet --version
2.1.402

$git --version
git version 2.17.1 (Apple Git-112)

Visual studio code 
September 2018 (version 1.28)

$mkdir mvc
$cd mvc

$dotnet new mvc
The template "ASP.NET Core Web App (Model-View-Controller)" was created successfully.
This template contains technologies from parties other than Microsoft, see https://aka.ms/aspnetcore-template-3pn-210 for details.

Processing post-creation actions...
Running 'dotnet restore' on /Users/zhangyong/github/mvc/mvc.csproj...
  Restoring packages for /Users/zhangyong/github/mvc/mvc.csproj...
  Generating MSBuild file /Users/zhangyong/github/mvc/obj/mvc.csproj.nuget.g.props.
  Generating MSBuild file /Users/zhangyong/github/mvc/obj/mvc.csproj.nuget.g.targets.
  Restore completed in 2.15 sec for /Users/zhangyong/github/mvc/mvc.csproj.

Restore succeeded.

vsCode->Open folder->mvc

? Required assets to build and debug are missing from ‘mvc’. Add them?

yes

To generate a developer certificate run 'dotnet dev-certs https'. To trust the certificate (Windows and macOS only) run 'dotnet dev-certs https --trust'.

$dotnet dev-certs https --trust
$dotnet run

https://localhost:5001/


dotnet add package popper.js --version 1.14.3
