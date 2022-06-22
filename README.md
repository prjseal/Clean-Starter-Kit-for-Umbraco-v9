# Clean-Starter-Kit-for-Umbraco-v9

## Now updated to use Bootstrap 5

This works with Umbraco 9 and 10 now

To try it out on Windows, Mac or Linux, make sure you have downloaded the latest .Net 6 SDK and then run this block of commands in a folder somewhere.

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
