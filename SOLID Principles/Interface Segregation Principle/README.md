
# Interface Segregation Principle

The principle states that 'Clients should not be forced to depend on interfaces that they do not use.'

Interface represent the boundaries between what cient code requires and how the requirement is implemented. This principle states that the design should have small interfaces.

Each memeber of an interface needs to be inmplemented as a whole member : properties, events and methods. Interface should contain single method that serve the single purpose. At this level of granularity, they are a king to delegates, with various added benefits. When a client depends on a class that contain interfaces that the client does not use, but that other clients do use, then that client will be affected by changes that those other clients force upon the class. To avoid coupling, it is necessary to have seperated interface wherever possible.

## Class Interfaces versus Object Interfaces

Let's take an example of a TimedDoor. Here is an object which has two seperate interfaces used by two seperate clients : Timer and users of Door. These two interfaces must be implemented in the same object since the implementation of both interfaces manipulates the same data. How can we separate the interfaces when they must remain together?

The answer to this lies in the fact that clients of an object do not need to access it through the interface of the object. Rather, they can access it through delegation, or through a base class of the object.

### Seperation through Delegation

We can employ object form of the Adapter pattern to the TimedDoor problem.The solution is to create an adapter object that derives from TimerClient and delegates to the TimedDoor.

![isp](https://github.com/deekshakukreti/Images/blob/main/DoorTimerAdapter.png)

When the TimedDoor wants to register a timeout request with the Timer, it creates a DoorTimerAdapter and registers it with the Timer. When the Timer sends the TimeOut message to the DoorTimerAdapter, the DoorTimerAdapter delegates the message back to the TimedDoor.

### Seperation through Multiple - Inheritance







