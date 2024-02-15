/* Module 1 - Choose the Correct Data Type in your C# Code
  Console.WriteLine("***Signed integral types:***");
  Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
  Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
  Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
  Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

  Console.WriteLine("\n***Unsigned integral types:***");
  Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
  Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
  Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
  Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

  Console.WriteLine("\n***Floating point types:***");
  Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
  Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
  Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

  int[] data = new int[3];

  // CHOOSING THE CORRECT DATA TYPE(S): 
    //1. stick with the basics
      // While you've looked at several considerations, as you're getting started, for simplicity's sake you should prefer a subset of basic data types, including:
        // int for most whole numbers
        // decimal for numbers representing money
        // bool for true or false values
        // string for alphanumeric value

    // 2. Choose specialty complex types for special situations
      // Don't reinvent data types if one or more data type already exists for a given purpose. The following examples identify where a specific .NET data types can be useful:
        // byte: working with encoded data that comes from other computer systems or using different character sets.
        // double: working with geometric or scientific purposes. double is used frequently when building games involving motion.
        // System.DateTime for a specific date and time value.
        // System.TimeSpan for a span of years / months / days / hours / minutes / seconds / milliseconds.
*/

// Module 2 - Convert data types using casting and conversion techniques
  int first = 2;
  string second = "4";
  string result = first + second;
  Console.WriteLine($"safe conversion example for int(2) + string(\"4\") = string(\"24\"): {result}.");

// Widening Conversion for Implicit Conversion  
  int myInt = 3;
  decimal myDecimal = myInt;
  Console.WriteLine($"int: {myInt} vs. decimal: {myDecimal}");

// Perform a Cast for Explicit Conversion
  myDecimal = 3.95m; // value has precision denoted by the "m"
  myInt = (int)myDecimal; // casting operation ()
  Console.WriteLine($"decimal: {myDecimal} vs. int: {myInt}");

// Practice with a small test to see if data conversion is narrowing or widening
  myDecimal = 1.23456789m;
  float myFloat = (float)myDecimal;
  Console.WriteLine($"Decimal: {myDecimal} vs. Float: {myFloat}"); // output shows that casting a decimal to a float is a narrowing conversion because you're losing precision

// Practice with ToString() to convert a number to a string
  int firstNum = 5;
  int secondNum = 7;
  string message = firstNum.ToString() + secondNum.ToString(); 
  Console.WriteLine($"ToString() method used on 5 + 7 = {message}");

// Practice with Parse() to convert a string to an int
  string firstStr = "5";
  string secondStr = "7";
  int sum = int.Parse(firstStr) + int.Parse(secondStr);
  Console.WriteLine($"Parse() method used on \'5\' + \'7\' = {sum}");

// Practice with Convert class
  string value1 = "5";
  string value2 = "7";
  int multiply = Convert.ToInt32(value1) * Convert.ToInt32(value2);
  Console.WriteLine($"Convert class used on \'5\' * \'7\' = {multiply}");

// compare casting vs. converting a decimal to an int
  int someValue = (int)1.5m; // casting truncates
  int otherValue = Convert.ToInt32(1.5m); // converting rounds up 
  Console.WriteLine($"Casting: {someValue} vs. Converting: {otherValue}");