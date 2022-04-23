# StringComparator
Compare a string with another string and get the result in percent
[![Downloads](https://img.shields.io/nuget/dt/StringComparator.svg)](https://www.nuget.org/packages/StringComparator/)<br><br><br>
- 📦 [NuGet](https://www.nuget.org/packages/HG-Finance/): `dotnet add package HG-Finance --version 1.0.0` (**package**)


### Usage

- first add the library import
```csharp
using StringComparator;
```

- Comparing strings

Call the method and add the strings, we recommend that the "Original string" be the largest text/word

The result will be in decimal percentage

```chsarp 
string fist = "Programing";
string second = "program";
Console.WriteLine(Comparator.Compare(fist, second));
```

## License

The gem is available as open source under the terms of the [MIT License](http://opensource.org/licenses/MIT).
