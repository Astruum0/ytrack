# Instructions

Create a filename `Truck.cs` with the same namespace `CSharpDiscovery.Quest04`.

Create a class named `Truck` and make it inherit from `Vehicule`, found a way to also add a property `Brand` to your truck, but without having some duplicated code with your `Car` class (try to remember your parent `Vehicule` class)

Add an Integer property `Tonnage` to your `Truck` class.

Using the keyword `base()`, create a constructor that requires the following arguments: `Color`, `Speed`, `Brand` and `Tonnage`

Redefine the method `WhoAmI` so that it prints something like that: "I'm a (Color) (Brand) truck of (Tonnage) tons, and I'm moving at a speed of (Speed) km/h"

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
            var RandomVehicule = new Vehicule("blue", 30, "");
            var Megane = new Car("red", 50, "Renault", "Megane");
            var RenaultTruck = new Truck("black", 30, "Renault", 1000);

            Vehicule.WhoIsThere();
        }
    }
}
```

Normally, your code is supposed to output this:

```
$ dotnet run
---------------------------------
I'm a blue vehicule and I'm moving at a speed of 30 km/h
I'm a Red car (Renault/Megane) and I'm moving at a speed of 50 km/h
I'm a Black Renault truck of 1000 tons, and I'm moving at a speed of 30 km/h
---------------------------------
$
```
