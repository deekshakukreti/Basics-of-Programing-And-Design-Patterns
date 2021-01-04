
# Dependency Inversion Principle

The class should depend on abstraction's instead of concrete implementations.

The principle states that :

1. High level modules should not depend upon low level modules. Both should depend upon abstraction.
2. Abstraction should not depend upon details. Details should depend upon abstraction.

In conventional programming, higher level componenets depends on lower level componenets as shown below.

![DIP1](https://github.com/deekshakukreti/Images/blob/main/DIP1.png)

In the above figure, the componenet A is dependent on componenet B which is dependent on component C. Due to these dependencies, higher level componenets are coupled with lower level componenets. The main objective of dependency inversion is to decouple higher level componenets dependencies on the lower level componenets. This can be achieved as part of higher level component package which define the component's external needs. This allows the component to be isolated from any particular implementation of the provided interface, thus increasing the component’s portability. Below is the figure :

![DIP2](https://github.com/deekshakukreti/Images/blob/main/DIP2.png)



