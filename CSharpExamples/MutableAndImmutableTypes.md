﻿C# programming language; that means the
Mutable types are those whose data members can be changed after the instance is created
but
Immutable types are those whose data members can not be changed after the instance is created.

When we change the value of mutable objects,
value is changed in same memory.
But in immutable type, the new memory is created and the modified value is stored in new memory.

Let’s start with examples of predefined classes (String and StringBuilder).

String
======
Strings are immutable, which means we are creating new memory everytime instead of working on existing memory.

So, whenever we are modifying a value of the existing string, i.e., we are creating a new object which refers to that modified string and the old one becomes unreferenced. Hence, if we are modifying the existing string continuously, then numbers of the unreferenced object will be increased and it will wait for the garbage collector to free the unreferenced object and our application performance will be decreased.

Example
=======

            string str = string.Empty;  
  
            for (int i = 0; i < 1000; i++)  
            {  
                str += "Modified ";  
            }   
In the code given above, string str will update 1000 times inside the loop and every time it will create new instance so all old values will be collected by garbage collector after some time.

It is not a good approach for this solution so, it’s better to go for mutable type. So in C#, we have StringBuilder which is a mutable type. We have some advantages of immutable classes like immutable objects are simpler to construct, test, and use. immutable objects are always thread-safe and etc.

StringBuilder
==============

StringBuilder is a mutable type, that means we are using the same memory location and keep on appending/modifying the stuff to one instance. It will not create any further instances hence it will not decrease the performance of the application.

Example
=======

            StringBuilder strB = new StringBuilder();  
  
            for (int i = 0; i < 10000; i++)  
            {  
                strB.Append("Modified ");  
            }   
In the code given above, It has the huge impact of allocated memory because it will not create instance each time.

We have many methods for modifying the StringBuilder String as below,

Append - Appends information to the end of the current StringBuilder.
AppendFormat - Replaces a format specifier passed in a string with formatted text.
Insert - Inserts a string or object into the specified index of the current StringBuilder.
Remove - Removes a specified number of characters from the current StringBuilder.
Replace - Replaces a specified character at a specified index.
Creating an Immutable Class

For creating an immutable class, we have to think about their properties or variables which will never change the value(s) after assigning the first time. So, we are going to follow some simple steps for creating the immutable class in C#.
===============================
Step 1
=======

Make the variables read-only so we can not modify the variable after assigning the first time. 

class MyClass  
    {  
        private readonly string myStr;          
}   
Step 2
======

Use parameterized constructor for assigning the myStr value for the class while creating the object of the class as below 

class MyClass  
    {  
        private readonly string myStr;  
  
        public MyClass(string str)  
        {  
            myStr = str;  
        }  
    }   
Step 3
=======

Use properties for getting the variables of the class and remove the setters of the property, use only getters as below. 

class MyClass  
    {  
        private readonly string myStr;  
  
        public MyClass(string str)  
        {  
            myStr = str;  
        }  
  
        public string GetStr  
        {  
            get { return myStr; }  
        }  
    }   
