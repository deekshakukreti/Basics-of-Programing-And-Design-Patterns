
# Single Responsibility Principle

There should not be more then one reason for a class to change.

It is the concept that instructs developers to write code that has only one reason to change. If suppose class has more then one reason to change, then it will have multiple responsibilities. So class with more then one responsibility can be broken down to small classes, each of which will have one responsibility and one reason to change.

It is a concept of a class doing one single thing at a time and not trying to do more then it. It is also referred as high cohesion.


Why is it important to seperate two responsibilitites into two classes ?
Because it is easy to maintain code as responsibility is an axis of change. If the requirement changes, the change will be implemented by change in responsibility among the classes. If a class will perform multiple responsibilitites, then there will be multiple changes in the class.

With more then one responsibility in class, the classes are coupled. If the classes are coupled, then changes in one responsility might break the other responsibility. This design leads to fragile design that breaks in unexpected ways when changed.

For example two different applications Computational Geometry Application and Graphical Application uses a Square class which have Draw method and Area method. The Computational Geometry application does not draw square on the screen but the Graphical application does draw square on the screen.

This design violates the SRP. This is because, it has more then one responsibility in the class. Secondly, if a change to the Graphical Application causes the Square to
change for some reason, that change may force us to rebuild, retest, and redeploy the Computational Geometry Application. The application will break if it is not done.

Below is the SPR followed design class structure :

<p align="center">
  <img width="460" height="300" src="https://github.com/deekshakukreti/Images/blob/main/spr.png">
</p>

With the help of delegation and abstraction, the class which contain more then one responsibilitites could delegate responsibilities to other classes. 
