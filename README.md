# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a property before it has been assigned a value.  Uninitialized properties can contain garbage data, leading to unexpected results or runtime exceptions.

## The Bug

The `bug.cs` file shows a simple class with a property that is not initialized before use.  The `MyMethod` attempts to use the property in a calculation without first setting a value. This can result in unexpected values or exceptions.

## The Solution

The `bugSolution.cs` file shows a corrected version. The property is initialized with a default value before it's used.