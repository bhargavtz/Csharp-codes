step-by-step guide for writing C# code in Visual Studio:

1. Install Visual Studio
- Download and install the latest version of Visual Studio Community, Professional, or Enterprise. Make sure to select the ASP.NET and web development workload during installation.

2. Create a new project
- Open Visual Studio and click "Create a new project".
- Select the C# template you want - for example "Console App (.NET Core)". 
- Give the project a name and set the location.

3. Add a C# file
- In the Solution Explorer, right click on your project and select Add > New Item.
- Select the "Code File" template and give it a name with the .cs extension.

4. Write some C# code
- Open the .cs file you just created and add the following code:

```csharp
using System;

namespace MyApp 
{
  class Program 
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!"); 
    }
  }
}
```

5. Run the code
- Press Ctrl+F5 or click the green play button to run the code without debugging.
- The console window will appear with the printed text "Hello World!".

6. Add more features
- Continue adding C# statements, functions, classes etc. to create your application logic.
- Remember to rebuild after making changes.

That covers the basics of getting started with C# coding using Visual Studio!