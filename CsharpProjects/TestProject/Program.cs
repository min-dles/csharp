// Exercise - Decision Logic Game
Random dice = new Random();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);
int total = roll1 + roll2 + roll3;

// Intial total:
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// Check for triples and then doubles:
if ((roll1 == roll2) && (roll2 == 3))
{
  total +=6;
  Console.WriteLine($"Congrats, you rolled a triple! +6 to your score: {total}");
}
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
  total += 2;
  Console.WriteLine($"Congrats, you rolled doubles! +2 added to your score: {total}");
}

// final score:
if (total >= 15)
{
  Console.WriteLine("You win!");
}

if (total < 15)
{
  Console.WriteLine("Sorry, you lose.");
}

// Exercise - Math class methods
int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);