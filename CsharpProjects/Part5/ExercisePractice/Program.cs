using System;
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

  // Exercise 2: refactor duplicate code by writing methods
  int[] times = {800, 1200, 1600, 2000};
  int diff = 0;

  Console.WriteLine("Enter current GMT");
  int currentGMT = Convert.ToInt32(Console.ReadLine());

  Console.WriteLine("Current Medicine Schedule:");
  DisplayTimes(); // first call to this method

  Console.WriteLine("Enter new GMT");
  int newGMT = Convert.ToInt32(Console.ReadLine());

  if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
  {
    Console.WriteLine("Invalid GMT");
  }
  else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
  {
    diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
    AdjustTimes(); // first call 
  } 
  else 
  {
    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
    AdjustTimes(); // second call
  }

  Console.WriteLine("New Medicine Schedule:");
  DisplayTimes(); // second call to this method

  void DisplayTimes() // method defined at the end
  {
    /* Format and display medicine times */
    foreach (int val in times)
    {
      string time = val.ToString();
      int len = time.Length;

      if (len >= 3)
      {
        time = time.Insert(len - 2, ":");
      }
      else if (len == 2)
      {
        time = time.Insert(0, "0:");
      }
      else
      {
        time = time.Insert(0, "0:0");
      }

      Console.Write($"{time} ");
    }
    Console.WriteLine(); // need to append a new line after times are displayed
  }

  void AdjustTimes()
  {
    /* Adjust the times by adding the difference, keeping the value within 24 hours */
    for (int i = 0; i < times.Length; i++) 
    {
      times[i] = ((times[i] + diff)) % 2400;
    }
  }

// Exercise 3: practice developing code with methods & pseudo-code

/*
if ipAddress consists of 4 numbers
and
if each ipAddress number has no leading zeroes
and
if each ipAddress number is in range 0 - 255

then ipAddress is valid

else ipAddress is invalid
*/

if (ValidateLength() && ValidateZeroes() && ValidateRange())
{
  Console.WriteLine($"ip is a valid IPv4 address.");
}
else 
{
  Console.WriteLine($"ip is *NOT* a valid IPv4 address.");
}

void ValidateLength() {}
void ValidateZeroes() {}
void ValidateRange() {}