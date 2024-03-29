// the ourAnimals array will store the following:
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
  switch (i)
  {
    case 0:
      animalSpecies = "dog";
      animalID = "d1";
      animalAge = "2";
      animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";       animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
      animalNickname = "lola";
      break;

    case 1:
      animalSpecies = "dog";
      animalID = "d2";
      animalAge = "9";
      animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
      animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
      animalNickname = "loki";
      break;

    case 2:
      animalSpecies = "cat";
      animalID = "c3";
      animalAge = "1";
      animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
      animalPersonalityDescription = "friendly";
      animalNickname = "Puss";
      break;

    case 3:
      animalSpecies = "cat";
      animalID = "c4";
      animalAge = "?";
      animalPhysicalDescription = "";
      animalPersonalityDescription = "";
      animalNickname = "";
      break;

    default:
      animalSpecies = "";
      animalID = "";
      animalAge = "";
      animalPhysicalDescription = "";
      animalPersonalityDescription = "";
      animalNickname = "";
      break;
  }

  ourAnimals[i, 0] = "ID #: " + animalID;
  ourAnimals[i, 1] = "Species: " + animalSpecies;
  ourAnimals[i, 2] = "Age: " + animalAge;
  ourAnimals[i, 3] = "Nickname: " + animalNickname;
  ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
  ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}

do
{
  // display the top-level menu options
  Console.Clear();

  Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
  Console.WriteLine(" 1. List all of our current pet information");
  Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
  Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
  Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
  Console.WriteLine(" 5. Edit an animal’s age");
  Console.WriteLine(" 6. Edit an animal’s personality description");
  Console.WriteLine(" 7. Display all cats with a specified characteristic");
  Console.WriteLine(" 8. Display all dogs with a specified characteristic");
  Console.WriteLine();
  Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

  readResult = Console.ReadLine();
  if (readResult != null)
    menuSelection = readResult.ToLower();

  // Console.WriteLine($"You selected menu option: {menuSelection}.");
  // Console.WriteLine("Press the Enter key to continue");

  // // pause code execution
  // readResult = Console.ReadLine();

  switch (menuSelection)
  {
    case "1":
      // List all current pet info
      for (int i = 0; i < maxPets; i++)
      {
        if (ourAnimals[i, 0] != "ID #: ")
        {
          Console.WriteLine();

          for (int j = 0; j < 6; j++)
          {
            Console.WriteLine(ourAnimals[i, j]);
          }
        }
      }
      Console.WriteLine("Press the Enter key to continue");
      readResult = Console.ReadLine();
      break;

    case "2":
      // Add new pet to ourAnimals array
      string anotherPet = "y";
      int petCount = 0;

      for (int i = 0; i < maxPets; i++)
      {
        if (ourAnimals[i, 0] != "ID #: ")
        {
          petCount += 1;
        }
      }

      if (petCount < maxPets)
      {
        Console.WriteLine($"We currently have {petCount} pets and can take in {(maxPets - petCount)} more.");
      }

      while (anotherPet == "y" && petCount < maxPets)
      {
        bool validEntry = false;
        do
        {
          Console.WriteLine("\n\rEnter \"dog\" or \"cat\" to begin a new entry.");
          readResult = Console.ReadLine();

          if (readResult != null)
          {
            animalSpecies = readResult.ToLower();

            if (animalSpecies != "dog" && animalSpecies != "cat")
              validEntry = false;
            else
              validEntry = true;
          }
        } while (validEntry == false);

        animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();

        do
        {
          int petAge;
          Console.WriteLine("Enter pet's age or \"?\" if unknown.");
          readResult = Console.ReadLine();

          if (readResult != null)
          {
            animalAge = readResult;

            if (animalAge != "?")
            {
              validEntry = int.TryParse(animalAge, out petAge);
            }
            else
            {
              validEntry = true;
            }
          }
        } while (validEntry == false);

        do
        {
          Console.WriteLine("Enter info about animal's physical description.");
          readResult = Console.ReadLine();

          if (readResult != null)
          {
            animalPhysicalDescription = readResult.ToLower();

            if (animalPhysicalDescription == "")
            {
              animalPhysicalDescription = "tbd";
            }
          }
        } while (animalPhysicalDescription == "");

        do
        {
          Console.WriteLine("Enter description of pet's personality.");
          readResult = Console.ReadLine();

          if (readResult != null)
          {
            animalPersonalityDescription = readResult.ToLower();

            if (animalPersonalityDescription == "")
            {
              animalPersonalityDescription = "tbd";
            }
          }
        } while (animalPersonalityDescription == "");

        do
        {
          Console.WriteLine("Enter pet's nickname:");
          readResult = Console.ReadLine();

          if (readResult != null)
          {
            animalNickname = readResult.ToLower();

            if (animalNickname == "")
            {
              animalNickname = "tbd";
            }
          }
        } while (animalNickname == "");

        ourAnimals[petCount, 0] = "ID #: " + animalID;
        ourAnimals[petCount, 1] = "Species: " + animalSpecies;
        ourAnimals[petCount, 2] = "Age: " + animalAge;
        ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
        ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
        ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

        petCount = petCount + 1;

        if (petCount < maxPets)
        {
          Console.WriteLine("Do you want to add another pet? (y/n)");
          do
          {
            readResult = Console.ReadLine();

            if (readResult != null)
            {
              anotherPet = readResult.ToLower();
            }

          } while (anotherPet != "y" && anotherPet != "n");
        }
      }

      if (petCount >= maxPets)
      {
        Console.WriteLine("Maximum number of pets reached; NO MORE OR ELSE");
        Console.WriteLine("Press the Enter key to continue");
        readResult = Console.ReadLine();
      }
      break;

    case "3":
      for (int i = 0; i < maxPets; i++)
      {
        if (ourAnimals[i, 0] != "ID #: ")
        {
          if (ourAnimals[i, 2] == "Age: ?")
          {
            int petAge = 0;
            do
            {
              Console.WriteLine($"Enter an age for {ourAnimals[i, 0]}.");
              readResult = Console.ReadLine();
              petAge = 0;
              bool validEntry = false;
              validEntry = int.TryParse(readResult, out petAge);
              if (!validEntry)
              {
                Console.WriteLine("Please enter a number");
              }
              else if (petAge <= 0)
              {
                Console.WriteLine("You sure about that? Your pet isn't even born yet?!");
              }
              else if (petAge > 100)
              {
                Console.WriteLine($"Holy smokes ur cat or dog is {petAge} years old?! Try Again, bud.");
              }
              else
              {
                ourAnimals[i, 2] = "Age: " + petAge.ToString();

                Console.WriteLine($"Thank you for updating data for pet {ourAnimals[i, 0]}. You reported age as: {petAge} years old.");
              }
            } while ((petAge <= 0) || (petAge > 100));
          }
          
          if ((ourAnimals[i, 4] == "Physical description: ") || (ourAnimals[i, 4] == "Physical description: tbd"))
          {
            animalPhysicalDescription = "";
            do
            {
              Console.WriteLine($"Please provide a physical description for {ourAnimals[i, 0]}.");
              readResult = Console.ReadLine();

              if (readResult != null)
              {
                animalPhysicalDescription = readResult.ToLower();

                if (animalPhysicalDescription.Length < 4)
                {
                  Console.WriteLine($"Please provide more info than '{animalPhysicalDescription}'. You can mention things like size, color, breed, etc.");
                  continue;
                }

                ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;

                Console.WriteLine($"Thank you for updating data for pet {ourAnimals[i, 0]}. You reported physical description as: {animalPhysicalDescription}.");
              }
            } while (animalPhysicalDescription.Length < 4);

            Console.WriteLine("All animal data is filled in; no missing data. Thanks! Press the Enter key to continue.");
            readResult = Console.ReadLine();
          }
        }
      }
      Console.WriteLine("Press the Enter key to return to main menu.");
      readResult = Console.ReadLine();
      break;

    case "4":
      // Ensure animal nicknames and personality descriptions are complete
      for (int i = 0; i < maxPets; i++)
      {
        if ((ourAnimals[i, 0] != "ID #: ") && ((ourAnimals[i, 3] == "Nickname: ") || (ourAnimals[i, 3] == "Nickname: tbd")))
        {
          animalNickname = "";
          do
          {
            Console.WriteLine($"Please enter a nickname for {ourAnimals[i, 0]}.");
            readResult = Console.ReadLine();

            if (readResult != null)
            {
              animalNickname = readResult.ToLower();

              if (animalNickname.Length == 0)
              {
                Console.WriteLine("Please try again; need to enter at least one character for the nickname.");
                continue;
              }

              ourAnimals[i, 3] = "Nickname: " + animalNickname;

              Console.WriteLine($"Thanks for updating data on {ourAnimals[i, 0]}. Nickname entered as: {animalNickname}.");
            }
          } while (animalNickname == "");
        }
        
        if ((ourAnimals[i, 0] != "ID #: ") && ((ourAnimals[i, 5] == "Personality: ") || (ourAnimals[i, 5] == "Personality: tbd")))
        {
          animalPersonalityDescription = "...";
          do
          {
            Console.WriteLine($"Hi, personality for {ourAnimals[i, 0]} is currently listed as '{animalPersonalityDescription}'. Please update this ASAP.");
            readResult = Console.ReadLine();

            if (readResult != null)
            {
              animalPersonalityDescription = readResult.ToLower();

              if (animalPersonalityDescription.Length < 5)
              {
                Console.WriteLine("Please provide more info than this; how would you describe this sweet little baby?! What are they like?");
                continue;
              }

              ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;

              Console.WriteLine($"Thanks for updating info on {ourAnimals[i, 0]}. Personality description provided is: {animalPersonalityDescription}.");
            }
          } while (animalPersonalityDescription.Length < 5);
          
          Console.WriteLine("All animal data is filled in; no missing data. Thanks! Press the Enter key to continue.");
          readResult = Console.ReadLine();
        }
      }
      Console.WriteLine("Press the Enter key to return to main menu.");
      readResult = Console.ReadLine();
      break;

    case "5":
      // Edit an animal’s age
      Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
      Console.WriteLine("Press the Enter key to continue");
      readResult = Console.ReadLine();
      break;

    case "6":
      // Edit an animal’s personality description
      Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
      Console.WriteLine("Press the Enter key to continue");
      readResult = Console.ReadLine();
      break;

    case "7":
      // Display all cats with a specified characteristic
      Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
      Console.WriteLine("Press the Enter key to continue");
      readResult = Console.ReadLine();
      break;

    case "8":
      // Display all dogs with a specified characteristic
      Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
      Console.WriteLine("Press the Enter key to continue");
      readResult = Console.ReadLine();
      break;

    default:
      break;
}

} while (menuSelection != "exit");