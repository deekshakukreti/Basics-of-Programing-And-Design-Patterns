# Encapsulation

As the name suggests, encapsulation is hiding or covering.

## Using Access Modifiers in C#

The access modifiers available in C# are:

1) Public
2) Private
3) Protected
4) Internal
5) Protected Internal

In the coming description, I will show how the access modifiers are used in hiding class, properties or methods.

```CSharp
public class BankAccount
{
  private double AccountBalance {get;set;}
  
  protected double GetBalance()
  {
    //code to retrieve account balance from database
    return (double)10000;
  }
}
```
In the above example the class is kept public , however the property AccountBalance is not exposed to other class. It can only be used in BankAccount class. By defining above method protected, it gets accessible to the derived class but not to the client code accessing an instance of the BankAccount class.

Internal types or members are accessible only within files in the same assembly.

Below is the example how internal access modifier is used

```CSharp
//Assembly1.cs
public class Baseclass
{
    internal static int intM = 0;
}

//Assembly2.cs
//Reference of Assemble1.cs 
public class TestInternalAccess
{
    static void Main()
    {
      BaseClass objBaseClass =  new BaseClass();
      BaseClass.intM = 44  // This code will produce error because it is defined as internal
    }
}
```
The protected internal members of a class or class itself is accessible from current assembly or also accessible in a derived class located in another assembly only if the access occurs through a variable of the derived class type .

Below is the good example for protected internal access modifier.

```CSharp
//Assembly1.cs
public class BaseClass
{
   protected internal int myValue = 0;
}

class TestAccess
{
    void Access()
    {
        var baseObject = new BaseClass();
        baseObject.myValue = 5;
    }
}

//Assemble2.cs
//Reference of Assembly1.cs added
class DerivedClass : BaseClass
{
    static void Main()
    {
        var baseObject = new BaseClass();
        var derivedObject = new DerivedClass();

        baseObject.myValue = 10;        //Error on this line as myValue can only be accessed by classes derived from BaseClass 
        derivedObject.myValue = 10;     // OK, because this class derives from BaseClass.
    }
}
```

## Using Access Modifiers in Python

Python has three access modifiers. They are :

1) Public
2) Private
3) Protected

The definition of the access modifiers remain the same as in C#, however the implementation is different. Below I will show how thw aaccess modifiers are implemented in Python.

The Public memebers in Python
```Python
class employee:
    def __init__(self, name, sal):
        self.name=name
        self.salary=sal
```

Protected members are represented by single underscore (_).
```Python
class employee:
    def __init__(self, name, sal):
        self._name=name  # protected attribute 
        self._salary=sal # protected attribute
```

Private attributes are denoted by double underscore(__).

```Python
class employee:
    def __init__(self, name, sal):
        self.__name=name  # private attribute 
        self.__salary=sal # private attribute
```


# Summary
This section I have covered basic implementation of Access modifiers used to hide information to implement Encapsulation. In the next section, I will briefly explain Polymorphism.
