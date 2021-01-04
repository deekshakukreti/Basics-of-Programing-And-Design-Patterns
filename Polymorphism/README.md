
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

This is related to abstract class. It is achieved by different methods in different classes can use or implement abstract class, the polymorphic nature is achieved. This type of polymorphism is also called as run-time polymorphism because of the decision about which method should be called is taken at run-time. In dynamic polymorphism, we override the base class method in derived class using inheritance, and this can be achieved using override and virtual keyword. 

```CSharp
using System;
namespace Studytonight
{
    public class Interest
    {
        public virtual double TrueBank(double amount, double rate)
        {
            return amount + (amount * rate);
        }
    }
    // first child class
    public class SimpleInterest: Interest
    {
        public override double TrueBank(double amount, double rate)
        {
            return amount + (amount * rate) + 1000;
        }
    }
    // second child class
    public class FixedInterest: Interest
    {
        public override double TrueBank(double amount, double rate)
        {
            return amount + (amount * rate) + 1500;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Interest i = new Interest();
            double finalamount = i.TrueBank(5000.00,0.1);
            Console.WriteLine("Normal interest for a holder "+finalamount);
            
            i = new SimpleInterest();
            finalamount = i.TrueBank(5000.00,0.1);
            Console.WriteLine("Simple interest for a holder "+finalamount);
            
            i = new FixedInterest();
            finalamount = i.TrueBank(5000.00,0.1);
            Console.WriteLine("Fixed interest for a holder "+finalamount);
            
        }
    }
}

```

The base class uses the virtual keyword so that it can be overriden in the derived class using override keyword. Here, we have given the same method name that is TrueBank and the same signature (number and type parameters) but different method definitions in the derived/child classes.

The we created the object of the Interest class and provided the parameter list. If you closely observe the above parameter list, you will find the same parameters have been provided for each method call. Here the compiler only requires TrueBank() method to compile successfully and at the run-time desired methods get called respectively, based on which class's object is calling it.


