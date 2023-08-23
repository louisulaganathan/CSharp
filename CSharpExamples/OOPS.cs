/*
     * classes are datastructure that combines the state[fields] and actions[methods and other function members] in a signle unit
     * Only single inheritence is allowed in c#. A class can implement from one base class.However a class can implement more than one interface.
     * class ChildClass: BaseClass {}
     * class DerivedClass: IInterface1, IInterface2 {}
     * class Derivedclass: BaseClass, IInterface1{}
     * Access Modifiers
     *      1) public              - can be accessed within the same assemble or another assembly
     *      2) private             - Type or member can be accessed only by the code in the same class or struct
     *      3) protected           - Can be access by the code in the same class or the derived class
     *      4) internal            - Type or member can be accessed by the code in the same assesmbly
     *      5) protected internal  - can be accessed by the code in the same assembly or from within a derived class from another assembly
     *      6) private protected   - can be accessed by the types derived from the class in the same assembly
     *      
     * Gerneric classes encapsulate the operations that are not specific to any particular data typle.
     * Most common use of generic class is with collection like linkedlist, hash table, stack, queue tree etc.
     * delegate is a type that represents the reference of the methods with a particular parameter list and return type.
     * When we instantiate the delegate you can associate any compatible methods.delegates allow method to be passed as parameters
     * delegate can be used to define the callback functions
     * public delegate int delegateName(int x, int y)
     * 
     * A class can't inherit from more than one class directly however the baseclass itself can inherit from another base class. So A class might
     * indirectly inherit from multiple base class
     * Abstract class can't be instantiated. They can only be used through derviced classes that implement abstract methods.
     * 
     * sealed classes doesn't allow other classes to inherit from it
     * 
     * Abstraction 
     *         Modeling the relevant attributes and interactions of entities as classes to define an abstract representation of a system.
     * Encapsulation 
     *         Hiding the internal state and functionality of an object and only allowing access through a public set of functions.
     * Inheritance 
     *          Ability to create new abstractions based on existing abstractions.
     * Polymorphism 
     *          Ability to implement inherited properties or methods in different ways across multiple abstractions.
     */

/*
 * Arrays - Single dimention int[] obj = new int[3]; int[] arr = new int[3] {1,2,3}; int[] arr = {1,2,3};
 * Multiple Dimention => int[,] obj = new int[2,3]; int[,] arr = {{1,2,3},{4,5,6}};
 * Jaggerd array => int[][] obj = new int[2][]; obj[0] = new int[3]{1,2,3};

* OOPS:
* Class,Struct or record types are like blueprints that specifies what the type can do.
* An object is an instance of a class. Object is basically a block of memory that has been allocated and configured according to the blueprint.
* 
* Encapsulation:
*      Class or struct types can specify how accessible each of its members to code outside of class or struct
*      Methods and variables that aren't intended to use outsdie of class or assembly can be hidden to limit the coding errors or malicious exploits
*  Members Fields, constants, properties,Methods, constructors, Events, Finalizers, Indexers, Operators,Nested type   
*  Access modifiers helps to set the acess levels
*      public - Members can be accessible from anywhere and no restriction 
*      protected - Member is accessible within the class and its derived class
*      private   [default] - member is accessible within the class
*      internal  - members are accessible within the same assembly
*      protected internal - members are accessible within the same assembly and derived classes in other assembly.
*      private protected - Member is accessible within the class and its derived types withing the assembly.
*      
* Inheritence: [only class, structure doesn't support inheritence]
*      A class can be dervied from another class is called inheritence.
*      Derived class automatically contains all the public, protected & internal members of base class except constructor and finalizers
*      
*   Abstract class:   
*      Class can be declared as abstract means that one or more methods have no impln.
*      An abstract class can't be instantiated. they can serve as base class for other classes which should provide missing impln.
*      
*   Sealed class:
*      Class can be declared as sealed to prevent other classes from inheriting from them.
*      
*   Interfaces:
*      Interface is a reference type which will have Members for group of related functionalities
*      class, struct and records can implement multiple interface. 
*      Interface can have only method definition/declaration not impln. 
*      Interface may have default implementation for methods.
*      Interface may have the static methods which must have an impln. Derived type doesn't have to implement the methods with default impln.
*      Can't be instantiated 
*      Derived classes must implement all the methods defined in the interface.
*  
*  Generic Type:    
*      Class, Struct and records can be defined with one or more type parameters class<tkey,tValue>, class<T>. Client code supply this type 
*  while it creates the new instance.
*  Static Type: 
*      Static Class:[Class  not the struct or record]
*          Static class can contain only the static members. can't be instantiated with new keyword.
*          only one copy of the class is loaded into the memory when the program loads.
*          It is sealed
*      Static members: public static string code = "C1"
*          Non static class can have static fields,properties & events.
*          Static members can be accessed using className.staticmember.
*          Static members can share only one copy regardless of number of instances of the class.
*  Nested types: 
*      class, struct and record can be nested inside another class, struct and record. 
*  Partial Types:
*      Partial class:
*              Class can be partially defined in multiple code files
*              working on large projects where multiple dev work on the same class.
*              when using Code generators to generate and add additional func in class
*      Partial methods:
*          One part of the class contains the signature of the method. An implementation can be defined in the same part or another part.
*          It doesn't have any accessibility modifiers (including the default private).
        It returns void.
        It doesn't have any out parameters.
        It doesn't have any of the following modifiers virtual, override, sealed, new, or extern.
*  Object Initializer:
*    objects can be initialized using objectinitializer using declarative manner.
*    sample obj = new Sample{ prop1 = value}       This will not invoke only the parameterless constructor but initialize the prop.
*    sample obj = new Sample(prop1);               This will invoke parameterized constructor where we have to initialize prop1
* 
* AnonymousTypes:
*      Anonymous types provide a convenient way to encapsulate a set of read-only properties into a single object 
*      without having to explicitly define a type first
*      var v = new { Amount = 108, Message = "Hello" };
*      Used in select clause of LINQ query expressions
*      
* 
* 
*  Because classes are reference types, a variable of a class object holds a reference to the address of the object on the managed heap
*      Obj1.Equals(obj2) compare the memory address of both objects
*  Because structs are value types, a variable of a struct object holds a copy of the entire object.
*      Struct1.Equals(struct2) compare the values of entire objects
*  If ClassC is derived from ClassB, and ClassB is derived from ClassA, ClassC inherits the members declared in ClassB and ClassA.
*      
*      
*  Polymorphism:
*       Polymorphism means many forms/shapes. 
*       An object can refer to the multiple types like base type or dervived type.
*       When this polymorphism occurs, the object's declared type is no longer identical to its run-time type.
*       Baseclass obj = new dervied class();
*       
*       Static Polymorphism:
*           The process of associating the object to the methods during compile time is called early binding
*           
*           Function overloading  - The process of defining multiple methods with same function signature within a class
*           Operator overloading - The process of providing alternate implementation for built in operators.
*           Overloaded operators are functions with special names the keyword operator followed by the symbol
*       
*       Dynamic Polymorphism:
*           An object of a derives class can sometime treated as object of the base class.
*           An object can change its behavior dynamically at runtime.
*           
*           Overridding: The process of redefining the base class methods in the derived class. 
*                   Base class method should be marked as virtual.
*                   Function signature and return type should match with override keyword.
*           
*                   Achieved using inheritance, Abstract class & Overriding
*                   
*  An interface provides another way to define a method or set of methods whose implementation is left to derived classes.                
*                   
* 
*       
*      
*/

