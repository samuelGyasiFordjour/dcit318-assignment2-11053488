# Abstract Classes and Methods Demo

This C# console application demonstrates abstract classes and methods in object-oriented programming.

## Requirements

- Define an abstract class called Shape with an abstract method GetArea()
- Create a derived class Circle that implements GetArea() to calculate the area of a circle
- Create another derived class Rectangle that implements GetArea() to calculate the area of a rectangle
- In the Main method, create instances of Circle and Rectangle, and display their areas

## Class Structure

### Shape (Abstract Base Class)
- `GetArea()` - Abstract method that must be implemented by derived classes

### Circle (Derived Class)
- Inherits from Shape
- Constructor takes radius parameter
- Implements `GetArea()` to calculate circle area using π × r²

### Rectangle (Derived Class)
- Inherits from Shape  
- Constructor takes width and height parameters
- Implements `GetArea()` to calculate rectangle area using width × height

## How to Run

### Option 1: Using .NET SDK (if installed)
```bash
cd AbstractShapeDemo
dotnet run
```

### Option 2: Using Windows .NET Framework Compiler
If you don't have .NET SDK installed, you can use the built-in Windows .NET Framework compiler:

1. **Navigate to the AbstractShapeDemo folder:**
   ```powershell
   cd AbstractShapeDemo
   ```

2. **Compile the application using csc.exe:**
   ```powershell
   & "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\csc.exe" /out:AbstractShapeDemo.exe Program.cs Models\Shape.cs Models\Circle.cs Models\Rectangle.cs
   ```

3. **Run the compiled executable:**
   ```powershell
   .\AbstractShapeDemo.exe
   ```

## Expected Output

```
Circle area: 78.53981633974483
Rectangle area: 24
```

This demonstrates how abstract classes enforce a contract that derived classes must implement specific methods, while providing a common base type for polymorphism.
