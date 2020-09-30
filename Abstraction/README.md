# How to Create Abstract Class ?

## Abstraction in C#

It is the need while coding that the base class should not be instantiated. It is the derived class that have access to the methods and properties of base class. In this scenario the base class with abstract modifier is created.

Here is the example of Abstract class :

```csharp
abstract class Shape
{
  public abstract int GetNumberofCorners();
}

public class Pentagon : Shape
{
  public int NumberOfCorners {get;set;}
  
  public override int GetNumberofCorners()
  {
    return NumberOfCorners;
  }
  
  static void Main()
  {
    var objPentagon = new Pentagon();
    objPentagon.NumberOfCorners = 5;
    objPentagon.GetNumberofCorners();    
  }
}
```
Few things that are important with an Abstract class is :
1. An abstract class can never be instantiated.
2. An abstract class can contain abstract method and accessors.
3. A non-abstract class derived from an abstract class must include actual implementations of all inherited abstract methods and accessors.

## Abstraction with Python

```python

```
