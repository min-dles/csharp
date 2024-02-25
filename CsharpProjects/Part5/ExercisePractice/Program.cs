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

// Exercise 4: Test pass by value
  int a = 3;
  int b = 4;
  int c = 0;

  Multiply(a, b, c); // inside Multiple method: 3 x 4 = 12
  Console.WriteLine($"global statement: {a} x {b} = {c}"); // global statement: 3 x 4 = 0

  void Multiply(int a, int b, int c) 
  {
    c = a * b; // this line of code executed actually calculates the answer
    Console.WriteLine($"inside Multiply method: {a} x {b} = {c}"); 
  }
  // About this exercise: The variables a, b, and c are passed to the Multiply method. The values of the variables are printed during the method execution, and printed again after the method is complete.

// Exercise 5: Test pass by reference
  int[] array = {1, 2, 3, 4, 5};

  PrintArray(array); // 1 2 3 4 5
  Clear(array); // [no output]
  PrintArray(array); // 0 0 0 0 0

  void PrintArray(int[] array) 
  {
    foreach (int a in array) 
    {
      Console.Write($"{a} ");
    }
    Console.WriteLine();
  }

  void Clear(int[] array) 
  {
    for (int i = 0; i < array.Length; i++) 
    {
      array[i] = 0;
    }
  }
  // About this exercise: Arrays are reference types. Reference types store the address of their values in memory. Notice that the array remains altered outside of the Clear method scope. This happens because the Clear method updated the values stored at each address.

// Exercise 6: Test with Strings
  string status = "Healthy";

  Console.WriteLine($"Start: {status}"); // Start: Healthy
  SetHealth(false); // Middle: Unhealthy
  Console.WriteLine($"End: {status}"); // End: Unhealthy

  void SetHealth(bool isHealthy) // remove parameter to instead change the value of global var 'status'
  {
    status = (isHealthy ? "Healthy" : "Unhealthy");
    Console.WriteLine($"Middle: {status}");
  }
  // About this exercise: If the SetHealth method didn't output the status, you might have assumed the method didn't execute correctly. Instead, a new string with the value "Unhealthy" was created and then lost in the method scope. To correct this problem, you can change SetHealth to use the global status variable instead.

// Exercise 7: RSVP exercise to test optional params
string[] guestList = {"S.Bob", "Krabs", "Gary", "Patrick"};
string[] rsvps = new string[10];
int count = 0;

// Note: When calling a method that accepts many parameters, it can be tricky to understand what the arguments represent. Using named arguments can improve the readability of your code. Use a named argument by specifying the parameter name followed by the argument value. In this task, you'll practice using named arguments.

// NOTE: Named arguments, when used with positional arguments, are valid if they're used in the correct position. (see line 299 for example)

RSVP("S.Bob");
RSVP("Krabs", 2, "Nuts");
RSVP(partySize: 2, name: "Pearl", inviteOnly: false); // named arguments are not required to be in a particular order; this line of code is the same as: 
RSVP(name: "Pearl", partySize: 2, inviteOnly: false); // Pearl now added to the list twice
RSVP("Squidward", inviteOnly: true, allergies: "Jackfruit"); // mix-and-match positional arguments with named arguments. This still outputs "Sorry, Squidward is not on the guest list."
RSVP("Gary", 4, inviteOnly: false);
RSVP("Patrick", 2, "Stone fruit", false);
ShowRSVPs(); // [all RSVPs listed: S.Bob, Krabs, Pearl, Gary, and Patrick]

void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true) 
{
  if (inviteOnly)
  {
    bool found = false;
    foreach (string guest in guestList)
    {
      if (guest.Equals(name)) {
        found = true;
        break;
      }
    }
    if (!found)
    {
      Console.WriteLine($"Sorry, {name} is not on the guest list");
      return;
    }
  }

  rsvps[count] = $"Name: {name},\tParty Size: {partySize}, \tAllergies: {allergies}";
  count++;
}

void ShowRSVPs()
{
  Console.WriteLine("\nTotal RSVPs:");
  for (int i = 0; i < count; i++)
  {
    Console.WriteLine(rsvps[i]);
  }
}