
# Polymorphism

## Polymorphism with C#

As the name suggest poly means different forms. Say for example Bill Gates. He is a software developer, philanthropist and a businessman. He is one individual, but have different roles and perform different tasks. This is polymorphism.

In C# their are two types of polymorphism. They are :

1) Static polymorphism 
2) Dynamic polymorphism

## Static Polymorphism

Static polymorphism is a polymorphism where the role of the menthod is determined at the compilation time. Examples of static polymorphism is method overloading and operator overloading.

Let's first consider example of method overloading.

```CSharp
public class calculator
{
  public int MultiplyNumbers(int Num1, int Num2)
  {
      return Num1 * Num2
  }
  
  public double MultipleNumbers(double Num1, double Num2)
  {
      return Num1 * Num2
  }
}
```

It is called method overloading because the name of the method is the same, however the parameters are different.

The next example is of operator overloading.

```CSharp
public class MyCalculator
{
    public int a;
    public int b;
        
    public MyCalc(int a, int b)
    {
        this.a = a;
        this.b = b;
    }

    public static MyCalculator operator +(MyCalculator a, MyCalculator b)
    {
        return new MyCalculator(a.a * 3 ,b.b * 3);
    }
}
```

In the above example (+) operator is overloaded with another sort of calculation. If we add two MyCalculator objects, the result will be sum of objects. This will happen at the compile time.

## Dynamic Polymorphism

This is related to abstract class. It is achieved by different methods in different classes can use or implement abstract class, the polymorphic nature is achieved.


# Polymophism with Python
