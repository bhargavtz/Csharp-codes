## Post-Lab questions 

1. List commonly used data types in C#.NET. Give example of each.

    - int: stores whole numbers like 10, 25, etc
    - double: stores fractional numbers with decimal point like 3.14, 12.5 etc 
    - char: stores single characters like 'a', 'Z' etc
    - string: stores sequence of characters, like "Hello"
    - bool: stores boolean logical values - true or false

2. Give the difference between Write() and WriteLine() Method with proper example.

    `Write()` method prints the text or value passed to it. For example:

    ```
    Console.Write("Hello ");
    Console.Write("World!");
    ```
    
    Output: Hello World!

    `WriteLine()` writes the text and moves the cursor to the next line. For example:

    ``` 
    Console.WriteLine("Hello");
    Console.WriteLine("World!");
    ```
    
    Output: 
    Hello
    World!

3. What is the difference between Read(), ReadLine() and ReadKey() Method?

    - `Read()`: Reads next character from standard input stream.
    - `ReadLine()`: Reads an entire line from input as a string  
    - `ReadKey()`: Reads next key/character pressed by the user without echoing it on the console.
    
    So Read() reads individual characters, ReadLine() reads entire line string, and ReadKey() reads key press input without echoing on console.
