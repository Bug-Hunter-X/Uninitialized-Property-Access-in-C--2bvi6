# C# Uninitialized Property Access Bug

This repository demonstrates a common error in C#: accessing a property before it's been assigned a value.  This can lead to unpredictable results, as the property's value will be its default value (0 for integers, null for objects, etc.), which might not be what's expected.  The example shows how to identify and resolve this issue.

## Bug Description

The `MyClass` class has a property `MyProperty`. The `MyMethod` attempts to access and use `MyProperty` before it's assigned a value.  This results in `MyProperty` having its default value (0 in this case) which is likely not the intended behavior.