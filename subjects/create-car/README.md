# Instructions

Create a filename `Car.cs` with the same namespace `CSharpDiscovery.Quest04`.

Create a class named `Car` and make it inherit from `Vehicule` and add the property `Brand` and `Model` (both string)

Using the keyword `base()`, create a constructor that requires the following arguments: `Color`, `Speed`, `Brand` and `Model`

Redefine the method `WhoAmI` so that it prints something like that: "I'm a (Color) car ((Brand)/(Model)) and I'm moving at a speed of (Speed) km/h"

# Usage

Here is a possible Program.cs file to test your code :

```c#
using CSharpDiscovery.Quest04;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] str)
        {
            var myVehicule = new Car("Red", 50, "Renault", "Megane");
            myVehicule.WhoAmI();
        }
    }
}
```

and it's output :

```
$ dotnet run
I'm a Red car (Renault/Megane) and I'm moving at a speed of 50 km/h
$
```
