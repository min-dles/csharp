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

/* Module 2 - Control variable scope and logic using code blocks in C#
bool flag = true;
int value = 0;

if (flag)
{
  value = 10;
  Console.WriteLine($"Inside of the code block: {value}"); // 10
}

Console.WriteLine($"Outside of the code block: {value}"); // still 10

if (flag)
{
  Console.WriteLine($"True, but don't need a whole code block. -> {flag}"); // true
}

if (flag)
  Console.WriteLine($"Still True! -> {flag}"); // true

if (flag) Console.WriteLine($"Still True, but less readable on one line. -> {flag}"); // true

string name1 = "lola";
if (name1 == "mandi") Console.WriteLine("Found Mandi");
else if (name1 == "lola") Console.WriteLine("Found Lola");
else Console.WriteLine("Found Ximena");

// compare above readability to code below:
string name2 = "lola";

if (name2 == "mandi")
  Console.WriteLine("Found Mandi");
else if (name2 == "lola")
  Console.WriteLine("Found Lola");
else
  Console.WriteLine("Found Ximena");

// set up Variable Scope Challenge:
  // Output should read as follows
    // Set contains 42
    // Total: 108
Console.WriteLine("*** VARIABLE SCOPE CHALLENGE: ***");
int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;

foreach (int number in numbers)
{
  total += number;

  if (number == 42)
    found = true;
}

if (found)
  Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");
*/

/* Module 3 - Branch the flow of code using the switch-case construct in C#
int employeeLevel = 100;
string employeeName = "John Smith";

string title = "";

// The switch statement defines a single code block that includes 
// a list of switch sections. To the right of the switch keyword 
// is a switch expression that's enclosed in parentheses.
switch (employeeLevel) // switch statement = switch keyword + switch expression
{
    case 100: // case label in a switch section
    case 200: // two case labels assigned to same switch section 
        title = "Senior Associate";
        break;
    case 300: // case label in switch section
        title = "Manager";
        break;
    case 400: // case label switch section
        title = "Senior Manager";
        break;
    default: // default case in switch section
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");

  // Code Challenge: Convert to Switch Statement
  Console.WriteLine("*** CODE CHALLENGE: Rewrite if-else to Switch ***");

// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0])
{
  case "01":
    type = "Sweat shirt";
    break;
  case "02":
    type = "T-Shirt";
    break;
  case "03":
    type = "Sweat pants";
    break;
  default:
    type = "Other";
    break;
}

switch (product[1])
{
  case "BL":
    color = "Black";
    break;
  case "MN":
    color = "Maroon";
    break;
  default:
    color = "White";
    break;
}

switch (product[2])
{
  case "S":
    size = "Small";
    break;
  case "M":
    size = "Medium";
    break;
  case "L":
    size = "Large";
    break;
  default:
    size = "One size fits all.";
    break;
}

Console.WriteLine($"Product: {size} {color} {type}");
*/

// Module 4 - Iterate through a code block using for statement in C#
Console.WriteLine("*** Exercise - Create & Configure (for) iteration loops ***");

// below is an example "for" statement which includes six parts:
  // 1. the "for" keyword
  // 2. parentheses after the keyword which defines the conditions of the "for" iteration; it contains three distinct parts:
    // 3. part one: INITIALIZER. defines & initializes the iterator variable
    // 4. part two: CONDITION. defines the completion condition.
    // 5. part three: ITERATOR. defines the action to take after each iteration.
  // 6. The code block contains the code that will be executed for each iteration. 
    // 6a. Inside the example code block below, the value of 'i' is referenced; this section is referred to as the BODY.
for (int i = 0; i < 10; i++)
{
  Console.WriteLine(i);
}

Console.WriteLine("*** Countdown with (for) Iteration: ***");
for (int i = 10; i >= 0; i--)
{
  Console.WriteLine(i);
}

Console.WriteLine("*** Experiment with Iterator's Pattern: ***");
for (int i = 0; i < 10; i += 3)
{
  Console.WriteLine($"Count by threes: {i}");
}

Console.WriteLine("*** Practice with Break keyword on iteration statements: ***");
for (int i = 0; i < 10; i++)
{
  Console.WriteLine($"Stop counting at 7: {i}");
  if (i == 7) break;
}

Console.WriteLine("*** iteration to loop thru each element in array: ***");
// foreach iterates thru every element in an array, but for statements can be configured to more precision:
string[] names = { "Lola", "Ximena", "Mandi", "Adrianna" };
for (int i = names.Length - 1; i >= 0; i--)
{
  Console.WriteLine($"See names in array backwords: {names[i]}");
}