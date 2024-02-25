using System;
/* Module 1 - Write your first C# Method
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
      // Format and display medicine times
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
      // Adjust the times by adding the difference, keeping the value within 24 hours
      for (int i = 0; i < times.Length; i++) 
      {
        times[i] = ((times[i] + diff)) % 2400;
      }
    }

  // Exercise 3: practice developing code with methods & pseudo-code
    string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
    string[] address;
    bool validLength = false;
    bool validZeroes = false;
    bool validRange = false;

    foreach (string ip in ipv4Input)
    {
      address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);
      ValidateLength();
      ValidateZeroes();
      ValidateRange();

      if (validLength && validZeroes && validRange)
      {
        Console.WriteLine($"{ip} is a valid IPv4 address.");
      }
      else 
      {
        Console.WriteLine($"{ip} is *NOT* a valid IPv4 address.");
      }
    };

    void ValidateLength() 
    {
      validLength = address.Length == 4;
    };

    void ValidateZeroes() 
    {
      foreach (string number in address)
      {
        if (number.Length > 1 && number.StartsWith("0"))
        {
          validZeroes = false;
          return; // if even one invalid Zero is found, the method call will end with this return
        }  
      }
      validZeroes = true;
    };

    void ValidateRange() 
    {
      foreach (string number in address)
      {
        int value = int.Parse(number);
        if (value < 0 || value > 255)
        {
          validRange = false;
          return;
        }
      }
      validRange = true;
    };

  // Exercise 4: Challenge to create a reusable method
    Random random = new Random();
    int luck = random.Next(100);

    string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
    string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
    string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
    string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};

    TellFortune();
    luck = random.Next(100);
    TellFortune();

    void TellFortune() 
    {
      Console.WriteLine("A fortune teller whispers the following words:");
      string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
      for (int i = 0; i < 4; i++) 
      {
        Console.WriteLine($"{i + 1}. {text[i]} {fortune[i]} ");
      }
      Console.WriteLine();
    };
*/
// Module 2 - Create methods with parameters
// Exercise 1: create a method that adjusts a time schedule
int[] schedule = {800, 1200, 1600, 2000};
DisplayAdjustedTimes(schedule, 6, -6);

void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT) 
{
  int diff = 0;
  if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
  {
    Console.WriteLine("Invalid GMT");
  }
  else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
  {
    diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
  } 
  else 
  {
    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
  }

  for (int i = 0; i < times.Length; i++)
  {
    int newTime = ((times[i] + diff)) % 2400;
    Console.WriteLine($"{times[i]} -> {newTime}");
  }
}

// Exercise 2: practice with scope
string[] students = { "Spongebob", "Patrick", "Sandy", "Squidward" }; // global variable scope

DisplayStudents(students);
DisplayStudents(new string[] {"Pearl", "Plankton"}); // not global; inaccessible outside of this context

void DisplayStudents(string[] students)
{
  foreach (string student in students)
  {
    Console.Write($"{student}, ");
  }
  Console.WriteLine();
}

// Exercise 3: Additional scope practice - with CircleArea
double pi = 3.14159;
PrintCircleInfo(12);
PrintCircleInfo(24);

void PrintCircleInfo(int radius)
{
  Console.WriteLine($"Circle details with this radius: {radius}");
  PrintCircleArea(radius);
  PrintCircleCircumference(radius);
}

void PrintCircleCircumference(int radius)
{
  double circumference = 2 * pi * radius;
  Console.WriteLine($"Circumference = {circumference}");
}

void PrintCircleArea(int radius)
{
  double area = pi * (radius * radius);
  Console.WriteLine($"Area = {area}");
}