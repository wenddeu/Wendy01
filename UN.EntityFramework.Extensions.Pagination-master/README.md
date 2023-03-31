# UN.EntityFramework.Extensions.Pagination
EntityFramework query extension for getting page data from database for views

[![NuGet version](https://badge.fury.io/nu/UN.EntityFramework.Extensions.Pagination.png)](https://badge.fury.io/nu/UN.EntityFramework.Extensions.Pagination) ![Build and Publish](https://github.com/umairsyed613/UN.EntityFramework.Extensions.Pagination/workflows/Build%20and%20Publish/badge.svg) [![Nuget](https://img.shields.io/nuget/dt/UN.EntityFramework.Extensions.Pagination)](https://www.nuget.org/packages/UN.EntityFramework.Extensions.Pagination)

### Getting started

Install the [UN.EntityFramework.Extensions.Pagination](https://www.nuget.org/packages/UN.EntityFramework.Extensions.Pagination/) package from NuGet:

```powershell
Install-Package UN.EntityFramework.Extensions.Pagination
```

### Information

TakePageResult method is the IQueryable<T> extension method. which adds the skip and take to your IQueryable Query. It can be used with your any generic list or entity framework query.

PagedResult<T> is the generic class which have the 4 paramaters which you can use to return data its really up to you if you would want to use this class.

IPageQuery is a interface which holds all the parameter required for pagination which must be passed in your query.



### How it works

Example 1
```charp
public asyc Task<PagedResult<YourModel>> GetMyModelsByPage(IPageQuery pageQuery)
{
	var result = await dbcontext.Table
                .TakePageResult(pageQuery).ToArrayAsync();

	var totalItems = result.Count;
	
    return new PagedResult<YourModel>
    {
        TotalItems = totalItems,
        PageSize = pageQuery.PageSize,
        PageNr = pageQuery.PageNr,
        Result = result
    };
}
```

Example 2
Get all the list of persons based on name from your database

```csharp
public class MySearchQuery : IPageQuery
{
	public string Name { get ; set ; }	
	public int PageSize { get ; set ; }
	public int PageNr { get ; set ; }
}

public asyc Task<PagedResult<Person>> GetPersonsByNameAndPageResult(MySearchQuery searchQuery)
{
	var result = await dbcontext.Persons.Where(w => x.Name == searchQuery.Name)
                .TakePageResult(searchQuery).ToArrayAsync();

	var totalItems = result.Count;
	
    return new PagedResult<Person>
    {
        TotalItems = totalItems,
        PageSize = searchQuery.PageSize,
        PageNr = searchQuery.PageNr,
        Result = result
    };
}

```

### Sample Running App

Find the sample running application [here](https://github.com/umairsyed613/UN.EntityFramework.Extensions.Pagination/tree/master/Src/Samples/SampleBlazorWeb)

![Sample](https://github.com/umairsyed613/UN.EntityFramework.Extensions.Pagination/blob/master/SampleRunningApp.gif)
