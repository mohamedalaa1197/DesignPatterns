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
                  
  
