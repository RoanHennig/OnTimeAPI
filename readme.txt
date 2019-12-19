Starting up the project using Visual Studio:  (Recommended version - VS Community 2019)

1. Open the project

2. Open Package Manager Console

3. Run the following command
    Update-Database

4. Run the project

Reference:

https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli


Running the database migration without Visual Studio:

https://github.com/aspnet/EntityFramework6/issues/1053

Example:

dotnet exec \
  --depsfile ./bin/Debug/netcoreapp3.0/MyApp.deps.json \
  --runtimeconfig ./bin/Debug/netcoreapp3.0/MyApp.runtimeconfig.json \
  ~/.nuget/packages/entityframework/6.3.0/tools/netcoreapp3.0/any/ef6.dll \
  --assembly ./bin/Debug/netcoreapp3.0/MyApp.dll \
  database update