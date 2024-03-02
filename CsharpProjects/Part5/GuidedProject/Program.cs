using System;

string[] pettingZoo = 
{
  "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
  "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
  "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

void RandomizeAnimals()
{
  // this method will pick animals randomly
  Random random = new Random();

  for (int i = 0; i < pettingZoo.Length; i++)
  {
    int r = random.Next(i, pettingZoo.Length);

    string temp = pettingZoo[i];
    pettingZoo[i] = pettingZoo[r];
    pettingZoo[r] = temp;
  }
};

// string[,] group = AssignGroup();

Console.WriteLine("School A");

void PrintGroup(string group)
{
  // method to print the animal groups
};

RandomizeAnimals();
// test code written to this point:
foreach (string animal in pettingZoo)
{
  Console.Write($" {animal},");
}