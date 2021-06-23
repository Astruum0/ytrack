# Instructions

Write a function `NextTrafficLightColor` that returns the next traffic color based on the traffic color passed as parameter, if the color 'None' is passed as parameters, you will need to return the None color back

In order to do this exercice, you will need to download the `TrafficLightColor.cs` file [here]() that contains an enum of all 3 colors Green, Orange and Red. Place this file in a `Models` folder

# Expected Functions

```C#
namespace CSharpDiscovery.Quest01
{
    public class NextTrafficLight_Exercice
    {
        public static TrafficLightColor NextTrafficLight(TrafficLightColor currentColor)
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
using CSharpDiscovery.Quest01;
using CSharpDiscovery.Models;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NextTrafficLightColor_Exercice.NextTrafficLightColor(TrafficLightColor.Red));
            Console.WriteLine(NextTrafficLightColor_Exercice.NextTrafficLightColor(TrafficLightColor.Orange));
            Console.WriteLine(NextTrafficLightColor_Exercice.NextTrafficLightColor(TrafficLightColor.None));
        }
    }
}
```

And its output :

```
$ dotnet run
Green
Red
None
$
```

# Notions

- https://docs.microsoft.com/fr-fr/dotnet/csharp/language-reference/builtin-types/enum
