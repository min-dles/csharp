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

// Exercise 3 - Challenge: Improve renewal rate of subscriptions
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