/* Module Two: Implement Debugging Tools in VSCode: 

Console.WriteLine("Hello World");

int productCount = 2000;
string[,] products = new string[productCount, 2];

LoadProducts(products, productCount);

for (int i = 0; i < productCount; i++)
{
  string result;
  result = Process1(products, i);

  if (result != "obsolete")
  {
    result = Process2(products, i);
  }
}

bool pauseCode = true;
while (pauseCode == true);

// dummy data generated for this debugging practice:
static void LoadProducts(string[,] products, int productCount)
{
  Random rand = new Random();

  for (int i = 0; i < productCount; i++)
  {
    int num1 = rand.Next(1, 10000) + 10000;
    int num2 = rand.Next(1, 101);

    string prodID = num1.ToString();

    if (num2 < 91)
    {
      products[i, 1] = "existing";
    }
    else if (num2 == 91)
    {
      products[i, 1] = "new";
      prodID = prodID + "-n";
    }
    else
    {
      products[i, 1] = "obsolete";
      prodID = prodID + "-0";
    }

    products[i, 0] = prodID;
  }
}

// simulate data processing:
static string Process1(string[,] products, int item)
{
  Console.WriteLine($"Process1 message - working on {products[item, 1]} product");

  return products[item, 1];
}

static string Process2(string[,] products, int item)
{
  Console.WriteLine($"Process2 message - working on product ID #: {products[item, 0]}");
  if (products[item, 1] == "new")
    Process3(products, item);

  return "continue";
}

static void Process3(string[,] products, int item)
{
  Console.WriteLine($"Process3 message - processing product information for 'new' product");
}
*/

/* Module Three: Implement Exception Handling in C# console apps
// implement a simple try-catch
try
{
  TestCallStack();
}
catch
{
  Console.WriteLine("Exception caught in top-level");
}

Console.WriteLine("Exit program");

static void TestCallStack()
{
  try
  {
    WriteMessage();
  }
  catch (DivideByZeroException ex)
  {
    Console.WriteLine($"exception caught in TestCallStack method: {ex.Message}");
  }
}

static void WriteMessage()
{
  double float1 = 3000.0;
  double float2 = 0.0;
  int number1 = 3000;
  int number2 = 0;
  byte smallNumber;

  try
  {
    Console.WriteLine(float1 / float2);
    Console.WriteLine(number1 / number2);
  }
  catch (DivideByZeroException ex)
  {
    Console.WriteLine($"exception caught in WriteMessage method: {ex.Message}");
  }

  checked
  {
    smallNumber = (byte)number1;
  }
}

// catch separate exception types
// inputValues is used to store numeric values entered by a user
string[] inputValues = new string[]{"three", "9999999999", "0", "2" };

foreach (string inputValue in inputValues)
{
  int numValue = 0;
  try
  {
    numValue = int.Parse(inputValue);
  }
  catch (FormatException)
  {
    Console.WriteLine("Invalid readResult. Please enter a valid number.");
  }
  catch (OverflowException)
  {
    Console.WriteLine("The number you entered is too large or too small.");
  }
  catch(Exception ex)
  {
    Console.WriteLine(ex.Message);
  }
}

// Exercise with exception types:
checked // in my initial attempt, forgot to use checked and the output was: "Result: -2"
{
  try
  {
    int num1 = int.MaxValue;
    int num2 = int.MaxValue;
    int result = num1 + num2;
    Console.WriteLine("Result: " + result);
  }
  catch (OverflowException ex)
  {
    Console.WriteLine("Error: The number is too large to be represented as an integer." + ex.Message);
  }
}

try
{
  string str = null;
  int length = str.Length;
  Console.WriteLine("String Length: " + length);
}
catch (NullReferenceException ex)
{
  Console.WriteLine("Error: The reference is null." + ex.Message);
}

try
{
  int[] numbers = new int[5];
  numbers[5] = 10;
  Console.WriteLine("Number at index 5: " + numbers[5]);
}
catch (IndexOutOfRangeException ex)
{
  Console.WriteLine("Error: Index out of range." + ex.Message);
}

try
{
  int num3 = 10;
  int num4 = 0;
  int result2 = num3 / num4;
  Console.WriteLine("Result: " + result2);
}
catch (DivideByZeroException ex)
{
  Console.WriteLine("Error: Cannot divide by zero." + ex.Message);
}

Console.WriteLine("Exiting program.");
*/

// Module Four: Create and Throw Exceptions in C# console apps
// review throw keyword and processes in debug (add breakpoints to see steps)
try
{
  OperatingProcedure1();
}
catch (Exception ex)
{
  Console.WriteLine(ex.Message);
  Console.WriteLine("Exiting application.");
}

static void OperatingProcedure1()
{
  string[][] userEnteredValues = new string[][]
  {
    new string[] { "1", "two", "3"},
    new string[] { "0", "1", "2"}
  };

  foreach (string[] userEntries in userEnteredValues)
  {
    try
    {
      BusinessProcess1(userEntries);
    }
    catch (Exception ex)
    {
      if (ex.StackTrace.Contains("BusinessProcess1"))
      {
        if (ex is FormatException)
        {
          Console.WriteLine(ex.Message);
          Console.WriteLine("Corrective action taken in OperatingProcedure1");
        }
        else if (ex is DivideByZeroException)
        {
          Console.WriteLine(ex.Message);
          Console.WriteLine("Partial correction in OperatingProcedure1 - further action required");

          // re-throw the original exception
          throw;
        }
        else
        {
          // create a new exception object that wraps the original exception
          throw new ApplicationException("An error occurred - ", ex);
        }
      }
    }
  }
}

static void BusinessProcess1(string[] userEntries)
{
  int valueEntered;

  foreach (string userValue in userEntries)
  {
    try
    {
      valueEntered = int.Parse(userValue);

      checked
      {
        int calculatedValue = 4 / valueEntered;
      }
    }
    catch (FormatException)
    {
      FormatException invalidFormatException = new FormatException("FormatException: User input values in 'BusinessProcess1' must be valid integers");
      throw invalidFormatException;
    }
    catch (DivideByZeroException)
    {
      DivideByZeroException unexpectedDivideByZeroException = new DivideByZeroException("DivideByZeroException: Calculation in 'BusinessProcess1' encountered an unexpected divide by zero");
      throw unexpectedDivideByZeroException;
    }
  }
}