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

// Module 2 - 