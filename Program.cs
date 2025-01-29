using System;
using System.Collections.Generic;
using System.IO;

class FoxAdventureGame
{
    static string foxName = "";
    static bool helpedRabbits = false;
    static bool foundEagleFeather = false;
    static bool convincedEagle = false;
    static bool stoppedWolf = false;
    static bool helpedHedgehog = false;
    static bool protectedTreasure = false;
    static bool squirrelTrust = false;
    static bool owlWisdom = false;
    static string currentLocation = "The Whispering Glade"; // Starting location
    static List<string> inventory = new List<string>();
    static string saveFilePath = "FoxAdventureSave.txt";

    static void Main(string[] args)
    {
        Console.Title = "Vixen";
        MainMenu();
    }

    static void MainMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("SdoowEhtNiEmTeem");
            Console.WriteLine("\n1 - New Game");
            Console.WriteLine("2 - Load Game");
            Console.WriteLine("3 - Exit");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                StartNewGame();
                break;
            }
            else if (choice == "2")
            {
                LoadGame();
                break;
            }
            else if (choice == "3")
            {
                Console.WriteLine("Farewell, wanderer...");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("A shadow veils your choice. Try again.");
                Console.ReadKey();
            }
        }
    }

    static void StartNewGame()
    {
        Console.Clear();
        Console.WriteLine("In the heart of the ancient forest, a fox stirs. It's name is...");
        foxName = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(foxName))
        {
            foxName = "Nameless Fox";
        }
        Console.WriteLine($"{foxName}, awake.");
        Console.ReadKey();
        PlayGame();
    }

    static void PlayGame()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"You are looking to {currentLocation}, where shadows dance and secrets linger.");
            Console.WriteLine($"{foxName}. The forest watches, and the path ahead is shrouded in mystery.");
            Console.WriteLine("\nWhat will you do?");
            Console.WriteLine("1 - Aid the Timid Rabbits");
            Console.WriteLine("2 - Seek the Eagle's Favor");
            Console.WriteLine("3 - Confront the Shadow Wolf");
            Console.WriteLine("4 - Rescue the Trapped Hedgehog");
            Console.WriteLine("5 - Guard the Squirrel's Hoard");
            Console.WriteLine("6 - Seek Wisdom from the Owl");
            Console.WriteLine("7 - Inspect Your Belongings");
            Console.WriteLine("8 - Save Your Journey");
            Console.WriteLine("9 - Leave the Forest");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    HelpRabbits();
                    break;
                case "2":
                    ConvinceEagle();
                    break;
                case "3":
                    FaceTheWolf();
                    break;
                case "4":
                    HelpHedgehog();
                    break;
                case "5":
                    ProtectSquirrelTreasure();
                    break;
                case "6":
                    SeekOwlWisdom();
                    break;
                case "7":
                    CheckInventory();
                    break;
                case "8":
                    SaveGame();
                    break;
                case "9":
                    Console.WriteLine("The forest bids you farewell...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("The wind carries no answer. Choose again.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void HelpRabbits()
    {
        Console.Clear();
        currentLocation = "The Rabbit's Glade";
        if (!helpedRabbits)
        {
            Console.WriteLine("You find yourself in a sunlit glade, where the rabbits huddle together, their ears twitching nervously.");
            Console.WriteLine("\"Please, help us,\" one whispers. \"The Shadow Wolf has been prowling nearby. We don't know what to do.\"");
            Console.WriteLine("\n1 - Help the rabbits");
            Console.WriteLine("2 - Leave them to their fate");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                helpedRabbits = true;
                Console.WriteLine("You guide the rabbits to a safer part of the forest, showing them how to camouflage their burrows.");
                Console.WriteLine("\"Thank you,\" they say, their voices trembling with relief. \"We won't forget this.\"");
                inventory.Add("Rabbit's Blessing");
                Console.WriteLine("\nPress anything.");
                Console.ReadKey();
            }
            else if (choice == "2")
            {
                Console.WriteLine("You turn away, leaving the rabbits to their fate. Their soft cries linger in the air as you walk away.");
                Console.WriteLine("\nPress anything.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("The forest grows silent, as if waiting for your decision.");
                Console.WriteLine("\nPress anything.");
                Console.ReadKey();
            }
        }
        else
        {
            Console.WriteLine("The rabbits nod at you gratefully. \"You've already done so much for us,\" they say. \"We're safe now.\"");
            Console.WriteLine("\nPress anything.");
            Console.ReadKey();
        }
    }

    static void ConvinceEagle()
    {
        Console.Clear();
        currentLocation = "The Eagle's Perch";
        if (!convincedEagle)
        {
            Console.WriteLine("You climb to the Eagle's Perch, a rocky outcrop high above the forest. The eagle watches you with sharp, calculating eyes.");
            Console.WriteLine("\"Why have you come here, little fox?\" it asks, its voice low and steady.");
            Console.WriteLine("To earn its trust, you must find one of its feathers, lost somewhere in the forest.");
            Console.WriteLine("\n1 - Search for the feather");
            Console.WriteLine("2 - Leave without its favor");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                if (!foundEagleFeather)
                {
                    if (inventory.Contains("Forest Key"))
                    {
                        foundEagleFeather = true;
                        Console.WriteLine("Using the Forest Key, you unlock a hidden grove and find the eagle's feather, gleaming in the sunlight.");
                        Console.WriteLine("You present it to the eagle, who studies you for a long moment before nodding.");
                        convincedEagle = true;
                        inventory.Add("Eagle's Alliance");
                        Console.WriteLine("\"You have proven yourself, fox. If you ever need my aid, call for me.\"");
                    }
                    else
                    {
                        Console.WriteLine("The forest is vast, and the feather is well-hidden. You'll need to explore further to find it.");
                    }
                }
                else
                {
                    Console.WriteLine("You already hold the eagle's feather.");
                }
                Console.WriteLine("\nPress anything.");
                Console.ReadKey();
            }
            else if (choice == "2")
            {
                Console.WriteLine("You descend the perch, the eagle's gaze following you until you disappear into the trees.");
                Console.WriteLine("\nPress anything.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("The wind howls, as if urging you to make a choice.");
                Console.WriteLine("\nPress anything.");
                Console.ReadKey();
            }
        }
        else
        {
            Console.WriteLine("The eagle nods at you. \"You have my trust, fox. The skies are yours to call upon.\"");
            Console.WriteLine("\nPress anything.");
            Console.ReadKey();
        }
    }

    static void FaceTheWolf()
    {
        Console.Clear();
        currentLocation = "The Wolf's Lair";
        if (!stoppedWolf)
        {
            Console.WriteLine("You step into the Wolf's Lair, a dark and foreboding place where the air feels heavy with danger.");
            Console.WriteLine("The Shadow Wolf emerges from the shadows, its eyes glowing like twin embers.");
            Console.WriteLine("\n1 - Stand your ground");
            Console.WriteLine("2 - Retreat into the shadows");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                if (helpedRabbits && convincedEagle && protectedTreasure && helpedHedgehog)
                {
                    Console.WriteLine("With the strength of your allies, you face the wolf head-on. The eagle swoops down, the rabbits distract it, and the hedgehog's thorn drives it back.");
                    Console.WriteLine("The wolf snarls but retreats into the darkness, defeated.");
                    stoppedWolf = true;
                }
                else
                {
                    Console.WriteLine("You're not ready to face the wolf alone. Seek the aid of the forest's creatures first.");
                }
                Console.ReadKey();
            }
            else if (choice == "2")
            {
                Console.WriteLine("You slip away, the wolf's growls echoing behind you. It's not the right time to fight.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("The forest holds its breath, waiting for your decision.");
                Console.ReadKey();
            }
        }
        else
        {
            Console.WriteLine("The wolf is gone, and the forest feels safer. Your courage has made a difference.");
            Console.ReadKey();
        }
    }

    static void HelpHedgehog()
    {
        Console.Clear();
        currentLocation = "The Hedgehog's Hollow";
        if (!helpedHedgehog)
        {
            Console.WriteLine("You find a hedgehog trapped in a pit, its spines quivering with fear.");
            Console.WriteLine("\"Please, help me!\" it pleads, its voice trembling. \"I can't get out on my own.\"");
            Console.WriteLine("\n1 - Rescue the hedgehog");
            Console.WriteLine("2 - Leave it to its fate");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                helpedHedgehog = true;
                Console.WriteLine("You carefully help the hedgehog out of the pit. It sighs in relief and hands you a small, sharp thorn.");
                Console.WriteLine("\"Take this,\" it says. \"It might help you someday.\"");
                inventory.Add("Protective Thorn");
                Console.WriteLine("\nPress anything.");
                Console.ReadKey();
            }
            else if (choice == "2")
            {
                Console.WriteLine("You walk away, the hedgehog's cries fading behind you. The forest feels colder somehow.");
                Console.WriteLine("\nPress anything.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("The forest seems to hold its breath, awaiting your choice.");
                Console.WriteLine("\nPress anything.");
                Console.ReadKey();
            }
        }
        else
        {
            Console.WriteLine("The hedgehog nods at you. \"Thank you again for helping me,\" it says. \"I won't forget it.\"");
            Console.WriteLine("\nPress anything.");
            Console.ReadKey();
        }
    }

    static void ProtectSquirrelTreasure()
    {
        Console.Clear();
        currentLocation = "The Squirrel's Cache";
        if (!protectedTreasure)
        {
            Console.WriteLine("A squirrel scurries up to you, its eyes wide with fear.");
            Console.WriteLine("\"Please, help me!\" it says. \"There are thieves in the forest, and they're after my hoard.\"");
            Console.WriteLine("\n1 - Protect the hoard");
            Console.WriteLine("2 - Ignore the plea");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                protectedTreasure = true;
                squirrelTrust = true;
                Console.WriteLine("You stand guard over the squirrel's hoard, scaring off the thieves with your presence.");
                Console.WriteLine("\"Thank you,\" the squirrel says, handing you a small key. \"This might help you in your journey.\"");
                inventory.Add("Forest Key");
                Console.WriteLine("\nPress anything.");
                Console.ReadKey();
            }
            else if (choice == "2")
            {
                Console.WriteLine("You walk away, the squirrel's eyes filled with disappointment. The forest feels less safe.");
                Console.WriteLine("\nPress anything.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("The forest whispers, urging you to choose wisely.");
                Console.WriteLine("\nPress anything.");
                Console.ReadKey();
            }
        }
        else
        {
            Console.WriteLine("The squirrel's hoard is safe, and it chirps its thanks. \"You're a true friend,\" it says.");
            Console.WriteLine("\nPress anything.");
            Console.ReadKey();
        }
    }

    static void SeekOwlWisdom()
    {
        Console.Clear();
        currentLocation = "The Owl's Tree";
        if (!owlWisdom)
        {
            Console.WriteLine("The wise owl perches above you, its eyes gleaming with ancient knowledge.");
            Console.WriteLine("\"Answer my riddle, fox, and I shall share my wisdom with you.\"");
            Console.WriteLine("The owl's riddle: \"She is not alive, but she can grow; she doesn’t have lungs, but she needs air. She is in between moments. What is she?\"");
            Console.WriteLine("\n1 - Fire");
            Console.WriteLine("2 - Mold");
            Console.WriteLine("3 - Rust");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                owlWisdom = true;
                Console.WriteLine("The owl nods. \"Correct. You are wise indeed. Take this gift of knowledge.\"");
                inventory.Add("Owl's Wisdom");
                Console.WriteLine("\nPress anything.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("The owl shakes its head. \"Farewell, fox. Perhaps another time.\"");
                Console.WriteLine("\nPress anything.");
                Console.ReadKey();
            }
        }
        else
        {
            Console.WriteLine("The owl nods at you. \"You already have my wisdom, fox. Use it well.\"");
            Console.WriteLine("\nPress anything.");
            Console.ReadKey();
        }
    }

    static void CheckInventory()
    {
        Console.Clear();
        Console.WriteLine("Your Belongings:");
        if (inventory.Count > 0)
        {
            foreach (var item in inventory) Console.WriteLine("- " + item);
        }
        else Console.WriteLine("Your paws are empty.");
        Console.ReadKey();
    }

    static void SaveGame()
    {
        using (StreamWriter sw = new StreamWriter(saveFilePath))
        {
            sw.WriteLine(foxName);
            sw.WriteLine(helpedRabbits);
            sw.WriteLine(foundEagleFeather);
            sw.WriteLine(convincedEagle);
            sw.WriteLine(stoppedWolf);
            sw.WriteLine(helpedHedgehog);
            sw.WriteLine(protectedTreasure);
            sw.WriteLine(squirrelTrust);
            sw.WriteLine(owlWisdom);
            sw.WriteLine(currentLocation);
            sw.WriteLine(string.Join(",", inventory));
        }
        Console.WriteLine("Your journey has been saved.");
        Console.ReadKey();
    }

    static void LoadGame()
    {
        if (File.Exists(saveFilePath))
        {
            using (StreamReader sr = new StreamReader(saveFilePath))
            {
                foxName = sr.ReadLine();
                helpedRabbits = bool.Parse(sr.ReadLine());
                foundEagleFeather = bool.Parse(sr.ReadLine());
                convincedEagle = bool.Parse(sr.ReadLine());
                stoppedWolf = bool.Parse(sr.ReadLine());
                helpedHedgehog = bool.Parse(sr.ReadLine());
                protectedTreasure = bool.Parse(sr.ReadLine());
                squirrelTrust = bool.Parse(sr.ReadLine());
                owlWisdom = bool.Parse(sr.ReadLine());
                currentLocation = sr.ReadLine();
                inventory = new List<string>(sr.ReadLine().Split(','));
            }
            Console.WriteLine("Your journey has been restored.");
            Console.ReadKey();
            PlayGame();
        }
        else
        {
            Console.WriteLine("No saved journey found.");
            Console.ReadKey();
            MainMenu();
        }
    }
}