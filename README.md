A project that can be used to test the latest version of the [ecoCode-charp](https://github.com/green-code-initiative/ecoCode-charp) NuGet package.

### 1. Set up your local environment

- Install/update the .NET SDK on your machine, the minimum required version is specified in the ecoCode-charp's [global.json](https://github.com/green-code-initiative/ecoCode-csharp/blob/main/global.json) file.
- Clone this repository locally on your machine. Since this project is used to test the very latest ecoCode-csharp rules, including the beta versions, it is recommended to check it out often.
- Optional : install the IDE of your choice for C# (e.g. Visual Studio, Visual Studio Code, Rider, etc.) if you want to test with a GUI.

### 2. Test the rules through the CLI

- Open a command window and navigate to the solution directory.
- Run the following commands: ```dotnet clean``` then ```dotnet build```
- The 2nd command output will contain all the rules violations in the project.

### 3. Test the rules in your IDE

- Open your IDE and load the solution.
- Rebuild the solution, to make sure the NuGet packages are restored and all the code is re-analyzed.
- Open the error list window in your IDE, you should see all the rules violations in the project.
- Open one of the EC*.cs files in the project, you should see the rules violations highlighted in the code.
  - For the rules that support generated code fixes, you can use your IDE's quick action to see what the analyzers automatically propose to fix the issues.
