
# The Liskov Substitution Principle

The Liskov substitution principle says that the function that use pointers or reference to base classes
must be able to use objects of derived classes without knowing it.

It is basically, a collection of guidelines for creating inheritance hierarchies in which client can reliably use any class or subclass without compromising the expected behaviour. If the rules are followed then client can remain unaware of the changes to any class hierarchies. However, if LSP is not followed then, an extension to a class hierarchy—that is, a new subclass—might necessitate changes to any client of the base class or interface. The LSP, therefore, helps to enforce both the open/closed principle and the single responsibility principle.

## Formal Definition

The official definition says that if  S is a subtype of T, then objects of type T may be replaced with objects of type S, without breaking the program.

The three code ingidients relating to the LSP:

1. Base Type : The type(T) that client has reference to.
2. Sub Type : Any one of a possible family of a classes (S) that inherit from the base type (T). Client should not be aware of which subtype they are calling, nor they need to know. The client should behave the same regardess of the subtype instance that is given.
3. Context : The way in which the client interacts with the subtype. If the client does not interact with the subtype, the LSP can niether be honoured or contravened.

## Design by Contract

Contract rules are related to expectations of the classes. These rules relate to the contract of the supertype and the restrictions placed on the contracts that can be added to the subtype.

Using this scheme, method of classes declare preconditions and postconditions. Preconditions are defined as all the conditions necessary for a method to run reliable and without any fault. Upon completion, the method guarantees that the postcondition will be true. .when redefining a routine [in a derivative], you may only replace its precondition by a weaker one, and its postcondition by a stronger one.

In other words, when using an object through its base class interface, the user knows only the preconditions and postconditions of the base class. Thus, derived objects must not expect such users to obey preconditions that are stronger then those required by the base class. That is, they must accept anything that the base class could accept. Also, derived classes must conform to all the postconditions of the base. That is, their behaviors and outputs must not violate any of the constraints established for the base class. Users of the base class must not be confused by the output of the derived class.


## Conclusion

The open-closed principle is the heart of object oriented design.The Liskov Substitution Principle (A.K.A Design by Contract) is an important feature of all programs that conform to the Open-Closed principle. It is only when derived types are completely substitutable for their base types that functions which use those base types can be reused with impunity, and the derived types can be changed with impunity







