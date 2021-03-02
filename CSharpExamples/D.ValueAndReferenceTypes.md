**﻿There are two kinds of types in C#:**
  1) Value types      => Variables of value types directly contain their data. 
  2) Reference types  => ariables of reference types store references to their data, the latter being known as objects.

it's possible for two variables to reference the same object and possible for operations on one variable to affect the object referenced by the other variable.
A variable of a value type contains an instance of the type. This differs from a variable of a reference type, which contains a reference to an instance of the type. 

**Value types**
  **Simple types**
    **Signed integral:** sbyte[-128 to 128], short[System.Int16], int[System.Int32], long[System.Int64]
    **Unsigned integral:** byte[0 to 256], ushort[System.UInt16], uint, ulong[System.UInt64]
    **Unicode characters:** char, which represents a UTF-16 code unit
    IEEE binary **floating-point:** float, double
    High-precision **decimal floating-point:** decimal
    **Boolean:** bool, which represents Boolean values—values that are either true or false
    **Enum types**
    User-defined types of the form enum E {...}. An enum type is a distinct type with named constants. Every enum type has an underlying type, which must be one      of the eight integral types. The set of values of an enum type is the same as the set of values of the underlying type.
    **Struct types**
      User-defined types of the form struct S {...}
    **Nullable value types**
      Extensions of all other value types with a null value T?
      **string? str = "";   str.HasValue property returns true since it has non-null value.string? str = null;str.HasValue; returns false if it has null value.
      str.Value return the actual string value.**
    **Tuple value types**
      User-defined types of the form (T1, T2, ...)
  **Reference types**
    Class types
      Ultimate base class of all other types: object
    Unicode strings: string, which represents a sequence of UTF-16 code units
      User-defined types of the form class C {...}
    Interface types
      User-defined types of the form interface I {...}
    Array types
      Single-dimensional, multi-dimensional, and jagged. For example: int[], int[,], and int[][]
    Delegate types
      User-defined types of the form delegate int D(...)

