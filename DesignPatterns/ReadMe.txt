http://csharpindepth.com/Articles/General/Singleton.aspx
Why we should not use if - else or case for factory , maintainance and voilation of Open Close Principle
there is no factory pattern, its factory method pattern , 
use interface or abstract class but I am going with Interface for now.
caller shoiuld only know , whi he is going to instantiate> like in my console app
singleton: why not static ?
http://stackoverflow.com/questions/519520/difference-between-static-class-and-singleton-pattern
The true answer is by Jon Skeet, on another forum here.
https://bytes.com/topic/c-sharp/answers/271199-diff-between-singleton-class-static-class#post1084937

A singleton allows access to a single created instance - that instance (or rather, a reference to that instance) can be passed as a parameter to other methods, and treated as a normal object.

A static class allows only static methods.


**********--------*********
Factroy Method : In real world > you create objetc using Activator.getInstance("Type") or use some DI .i.e. Autofac
Virtual constructor
If there is just interface and many implementation then IBase IbObj = new BMW(); is not an example of Factory Method

*********--------**********




http://www.dofactory.com/net/facade-design-pattern
Facade : Provide a unified interface to a set of interfaces in a subsystem. 
Façade defines a higher-level interface that makes the subsystem easier to use.

http://www.dofactory.com/net/observer-design-pattern
Observer : Define a one-to-many dependency between objects so that when one object changes state,
 all its dependents are notified and updated automatically.