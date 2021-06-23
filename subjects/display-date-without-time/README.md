# Instructions

Write a function `DisplayDateWithoutTime` that returns a string in the form 'Day/Month/Year' based on the DateTime passed as parameter (Ex: 23/11/2005)

# Expected Functions

```C#
namespace CSharpDiscovery.Quest02
{
    public class DisplayDateWithoutTime_Exercice
    {
        public static int DisplayDateWithoutTime(DateTime date)
        {
            // Your code
        }
    }
}
```

# Usage

Here is a possible Program.cs file to test your function :

```C#
using System;
using CSharpDiscovery.Quest02;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DisplayDateWithoutTime_Exercice.DisplayDateWithoutTime(new DateTime(2021, 1, 14)));
        }
    }
}
```

And its output :

```
$ dotnet run
14/01/2021
$
```

# Notions

- https://docs.microsoft.com/fr-fr/dotnet/api/system.datetime.tostring?view=net-5.0
