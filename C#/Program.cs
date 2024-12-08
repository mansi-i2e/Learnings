
// Hello World Program
// class Program
// {
//     public static void Main(string[] args)           // entry point to the application
//     {
//          Console.Write("Hello World");      // no new line at end of program
//           Console.WriteLine("Hello World");               // prints new line 
//     }
// }


// Variable Declaration

// int EmpId = 101;
// double EmpSalary = 40000.450;
// char EmpLetter = 'm';
// string EmpName = "mansi";
// bool IsWorking = true;

// Console.WriteLine(EmpId);
// Console.WriteLine(EmpLetter);
// Console.WriteLine(EmpName);
// Console.WriteLine(IsWorking);
// Console.WriteLine(EmpSalary);


// Const variable           // initialse with 'const' keyword, cannot be modified throughout the program
// const int myNum = 10;
// myNum = 20;


// string FirstName = "Alice ", LastName = "Bob";        // "+" concatenates string
// int FirstNum = 10, SecondNum = 20;                    // "+" adds numbers

// Console.WriteLine(FirstNum + SecondNum);
// Console.WriteLine(FirstName + LastName);


// TypeCasting

// int num = 10;
// double num2 = num;
// Console.WriteLine(num2);    // possible - prints the value i.e implicit typecasting (char -> int -> long -> float -> double)

// double myNum = 20;
// // int myNum2 = myNum;        // not possible - does not print the value i.e explicit typecasting (double -> float -> long -> int -> char)
// int myNum2 = (int)myNum;
// Console.WriteLine(myNum2);    // prints the value without any error

// int number = 20;
// Console.WriteLine(Convert.ToString(number));    // similar inbuit funcitions in c# for type conversion
// string str = "30";
// Console.WriteLine(str+number);


// User Input
// Console.WriteLine("Enter your details: ");
// string? FirstName, LastName;
// FirstName = Console.ReadLine();
// LastName = Console.ReadLine();
// int age = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Here are your details: ");
// Console.WriteLine("Hello " + FirstName + " " + LastName + " your age is " + age);


// operators 

// class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.WriteLine(Operators.Addition(10, 20));               // static access of class functions
//         Console.WriteLine(Operators.Subtraction(30, 20));
//         Console.WriteLine(Operators.Multiplication(10, 10));
//         Console.WriteLine(Operators.Division(100, 20));
//         Console.WriteLine(Operators.Modulo(101, 20));
//         Console.WriteLine(Operators.Increment(10));
//         Console.WriteLine(Operators.Decrement(20));
//     }
// }

// some inbuilt Math functions (many are present in C#)
// Console.WriteLine(Math.Max(10,20));
// Console.WriteLine(Math.Min(10,20));
// Console.WriteLine(Math.Sqrt(100));


// if-else conditional statements
// class Program
// {
//     public static void Main(string[] args)
//     {
// Console.WriteLine(IfElse.showDetail(36));
// Console.WriteLine(IfElse.showDetail(10));
// Console.WriteLine(IfElse.showDetail(70));
//     }
// }

// switch case 

// class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.WriteLine(Switch.ShowDays(5));
//         Console.WriteLine(Switch.ShowDays(3));
//     }
// }


// loops (for, while, do-while)
class Program
{
    public static void Main(string[] args)
    {
       Console.WriteLine(ForLoop.ShowSum(11));
       Console.WriteLine(WhileLoop.GetSum(11));
       Console.WriteLine(DoWhileLoop.MySum(11));
    }
}

