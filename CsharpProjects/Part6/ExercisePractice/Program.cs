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

// Module Three: Implement Exception Handling in C# console apps
try
{   
   // try code block - code that may generate an exception
}
catch
{   
   // catch code block - code to handle an exception
}
finally
{   
   // finally code block - code to clean up resources
}