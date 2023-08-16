**Virtual, override, and abstract methods**


A virtual method can be overridden in a derived class. When an instance method declaration includes an override modifier, 
the method overrides an inherited virtual method with the same signature.


An abstract method is a virtual method with no implementation. An abstract method is declared with the abstract modifier and is permitted only in an abstract class. 
An abstract method must be overridden in every non-abstract derived class.

using System.Diagnostics;
using static System.Console;
namespace CSharpLearning
{
    internal class Program
    {

        #region ValueTypes

        #region SimpleTypes
        //represents 8bit signed integer
        sbyte _sByte = 1;

        //represents 16bit signed integer
        short _short = 2;

        //represents 32 bit signed integer
        int _int = 3;

        //represents 64 bit signed integer
        long _long = 4;

        //represents 8bit unsigned integer
        byte _Byte = 1;

        //represents 16bit unsigned integer
        ushort _ushort = 2;

        //represents 32 bit unsigned integer
        uint _uint = 3;

        //represents 64 bit unsigned integer
        ulong _ulong = 4;

        //Single[float, double][occupies 32 bits]/double[decimal][64bits] precision is a format proposed by IEEE for floating point numbers
        //----------------------------------------------
        //|Sign bit | 8 exponent bit | 23 Mantissa bits|
        //----------------------------------------------
        //represents single precision floating point number 6-9 digits
        float _float = 5;

        //----------------------------------------------
        //|Sign bit | 11 exponent bit | 52 Mantissa bits|
        //----------------------------------------------
        //represents double precision floating point number 15-17digits
        double _double = 6;
        
        //represents the decimal precision floating point number 28-29 digits[128 bits]
        decimal _decimal = 5;

        //represents the boolean values
        bool _bool = true;

        #endregion SimpleTypes

        #region enumtypes
        //represents valuetype defined by named constants
        enum Season
        {
            Spring = 0,
            Summer = 1,
            Autumn = 2,
            Winter = 3,
        }
        enum ErrorCodes
        {
            NotFound = 404,
            InternalServerError = 500,
        }
        #endregion enumtypes

        #region structtypes
        //Struct type can encapsulate the data & related functionality
        //Parameterless constructor and destructor is not allowed in struct, From c#10 you can create parameterless constructor
        //Use struct when you want to define small data centric type that provide little or no behavior
        //struct is a lightweight data structure which doesnot require inheritance wehereas class is complex data structure
        //readonly struct is used to define the structure as immutable
        public struct Coords
        {
            public double X { get; }
            public double Y { get; }
            public Coords(double x, double y)
            {
                X = x;
                Y = y;
            }
            public string ToString() => $"({X},{Y})";
        }
        #endregion structtypes

        #region TupleType
        //Tuples are the valuetype used to group multiple data elements in a lightweight datastructure.
        //members of tuple elements are public fields that makes tuple as mutable value types
        //Tuples supports value equality comparision.

        private void Tuple() {
            (double, int) t1 = new(4.5, 3);
            Console.WriteLine(t1.Item1);

            (double sum, int count) t2 = new(4.5, 3);
            Console.WriteLine(t2.sum);
        }

        #endregion TupleType

        #region ReferenceTypes
        public class Sample1
        {

        }

        public interface ISample { }

        /*
         * classes are datastructure that combines the state[fields] and actions[methods and other function members] in a signle unit
         * Only single inheritence is allowed in c#. A class can implement from one base class.However a class can implement more than one interface.
         * class ChildClass: BaseClass {}
         * class DerivedClass: IInterface1, IInterface2 {}
         * class Derivedclass: BaseClass, IInterface1{}
         * Access Modifiers
         *      1) public              - can be accessed within the same assemble or another assembly
         *      2) private             - Type or member can be accessed only by the code in the same class or struct
         *      3) protected           - Can be access by the code in the same class or the derived class
         *      4) internal            - Type or member can be accessed by the code in the same assesmbly
         *      5) protected internal  - can be accessed by the code in the same assembly or from within a derived class from another assembly
         *      6) private protected   - can be accessed by the types derived from the class in the same assembly
         *      
         * Gerneric classes encapsulate the operations that are not specific to any particular data typle.
         * Most common use of generic class is with collection like linkedlist, hash table, stack, queue tree etc.
         * delegate is a type that represents the reference of the methods with a particular parameter list and return type.
         * When we instantiate the delegate you can associate any compatible methods.delegates allow method to be passed as parameters
         * delegate can be used to define the callback functions
         * public delegate int delegateName(int x, int y)
         * 
         * A class can't inherit from more than one class directly however the baseclass itself can inherit from another base class. So A class might
         * indirectly inherit from multiple base class
         * Abstract class can't be instantiated. They can only be used through derviced classes that implement abstract methods.
         * 
         * sealed classes doesn't allow other classes to inherit from it
         */

        /*
         * Arrays - Single dimention int[] obj = new int[3]; int[] arr = new int[3] {1,2,3}; int[] arr = {1,2,3};
         * Multiple Dimention => int[,] obj = new int[2,3]; int[,] arr = {{1,2,3},{4,5,6}};
         * Jaggerd array => int[][] obj = new int[2][]; obj[0] = new int[3]{1,2,3};
        */

        #endregion ReferenceTypes

        #endregion ValueTypes
        static void Main(string[] args)
        {
            Third obj = new();
            obj.Test();
            WriteLine("Hello, World!");
        }
        
    }

    public class First
    {
        protected string strFirst = "First field";
        public First()
        {
            Console.WriteLine("First constructor");
        }
        ~First()
        {
            Console.WriteLine("First Destructor");
        }
    }
    public class Second: First
    {
        protected string strSecond = "Second field";
        public Second()
        {
            Console.WriteLine("Second constructor");
        }
        ~Second()
        {
            Console.WriteLine("Second Destructor");
        }
    }
    public class Third: Second
    {
        protected string strThird = "Third field";
        public Third()
        {
            Console.WriteLine("Third constructor");
        }

        public void Test()
        {
            Console.WriteLine($"{strFirst},{strSecond},{strThird}");
        }
        ~Third()
        {
            Console.WriteLine("Third Destructor");
        }
    }
}
