# DesignPatterns
 
 **Singleton Design pattern** ==> It is a creational design pattern, that is used to ensure that there is only one instance of the class during the whole life time of the application.

  How to Implement :- 
    1. make the Ctor Private.
    2. make a public Field (Instance here), that can create the object at the first time, and always return the cached one if it is already created.
    3. make a public function that holds the logic u want to do (Like loading the Lookups, Loading data from appsettings, any action), and use this function from the instance u created above.
    
    
Pros => 
  1. Data sharing, the same Instance with its properties is shared across the whole app.
  2. Memory efficient, u have created only one object in the memory, not a new one with each call.
    
Cons => 
  1. **Global state** => into the application, which makes it is hard to debug and test the code, as the instance is shared accross the app
    a. Example => Suppose u have a configuration class (as a singleton), and this has a public method that returns the same instance to all callers, and also a public method that change the state of this configuration class
                  and this class has been called from two different places at the same time and each one has changed the state of the configuration class, this will lead to an issue.
  2. **Coupling** => a singleton, can make ur application tightly coupled, So it is hard to test and maintaine in the future.
  3. Multithreading => a singleton, can make an issue for multithreading apps, (Race conditions happen)
      a. suppose u have a singleton class, and has a function that sets how many times, this function has been called
      b. and there is two places (threads) at the same time called this function to increase the counter of the method calls, in this time **race condition happens**, and the counter variable will not be correct.
      b. Diffcult to test, (write unit testing).
      
      
**Strategy Desing Pattern** => It is used when the behaviour of an entity will change during the run time of the application

How to Implement => 
 1. make an Interface that contain the method, that its behaviour will change during the run of the application
 2. create a different class for each behaviour u expect to have during the runtime, and Implement this interface and Implemnt its function
 3. then u can use this Interfac as an instance an call the sutable implementaion u need to have.

Pros => 
 1. U encapsulated ur code.
 2. Easy to add new strategy.
 3. Open/Closed Pattern.
 4. Improves Clean code.

Cons => 
1. more Complixitey in your application. 

**Adaptor Design Pattern ** => It is used when u need to integrate with two applications that are incompatable with each other

How to Implement => 
 1. Create a middle layer of the classes u want that connects the two applications, and use this class.

Pros => 
 1. allows you to use existing code
 2. Add flexiability, as u can connect with any system u need.
 3. no need to change the client code

Cons => 
1. Add more complexity to ur code.
2. may lead to performance issues, as there is a new layer between the two applications now, needs to be created


**Simple Factory Design pattern** => it is a creational design that hide the creation of an object from the client, by hiding it in its own place (function), this function will take parameters and based on it, it will return the correct object.

How to implement :- 
 Create a class, with a function, that return different (return the parent) objects, based on the function parameters



 pros => 
    1. Encapsulation:- it encapsulate the creational logic into one function.
    2. Abstraction :- it abstract the creational logic from the client. 
    3. Code centeralization :-  all the creational code in one place.

cons => 
    1. Violets the Open/closed principle. 
    2. tightly coupled with concrete classes.
    
**Template Method Design Pattern** => it is a pattern where the base class provide the skeleton of a specific method, which implemenation will vary in the child classes of this base.

 How to Implement :- 
  1. create a parent class as abstract, and in this class define the function (which has different logic in each child)
  2. create the subclasses and Inherit from the parent, and Implement the function logic for each child.

   Pros ==>  
    1. Reusability, the parent class is used in each child.
    2. flexability, we can have more childs each one with its implementation.
    
    
 **Factory Method Design pattern ** ==> this design pattern provides an interface for the object creation, and the instianting of this class will be in the sub classes

  Example on the Implementation => 
```
// Abstract Product
public interface IAnimal
{
    void MakeSound();
}

// Concrete Products
public class Dog : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Woof!");
    }
}

public class Cat : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Meow!");
    }
}

// Abstract Creator
public abstract class AnimalFactory
{
    // Factory Method
    public abstract IAnimal CreateAnimal();

    // Other methods
    public void DoSomething()
    {
        IAnimal animal = CreateAnimal();
        animal.MakeSound();
    }
}

// Concrete Creators
public class DogFactory : AnimalFactory
{
    public override IAnimal CreateAnimal()
    {
        return new Dog();
    }
}

public class CatFactory : AnimalFactory
{
    public override IAnimal CreateAnimal()
    {
        return new Cat();
    }
}

// Client code
public class MainClass
{
    public static void Main(string[] args)
    {
        AnimalFactory dogFactory = new DogFactory();
        IAnimal dog = dogFactory.CreateAnimal();
        dog.MakeSound(); // Output: Woof!

        AnimalFactory catFactory = new CatFactory();
        IAnimal cat = catFactory.CreateAnimal();
        cat.MakeSound(); // Output: Meow!
    }
}
```

Pros ==> 
 1.  Encapsulation :- it encapuslate the code creation in one iterface, any class (Factory class) want to have this to create its objects, should implement this interface or abstarct method.
 2.  applying the Dependency Inversion P :- which states, High Level models, should not depend on low level modules, both should depend on abstraction, and abstraction should not depend on details, details should depend    on abstraction, the client code (the last part) doesn't directly depend on the concrete class itself, but it depends on the abstarct layer (DogFactory for ex), and the Dogfactory depend on a the factory Method itself

cons ==> 
1. Adding more complexity to the code 
2. Runtime desicions




     
                  
  
