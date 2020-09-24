# Introduction-to-OOP
In this section you will be able to understand basic concepts of OOP and how they are implemented in day today life.

# Evolution of OOP
During the 1980's, procedural-oriented programming languages such as C, Pascal and Fortran were widely used to develop business-oriented software systems. Procedural languages organise from top to bottom i.e. the program is a series of steps that run one after another. These type of programs were easy to manage with few hundred lines of code, but it was difficult to manage when they become large. In order to overcome this challenge, structured programming was introduced which would break down the code into functions or procedures. Although it was an improvement, the program failed to perform complex business logics as it was difficult to maintain the code. Existing functionality was not easy to alter without impacting other dependent functionality which affected other systems.

Next came the object-oriented programming methods and programming language. The benefits included :

1. The ability to maintain and implement changes in the programs more efficiently and rapidly.
2. The ability to reuse code componenets in other programs.
3. The ability to create a more intuitive graphical-user interface for users.

# Basic Characterstics of OOP
In this section we will understand what is common to all OOP languages and their fundamental concepts. The implementation of all the concepts below can be found in above folders.

## Objects
Objects are structures for incorporating data and procedures/method for working with that data. For example, you are an object with data like height and weight. You have methods that perform task like walking and eating.   

## Abstraction
When working on objects, it is very important to know the subset of their properties. And when these properties are abstracted or filtered out, it becomes easy to process the information and make the task easy.
For example, if we interact with same object then we might be insterested to know different subset of properties of the object. When you go out to purchase a laptop for professional work, you need to know the Processor and RAM of the laptop. Because the laptop also has Graphics card, you don't find the need to know about it. However, if the gamer is interested to know about the graphics card in the laptop as this information is critical to him and will not filter it out.

## Encapsulation
Encapsulation is the process in which no direct access is given to the data instead it is kept hidden. In order to have access to the data, you need to interact with the object beholding that data. 
Encapsulation is very common in daily life. Say for example, the human resource department is responsible to encapsulate(hide) the records of each employee. They are the one who would carry on request to update the records. They determine how the data can be manipulated or shared on requests.
Encapsulation helps to keep the data secure and reliable. You are aware how the data will be manipulated or accessed. This helps in making programs easy to maintain and simplifies debugging.

## Polymorphism
Polymorphism means same name different forms. It is the ability of two different objects that respond to the same request in their own unique way. One good example is where we know that a dog barks and a bird chirps. We train bothe of them in a manner that when we command them to speak, then the dog will respond with bark and the bird will respond with chirp. Another good example, is where you send a message to printer object to print message on text page and also send the same message to the screen object to display the same message on screen.
In OOP, this type of polymorphism can be implemented by overloading. Different methods of an object can be implemented that have the same name. The object can then tell which method to implement depending on the type of arguments passed on the message.

## Inheritance
Inheritance is used to classify the objects according to their characterstics and functions. Objects become easier to work with and more instinctive. The programming becomes easier as it helps to bind the general characterstics into the parent class and then inherit these characterstics in child object. For example, the employee in the company is the base class which have all the characterstics related to it. However, the manager is the child class which is derived from employee class and also have unque characterstics of the manager role in the company. 
