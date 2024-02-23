// Module 1 - Write your first C# Method

// Exercise 1: write your first method
Console.WriteLine("Generating 5 Random Numbers:");
DisplayRandomNumbers(); // call the method first

void DisplayRandomNumbers() // can then define it at the end
{
  Random random = new Random();

  for (int i = 0; i < 5; i++)
  {
    Console.Write($"{random.Next(1, 100)} ");
  }
  Console.WriteLine(); // called to display a new line after the loop displaying the numbers is complete
}