**﻿There are two kinds of types in C#:**
  1) Value types[STACK Memory]      => Variables of value types directly contain their data. 
  2) Reference types[HEAP Memory]  => ariables of reference types store references to their data, the latter being known as objects.

Both stack and heap are the memories in RAM. 
OS allocates the STACK memory when the new thread is created at the system level. LIFO
RUNTIME reqests OS to allocate HEAP memory at the appln level during app startup.

STACK is faster

it's possible for two variables to reference the same object and possible for operations on one variable to affect the object referenced by the other variable.
A variable of a value type contains an instance of the type. This differs from a variable of a reference type, which contains a reference to an instance of the type. 

**Value types**
  **Simple types**
  
    |**Signed integral:** |sbyte[-128 to 128], short[System.Int16], int[System.Int32], long[System.Int64]|
    |---------------------|------------------------------------------------------------------------------|
    ||**Unsigned integral:** |byte[0 to 256], ushort[System.UInt16], uint, ulong[System.UInt64].         |   
    |---------------------|------------------------------------------------------------------------------|
    |**Unicode characters:** |char, which represents a UTF-16 code unit.                                 |
    |---------------------|------------------------------------------------------------------------------|
    |IEEE binary **floating-point:** |float, double                                                      |
    |---------------------|------------------------------------------------------------------------------|
    |High-precision **decimal floating-point:** |decimal                                                 |
    |---------------------|------------------------------------------------------------------------------|
    |**Boolean:** bool, which represents Boolean values—values that are either true or false             |
    |---------------------|------------------------------------------------------------------------------|
    |**Enum types**       |
    User-defined types of the form enum E {...}. An enum type is a distinct type with named constants. Every enum type has an underlying type, which must be one      of the eight integral types. The set of values of an enum type is the same as the set of values of the underlying type.|
    |---------------------|------------------------------------------------------------------------------|
    |**Struct types**|
      User-defined types of the form struct S {...}|
      |---------------------|------------------------------------------------------------------------------|
    |**Nullable value types**|
      Extensions of all other value types with a null value T?
      **string? str = "";   str.HasValue property returns true since it has non-null value.string? str = null;str.HasValue; returns false if it has null value.
      str.Value return the actual string value.**|
      |---------------------|------------------------------------------------------------------------------|
    |**Tuple value types**. |
      User-defined types of the form (T1, T2, ...)|
      |---------------------|------------------------------------------------------------------------------|
  **Reference types**<br/>
    Class types<br/>
      &emsp; Ultimate base class of all other types: object<br/>
    Unicode strings: string, which represents a sequence of UTF-16 code units<br/>
     &emsp; User-defined types of the form class C {...}<br/>
    Interface types<br/>
      &emsp;User-defined types of the form interface I {...}<br/>
    Array types<br/>
      &emsp;Single-dimensional, multi-dimensional, and jagged. For example: int[], int[,], and int[][]
    Delegate types<br/>
     &emsp; User-defined types of the form delegate int D(...)<br/>
    Record<br/>


**Boxing & UnBoxing:**

int i = 123;
object o = i;    // Boxing.  conversion of value type to ref type
int j = (int)o;  // Unboxing. conversion of ref type to value type
