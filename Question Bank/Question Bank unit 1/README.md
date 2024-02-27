## Short Questions [1 Mark]


1. **Define Integrated Development Environment.**
   - An integrated development environment (IDE) is a software application that provides comprehensive facilities to programmers for software development. It typically includes a code editor, compiler, debugger, and other tools to streamline the development process.

2. **If the Solution Explorer Window is not visible in the project, write steps to display it.**
   - To display the Solution Explorer in Visual Studio:
     - Go to the "View" menu.
     - Select "Solution Explorer" from the list.

3. **Define Solution Explorer.**
   - Solution Explorer is a tool window in Visual Studio that provides a hierarchical view of the files, projects, and solutions in your application. It allows developers to navigate and manage the various elements of their projects easily.

4. **Give the full form of MSIL.**
   - MSIL stands for Microsoft Intermediate Language. It is an intermediate language used by the .NET Framework during the compilation of source code into executable code.

5. **What is the role of JIT Compiler?**
   - Just-In-Time (JIT) Compiler is responsible for converting the MSIL code into native machine code at runtime. It allows the .NET Framework to execute applications in a platform-independent manner by compiling code when needed on the target system.

6. **Which types of applications can make use of .NET class library?**
   - Any application developed using .NET technologies, such as Windows Forms, ASP.NET web applications, WPF applications, and console applications, can make use of the .NET class library.

7. **What is Common Type System?**
   - Common Type System (CTS) is a standard that defines how types are declared, used, and managed in the .NET Framework. It ensures interoperability between languages and facilitates communication among different components.

8. **List at least two features of CLS.**
   - CLS (Common Language Specification) features:
     1. Defines a set of rules to ensure language interoperability.
     2. Specifies guidelines for data types, exceptions, and other elements to promote consistency across different .NET languages.

9. **What do .NET assemblies contain?**
   - .NET assemblies contain compiled code (in MSIL), metadata, and manifest. The metadata includes information about the assembly, and the manifest contains details like versioning, security requirements, and references to other assemblies.

10. **“A strong name has to be created for a public assembly, not for a private assembly.” Justify.**
    - A strong name is typically created for a public assembly to ensure its uniqueness and to prevent naming conflicts when multiple assemblies are used. Private assemblies are specific to an application and are not shared, so a strong name is not necessary for them.

11. **What does assembly manifest store?**
    - An assembly manifest stores metadata about the assembly, including version information, culture information, security permissions, and a list of files that make up the assembly. It serves as a blueprint for the assembly.

12. **State the use of metadata in .NET assembly.**
    - Metadata in a .NET assembly provides detailed information about the types, methods, properties, and other elements in the assembly. It is used for type checking, runtime type identification, and to enable language interoperability within the Common Language Runtime (CLR).

13. **What is the Global Assembly Cache (GAC)?**
    - The Global Assembly Cache (GAC) is a central repository in the .NET Framework where strongly named assemblies are stored. It allows assemblies to be shared among multiple applications on the same machine, promoting code reuse and versioning.

14. **List at least four features supported in C#.**
    - Four features supported in C#:
      1. Object-oriented programming support
      2. Automatic garbage collection
      3. Delegates and events for event-driven programming
      4. Properties for encapsulating data with accessors.

15. **Write at least four advantages of C#.**
    - Four advantages of C#:
      1. Simplified syntax and easy-to-learn language.
      2. Integration with the .NET Framework for seamless development.
      3. Strong typing and type safety.
      4. Robust support for component-based software development.

16. **What are namespaces in C#.NET?**
    - Namespaces in C#.NET are used to organize and categorize code elements, preventing naming conflicts and providing a hierarchical structure to the code. They help in creating modular and maintainable code by grouping related functionalities.

17. **Can we use multiple inheritances in C#? Justify your answer.**
    - No, C# does not support multiple inheritances for classes. However, it supports multiple inheritances through interfaces. This is done to avoid the complications and ambiguities associated with the Diamond Problem, which can arise in languages that support multiple inheritances for classes.

18. **What is Property in C#.NET?**
    - In C#.NET, a property is a member of a class that provides a flexible mechanism to read, write, or compute the value of a private field. It encapsulates access to the field by providing getter and setter methods. Properties are used to maintain encapsulation and can have additional logic within their accessors.

---
### Answers to the short questions [1 mark]

1. Define Integrated Development Environment.

    An integrated development environment (IDE) is a software application that provides comprehensive facilities to computer programmers for software development.

2. If the Solution Explorer Window is not visible in project, write step to display it.

    Go to View menu and click on Solution Explorer.

3. Define Solution Explorer.

    Solution Explorer shows all the files that are part of a Visual Studio solution. It is used to view, navigate and manage files within a solution.

4. Give the full form of MSIL.

    MSIL stands for Microsoft Intermediate Language.

5. What is the role of JIT Compiler?

    JIT compiler converts the MSIL code into native machine code at runtime.

6. Which types of applications that can make use of .net class library?

    Console applications, Windows applications, Web applications, Web services etc. can make use of .NET class library.

7. What is Common Type System?

    Common Type System (CTS) provides a framework that enables .NET languages to share commonality in types so that they can easily integrate and communicate with each other.

8. List at least two features of CLS.

    - All CLS-compliant languages must support the primitive data types.
    - Only single inheritance is allowed.

9. What .NET assemblies contain?

    .NET assemblies contain CIL code and metadata of types.

10. “A strong name has to be created for public assembly not for private assembly.” Justify.

    Public assemblies are shared assemblies and they need to have a unique identity using strong names. Private assemblies reside in their own directory structure. So they do not need a strong name.
    
11\. What assembly manifest store?

An assembly manifest stores assembly metadata which includes the assembly name, version number, culture, public key, list of files, referenced assemblies etc.

12\. State the use of metadata in .NET assembly.

Metadata describes every type and member defined in the assembly code in a self-describing way. It is used by CLR for type safety, versioning and other features.

13\. What is the Global Assembly Cache (GAC)?

GAC is a central repository where assemblies shared by multiple applications can be stored and accessed globally.

14\. List at least four features supported in C#.

- Object-Oriented Programming
- Automatic memory management 
- Rich library 
- Component-oriented

15\. Write at least four advantages of C#.

- Simple and easy to learn
- Object-oriented 
- Component-oriented
- Supports rapid application development

16\. What are namespaces in C#.NET?

Namespaces are containers that organize C# classes and other types into unique groups that avoid naming conflicts.

17\. Can we use multiple inheritances in C#? Justify your answer.

No, C# supports only single inheritance. Multiple inheritance introduces complexity and ambiguity so it is not supported.

18\. What is Property in C#.NET?

A property is a member that provides access to an attribute of an object in a readable and simple syntax. It encapsulates the access and data validation for a field.

---
## long Questions [5 Mark]

## .NET Assembly: The Building Block of .NET Applications

In the realm of .NET development, an **assembly** is the fundamental unit of **deployment, versioning, reuse, activation scoping, and security permissions**. It serves as the foundational building block for building and deploying .NET applications. Here's a breakdown of its key aspects:

**Components of an Assembly:**

* **Types:** These are the blueprints representing the classes, structures, interfaces, and enumerations that define the application's logic and functionality.
* **Metadata:** This information describes the types within the assembly, including their names, properties, methods, and relationships. It provides a roadmap for the Common Language Runtime (CLR) to understand and execute the code.
* **Manifest:** This essential file acts as the assembly's blueprint, containing information like the assembly name, version, dependencies, security requirements, and resources (such as images and icons).

**Types of Assemblies:**

* **Executable (`.exe`):** This type represents the main application file, containing the entry point (starting point) for program execution.
* **Library (`.dll`):** These assemblies contain reusable code that can be referenced and utilized by other assemblies, promoting modularity and code reuse.
* **Satellite assemblies:** These are localized versions of assemblies that contain culture-specific resources, like translated text or images.

**Key Characteristics of Assemblies:**

* **Deployment:** Assemblies are the primary units deployed and distributed for running a .NET application. They provide a self-contained package with everything the application needs to function.
* **Versioning:** Each assembly comes with a unique version number, allowing for managing different versions and facilitating upgrades without breaking existing applications that depend on older versions.
* **Reuse:** Assemblies promote code reuse by enabling the creation of libraries containing reusable components that can be incorporated into multiple applications.
* **Activation Scoping:** Each assembly defines its own activation scope, meaning the CLR manages its loading and unloading independently. This helps in isolating assemblies and preventing conflicts between them.
* **Security Permissions:** Assemblies can specify security permissions, controlling access to resources and functionalities based on specific user roles or requirements.

**In summary, .NET assemblies serve as the fundamental building blocks for constructing and deploying .NET applications. They offer a structured and manageable way to package code, metadata, and resources, while enabling key features like versioning, reuse, and security control.**

---
1. List and briefly explain the features of .NET.

Here's a breakdown of the key features of the .NET framework:

**1. Cross-Platform Compatibility**

* While core parts of .NET are fully cross-platform, some features might be OS-specific.
* .NET apps can run on various operating systems (Windows, Linux, macOS) using an appropriate implementation of the framework (.NET Core, Mono, Xamarin). 
* This facilitates code reuse and reduces development costs when targeting multiple platforms.

**2. Language Interoperability (Common Language Specification)**

* .NET supports a wide variety of compatible programming languages like C#, F#, and Visual Basic.NET.
* Code written in these languages can seamlessly interact with each other due to all adhering to the Common Language Specification (CLS).
* This unlocks developer choice and the ability to use the best language for specific tasks within a project.

**3. Automatic Memory Management**

* .NET features a robust garbage collector that automates memory allocation and deallocation.
* This eliminates the burden on developers to manually manage memory, significantly reducing memory leaks and related errors.
* It leads to improved code stability and maintainability.

**4. Common Type System (CTS)**

* CTS defines how types are declared, used, and managed in the .NET runtime, regardless of the programming language used.
* This ensures seamless interaction between objects created using different .NET languages. 

**5. Extensive Class Library**

* The .NET framework offers a vast set of reusable classes, interfaces, and value types bundled within the Framework Class Library (FCL).
* These pre-built components cover common functionalities like file I/O, data access, networking, UI development, and much more.
* This accelerates development and reduces the need to reinvent the wheel.

**6. Security**

* .NET incorporates a robust security model with features like code access security (CAS) and role-based security.
* This allows the enforcement of granular security policies to control the actions an assembly can perform and to define permissions based on user identity or code origin.

**7. Simplified Deployment**

* .NET assemblies promote simplified deployment. Assemblies are largely self-contained, simplifying the distribution and installation process of your applications.
* Features like XCOPY deployment and ClickOnce installation further streamline this process.

**8. Robust Tooling**

* .NET comes with a rich ecosystem of development tools and IDEs, most notably Visual Studio.
* These tools provide features like IntelliSense (code completion), a powerful debugger, integrated profilers, and GUI designers to aid in the development process.

---

1.Give the difference between ReadLine(), Read(), ReadKey() in C#.

In C#, the methods `ReadLine()`, `Read()`, and `ReadKey()` are all used for reading input from the user, but they differ in what they read and how they handle the user pressing the Enter key:

**1. ReadLine():**

* **Purpose:** Reads a line of text from the standard input stream, including any characters typed until the user presses the Enter key (newline character).
* **Returns:** A string containing the entire line of text entered by the user, excluding the newline character.
* **Behavior upon Enter:** Stops reading and returns the complete line.

**2. Read():**

* **Purpose:** Reads a single character from the standard input stream.
* **Returns:** An integer representing the ASCII code of the character read.
* **Behavior upon Enter:** **Also reads the Enter key press**, returning the ASCII code for newline (typically 10 or 13, depending on the operating system).

**3. ReadKey():**

* **Purpose:** Reads a single character or function key from the keyboard, without waiting for the user to press Enter.
* **Returns:** A `ConsoleKey` object if a key was pressed, otherwise `ConsoleKey.NoKey`. 
* **Behavior upon Enter:** **Does not read the Enter key press**. This means it returns immediately without waiting for any further input.

**Here's a table summarizing the key differences:**

| Method          | Purpose                                         | Returns                                    | Behavior upon Enter |
|----------------|-------------------------------------------------|-----------------------------------------------|---------------------|
| `ReadLine()`   | Reads a line of text                              | String (excluding newline)                   | Stops reading        |
| `Read()`        | Reads a single character                           | Integer (ASCII code of character)              | Reads and returns    |
| `ReadKey()`     | Reads a single character or function key         | `ConsoleKey` object or `ConsoleKey.NoKey`      | Does not read         |

**Choosing the right method:**

* Use `ReadLine()` when you need to capture the entire line of user input, including spaces.
* Use `Read()` when you only need to read a single character and want to capture the Enter key press as well.
* Use `ReadKey()` when you want to read a single character or function key (like arrow keys) without waiting for the user to press Enter and potentially react to key presses as they happen.
