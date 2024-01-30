/* Module 1 - Evaluate Boolean expressions to make decisions in C#
  // Practice with the equlity operator & Boolean expressions:
    Console.WriteLine("** Equality Operators Practice: **");
Console.WriteLine("a" == "a"); // true
Console.WriteLine("a" == "A"); // false
Console.WriteLine(1 == 2); // false

string myValue1 = "a";
Console.WriteLine(myValue1 == "a"); // true

string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower()); // true
  // Practice with inequality operators:
  Console.WriteLine("** Inequality Operators Practice: **");
Console.WriteLine("a" != "a"); // false
Console.WriteLine("a" != "A"); // true
Console.WriteLine(1 != 2); // true

string myValue2 = "a";
Console.WriteLine(myValue2 != "a"); // false
  // Practice with comparison operators:
  Console.WriteLine("** Comparison Operators Practice: **");
Console.WriteLine(1 > 2); // false
Console.WriteLine(1 < 2); // true
Console.WriteLine(1 >= 1); // true
Console.WriteLine(1 <= 1); // true

  // Practice with method that returns a Boolean:
  Console.WriteLine("** method that returns a Boolean: **");

string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox")); // true
Console.WriteLine(pangram.Contains("cow")); // false

  // Practice with logical negation:
  Console.WriteLine("** Logical Negation Practice: **");
// These two lines of code will create the same output
Console.WriteLine(pangram.Contains("fox") == false); // false
Console.WriteLine(!pangram.Contains("fox")); // false
  // Practice with logical negation operators:
  Console.WriteLine("** Logical Negation Operators: **");
Console.WriteLine(!pangram.Contains("fox")); // false
Console.WriteLine(!pangram.Contains("cow")); // true
// Additional practice:
int a = 7;
int b = 6;
Console.WriteLine(a != b); // output: True
string s1 = "Hello";
string s2 = "Hello";
Console.WriteLine(s1 != s2); // output: False

  // Practice with conditional operators:
  Console.WriteLine("** Ternary Conditional Operators: **");
// my practice example:
int promotionalDiscount = 100;
int normalDiscount = 50;
int customerPurchase = 99;
int customerDiscount = customerPurchase > 1000 ? promotionalDiscount : normalDiscount;

Console.WriteLine(customerDiscount);

// lesson example:
int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50; // 100
Console.WriteLine($"Discount: {discount}");

// simplify this even more: 
int newSaleAmount = 1001;
// int discount = newSaleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {(newSaleAmount > 1000 ? 100 : 50)}");

  // Challenge - conditional operators:
  Console.WriteLine("** Ternary Conditional Operators: Challenge **");

Random coin = new Random();
int coinFlip = coin.Next(1, 3); // 1 = heads, 2 = tails
Console.WriteLine($"Flip a Coin: {(coinFlip == 1 ? "heads" : "tails")}");
  // lesson simplified this example even more by skipping variable initialized:
    // and use values 0, 2 rather than 1, 3
Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");

  // Challenge - Decision Logic:
  Console.WriteLine("** Decision Logic: Challenge **");

string permission = "Manager";
int level = 20;
string insufficientPrivileges = "You do not have sufficient privileges.";
// Business rules of this challenge: 
  // 1. "Admin" && level > 55 : "Welcome, Super Admin user."
  // 2. "Admin" && level <= 55 : "Welcome, Admin user."
  // 3. "Manager" && level >= 20 : "Contact an Admin for access."
  // 4. "Manager" && level < 20 : "You do not have sufficient privileges."
  // 5. !"Admin|Manager" : "You do not have sufficient privileges."
Console.WriteLine("Expected output with current data: Contact admin");

if (permission.Contains("Admin"))
{
  if (level > 55)
  {
    Console.WriteLine("Welcome, Super Admin User.");
  }
  else
  {
    Console.WriteLine("Welcome, Admin.");
  }
}
else if (permission.Contains("Manager"))
{
  if (level >= 20)
  {
    Console.WriteLine("Contact Admin for support.");
  }
  else
  {
    Console.WriteLine(insufficientPrivileges);
  }
}
else
{
  Console.WriteLine(insufficientPrivileges);
}
*/

// Module 2 - Control variable scope and logic using code blocks in C#
bool flag = true;
int value = 0;

if (flag)
{
  value = 10;
  Console.WriteLine($"Inside of the code block: {value}"); // 10
}

Console.WriteLine($"Outside of the code block: {value}"); // still 10

if (flag)
  Console.WriteLine($"Still True! -> {flag}"); // true