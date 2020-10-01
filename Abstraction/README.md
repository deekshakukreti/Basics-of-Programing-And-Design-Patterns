# How to Create Abstract Class ?

## Abstraction in C#

It is the need while coding that the base class should not be instantiated. It is the derived class that have access to the methods and properties of base class. In this scenario the base class with abstract modifier is created.

Here is the example of Abstract class :

```csharp

namespace ConsoleApp2
{
    public abstract class Shape
    {
        public abstract void GetNumberofCorners();
    }

    public class Pentagon : Shape
    {
       /*
        * Method : GetNumberofCorners
        * Output Parameter : Write the output
        */

       public override void GetNumberofCorners()
       {    
            Console.WriteLine("Pentagon has five corners.");
       }

       static void Main(string[] args)
       {
            Pentagon objPentagon = new Pentagon();                
            objPentagon.GetNumberofCorners();
       }
    }
}

```

Few things that are important with an Abstract class is :
1. An abstract class can never be instantiated.
2. An abstract class can contain abstract method and accessors.
3. A non-abstract class derived from an abstract class must include actual implementations of all inherited abstract methods and accessors.

## Abstraction with Python

Python introduces the idea of Abstract Base Classes(ABC). 

```python
"""
Created on Fri Sep 30 14:16:41 2020
@author: Deeksha Kukreti
"""
from abc import ABC, abstractmethod
 
class Shape(ABC):
    
    @abstractmethod
    def GetNumberofCorners(self):
        pass
        
class Pentagon(Shape):

    def GetNumberofCorners(self):
        print("Pentagon has five corners.")
        
x = Pentagon()
x.GetNumberofCorners()

```

# Summary

This section describe how the abstract can be implemented in Python and C#. In the next section, I will explain Encapsulation and it's implementation.

