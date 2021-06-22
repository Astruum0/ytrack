# Setup

Install the .NET 5.0 framework here:
https://dotnet.microsoft.com/download

Create a repository named `piscine-csharp-discovery`

Once created, clone and cd into the repo and run this command:
```sh
dotnet new console
```

# Instructions

Write a function `HelloWorld` that return the string 'Hello World !'

# Expected Functions

```C#
namespace CSharpDiscovery.Quest01
{
    public class _01_HelloWorld
    {
        public static string HelloWorld()
        {

        }
    }
}
```

# Usage

Here is a possible Program.cs file to test your function

```C#
using CSharpDiscovery.Quest01;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CSharpDiscovery.Quest01._01_HelloWorld.HelloWorld());
        }
    }
}
```

And it's output :

```sh
$ dotnet run
Hello World !
$
```
