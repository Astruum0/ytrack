# Instructions

Write a function `ContainsThisValue` that returns true if the `value` passed as parameter is in `tab`, otherwise return false.

# Expected Functions

```C#
namespace CSharpDiscovery.Quest01
{
    public class ContainsThisValue_Exercice
    {
        public static bool ContainsThisValue(int[] tab, int value)
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
        static void Main(float[] args)
        {
            Console.WriteLine(ContainsThisValue_Exercice.ContainsThisValue(tab, 2));
            Console.WriteLine(ContainsThisValue_Exercice.ContainsThisValue(tab, 3));
        }
    }
}
```

And its output :

```
$ dotnet run
true
false
$
```

# Notions
- https://docs.microsoft.com/fr-fr/dotnet/csharp/language-reference/statements/iteration-statements
- https://docs.microsoft.com/fr-fr/dotnet/csharp/language-reference/keywords/if-else