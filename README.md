# Lab09-LINQ
- Our task is to read a file containing neighborhoods in New York City, while filtering and organizing that data.
- A project for practicing the use of LINQ to read data in .NET C#.

## Feature Tasks:
1. Output all of the neighborhoods in this data list (Final Total: 147 neighborhoods)
2. Filter out all the neighborhoods that do not have any names (Final Total: 143)
3. Remove the duplicates (Final Total: 39 neighborhoods)
4. Rewrite the queries from above and consolidate all into one single query.
5. Rewrite at least one of these questions only using the opposing method (example: Use LINQ Query statements instead of LINQ method calls and vice versa.)

![App in Action](assets/LINQInActionIncomplete.png)

## Instructions:
1. git clone this repo onto your local machine.
2. open visual studio, and select the option to open a current project.
3. Navigate to the folder where you cloned the repo, and select LINQInManhattan.sln to open.
4. Make sure you're in the solution explorer, and click the green play button to debug.

## Approach:
- This code first reads in all the text from data.JSON, and converts it to the C# class type DataObject. We have a class structure that directly translates all the properties of the JSON object into a corresponding C# object.

## Status:
- Project complete for all five feature tasks