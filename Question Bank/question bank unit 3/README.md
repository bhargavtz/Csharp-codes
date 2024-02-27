## Short Questions [1 Mark]

1. What is polymorphism in C#?
Polymorphism in C# allows an object to take on many forms. The same method or operator can behave differently depending on the type of object it is acting on.

2. What is overriding in C#?
Method overriding in C# allows a derived class to provide a specific implementation of a method that is already provided by one of its base classes.

3. What is an interface in C#?
An interface in C# is a contract that contains only method declarations and definitions for properties, events etc. Any class that implements the interface must provide an implementation for the methods of the interface.  

4. What is a constructor in C#? 
A constructor in C# is a special method that is executed automatically when an object of a class is created. It is used to initialize the data members of new objects.

5. What is a destroyer in C#?
A destructor in C# is a method that frees up resources and performs cleanup operations when the object is destroyed. 

6. What is the base class in.NET from which all the classes are derived from? 
The System.Object class is the base class in .NET from which all other classes are derived either directly or indirectly.

7. Differences between one line method overriding and method overloading.
Method overriding occurs when a derived class has a method with same name and signature as a method in its base class. Method overloading occurs when there are multiple methods with the same name but different parameters within the same class.

8. How can we set classes to be inherited, but prevent the method from being overridden?
We can use the sealed keyword to prevent a class from being inherited and the virtual keyword along with override to prevent a method from being overridden.  

9. Why can’t we specify access modifiers for items in an interface?
Interfaces contain only declarations. The actual implementation needs to be provided by the implementing classes in .NET.

10. List the different types of constructors used in C#.
Some types of constructors in C# are default constructor, parameterized constructor, copy constructor, static constructor etc.  

11. Can you use multiple inheritance in .NET?
No, C# does not support multiple inheritance of classes. However, it does support multiple interface inheritance.

## Short Questions [2 Mark]


### 1. **What is an Object?**
   - An object is an instance of a class in C# that encapsulates data (attributes) and behaviors (methods). Objects are created based on the blueprint defined by a class.
The provided documents contain a variety of questions related to C# programming. Here are the answers to the remaining questions:

### 2. **Difference Between Struct and Class in C#**
   - **Struct:**
     - Value type.
     - Stored on the stack.
     - Cannot be inherited.
     - Does not support default parameterless constructor.
   - **Class:**
     - Reference type.
     - Stored on the heap.
     - Supports inheritance.
     - Supports default parameterless constructor.

### 3. **Data Encapsulation and Example**
   - **Data Encapsulation:** It is the concept of bundling data (attributes) and methods (behaviors) that operate on the data within a class, hiding the internal state of an object and requiring interaction through defined interfaces.
   - **Example:** In a `Car` class, private attributes like `speed` and `fuelLevel` can be encapsulated with public methods like `Accelerate()` and `Refuel()`, ensuring controlled access to these attributes.

### 4. **Inheritance in C# with Example**
   - Inheritance allows a class to inherit properties and behaviors from another class. For example:
     ```csharp
     class Animal {
         public void Eat() {
             Console.WriteLine("Animal is eating.");
         }
     }

     class Dog : Animal {
         public void Bark() {
             Console.WriteLine("Dog is barking.");
         }
     }
     ```

### 5. **Difference Between Interface and Abstract Class in .NET**
   - **Interface:**
     - Contains only method signatures.
     - Supports multiple inheritance.
   - **Abstract Class:**
     - Can have method implementations.
     - Supports single inheritance.

### 6. **Difference Between "ref" and "out" Keywords in C#**
   - Both are used for passing arguments by reference, but with a key difference:
     - `ref`: Requires the variable to be initialized before passing it to the method.
     - `out`: Does not require initialization; the method must assign a value to it before returning.

For more detailed explanations, refer to the provided search result documents[1][2].

### 7. **Can "this" be used within a static method?**
   - No, the `this` keyword cannot be used within a static method in C# because `this` refers to the current instance of the class, and static methods do not operate on instances but on the class itself.

### 8. **Extension Method in C# and How to Use Them**
   - Extension methods allow adding new methods to existing types without modifying the original type. They are defined as static methods in static classes and must be in the same namespace as they are used.

### 9. **Partial Classes**
   - Partial classes allow splitting a class into multiple files while retaining a single logical class definition. This feature is useful for separating auto-generated code from developer-written code.

### 10. **Late Binding vs. Early Binding in C#**
   - **Late Binding:** Resolving method calls at runtime, providing flexibility but potentially slower and less type-safe.
   - **Early Binding:** Resolving method calls at compile time, offering better performance and type safety.

### 11. **Conflicting Method Names in Inherited Interfaces**
   - When inherited interfaces have conflicting method names, the implementing class must explicitly implement both methods with unique names to resolve the conflict.

### 12. **Constructor Chaining in C#**
   - Constructor chaining refers to calling one constructor from another constructor within the same class or from a derived class constructor to an inherited class constructor, facilitating code reuse and initialization.
