# Interfaces Demo

This C# console application demonstrates interfaces in object-oriented programming.

## Requirements

- Define an interface called IMovable with a method Move()
- Create a class Car that implements IMovable and prints "Car is moving" when Move() is called
- Create a class Bicycle that implements IMovable and prints "Bicycle is moving" when Move() is called
- In the Main method, create instances of Car and Bicycle, and call the Move() method on each instance

## Class Structure

### IMovable (Interface)
- `Move()` - Method signature that implementing classes must provide

### Car (Class implementing IMovable)
- Implements `Move()` to print "Car is moving"

### Bicycle (Class implementing IMovable)
- Implements `Move()` to print "Bicycle is moving"

## How to Run

### Option 1: Using .NET SDK (if installed)
```bash
cd InterfaceDemo
dotnet run
```

### Option 2: Using Windows .NET Framework Compiler
If you don't have .NET SDK installed, you can use the built-in Windows .NET Framework compiler:

1. **Navigate to the InterfaceDemo folder:**
   ```powershell
   cd InterfaceDemo
   ```

2. **Compile the application using csc.exe:**
   ```powershell
   & "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\csc.exe" /out:InterfaceDemo.exe Program.cs Models\IMovable.cs Models\Car.cs Models\Bicycle.cs
   ```

3. **Run the compiled executable:**
   ```powershell
   .\InterfaceDemo.exe
   ```

## Expected Output

```
Car is moving
Bicycle is moving
```

This demonstrates how interfaces define a contract that classes must implement, enabling polymorphism and ensuring consistent method signatures across different classes.
