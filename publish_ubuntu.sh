#!/usr/bin/env bash
set -e

if [ ! -f "/usr/lib/gdiplus.dll" ]; then
    echo "ERROR:"
    echo "please install libgdiplus first:"
    echo "================================"
    echo "sudo apt-get install libgdiplus"
    echo "cd /usr/lib"
    echo "ln -s libgdiplus.so gdiplus.dll"
    echo "================================"
    exit
fi

if [ ! -d "../ZKWeb/Tools" ]; then
    echo "ERROR:"
    echo "please download ZKWeb and put it in the same directory as ZKWeb.Home"
    exit
fi

echo building project...
cd src/ZKWeb.Home.AspNetCore
dotnet restore
dotnet build -c Release -f netcoreapp2.2
dotnet publish -c Release -f netcoreapp2.2 -r ubuntu.16.04-x64
cd ../..

echo building plugins...
cd src/ZKWeb.Home.Console
dotnet restore
dotnet run -c Release -f netcoreapp2.2
cd ../..

echo publishing website...
dotnet ../ZKWeb/Tools/WebsitePublisher.Cmd.NetCore/ZKWeb.Toolkits.WebsitePublisher.Cmd.dll -f netcoreapp2.2 -r src/ZKWeb.Home.AspNetCore -n "ZKWeb.Home.Ubuntu" -o "../ZKWeb.Home.Publish"
echo "output directory: ../ZKWeb.Home.Publish"
