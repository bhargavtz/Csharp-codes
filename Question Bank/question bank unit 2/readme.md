## Short Questions [1 Mark]
1. How can you declare variables in C#?
Variables can be declared by specifying the data type followed by the variable name, e.g. `int number;`

2. What is the use of the “object” data type in C#.NET?  
The object data type is the ultimate base class for all data types in C#. It can be used to store any type of object.

3. List at least six value types in C#.
Six value types in C# are: int, float, double, bool, char, struct

4. What is Event-Driven Programming?
Event-driven programming is based on triggering events that run code in response to user actions or system events.

5. What is an event handler? 
An event handler is a method that executes in response to an event being raised.

6. How can you declare main() in C sharp?  
The main() method in C# is declared as: `static void Main(string[] args)`

7. List out two different types of errors in C#.
Two types of errors in C# are: compile time errors and runtime errors.  

8. What are fatal errors?
Fatal errors are serious errors that cause the program to crash.  

9. Which type of mistake can cause a program to stop unexpectedly during execution?
Runtime errors can cause the program to stop unexpectedly during execution.

10. What Error Handler handles? / What is Error Handling?
Error handlers handle exceptions and other errors in a program to prevent crashing. Error handling involves trapping errors and handling them gracefully.  

11. Define the term “exception.” 
An exception is an error that occurs during execution of a program.

12. How is exception handling done in C#?
Exception handling in C# uses try-catch-finally blocks to catch and handle exceptions.  

13. Can we have only a “try” block without a “catch” block in C#?
No, a try block must be followed by either a catch or finally block, or both.

14. Why use the “finally” block in C#? 
The finally block ensures execution of cleanup code like closing files, database connections etc.  

15. How can you set breakpoint in a C sharp program?
Breakpoints can be set in C# code by clicking on the left margin of the code editor window.

### Short Questions [2 Marks]

1. **Explain the implicit variable declaration in brief:**
   - Implicit variable declaration in C# allows the compiler to infer the type of a variable based on the value assigned to it. For example, `var num = 10;` will be inferred as an integer.
   
2. **Is there any special datatype for storing Date in Visual Studio? If yes, which is it? What is the size of it:**
   - In Visual Studio, the `DateTime` data type is used to store dates and times. It has a size of 8 bytes.

3. **What is Boxing and Unboxing? or Give the difference between Boxing and Unboxing:**
   - **Boxing:** It is the process of converting a value type to the object type.
   - **Unboxing:** It is the process of converting an object back to its original value type.
   
4. **Which operator is used to concatenate two strings? Give proper example:**
   - The `+` operator is used to concatenate two strings. Example: `"Hello" + "World"` will result in "HelloWorld".

5. **What is the usage of Bitwise operator:**
   - Bitwise operators in C# are used to perform operations at bit-level. They are commonly used for tasks like bit manipulation, flags, etc.

6. **What is the ternary operator? Provide an example:**
   - The ternary operator in C# is a conditional operator that takes three operands. It is often used as a shorthand for the if-else statement. An example of the ternary operator is: `int x = (a > b) ? a : b;`, which assigns the value of `a` to `x` if `a` is greater than `b`, otherwise it assigns the value of `b` to `x`.

7. **Namespace of Math Methods in .NET and five Math methods:**
   - The namespace for Math methods in .NET is `System.Math`. Five Math methods in .NET framework include:
     1. `Math.Abs()`: Returns the absolute value of a number.
     2. `Math.Sqrt()`: Returns the square root of a number.
     3. `Math.Round()`: Rounds a number to the nearest integer or to a specified number of decimal places.
     4. `Math.Max()`: Returns the larger of two numbers.
     5. `Math.Min()`: Returns the smaller of two numbers.

8. **Difference between "continue" and "break" statements in C#:**
   - The `continue` statement is used to skip the current iteration in a loop and move to the next iteration, while the `break` statement is used to exit the loop entirely and continue with the code after the loop.

9. **Difference between "constant" and "readonly" variables in C#:**
   - **Constant variables:** Once assigned, their value cannot be changed during runtime.
   - **Readonly variables:** Their value can be assigned at runtime or in a constructor, but once assigned, it cannot be changed.

10. **Example for do and while loops executing code based on a Boolean expression:**
    ```csharp
    bool condition = true;
    do
    {
        // Code block
    } while (condition);
    ```

11. **Difference between Convert.ToInt16(), Convert.ToInt32(), and Convert.ToInt64():**
    - These methods convert values to different integer types:
      - `Convert.ToInt16()`: Converts to a 16-bit signed integer.
      - `Convert.ToInt32()`: Converts to a 32-bit signed integer.
      - `Convert.ToInt64()`: Converts to a 64-bit signed integer.

12. **What is an enum in C#?**
    - An enum in C# is a value type that defines a set of named constants representing integral numeric values.

### 13. **Passing Parameters by Reference and Value in C# (or Difference between "out" and "ref" parameters):**
   - **By Reference (`ref`):** When passing a parameter by reference, any changes made to the parameter inside the method will affect the original variable outside the method.
   - **By Value (`out`):** When passing a parameter by value, a copy of the parameter is passed to the method, and changes made to it inside the method do not affect the original variable.

### 14. **Overloading in C#:**
   - Overloading in C# allows defining multiple methods in the same class with the same name but different parameters. The compiler determines which method to call based on the number and type of arguments passed.

### 15. **Function Overloading in C# (.NET) (or Method Overloading):**
   - Function overloading (method overloading) is when multiple methods in a class have the same name but different parameters. This allows for flexibility in calling methods with different argument lists.

### 16. **String Method for Concatenation in C#:**
   - The `Concat()` method is used for concatenating two strings in C#. Example: `string result = string.Concat("Hello", "World");`

### 17. **Declaring and Initializing an Array in C#:**
   - To declare and initialize an array in C#, you can use:
     ```csharp
     int[] numbers = new int[] { 1, 2, 3, 4, 5 };
     ```

### 18. **Difference between `System.Array.Clone()` and `System.Array.CopyTo()` methods in C#:**
   - **`System.Array.Clone()`:** Creates a shallow copy of an array.
   - **`System.Array.CopyTo()`:** Copies elements from one array to another array.

### 19. **Difference between Array and ArrayList in C#.Net:**
   - **Array:** 
     - Fixed size.
     - Stores a single data type.
     - More efficient in terms of memory and performance.
   - **ArrayList:** 
     - Dynamic size.
     - Can store different data types.
     - Less efficient due to boxing/unboxing operations.

### 20. **Using Multidimensional Array in C# with an Example:**
   - To use a multidimensional array in C#, you can declare and initialize it like this:
     ```csharp
     int[,] matrix = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
     ```

### 21. **Commonly Used Exceptions in C# (.NET):**
   - Some commonly used exceptions in C# include:
     1. `ArgumentException`
     2. `ArgumentNullException`
     3. `DivideByZeroException`
     4. `IndexOutOfRangeException`
     5. `InvalidOperationException`
     6. `NullReferenceException`

### 22. **Execution of Multiple Catch Blocks in C#:**
   - Multiple catch blocks can be executed in C# if an exception is thrown that matches the type specified in each catch block. The catch blocks are evaluated sequentially from top to bottom, and the first matching catch block is executed.

### 23. **Difference between Throw Exception and Throw Clause (or "throw ex" and "throw" methods):**
   - **`throw ex`:** Re-throws the current exception, resetting its stack trace.
   - **`throw`:** Throws the current exception without resetting its stack trace.
### 24. **Complexity Provided by try-catch Error Handler:**
   - The `try-catch` error handler in C# provides complexity by allowing developers to handle exceptions and errors gracefully. It enables the separation of error-handling logic from the main code, improving code readability and maintainability.

### 25. **Difference between "ArgumentOutOfRangeException" and "IndexOutOfRangeException":**
   - **`ArgumentOutOfRangeException`:** Occurs when an argument provided to a method is outside the valid range.
   - **`IndexOutOfRangeException`:** Occurs when trying to access an array element with an index that is outside the bounds of the array.

### 26. **Statement for Raising Custom Errors:**
   - In C#, you can raise your own errors using the `throw` statement followed by an exception object or a new exception instance.

### 27. **Nested Try-Catch Block Explanation with Example:**
   - A nested `try-catch` block in C# allows for handling exceptions at different levels of code execution. Here's an example:
     ```csharp
     try
     {
         try
         {
             // Inner try block
         }
         catch (Exception ex)
         {
             // Inner catch block
         }
     }
     catch (Exception ex)
     {
         // Outer catch block
     }
     ```

### 28. **Difference between "finalize" and "finally" Methods in C#:**
   - **`finalize()`:** It is a method in C# that is used for finalization of objects by the garbage collector.
   - **`finally`:** It is a block used in exception handling to ensure that a section of code is always executed, whether an exception is thrown or not.
