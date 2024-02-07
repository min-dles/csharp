// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("The current time is " + DateTime.Now);
Console.WriteLine("My name is Mandi, Hi!");

string[] scramble = { "meeting", "me!", ":)", "Thank", "for", "with", "you" };
int[] codex = { 3, 6, 4, 0, 5, 1, 2 };

foreach (int key in codex)
{
  Console.WriteLine(scramble[key]);
}