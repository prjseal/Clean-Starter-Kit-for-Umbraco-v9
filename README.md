# Clean-Starter-Kit-for-Umbraco-v9

## Now updated to use Bootstrap 5

To try it out on Windows with SqlCe, make sure you have downloaded the .Net 5 SDK and then run this block of commands in a folder somewhere.

```ps
# Ensure we have the latest Umbraco templates
dotnet new -i Umbraco.Templates

# Create solution/project
dotnet new sln --name MySolution
dotnet new umbraco -n MyProject --friendly-name "Admin User" --email "admin@admin.com" --password "1234567890" --connection-string "Data Source=|DataDirectory|\Umbraco.sdf;Flush Interval=1" -ce
dotnet sln add MyProject
dotnet add MyProject package Clean

# Run
dotnet run --project MyProject
# Site should be running now
```
