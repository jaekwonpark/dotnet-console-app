## Synopsis
This is an simple example of .NET Core console application that has 3 projects.

- DotNetConsoleApp - an executable application
- ClassLibrary - a simple libarary that adds two numbers and returns the result
- ClassLibraryWrapper - another simple library that depenends on ClassLibrary. DotNetConsoleApp depends on this.

## Steps to build and run
- Follow this link to install prerequisites. Verify that you 'dotnet' command is available.
- Clone this and go to dotnet-console-app directory
- Run 'dotnet restore'. This will install dependent libraries and creates lock files. For example, project.lock.json
- Go to src/DotNetConsoleApp directory and run 'dotnet build', which will build the all .dll files from each project and place them to DotNetConsoleApp/bin/Debug/netcoreapp1.0/
- To run the application, Go to src/DotNetConsoleApp/bin/Debug/netcoreapp1.0/ then run 'dotnet DotNetConsoleApp.dll'. You should see some trivial add output.


