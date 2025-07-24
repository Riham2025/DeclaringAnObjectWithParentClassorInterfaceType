##  Title: Declaring an Object with Parent Class or Interface Type :

This means: 

You can create an object from a child class, but use a parent class or interface as the variable type..

This is useful for polymorphism, where you can treat different objects in a uniform way.

Step 1: Basic Example:

ParentClass obj = new ChildClass(); 
IMyInterface obj = new MyClass();

📌 Explanation:

ChildClass is a class that inherits from ParentClass.

MyClass is a class that implements IMyInterface.




