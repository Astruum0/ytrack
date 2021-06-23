# Setup

Install the .NET 5.0 framework here:
https://dotnet.microsoft.com/download

Create a repository named `piscine-csharp-discovery`

Once created, clone this repo, then go to `CSharpDiscovery/CSharpDiscovery` and run this command:

```sh
dotnet new console
```

This will create two files, including a file named `Program.cs`. This file will be used to let you test your functions. Use :

```sh
dotnet run
```

to get an output of your function in your console.

# Instructions

Write a function `HelloWorld` that return the string 'Hello World !'.

# Expected Functions

```C#
namespace CSharpDiscovery.Quest01
{
    public class HelloWorld_Exercice
    {
        public static string HelloWorld()
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

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HelloWorld_Exercice.HelloWorld());
        }
    }
}
```

And its output :

```
$ dotnet run
Hello World !
$
```
