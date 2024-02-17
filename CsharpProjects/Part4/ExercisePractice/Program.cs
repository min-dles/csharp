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

/* Module 2 - Convert data types using casting and conversion techniques
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

  // TryParse() to prevent runtime errors during type conversion from string to int
    string valueA = "102";
    int resultA = 0;
    if (int.TryParse(valueA, out resultA))
      Console.WriteLine($"Measurement: {resultA}");
    else
      Console.WriteLine("Error: unable to report measurement.");
    Console.WriteLine($"Measurement (w/ offset): {50 + resultA}"); // outside of the if-else statement, meaning resultA's value remains AFTER the if-else statement and doesn't revert to it's initialized value of 0

  // see TryParse() with a "bad" value (i.e. can't be converted)
    string valueB = "bad";
    int resultB = 0;
    if (int.TryParse(valueB, out resultB))
      Console.WriteLine($"Measurement: {resultB}");
    else // this is the line of code that will be run
      Console.WriteLine("Unable to process request");
    if (resultB > 0) // this evaluates to FALSE and therefore won't execute the next line of code
      Console.WriteLine($"Measurement (w/ offset): {50 + resultB}");

  // Code challenge 1
    string[] values = { "12.3", "45", "ABC", "11", "DEF" };
    float total = 0;
    string message = "";
    for (int i = 0; i < values.Length; i++)
    {
      float storageNum = 0;
      if (float.TryParse(values[i], out storageNum))
        total += storageNum;
      else 
        message = message + values[i];
    }

    Console.WriteLine($"Message: {message} \nTotal: {total}");

  // Code Challenge 2
    int value1 = 12;
    decimal value2 = 6.2m;
    float value3 = 4.3f;

    int result1 = Convert.ToInt32((decimal)value1 / value2);
    // Hint: You need to round the result to nearest integer (don't just truncate)
    Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

    decimal result2 = value2 / (decimal)value3;
    Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

    float result3 = value3 / value1;
    Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
*/

/* Module 3 - Perform operations on arrays using helper methods
  string[] pallets = { "B14", "A11", "B12", "A13" };

  Console.WriteLine("Sorted...");
  Array.Sort(pallets);
  foreach (var pallet in pallets)
  {
      Console.WriteLine($"-- {pallet}");
  }

  Console.WriteLine("\nReversed...");
  Array.Reverse(pallets);
  foreach (var pallet in pallets)
  {
    Console.WriteLine($"-- {pallet}");
  }

  Array.Clear(pallets, 0, 2); // in pallets array, start at index 0 and clear 2 elements
  Console.WriteLine($"\nClearing 2 ... count: {pallets.Length}");
  foreach (var pallet in pallets)
  {
    Console.WriteLine($"-- {pallet}");
  }

  Array.Resize(ref pallets, 6);
  Console.WriteLine($"\nResizing to 6 ... count: {pallets.Length}");

  pallets[4] = "C01";
  pallets[5] = "C02";

  foreach (var pallet in pallets)
  {
    Console.WriteLine($"-- {pallet}");
  }

  Array.Resize(ref pallets, 3);
  Console.WriteLine($"\nResizing to 3 ... count: {pallets.Length}");

  foreach (var pallet in pallets)
  {
    Console.WriteLine($"-- {pallet}");
  }

  string value = "abc123";
  char[] valueArray = value.ToCharArray();
  Array.Reverse(valueArray);
  // string result = new string(valueArray);
  string result = String.Join(",", valueArray); // create one string value out of array values, joined by commas
  Console.WriteLine($"\n{result}\n");
  string[] items = result.Split(','); // then split the string value created above by separating at the commas
  foreach (string item in items)
  {
    Console.WriteLine($"{item}");
  }


  // Code Challenge 1
    string pangram = "The quick brown fox jumps over the lazy dog";
    string[] words = pangram.Split(" ");
    string[] newWords = new string[words.Length];

    for (int i = 0; i < words.Length; i++)
    {
      char[] wordArr = words[i].ToCharArray();
      Array.Reverse(wordArr);
      string newWord = String.Join("", wordArr);
      newWords[i] = newWord;
    }
    string finalMessage = String.Join(" ", newWords);
    Console.WriteLine(finalMessage);

  // Code Challenge 2
    string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
    string[] orderNums = orderStream.Split(",");
    Array.Sort(orderNums);

    for (int i = 0; i < orderNums.Length; i++)
    {
      if (orderNums[i].Length == 4)
        Console.WriteLine(orderNums[i]);
      else
        Console.WriteLine($"{orderNums[i]} \t- Error");
    }
*/

/* Module 4 - Format alphanumeric data for presentation in C#
  string first = "Hello";
  string second = "World";
  Console.WriteLine($"{first} {second}"); // Hello World!
  Console.WriteLine($"{second} {first}!"); // World Hello!
  Console.WriteLine($"{first} {first} {first}!"); // Hello Hello Hello!

  decimal price = 123.45m;
  int discount = 50;
  Console.WriteLine($"Price: {price:C} (Save {discount:C})"); // currency format specifier
  // culture code: five character string that computers use to identify the location and language of the end user (ex: en-US)

  decimal measurement = 123456.78912m;
  Console.WriteLine($"Measurement: {measurement:N2} units"); // Measurement: 123,457.79 units (numeric format specifier, 2 digits after decimal point)

  decimal tax = .36785m;
  Console.WriteLine($"Tax rate: {tax:P2}"); // Tax rate: 36.79% (P format specifier for formatting percentages, 2 digits after decimal point)

  decimal originalPrice = 67.55m;
  decimal salePrice = 59.99m;
  // combine formatting approaches; option A
    string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price.", (originalPrice - salePrice), originalPrice);
  // combine formatting approaches; option B
    yourDiscount += $" A discount of {(originalPrice - salePrice)/price:P2}!";
    Console.WriteLine(yourDiscount);

    string input = "Pad this";
    Console.WriteLine(input.PadLeft(12)); //     Pad this
    Console.WriteLine(input.PadRight(12, '-')); // Pad this---- (this is the overloaded method for PadRight() because now there is a second argument)

    string paymentId = "769C";
    string payeeName = "Mr. Bob Squarepants";
    string paymentAmount = "$5,000.00";

    var formattedLine = paymentId.PadRight(6);
    formattedLine += payeeName.PadRight(24, '.'); // additional practice with overload version of PadRight()
    formattedLine += paymentAmount.PadLeft(10);

    Console.WriteLine("1234567890123456789012345678901234567890"); // this line of numbers acts like a ruler to show in the console how many columns the formatted line should be 
    Console.WriteLine(formattedLine);

  // Code Challenge
    string customerName = "Mr. Patrick Star";

    string currentProduct = "Magic Yield";
    int currentShares = 2975000;
    decimal currentReturn = 0.1275m;
    decimal currentProfit = 55000000.0m;

    string newProduct = "Glorious Future";
    decimal newReturn = 0.13125m;
    decimal newProfit = 63000000.0m;

    // Your logic here
    string greeting = $"Dear {customerName},";
    string firstSentence = $"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.";
    string secondSentence = $"Currently, you own {currentShares:C} shares at a return of {currentReturn:P2}.";
    string thirdSentence = $"Our new product, {newProduct} offers a return of {newReturn:P2}. Given your current volume, your potential profit would be {newProfit:C}.";

    Console.WriteLine($"{greeting}\n\n{firstSentence}\n\n{secondSentence}\n\n{thirdSentence}\n");
    Console.WriteLine("Here's a quick comparison:\n");

    string comparisonMessage = "";

    // Your logic here
    var currentProductFormattedRow = currentProduct.PadRight(18);
    string currentReturnFormatted = $"{currentReturn:P2}";
    string currentProfitFormatted = $"{currentProfit:C2}";
    currentProductFormattedRow += currentReturnFormatted.PadLeft(8) + currentProfitFormatted.PadLeft(18);

    var newProductFormattedRow = newProduct.PadRight(18);
    string newReturnFormatted = $"{newReturn:P2}";
    string newProfitFormatted = $"{newProfit:C2}";
    newProductFormattedRow += newReturnFormatted.PadLeft(8) + newProfitFormatted.PadLeft(18);

    comparisonMessage = $"{currentProductFormattedRow}\n{newProductFormattedRow}";

    Console.WriteLine(comparisonMessage);

  // Per solution on Microsoft Learn, check out how the format specifier can be added to the token:
    comparisonMessage = currentProduct.PadRight(20) + String.Format("{0:P}", currentReturn).PadRight(10) + String.Format("{0:C}", currentProfit).PadRight(20);

    comparisonMessage += "\n" + newProduct.PadRight(20) + String.Format("{0:P}", newReturn).PadRight(10) + String.Format("{0:C}", newProfit).PadRight(20);

    Console.WriteLine(comparisonMessage);
  */

// Module 5 - Modify the content of strings using built-in string data type methods
string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

Console.WriteLine(openingPosition); // 13
Console.WriteLine(closingPosition); // 36

int length = closingPosition - (openingPosition + 1);
Console.WriteLine(message.Substring(openingPosition, length)); // (inside the parenthese

int startMessage = openingPosition + 1;
Console.WriteLine(message.Substring(startMessage, length)); // inside the parentheses