# GlobalAirports.Net

A C# wrapper for the [Global Airports DB](http://www.partow.net/miscellaneous/airportdatabase/) data.

## Installation

    PM> Install-Package GlobalAirports.Net

**THIS HASN'T BEEN DONE YET**

Since this is written atop [.Net Standard](https://docs.microsoft.com/en-us/dotnet/standard/library) [1.0](https://github.com/dotnet/standard/blob/master/docs/versions/netstandard1.0.md), it will run on the following platforms:

* .NET Core 1.0
* .NET Framework 4.5
* Mono
* Xamarin.iOS
* Xamarin.Android
* Universal Windows Platform 10
* Windows 8.0
* Windows Phone 8.1
* Windows Phone Silverlight 8.0

## Usage

Create an instance of the `GlobalAirports`

```CSharp
var globalAirports = new GlobalAirports();
```

### Get by ICAOCode

Returns an airport that matches the given `ICAOCode`, or returns `null`

```CSharp
globalAirports.GetByICAOCode("VOMM");
```

### Get by IATACode

Returns an airport that matches the given `IATACode`, or returns `null`

```CSharp
globalAirports.GetByIATACode("MAA");
```

### Get by City

Returns airports that exist in the given `city`, or returns an empty list

```CSharp
globalAirports.GetByCity("LONDON");
```

### Get by Country

Returns airports that exist in the given `country`, or returns an empty list

```CSharp
globalAirports.GetByCountry("INDIA");
```

### Get all airports

Returns all airport data as an enumerable

```CSharp
globalAirports.GetAllAirports();
```
