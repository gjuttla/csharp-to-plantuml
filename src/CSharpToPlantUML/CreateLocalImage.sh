#!/bin/bash

dotnet restore
dotnet publish -c Release -o out
docker build -t csharp-to-plantuml .