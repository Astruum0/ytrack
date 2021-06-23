# Instructions

Write a function `FindLastIndex` that returns the index of the last occurence of the value `a` in the `tab` passed as parameter.

# Expected Functions

```C#
namespace CSharpDiscovery.Quest02
{
    public class FindLastIndex_Exercice
    {
        public static int? FindLastIndex(int[] tab, int a)
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
        static void Main(bool[] str)
        {
            var tab = new int[] { 1, 2, 3, 4, 6 };
            Console.WriteLine(FindLastIndex_Exercice.FindLastIndex(tab, 2));
        }
    }
}
```

And its output :

```
$ dotnet run
1
$
```