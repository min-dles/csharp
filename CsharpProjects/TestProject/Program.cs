/* Exercise 1 - Decision Logic Dice Game
Random dice = new Random();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);
int total = roll1 + roll2 + roll3;

// Initial total:
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// Check for doubles and then triples, without Point Stacking:
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
  if ((roll1 == roll2) && (roll2 == roll3))
  {
    total += 6;
    Console.WriteLine("Congrats, you rolled a triple! +6 to your score.");
  }
  else
  {
    total += 2;
    Console.WriteLine("Congrats, you rolled doubles! +2 added to your score.");
  }
  Console.WriteLine($"Your modified score after bonuses: {total}");
}

// final score & prize announcement:
if (total >= 16)
{
  Console.WriteLine("Woah, congrats! You win a brand new car!");
}
else if (total >= 10)
{
  Console.WriteLine("Nice roll; you win a new cell phone");
}
else if (total == 7)
{
  Console.WriteLine("Lucky 7; you win a free vacation!");
}
else
{
  Console.WriteLine("Thanks for playing; you win a donut!");
}
*/

/* Exercise 2 - Math class methods
int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);
*/

/* Exercise 3 - Challenge: Improve renewal rate of subscriptions
using System.Data;

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// code for testing purposes:
Console.WriteLine($"days until exp: {daysUntilExpiration}");

// first set of decision logic to determine path & set discount rate if appropriate:
if ((daysUntilExpiration <= 10) && (daysUntilExpiration > 5))
{
  Console.WriteLine("Your subscription will expire soon. Renew now!");
}
else if ((daysUntilExpiration <= 5) && (daysUntilExpiration > 1))
{
  Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
  discountPercentage = 10;
}
else if (daysUntilExpiration == 1)
{
  Console.WriteLine("Your subscription expires within a day!");
  discountPercentage = 20;
}
else if (daysUntilExpiration == 0)
{
  Console.WriteLine("Your subscription has expired.");
}

// second set of decision logic to display discount rates: 
if (discountPercentage == 10)
{
  Console.WriteLine("Renew now and save 10%!");
}
else if (discountPercentage == 20)
{
  Console.WriteLine("Renew now and save 20%!");
}
*/

/* Exercise 4 - Iterative data with arrays & foreach statements
// first way to initialize an array:
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";

// another way to initialize arrays using curly braces:
// string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

// Print the variables & access the array:
Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// Practice reassigning the value of an array element:
fraudulentOrderIDs[0] = "F000";
Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

// Length property of an array:
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

// Practice with foreach:
Console.WriteLine("***Practice with foreach statements below***");
int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
  sum += items;
  bin++;
  Console.WriteLine($"Bin {bin} = {items} items (Inventory running total: {sum})");
}
Console.WriteLine($"There are {sum} items in inventory.");

// Code Challenge: Find Fraudulent Orders in Array
string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
foreach (string ID in orderIDs)
{
  if (ID.StartsWith("B"))
  {
    Console.WriteLine($"{ID}");
  }
}
*/

/* Exercise 5 - Practice writing Readable Code
  // The following code creates five random OrderIDs
  // to test the fraud detection process. OrderIDs
  // consist of a letter from A to E, and a three 
  // digit number. Ex. A123.
Random random = new Random();
string[] orderIDs = new string[5];
for (int i = 0; i < orderIDs.Length; i++)
{
  int prefixValue = random.Next(65, 70);
  string prefix = Convert.ToChar(prefixValue).ToString();
  string suffix = random.Next(1, 1000).ToString("000");
  orderIDs[i] = prefix + suffix;
}
foreach (var orderID in orderIDs)
{
  Console.WriteLine(orderID);
}

// Practice using whitespace for readable code:
  // Example 1:
Console
.
WriteLine
(
  "Hello example 1!"
)
;

  // Example 2:
string firstWord="Hello";string lastWord="example 2!";Console.WriteLine(firstWord+" "+lastWord);

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) 
{
    if ((roll1 == roll2) && (roll2 == roll3)) 
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6; 
    } 
    else 
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}

// Code Challenge: Edit the code below to be more readable
  // Check the message for how many times "o" appears and then
  // reverse the message:
string message = "The quick brown fox jumps over the lazy dog.";

char[] lettersInMessage = message.ToCharArray();
int countOsInMessage = 0;
foreach (char letter in lettersInMessage) 
{ 
  if (letter == 'o') 
  { 
    countOsInMessage++; 
  } 
}
Console.WriteLine($"'o' appears {countOsInMessage} times.");

Array.Reverse(lettersInMessage);
string messageReversed = new String(lettersInMessage);
Console.WriteLine(messageReversed);
*/

/* Exercise 6 - Decision Logic
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
*/
  // Challenge - Decision Logic:
  Console.WriteLine("** Decision Logic: Challenge **");

string permission = "Manager";
int level = 10;
string insufficientPrivileges = "You do not have sufficient privileges.";
// Business rules of this challenge: 
  // 1. "Admin" && level > 55 : "Welcome, Super Admin user."
  // 2. "Admin" && level <= 55 : "Welcome, Admin user."
  // 3. "Manager" && level >= 20 : "Contact an Admin for access."
  // 4. "Manager" && level < 20 : "You do not have sufficient privileges."
  // 5. !"Admin|Manager" : "You do not have sufficient privileges."
Console.WriteLine($"Expected output with current data: {insufficientPrivileges}");

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