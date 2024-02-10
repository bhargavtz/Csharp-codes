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
