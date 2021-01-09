# Creational Design Patterns

The different types of design patterns are :

1. Singleton design patterns
2. The Factory Patterns


## Singleton design patterns

It is used to have a single instance of class in the entire application.

### Benefits of Singleton class

1. Shared State : A singleton class can be used to store your applications state. This is more common in mobile apps or console applications and 
   not so common in web apps and APIs.

2. Avoid Long Initialisations : Imagine having a class that has some very complex logic in its constructor. If not absolutely necessary you shouldn't 
   have to instantiate it multiple times in your app. The singleton is also a decent way to achieve communication between different classes that 
   can serve it.
   
3. Perfectly represent unique items : For example in the games with single player, we need not to instatiate players everytime. Hence, singleton
   class can be used to create single player once.

### Key implementation Points

1. Private constructor otherwise we are exposing a way to create an instance of our class and that defeats the whole purpose of having a singleton.
2. Read-only instance variable. We don't want other classes to be able to change where the instance reference points to
3. Static instance 
4. Static accessor
5. The class should be sealed so that it is not inherited.
5. Instance initialised in a static constructor. This is second constructor in the class which is not private. It is responsible for initializing our instance, 
   only once because we are using a singleton
   


   