﻿
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
//         Console.WriteLine("Enter your Age: ");
//         int age = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine(IfElse.showDetail(age));
//     }
// }


// switch case 

// class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.WriteLine("Enter day number: ");
//         int day = Convert.ToInt32(Console.ReadLine);
//         Console.WriteLine(Switch.ShowDays(day));
//     }
// }


// loops (for, while, do-while)
// class Program
// {
//     public static void Main(string[] args)
//     {
//        Console.WriteLine(ForLoop.ShowSum(11));
//        Console.WriteLine(WhileLoop.GetSum(11));
//        Console.WriteLine(DoWhileLoop.MySum(11));
//     }
// }


// strings 

// class Program
// {
//     public static void Main(string[] args)
//     {
//         string str1 = "Good Morning ";
// Console.Write("Enter your name: ");
// string userName = Console.ReadLine();

// concatenation of strings

// string display = str1 + userName;
// string display1 = string.Concat(str1, userName);

// Console.WriteLine("Hello, " + display);
// Console.WriteLine("Hello, " + display1);

// string in-built functions

// Console.WriteLine("length: " + userName.Length);     // to get length of string

// Console.WriteLine("Uppercase: " + userName.ToUpper());       // to get string in Uppercase

// Console.WriteLine("Lowercase: " + userName.ToLower());       // to get string in Lowercase

// Console.WriteLine("contains: " + display.Contains("Good"));    // to check occurence of a substring
// Console.WriteLine("contains: " + display.Contains("Hi"));

// string interpolation

// Console.Write("Enter favorite color: ");
// string color = Console.ReadLine();
// Console.WriteLine($"{userName}'s favorite color is {color}"); 

// accessing strings

// Console.WriteLine(str1[3]);

// int pos = str1.IndexOf('M');          // to get position of specific char
// Console.WriteLine(pos);

// string str2 = str1.Substring(pos);        // extract substring, starting from specifed index
// Console.WriteLine(str2);
// }
// }


// Arrays 

// class Program
// {
//     public static void Main(string[] args)
//     {
//         int[] arr = { 5, 10, 15, 20, 25 };

// array methods

// Console.WriteLine(arr.Max());
// Console.WriteLine(arr.Min());
// Console.WriteLine(arr.Sum());

// print array elements

// for (int i = 0; i < arr.Length; i++)
// {
//     Console.WriteLine($"index {i}: " + arr[i]);
// }

// int index=0;
// foreach (int num in arr)
// {
//     Console.WriteLine($"at index {index}: " + num);
//     index++;
// }

// ways to create an array

// string[] fruits = { "Apple", "Strawberry", "Orange", "Guava", "Mango" };       // without using 'new' keyword , not specifiying the size (preferred)

// string[] fruits = new string[] {"Apple", "Strawberry", "Orange", "Guava", "Mango"};         // not specifying the size , using 'new' keyword

// string[] fruits = new string[5] { "Apple", "Strawberry", "Orange", "Guava", "Mango" };        // using 'new' keyword and with size

// 'new' keyword is needed when array is initialised first and values are added later
// string[] fruits;
// fruits = new string[] { "Apple", "Mango", "Orange" };

// looping through array 

// string[] shapes = new string[5];
// for (int i = 0; i < 5; i++)
// {
//     Console.Write("Enter shape: ");
//     shapes[i] = Console.ReadLine();
// }

// Console.WriteLine("Shapes listed: ");
// foreach (string s in shapes)
// {
//     Console.WriteLine(s);
// }

// sorting in arrays      -- ascending order / alphabectically

// in numbers

// int[] nums = { 100, 30, 60, 10, 80 };
// Array.Sort(nums);

// foreach (int n in nums)
// {
//     Console.WriteLine(n);
// }

// in strings         

// string[] word = { "G", "E", "H", "F", "J", "I" };
// Array.Sort(word);

// foreach (string s in word)
// {
//     Console.WriteLine(s);
// }

// descending order / reverse alphabetical - first sort method then reverse method

// in numbers

// int[] nums = { 45, 75, 15, 95, 25 };
// Array.Sort(nums); Array.Reverse(nums);
// foreach (int n in nums)
// {
//     Console.WriteLine(n);
// }

// in strings

// string[] word = { "O", "K", "N", "L", "M" };
// Array.Sort(word); Array.Reverse(word);
// foreach (string s in word)
// {
//     Console.WriteLine(s);
// }

// 2-D Array
// int[,] myArr = { { 11, 33, 55 }, { 22, 44, 66 } };

// access elements
// Console.WriteLine(myArr[1, 2]);

// looping
// foreach (int n in myArr)
// {
//     Console.WriteLine(n);
// }

// for (int i = 0; i < myArr.GetLength(0); i++)
// {
//     for (int j = 0; j < myArr.GetLength(1); j++)
//     {
//         Console.WriteLine(myArr[i, j]);
//     }
// }

//     }
// }


// OOPS Concepts

// classes and objects

// class members - fields and methods

// class City
// {
//     string name = "Udaipur";
//     int pincode;

//     public void aboutCity()
//     {
//         Console.WriteLine("City of lakes");
//     }

//     public static void Main(string[] args)
//     {
//         City myCity = new City();
//         myCity.pincode = 313001;
//         myCity.aboutCity();
//         Console.WriteLine("City: " + myCity.name);
//         Console.WriteLine("Pincode: " + myCity.pincode);
//     }
// }

// using multiple classes

// class Program
// {
//     public static void Main(string[] args)
//     {
//         Person person = Person();
//         person.ShowInfo();
//     }
// }


// Constructors           -- no return type , called automatically when obj of class is created

// class Program
// {
//     public static void Main(string[] args)
//     {
//         Employee myEmp = new Employee();                // default constructor
//         Employee myEmp1 = new Employee("Ajay", 50000);          // parameterised constructor
//     }
// }


// Encapsulation       -- hides sensitive data from users

// class Program
// {
//     public static void Main(string[] args)
//     {
//         BankAcc myAcc = new BankAcc();
//         myAcc.Balance = 12350;
//         Console.WriteLine($"Balance is: Rs {myAcc.Balance}");
//     }
// }


// Polymerphism             -- perform single task in diff ways

// compile-time (behaviour of func is decided at compile time) 

// Method overloading 
// class Program
// {
//     public static void Main(string[] args)
//     {
//         int squareArea = MethodOverload.Area(5);
//         double triangleArea = MethodOverload.Area(4.2, 6.2);
//         int rectangleArea = MethodOverload.Area(12, 10);
//         double circleArea = MethodOverload.Area(3.2);

//         Console.WriteLine($"Square: {squareArea}");
//         Console.WriteLine($"Triangle: {triangleArea}");
//         Console.WriteLine($"Rectangle: {rectangleArea}");
//         Console.WriteLine($"Circle: {circleArea}");
//     }
// }

// run-time (behaviour of func is decided at run time) 

// Method overriding
// class Program
// {
//     public static void Main(string[] args)
//     {
//         Animal animal = new Animal();
//         Herbivore animal1 = new Herbivore();
//         Carnivore animal2 = new Carnivore();

//         animal.display();
//         animal1.display();
//         animal2.display();
//     }
// }


// Inheritance 

// class Program
// {
//     public static void Main(string[] args)
//     {
//         Child myChild = new Child();
//         myChild.displayChild();
//         myChild.displayParent();
//     }
// }


// Abstraction           -- hiding certain details, showing only essential info

// class Program
// {
//     public static void Main(string[] args)
//     {
//         Vehicle myVehicle = new Scooter();
//         myVehicle.start();
//         myVehicle.stop();
//     }
// }


// Interfaces      -- completely abstract classes (another way to achieve abstraction)

// multiple inheritance
// class Program
// {
//     public static void Main(string[] args)
//     {
//         Student myStud = new Student();
//         myStud.showInfo("Shivani", 56, "Blue");
//         myStud.showMarks(85.5, "Maths");
//         myStud.showMarks(90, "Chemistry");
//         myStud.showMarks(76.5, "Physics");
//     }
// }


// Enums              -- special classes in c#

// enum in class
// class Program
// {
//     public static void Main(string[] args)
//     {
// Direction dir = Direction.south;
// Console.WriteLine($"direction is: {dir}");
//     }
// }

// enum in Switch Case
// class Program
// {
//     public static void Main(string[] args){
//         int day = (int)Days.friday;
//         switch (day)
//         {
//             case 1:
//                 Console.WriteLine("Monday");
//                 break;
//             case 2:
//                 Console.WriteLine("Tuesday");
//                 break;
//             case 3:
//                 Console.WriteLine("Wednesday");
//                 break;
//             case 4:
//                 Console.WriteLine("Thursday");
//                 break;
//             case 5:
//                 Console.WriteLine("Friday");
//                 break;
//             case 6:
//                 Console.WriteLine("Saturday");
//                 break;
//             case 7:
//                 Console.WriteLine("Sunday");
//                 break;
//         }
//     }
// }


// exception handling

// class Program
// {
//     public static void Main(string[] args)
//     {
//         try
//         {
//             string[] myLetters = { "A", "B", "C" };
//             Console.WriteLine(myLetters[6]);
//         }
//         catch (Exception e)
//         {
//             Console.WriteLine(e.Message);
//             // Console.WriteLine("Could not access the array");     // own error msg instead of the default one
//         }
//         finally
//         {
//             Console.WriteLine("try..catch finished");
//         }
//     }
// }

// using exception class
// class Program
// {
//     public static void Main(string[] args)
//     {
//         Number.checkEven(23);
//     }
// }


// SOLID PRINCIPLES

// SRP - Single responsibilty principle
// class Program
// {
//     public static void Main(string[] args)
//     {
//         Teacher myTeacher = new Teacher();
//         myTeacher.name = "Suhani Gupta";
//         myTeacher.subject = "Social Science";
//         Display display = new Display();
//         display.TeacherDetail(myTeacher);
//     }
// }

// OCP  - Open/Close Principle
// class Program
// {
//     public static void Main(string[] args)
//     {
//         IntAdd intAdd = new IntAdd() { num1 = 5, num2 = 10 };
//         intAdd.Addition();

//         StrAdd strAdd = new StrAdd() { str1 = "Hello ", str2 = "Mansi" };
//         strAdd.Addition();

//         DoubleAdd doubleAdd = new DoubleAdd() { num1 = 4.3, num2 = 7.9 };
//         doubleAdd.Addition();
//     }
// }
