# Inheritance and Method Overriding Demo

This C# console application demonstrates inheritance and method overriding concepts in object-oriented programming.

## Requirements

- Define a base class called Animal with a method MakeSound() that prints "Some generic sound"
- Create a derived class Dog that overrides the MakeSound() method to print "Bark"  
- Create another derived class Cat that overrides the MakeSound() method to print "Meow"
- In the Main method, create instances of Animal, Dog, and Cat, and call the MakeSound() method on each instance

## Class Structure

### Animal (Base Class)
- `MakeSound()` - Virtual method that prints "Some generic sound"

### Dog (Derived Class)
- Inherits from Animal
- Overrides `MakeSound()` to print "Bark"

### Cat (Derived Class)  
- Inherits from Animal
- Overrides `MakeSound()` to print "Meow"

## How to Run

### Option 1: Using .NET SDK (if installed)
```bash
cd InheritanceDemo
dotnet run
```

### Option 2: Using Windows .NET Framework Compiler
If you don't have .NET SDK installed, you can use the built-in Windows .NET Framework compiler:

1. **Navigate to the InheritanceDemo folder:**
   ```powershell
   cd InheritanceDemo
   ```

2. **Compile the application using csc.exe:**
   ```powershell
   & "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\csc.exe" /out:InheritanceDemo.exe Program.cs Models\Animal.cs Models\Dog.cs Models\Cat.cs
   ```

3. **Run the compiled executable:**
   ```powershell
   .\InheritanceDemo.exe
   ```

**Note:** The .NET Framework compiler supports C# 5 and earlier versions, which is sufficient for this basic inheritance demonstration.

## Expected Output

```
Some generic sound
Bark
Meow
```

This demonstrates how inheritance allows derived classes to override base class methods with their own implementations.
