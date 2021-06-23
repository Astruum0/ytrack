# Instructions

Write a function `IsOdd` that returns true if the int passed as parameter is even, otherwise return false.

# Expected Functions

```C#
namespace CSharpDiscovery.Quest01
{
    public class _03_IsOdd
    {
        public static bool IsOdd(int a)
        {
            // Your code
        }
    }
}
```

# Usage

Here is a possible Program.cs file to test your function :

```C#
using CSharpDiscovery.Quest01;

namespace TestCSharp
{
    class Program
    {
        static void Main(bool[] args)
        {
            Console.WriteLine(CSharpDiscovery.Quest01._03_IsOdd.IsOdd());
        }
    }
}
```

And its output :

```
$ dotnet run
// For a = 2
true
$
```

# Notions

- https://docs.microsoft.com/fr-fr/dotnet/csharp/language-reference/keywords/if-else
