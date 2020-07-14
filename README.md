# OOP Application README
##### Lab06-OOP Part 1 of 2
##### Authors: Robert Carter, Na'ama Bar-Ilan

### Description

##### This is a C# console application that will utilize UML to plan an application that will incorporate both Inheritance and Abstraction. There are several abstract and concrete objects that are tied together utilizing inheritance, with values being shared due to abstraction. 
##### We first created the base class Animal, then created several subsidiary levels of classes that have an inheritance relationship (derived classes) with those above it. For example, Mammals and Reptiles are two created classes that inherit from the base class Animals, while several animal classes inherit from Mammals, Reptile, and Animal. We tested these relationships by creating several basic methods found within each class and testing them within the concrete animal classes. They were all able to run inherited methods from Animal, Mammal, and Reptile.

#### Getting started

##### Clone this repository to your local machine.
###### $ git clone https://github.com/racarter1215/Lab06-OOP.git

### To run this application from VS:

##### Select File, then Open, then Project/Solution
##### Find the location of the cloned Repository
##### Select Lab06OOP folder
##### Select the next Lab06OOP folder
##### Select the Program.cs document

### Application WhiteBoard
![App Image 1](./assets/Lab06UML.png)

### Technical Definitions
##### OOP Principles: Object Oriented Programming Principles, these are the fundamentals that allow us to differentiate objects with similar behavior.
##### Inheritance: The act of providing info to a derived class from a base class. This is the process of having one class take the properties and methods of another class
###### Examples of Inheritance in this project: Rattlesnake is a derived class that inherits both properties and methods from its base classes: Snake, Reptile, and Animal. One such example is the LayEgg method, which is a Reptile method that can be called by Rattlesnake.
##### Abstraction: The grouping of data that is used as a template for derived classes and can be seen without instantiating it. 
###### Examples of Abstraction in this project: The abstract classes in this project were Animal, Mammal, Reptile, and Snake. Taking Animal as an example, as an abstract class it's properties and methods were inherited by all of its derived classes. You can't instantiate and Animal itself, but you can instantiate it's derived classes using Animal properties and methods.


#### Change Log
###### 1.2: Updated UML picture and code comments - 14 July 2020
###### 1.1: App first created - 13 July 2020
