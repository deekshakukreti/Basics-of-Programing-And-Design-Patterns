
# Encapsulation

As the name suggests, encapsulation is hiding or covering.

## Using Access Modifiers in C#

The access modifiers available in C# are:

1) Public
2) Private
3) Protected
4) Internal
5) Internal Protected

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
public class TestInternalAccess
{
    static void Main()
    {
      BaseClass objBaseClass =  new BaseClass();
      BaseClass.intM = 44  // This code will produce error because it is defined as internal
    }
}
```

## Using Access Modifiers in Python
