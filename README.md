# Clean-Starter-Kit-for-Umbraco-v9

Latest Release Details:
- Converted Groups to Tabs
- Works with Umbraco 9 and 10
- Updated to use Bootstrap 5

To try it out on Windows, Mac or Linux, make sure you have [downloaded the latest .Net 6 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) and then run this block of commands in a folder somewhere.

```ps
# Ensure we have the latest Umbraco templates
dotnet new -i Umbraco.Templates

# Create solution/project
dotnet new sln --name "MySolution"
dotnet new umbraco -n "MyProject" --friendly-name "Administrator" --email "admin@example.com" --password "1234567890" --development-database-type SQLite
dotnet sln add "MyProject"

#Add starter kit
dotnet add "MyProject" package clean

dotnet run --project "MyProject"
#Running
```
