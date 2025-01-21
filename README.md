# C# DivideByZeroException Bug

This repository demonstrates a common runtime exception in C#: DivideByZeroException.  The `bug.cs` file contains code that can throw this exception, while `bugSolution.cs` provides a solution.

## Bug Description
The `Calculate` method in `bug.cs` performs division without checking for a zero denominator, resulting in a `DivideByZeroException` when `b` is 0.

## Solution
The `bugSolution.cs` file shows how to handle this exception using a try-catch block, preventing the program from crashing and providing a more graceful error handling mechanism.