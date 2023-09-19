# Clean Starter Kit for Umbraco 9, 10, 11 and 12

Latest Release Details:
- Added manifest filter to enable package telemetry
- Added copy button to code snippet row
- Added authors
- Added categories
- Posts can now be shown in full in the list page
- Added an Image Carousel Row
- Added a Code Snippet Row
- Converted Old Grid to Block List
- Converted Nested Content to Block List
- Added a Video Row with lazy iframe loading
- Converted Groups to Tabs
- Works with Umbraco 9, 10, 11 and 12
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
