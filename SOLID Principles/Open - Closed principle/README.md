
# Open - Closed Principle

Bertrand Mayer in 1988 paraphrased that software entities should be open for extension, but closed for modification.

What is that Open - Closed Principle brings to us ? When a single change in program results
in cascade of changes to dependent modules, the program becomes fragile, rigid, unpredictable and
unreasonable. The open - closed principle emphasise that modules should not change. If their is 
a change in requirement then it should be extended by adding new code, and not by changing old code that already
works. Modules in Open - Closed principle are open for extension and closed for modification.

Module that cannot be changed is considered to have a fixed behaviour, however the module that is changed
is extended with new funcionality. The question is how can these two opposing attributes be implemented?
It is possible by abstraction as they are abstract base classes. It is easily possible to make changes to
abstract classes. For example, in the below figure both client and server classes are not abstract. If the client
class want to use different server class, then the client class will be changed to name the new server class.

<p align="center">
  <img width="450" height="250" src="https://github.com/deekshakukreti/Images/blob/main/cp.png">
</p>

However, in below figure the ServerAbstract class is an abstract class with virtual member functions. The client
class uses this abstraction. The object of client class will be using the object of the derivative of the server class.
A new serverAbstract class can be created, if we want to use object of the new server class. The client class remain
unchanged.


<p align="center">
  <img width="460" height="300" src="https://github.com/deekshakukreti/Images/blob/main/op.png">
</p>

