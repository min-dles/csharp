using System;

string[] pettingZoo = 
{
  "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
  "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
  "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

PlanSchoolVisit("Lawndale High");
PlanSchoolVisit("Tom Landry Middle School", 3);
PlanSchoolVisit("Mrs. Puff's Boating School", 2);

void PlanSchoolVisit(string schoolName, int groups = 6)
{
  RandomizeAnimals();
  string[,] group = AssignGroup();
  Console.WriteLine(schoolName);
  PrintGroup(group);
  Console.WriteLine();
}

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

string[,] AssignGroup(int groups = 6)
{
  string[,] result = new string[groups, pettingZoo.Length/groups];
  int start = 0;

  for (int i = 0; i < groups; i++)
  {
    for (int j = 0; j < result.GetLength(1); j++)
    {
      result[i,j] = pettingZoo[start++];
    }
  }

  return result;
};

void PrintGroup(string[,] group)
{
  // method to print the animal groups
  for (int i = 0; i < group.GetLength(0); i++)
  {
    Console.Write($"Group {i + 1}: ");
    for (int j = 0; j < group.GetLength(1); j++)
    {
      Console.Write($"{group[i,j]} ");
    }
    Console.WriteLine();
  }
};