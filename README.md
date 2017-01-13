## Synopsis
This is an simple example of .NET Core console application that has 3 projects.

- DotNetConsoleApp - an executable application
- ClassLibrary - a simple libarary that adds two numbers and returns the result
- ClassLibraryWrapper - another simple library that depenends on ClassLibrary. DotNetConsoleApp depends on this.

## Steps to build and run
- Follow this link(https://www.microsoft.com/net/core#windowsvs2015) to install prerequisites. Verify that you 'dotnet' command is available.
- Clone this and go to dotnet-console-app directory
- Run 'dotnet restore'. This will install dependent libraries and creates lock files. For example, project.lock.json
- Go to src/DotNetConsoleApp directory and run 'dotnet build', which will build the all .dll files from each project and place them to DotNetConsoleApp/bin/Debug/netcoreapp1.0/
- To run the application, Go to src/DotNetConsoleApp/bin/Debug/netcoreapp1.0/ then run 'dotnet DotNetConsoleApp.dll'. You should see some trivial add output.

You may also use Rider by loading DotNetConsoleApp.sln at the top level of this directory.
![Rider 1.0 EAP](https://github.com/jaekwonpark/dotnet-console-app/blob/master/Program_cs_-_DotNetConsoleApp_-____work_src_github_com_jaekwonpark_dotnet-console-app_DotNetConsoleApp_sln__-_Rider_1_0_EAP.png)
