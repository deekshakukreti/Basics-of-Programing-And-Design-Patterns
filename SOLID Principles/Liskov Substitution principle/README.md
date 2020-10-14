
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









