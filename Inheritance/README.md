
# Inheritance

Not all members of the base class can be inherited. The following are :

1. Static constructor : This initialise the static data of class.
2. Instance constructore : This is called to create new instance of the class. Each class must define it's own constructor. 
3. Finalizers : This is called at the run-time by garbage collectors to destroy instances of a class.


Derived classes can also override inherited members by providing an alternate implementation. In order to be able to override a member, the member in the base class must be marked with the virtual keyword. By default, base class members are not marked as virtual and cannot be overridden. Attempting to override a non-virtual member, as the following example does, generates compiler error CS0506: "<member> cannot override inherited member <member> because it is not marked virtual, abstract, or override.
  
```CSharp

public class A
{
    public void Method1()
    {
        // Do something.
    }
}

public class B : A
{
    public override void Method1() // Generates CS0506.
    {
        // Do something else.
    }
}

```
  
In some cases, a derived class must override the base class implementation. Base class members marked with the abstract keyword require that derived classes override them. Attempting to compile the following example generates compiler error CS0534, "<class> does not implement inherited abstract member <member>", because class B provides no implementation for A.Method1.

```CSharp
public abstract class A
{
    public abstract void Method1();
}

public class B : A // Generates CS0534.
{
    public void Method3()
    {
        // Do something.
    }
}
```

