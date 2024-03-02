using System;

string[] pettingZoo = 
{
  "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
  "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
  "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

void RandomizeAnimals(string[] zooAnimals)
{
  // this method will pick animals randomly
  int i = 0;
  int r = 1;

  string temp = pettingZoo[i];
  pettingZoo[i] = pettingZoo[r];
  pettingZoo[r] = temp;
};

// string[,] group = AssignGroup();

Console.WriteLine("School A");

void PrintGroup(string group)
{
  // method to print the animal groups
};