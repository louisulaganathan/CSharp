Constants:
=========
Constants are immutable values which are known at compile time and do not change for the life of the program. Constants are declared with the const modifier.
Constants can be marked as public, private, protected, internal, protected internal or private protected.
These access modifiers define how users of the class can access the constant. For more information, see Access Modifiers.

Constants are accessed as if they were static fields because the value of the constant is the same for all instances of the type.
You do not use the static keyword to declare them.
Expressions that are not in the class that defines the constant must use the class name, a period, and the name of the constant to access the constant.

Enum:
=======
An enumeration type (or enum type) is a value type defined by a set of named constants of the underlying integral numeric type.
To define an enumeration type, use the enum keyword and specify the names of enum members:

Read-Only:
==========

