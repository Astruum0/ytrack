# Instructions

Download the `Vehicule.cs` class [here](Vehicule.cs)

- Add a second constructor that takes 2 parameters `Color` (String) and `Speed`(Int), don't forget to call the `AddToList` function at the end of the constructor as well !

- Add a `Accelerate` function that takes no argument and increase the speed by 10

- Add a `Brake` function that takes no argument and decrease the speed by 10 (the value MUST stay superior or equal to 0)

# Usage

Here is a possible Program.cs file to test your code :

```c#
using System;
using CSharpDiscovery.Quest04;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] str)
        {
            var myVehicule = new Vehicule("Rouge", 50);
            myVehicule.Accelerate();
            Console.WriteLine(myVehicule.Speed);
            myVehicule.Brake();
            Console.WriteLine(myVehicule.Speed);
        }
    }
}
```

and it's output :

```
$ dotnet run
60
50
$
```
