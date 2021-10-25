# Design_Patterns

**1.Singleton**

The singleton pattern is a design pattern that restricts the instantiation of a class to one object. 
Make the class of the single instance object responsible for creation, initialization, access, and enforcement. Declare the instance as a private static data member. Provide a public static member function that encapsulates all initialization code, and provides access to the instance.

The client calls the accessor function (using the class name and scope resolution operator) whenever a reference to the single instance is required.

Singleton should be considered only if all three of the following criteria are satisfied:

-Ownership of the single instance cannot be reasonably assigned

-Lazy initialization is desirable

-Global access is not otherwise provided for

This is the UML class diagram:


![This is an image](https://miro.medium.com/max/483/1*yJhauvncMRBBNoCtQJEWaQ.png)


This class has a property that generally is private, and has a method that returns the instance of the object. 
In the “Instance” method, it’s checked if the instance of the class was already created, and if it was it will return the created instance, otherwise, 
it will create an instance, and next time that this class is called it will return the same created instance. This can be a static class or use a static method.


For Example: https://github.com/nurbilgekul/Design_Patterns/tree/master/Singleton

**2.Factory Method**

Creates an instance of several derived classes.
The Factory Method design pattern defines an interface for creating an object, but let subclasses decide which class to instantiate. 
This pattern lets a class defer instantiation to subclasses.

The Factory Method pattern is generally used in the following situations:

-A class cannot anticipate the type of objects it needs to create beforehand.

-A class requires its subclasses to specify the objects it creates.

-You want to localize the logic to instantiate a complex object.

This is the UML class diagram:


![This is an image](https://www.dofactory.com/img/diagrams/net/factory.png)

 Factory Pattern lets a class postpone instantiation to sub-classes. The factory pattern is used to replace class constructors, 
 abstracting the process of object generation so that the type of the object instantiated can be determined at run-time. 
 
 For Example: https://github.com/nurbilgekul/Design_Patterns/tree/master/Factory_Method

**3.Builder**

The Builder design pattern separates the construction of a complex object from its representation so that the same construction process can create different representations.
Builder pattern aims to “Separate the construction of a complex object from its representation so that the same construction process can create different representations.” It is used to construct a complex object step by step and the final step will return the object. The process of constructing an object should be generic so that it can be used to create different representations of the same object.

Components involved in the Builder pattern are:

AbstractBuilder - Contains the steps required for creating final concrete object.

Builder - Constructs the Individual part of the Concrete Product implementing AbstractBuilder.

Director - Construct the complete Concrete Product using Builder.

Product - A Complex Object which is required to create.

This is the UML class diagram:

![This is an image](https://www.dofactory.com/img/diagrams/net/builder.png)


This pattern allows you to vary a product's internal representation, encapsulates code for construction and representation and
provides control over steps of construction process.

For Example: https://github.com/nurbilgekul/Design_Patterns/tree/master/Builder
