# Use the .NET SDK image for building the application
FROM mcr.microsoft.com/dotnet/sdk:8.0-windowsservercore-ltsc2022 AS build-env

# Set the working directory
WORKDIR /MauiApp3

# Copy the project files
COPY . ./

# Install required workloads
RUN dotnet workload install maui-tizen

# Enable Windows targeting
RUN dotnet restore --runtime win10-x64

# Build the application
RUN dotnet publish -c Release -o out

# Use the ASP.NET runtime image for the final image
FROM mcr.microsoft.com/dotnet/aspnet:8.0-windowsservercore-ltsc2022

# Set the working directory
WORKDIR /app3

# Copy the published output from the build stage
COPY --from=build-env /app3/out .

# Define the entry point for the application
ENTRYPOINT ["dotnet", "MauiApp3.dll"]