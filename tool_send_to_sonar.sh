#!/usr/bin/env sh

if [ `dotnet tool list --global | grep dotnet-sonarscanner | wc -l` -ne 1 ]
then
    echo "'dotnet-sonarscanner' tool NOT installed : please, install it with command 'dotnet tool install --global dotnet-sonarscanner'"
    exit 1
fi

PROJECT_KEY=ecoCode-csharp-test-project
SONAR_TOKEN=$1

dotnet sonarscanner begin /k:"$PROJECT_KEY" /d:sonar.host.url="http://localhost:9000"  /d:sonar.login="$SONAR_TOKEN"
dotnet build
dotnet sonarscanner end /d:sonar.login="$SONAR_TOKEN"