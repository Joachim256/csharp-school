all: build run

build:
	DOTNET_CLI_TELEMETRY_OPTOUT=1 dotnet build

run:
	csharp-school/bin/Debug/net6.0/csharp-school
