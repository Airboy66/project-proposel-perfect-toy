using System;
using System.Media;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Proposel___AronKohl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SoundPlayer musicplayer = new SoundPlayer();
            musicplayer.SoundLocation = "Pizza Tower OST - Pizza Deluxe! (Title screen).wav";
            musicplayer.Play();
            while (true)
            {
                Console.WriteLine("+--------------------+");
                Console.WriteLine("|    Perfect Toy     |");
                Console.WriteLine("+--------------------+");
                Console.WriteLine("Start Game (S)");
                Console.WriteLine("Instructions (I)");
                Console.WriteLine("Turn Music Off (O)");
                Console.WriteLine("Exit (E)");
                Console.WriteLine(" ");
                Console.Write("Enter a command: ");
                string input = Console.ReadLine();

                if (input == "S")
                {
                    Console.Clear();
                    Console.WriteLine("Heyyy babe, just wanna check on you for a sec.");
                    Console.ReadLine();
                    Console.WriteLine("Look... I know you and the rest of the guys are curious about this place...");
                    Console.ReadLine();
                    Console.WriteLine("But something doesnt seem right.");
                    Console.ReadLine();
                    Console.WriteLine("I mean, you heard about the officer that worked at the night shift here??");
                    Console.ReadLine();
                    Console.WriteLine("He never came back the next morning!!!");
                    Console.ReadLine();
                    Console.WriteLine("Look... promise me youll be careful going in there. I dont want anything bad to happen to you.");
                    Console.ReadLine();
                    Console.WriteLine("Love you so much, ttyl <3");
                    Console.WriteLine("- Allie");
                    Console.WriteLine(" ");
                    Console.WriteLine("-Press Enter to Proceed-");
                    Console.ReadLine();
                    musicplayer.Stop();
                    outsideFront();
                }
                else if (input == "I")
                {
                    Console.Clear();
                    Console.WriteLine("How to play the project:");
                    Console.WriteLine(" ");
                    Console.WriteLine("1. Pay attention to your vision. The higher it is, the more likely an enemy is close to you.");
                    Console.WriteLine("2. Use the keyboard to input commands in order to progress through the map");
                    Console.WriteLine("3. Manage where you are in the map in front of you. * represents your current location, while 0 is a empty space");
                    Console.WriteLine("4. Have Fun :)");
                    Console.WriteLine(" ");
                    Console.WriteLine("Return (R)");
                    Console.WriteLine(" ");
                    while (true)
                    {
                        Console.Write("Enter a command: ");
                        string optionsInput = Console.ReadLine();
                        if (optionsInput == "R")
                        {
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Command input incorrect");
                        }
                    }
                }
                else if (input == "E")
                {
                    Environment.Exit(1);
                }
                else if (input == "O")
                {
                    Console.Clear();
                    musicplayer.Stop();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Command input incorrect");
                }
            }
        }

        static void outsideFront()
        {
            Console.Clear();
            Room room = new Room();
            room.Name = "Outside of the Store";
            room.Interact = "You look up at the store, only to see a sign saying: DSU TOY STORE. OPEN SINCE 1990";
            room.Description = "Looks Dark, but otherwise clean from the outside";
            Console.WriteLine("Current Objective: Enter the Building");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|            (U)Up          (I)|");
            Console.WriteLine("|                              |");
            Console.WriteLine("|              0               |");
            Console.WriteLine("|              |               |");
            Console.WriteLine("|              |               |");
            Console.WriteLine("|              |               |");
            Console.WriteLine("|(L)Left       |       (R)Right|");
            Console.WriteLine("|              |               |");
            Console.WriteLine("|              *               |");
            Console.WriteLine("|                              |");
            Console.WriteLine("|            (D)Down           |");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("Location: " + room.Name);
            Console.WriteLine("Info: " + room.Description);
            Console.WriteLine(" ");
            while (true)
            {
                Console.Write("Enter a Command: ");
                string input = Console.ReadLine();
                if (input == "U")
                {
                    outsideDoor();
                }
                if (input == "R")
                {
                    Console.WriteLine("Cant go that direction. Type a different command");
                }
                if (input == "D")
                {
                    Console.WriteLine("Cant go back now. You just showed up");
                }
                if (input == "L")
                {
                    Console.WriteLine("Cant go that direction. Type a different command");
                }
                if (input == "I")
                {
                    Console.WriteLine("" + room.Interact);
                }
            }
        }

        static void outsideDoor()
        {
            Console.Clear();
            Room room = new Room();
            room.Name = "Front of the Store";
            room.Interact = "You see a door in front of you, do you want to enter? Yes(Y) or No(N): ";
            room.Description = "Looks Dark, but otherwise clean from the outside";
            Console.WriteLine("Current Objective: Enter the Building");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|            (U)Up          (I)|");
            Console.WriteLine("|                              |");
            Console.WriteLine("|              *               |");
            Console.WriteLine("|              |               |");
            Console.WriteLine("|              |               |");
            Console.WriteLine("|              |               |");
            Console.WriteLine("|(L)Left       |       (R)Right|");
            Console.WriteLine("|              |               |");
            Console.WriteLine("|              0               |");
            Console.WriteLine("|                              |");
            Console.WriteLine("|            (D)Down           |");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("Location: " + room.Name);
            Console.WriteLine("Info: " + room.Description);
            Console.WriteLine(" ");
            while (true)
            {
                Console.Write("Enter a Command: ");
                string input = Console.ReadLine();
                if (input == "U")
                {
                    Console.WriteLine("Cant go that direction. Why dont you use the Interact Command (I)");
                }
                if (input == "R")
                {
                    Console.WriteLine("Cant go that direction. Type a different command");
                }
                if (input == "D")
                {
                    Console.Clear();
                    outsideFront();
                }
                if (input == "L")
                {
                    Console.WriteLine("Cant go that direction. Type a different command");
                }
                if(input == "I")
                {
                    while (true)
                    {
                        Console.Write("" + room.Interact);
                        string answer = Console.ReadLine();
                        if (answer == "Y")
                        {
                            while (true)
                            {
                                Console.WriteLine("Would you like music playing? Yes(Y) or No(N): ");
                                string music = Console.ReadLine();
                                if (music == "Y")
                                {
                                    Console.Clear();
                                    SoundPlayer musicplayer = new SoundPlayer();
                                    musicplayer.SoundLocation = "Pizza Tower OST - Tunnely Shimbers (Don't Make A Sound).wav";
                                    musicplayer.Play();
                                    Entrance();
                                }
                                if (music == "N")
                                {
                                    Console.Clear();
                                    Entrance();
                                }
                                else
                                {
                                    Console.WriteLine("Not an valid answer");
                                }
                            }
                        }
                        if (answer == "N")
                        {
                            Console.WriteLine("*You Proceed to not go in yet*");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Not an valid answer");
                        }
                    }
                }
            }
        }

        static void vision()
        {
            Random rnd = new Random();
            int number = rnd.Next(0, 20);
            if (number == 0)
            {
                Console.WriteLine("Vision from Enemy: NULL");
            }
            if (number == 1 || number == 2 || number == 3 || number == 4 || number == 5)
            {
                Console.WriteLine("Vision from Enemy: Safe");
            }
            if (number == 6 || number == 7 || number == 8 || number == 9 || number == 10)
            {
                Console.WriteLine("Vision from Enemy: Average");
            }
            if (number == 11 || number == 12 || number == 13 || number == 14 || number == 15)
            {
                Console.WriteLine("Vision from Enemy: Watch Out");
            }
            if (number ==  16 || number == 17 || number == 18 || number == 19 || number == 20)
            {
                while (true)
                {
                    Console.WriteLine("Vision from Enemy: DANGER");
                    int death = rnd.Next(1, 5);
                    Console.Write("Pick a number between 1-5 to escape: ");
                    string pick = Console.ReadLine();
                    if (pick == "1")
                    {
                        if (death == 1)
                        {
                            gameOver();
                        }
                        Console.WriteLine("Safe, for now...");
                        break;
                    }
                    if (pick == "2")
                    {
                        if (death == 2)
                        {
                            gameOver();
                        }
                        Console.WriteLine("Safe, for now...");
                        break;
                    }
                    if (pick == "3")
                    {
                        if (death == 3)
                        {
                            gameOver();
                        }
                        Console.WriteLine("Safe, for now...");
                        break;
                    }
                    if (pick == "4")
                    {
                        if (death == 4)
                        {
                            gameOver();
                        }
                        Console.WriteLine("Safe, for now...");
                        break;
                    }
                    if (pick == "5")
                    {
                        if (death == 5)
                        {
                            gameOver();
                        }
                        Console.WriteLine("Safe, for now...");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please Pick a Number");
                    }
                }
            }
        }

        static void Entrance()
        {
            Console.Clear();
            Room room = new Room();
            room.Name = "Entrance";
            room.Interact = "What was the evidence?";
            room.Description = "Old, but Fresh";
            Console.WriteLine("Current Objective: Find the Evidence, and leave");
            Console.WriteLine(" ");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|            (U)Up          (I)|");
            Console.WriteLine("|                  0           |");
            Console.WriteLine("|                +-0-0         |");
            Console.WriteLine("|        0---0---+ | |         |");
            Console.WriteLine("|        |   |     | |0        |");
            Console.WriteLine("|        |   0  0--0 |         |");
            Console.WriteLine("|(L)Left |         | | (R)Right|");
            Console.WriteLine("|        0-----0---0-0         |");
            Console.WriteLine("|        0     |               |");
            Console.WriteLine("|              *               |");
            Console.WriteLine("|            (D)Down           |");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("Vision from Enemy: Safe");
            Console.WriteLine("Location: " + room.Name);
            Console.WriteLine("Info: " + room.Description);
            Console.WriteLine(" ");
            while (true)
            {
                Console.Write("Enter a Command: ");
                string input = Console.ReadLine();
                if (input == "U")
                {
                    entranceHall();
                }
                if (input == "R")
                {
                    Console.WriteLine("Cant go that direction. Type a different command");
                }
                if (input == "D")
                {
                    Console.WriteLine("Find the Evidence first, then intereact when you have it");
                }
                if (input == "L")
                {
                    Console.WriteLine("Cant go that direction. Type a different command");
                }
                if (input == "I")
                {
                    Console.WriteLine("" + room.Interact);
                    Console.Write("Answer: ");
                    string evidence = Console.ReadLine();
                    if(evidence == "SKIN")
                    {
                        SoundPlayer musicplayer = new SoundPlayer();
                        musicplayer.SoundLocation = "Pizza Tower OST - Tunnely Shimbers (Don't Make A Sound).wav";
                        musicplayer.Stop();
                        ending_1_Normal();
                    }
                    else
                    {
                        Console.WriteLine("Sorry, cant leave");
                    }
                }
            }
        }

        static void entranceHall()
        {
            Console.Clear();
            Room room = new Room();
            room.Name = "Entrance Hall";
            room.Interact = "Nothing for you to Interact";
            room.Description = "Looks Bigger than expected!!";
            Console.WriteLine("Current Objective: Find the Evidence, and leave");
            Console.WriteLine(" ");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|            (U)Up          (I)|");
            Console.WriteLine("|                  0           |");
            Console.WriteLine("|                +-0-0         |");
            Console.WriteLine("|        0---0---+ | |         |");
            Console.WriteLine("|        |   |     | |0        |");
            Console.WriteLine("|        |   0  0--0 |         |");
            Console.WriteLine("|(L)Left |         | | (R)Right|");
            Console.WriteLine("|        0-----*---0-0         |");
            Console.WriteLine("|        0     |               |");
            Console.WriteLine("|              0               |");
            Console.WriteLine("|            (D)Down           |");
            Console.WriteLine("+------------------------------+");
            vision();
            Console.WriteLine("Location: " + room.Name);
            Console.WriteLine("Info: " + room.Description);
            Console.WriteLine(" ");
            while (true)
            {
                Console.Write("Enter a Command: ");
                string input = Console.ReadLine();
                if (input == "U")
                {
                    Console.WriteLine("Cant go that direction. Type a different command");
                }
                if (input == "L")
                {
                    DiningArea();
                }
                if (input == "D")
                {
                    Entrance();
                }
                if (input == "R")
                {
                    Hallway_2();
                }
                if (input == "I")
                {
                    Console.WriteLine("" + room.Interact);
                }
            }
        }

        static void DiningArea()
        {
            Console.Clear();
            Room room = new Room();
            room.Name = "Toy Area";
            room.Interact = "You picked up a toy. You describe it as: a surreal trojan knight";
            room.Description = "Kids favorite place to look for their favorite toys";
            Console.WriteLine("Current Objective: Find the Evidence, and leave");
            Console.WriteLine(" ");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|            (U)Up          (I)|");
            Console.WriteLine("|                  0           |");
            Console.WriteLine("|                +-0-0         |");
            Console.WriteLine("|        0---0---+ | |         |");
            Console.WriteLine("|        |   |     | |0        |");
            Console.WriteLine("|        |   0  0--0 |         |");
            Console.WriteLine("|(L)Left |         | | (R)Right|");
            Console.WriteLine("|        *-----0---0-0         |");
            Console.WriteLine("|        0     |               |");
            Console.WriteLine("|              0               |");
            Console.WriteLine("|            (D)Down           |");
            Console.WriteLine("+------------------------------+");
            vision();
            Console.WriteLine("Location: " + room.Name);
            Console.WriteLine("Info: " + room.Description);
            Console.WriteLine(" ");
            while (true)
            {
                Console.Write("Enter a Command: ");
                string input = Console.ReadLine();
                if (input == "U")
                {
                    DiningHall();
                }
                if (input == "L")
                {
                    Console.WriteLine("Cant go that direction. Type a different command");
                }
                if (input == "D")
                {
                    DiningCloset();
                }
                if (input == "R")
                {
                    entranceHall();
                }
                if (input == "I")
                {
                    Console.WriteLine("" + room.Interact);
                }
            }
        }

        static void DiningCloset()
        {
            Console.Clear();
            Room room = new Room();
            room.Name = "Toy Closet";
            room.Interact = "You see a circle with a number (5) behind a stack of toys. Must be used for a code";
            room.Description = "Cluster of dolls and puppets";
            Console.WriteLine("Current Objective: Find the Evidence, and leave");
            Console.WriteLine(" ");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|            (U)Up          (I)|");
            Console.WriteLine("|                  0           |");
            Console.WriteLine("|                +-0-0         |");
            Console.WriteLine("|        0---0---+ | |         |");
            Console.WriteLine("|        |   |     | |0        |");
            Console.WriteLine("|        |   0  0--0 |         |");
            Console.WriteLine("|(L)Left |         | | (R)Right|");
            Console.WriteLine("|        0-----0---0-0         |");
            Console.WriteLine("|        *     |               |");
            Console.WriteLine("|              0               |");
            Console.WriteLine("|            (D)Down           |");
            Console.WriteLine("+------------------------------+");
            vision();
            Console.WriteLine("Location: " + room.Name);
            Console.WriteLine("Info: " + room.Description);
            Console.WriteLine(" ");
            while (true)
            {
                Console.Write("Enter a Command: ");
                string input = Console.ReadLine();
                if (input == "U")
                {
                    DiningArea();
                }
                if (input == "R")
                {
                    Console.WriteLine("Cant go that direction. Type a different command");
                }
                if (input == "D")
                {
                    Console.WriteLine("Cant go that direction. Type a different command");
                }
                if (input == "L")
                {
                    Console.WriteLine("Cant go that direction. Type a different command");
                }
                if (input == "I")
                {
                    Console.WriteLine("" + room.Interact);
                }
            }
        }

        static void DiningHall()
        {
            Console.Clear();
            Room room = new Room();
            room.Name = "Toy Hall";
            room.Interact = "Nothing for you to Interact";
            room.Description = "Long hall, but dark and scary";
            Console.WriteLine("Current Objective: Find the Evidence, and leave");
            Console.WriteLine(" ");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|            (U)Up          (I)|");
            Console.WriteLine("|                  0           |");
            Console.WriteLine("|                +-0-0         |");
            Console.WriteLine("|        *---0---+ | |         |");
            Console.WriteLine("|        |   |     | |0        |");
            Console.WriteLine("|        |   0  0--0 |         |");
            Console.WriteLine("|(L)Left |         | | (R)Right|");
            Console.WriteLine("|        0-----0---0-0         |");
            Console.WriteLine("|        0     |               |");
            Console.WriteLine("|              0               |");
            Console.WriteLine("|            (D)Down           |");
            Console.WriteLine("+------------------------------+");
            vision();
            Console.WriteLine("Location: " + room.Name);
            Console.WriteLine("Info: " + room.Description);
            Console.WriteLine(" ");
            while (true)
            {
                Console.Write("Enter a Command: ");
                string input = Console.ReadLine();
                if (input == "U")
                {
                    Console.WriteLine("Cant go that direction. Type a different command");
                }
                if (input == "R")
                {
                    Hallway_1();
                }
                if (input == "D")
                {
                    DiningArea();
                }
                if (input == "L")
                {
                    Console.WriteLine("Cant go that direction. Type a different command");
                }
                if (input == "I")
                {
                    Console.WriteLine("" + room.Interact);
                }
            }
        }

        static void Hallway_1()
        {
            Console.Clear();
            Room room = new Room();
            room.Name = "4 Way Hallway";
            room.Interact = "You feel air coming from a wall, but where?";
            room.Description = "Too many directions";
            Console.WriteLine("Current Objective: Find the Evidence, and leave");
            Console.WriteLine(" ");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|            (U)Up          (I)|");
            Console.WriteLine("|                  0           |");
            Console.WriteLine("|                +-0-0         |");
            Console.WriteLine("|        0---*---+ | |         |");
            Console.WriteLine("|        |   |     | |0        |");
            Console.WriteLine("|        |   0  0--0 |         |");
            Console.WriteLine("|(L)Left |         | | (R)Right|");
            Console.WriteLine("|        0-----0---0-0         |");
            Console.WriteLine("|        0     |               |");
            Console.WriteLine("|              0               |");
            Console.WriteLine("|            (D)Down           |");
            Console.WriteLine("+------------------------------+");
            vision();
            Console.WriteLine("Location: " + room.Name);
            Console.WriteLine("Info: " + room.Description);
            Console.WriteLine(" ");
            while (true)
            {
                Console.Write("Enter a Command: ");
                string input = Console.ReadLine();
                if (input == "U")
                {
                    SecretRoom();
                }
                if (input == "R")
                {
                    EntertainmentStageRoom();
                }
                if (input == "D")
                {
                    EngineerRoom();
                }
                if (input == "L")
                {
                    DiningHall();
                }
                if (input == "I")
                {
                    Console.WriteLine("" + room.Interact);
                }
            }
        }

        static void EngineerRoom()
        {
            Console.Clear();
            Room room = new Room();
            room.Name = "Engineer Room";
            room.Interact = "You find a key named PET, maybe this can be used for something";
            room.Description = "Cobwebs everywhere, but still functional";
            Console.WriteLine("Current Objective: Find the Evidence, and leave");
            Console.WriteLine(" ");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|            (U)Up          (I)|");
            Console.WriteLine("|                  0           |");
            Console.WriteLine("|                +-0-0         |");
            Console.WriteLine("|        0---0---+ | |         |");
            Console.WriteLine("|        |   |     | |0        |");
            Console.WriteLine("|        |   *  0--0 |         |");
            Console.WriteLine("|(L)Left |         | | (R)Right|");
            Console.WriteLine("|        0-----0---0-0         |");
            Console.WriteLine("|        0     |               |");
            Console.WriteLine("|              0               |");
            Console.WriteLine("|            (D)Down           |");
            Console.WriteLine("+------------------------------+");
            vision();
            Console.WriteLine("Location: " + room.Name);
            Console.WriteLine("Info: " + room.Description);
            Console.WriteLine(" ");
            while (true)
            {
                Console.Write("Enter a Command: ");
                string input = Console.ReadLine();
                if (input == "U")
                {
                    Hallway_1();
                }
                if (input == "R")
                {
                    Console.WriteLine("Cant go that direction. Type a different command");
                }
                if (input == "D")
                {
                    Console.WriteLine("Cant go that direction. Type a different command");
                }
                if (input == "L")
                {
                    Console.WriteLine("Cant go that direction. Type a different command");
                }
                if (input == "I")
                {
                    Console.WriteLine("" + room.Interact);
                }
            }
        }

        static void EntertainmentStageRoom()
        {
            Console.Clear();
            Room room = new Room();
            Puzzle puzzle = new Puzzle();
            room.Name = "Entertainment Room";
            room.Interact = "You see a stage meant for the mascots, but one of them is missing. Theres also a door, baracaded";
            room.Description = "Creepy and dark. That Trojan Knight is staring at me";
            Console.WriteLine("Current Objective: Find the Evidence, and leave");
            Console.WriteLine(" ");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|            (U)Up          (I)|");
            Console.WriteLine("|                  0           |");
            Console.WriteLine("|                +-*-0         |");
            Console.WriteLine("|        0---0---+ | |         |");
            Console.WriteLine("|        |   |     | |0        |");
            Console.WriteLine("|        |   0  0--0 |         |");
            Console.WriteLine("|(L)Left |         | | (R)Right|");
            Console.WriteLine("|        0-----0---0-0         |");
            Console.WriteLine("|        0     |               |");
            Console.WriteLine("|              0               |");
            Console.WriteLine("|            (D)Down           |");
            Console.WriteLine("+------------------------------+");
            vision();
            Console.WriteLine("Location: " + room.Name);
            Console.WriteLine("Info: " + room.Description);
            Console.WriteLine(" ");
            while (true)
            {
                Console.Write("Enter a Command: ");
                string input = Console.ReadLine();
                if (input == "U")
                {
                    Console.WriteLine("Whats the key: ");
                    string key = Console.ReadLine();
                    if (key == "PET")
                    {
                        BackStageRoom();
                    }
                    else
                    {
                        Console.WriteLine("Incorrect");
                    }
                }
                if (input == "R")
                {
                    PosterHallFront();
                }
                if (input == "D")
                {
                    ElevatorHall();
                }
                if (input == "L")
                {
                    Hallway_1();
                }
                if (input == "I")
                {
                    Console.WriteLine("" + room.Interact);
                }
            }
        }

        static void BackStageRoom()
        {
            Console.Clear();
            Room room = new Room();
            room.Name = "BackStage Room";
            room.Interact = "You found the evidence you need (SKIN), now get out for HE comes for you";
            room.Description = "Nothing but a destroyed human. Gone but his skin, nailed in the wall";
            Console.WriteLine("Current Objective: Find the Evidence, and leave");
            Console.WriteLine(" ");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|            (U)Up          (I)|");
            Console.WriteLine("|                  *           |");
            Console.WriteLine("|                +-0-0         |");
            Console.WriteLine("|        0---0---+ | |         |");
            Console.WriteLine("|        |   |     | |0        |");
            Console.WriteLine("|        |   0  0--0 |         |");
            Console.WriteLine("|(L)Left |         | | (R)Right|");
            Console.WriteLine("|        0-----0---0-0         |");
            Console.WriteLine("|        0     |               |");
            Console.WriteLine("|              0               |");
            Console.WriteLine("|            (D)Down           |");
            Console.WriteLine("+------------------------------+");
            vision();
            Console.WriteLine("Location: " + room.Name);
            Console.WriteLine("Info: " + room.Description);
            Console.WriteLine(" ");
            while (true)
            {
                Console.Write("Enter a Command: ");
                string input = Console.ReadLine();
                if (input == "U")
                {
                    Console.WriteLine("Cant go that direction. Type a different command");
                }
                if (input == "R")
                {
                    Console.WriteLine("Cant go that direction. Type a different command");
                }
                if (input == "D")
                {
                    EntertainmentStageRoom();
                }
                if (input == "L")
                {
                    Console.WriteLine("Cant go that direction. Type a different command");
                }
                if (input == "I")
                {
                    Console.WriteLine("" + room.Interact);
                }
            }
        }

        static void ElevatorHall()
        {
            Console.Clear();
            Room room = new Room();
            Puzzle puzzle = new Puzzle();
            room.Name = "Elevator Hall";
            room.Interact = "You see a lock elevator, maybe it leads to somewhere";
            puzzle.Interact = "Enter a three digit code from these shapes, 'Triangle, Circle, Square'";
            room.Description = "Long hall, but quite nice";
            Console.WriteLine("Current Objective: Find the Evidence, and leave");
            Console.WriteLine(" ");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|            (U)Up          (I)|");
            Console.WriteLine("|                  0           |");
            Console.WriteLine("|                +-0-0         |");
            Console.WriteLine("|        0---0---+ | |         |");
            Console.WriteLine("|        |   |     | |0        |");
            Console.WriteLine("|        |   0  0--* |         |");
            Console.WriteLine("|(L)Left |         | | (R)Right|");
            Console.WriteLine("|        0-----0---0-0         |");
            Console.WriteLine("|        0     |               |");
            Console.WriteLine("|              0               |");
            Console.WriteLine("|            (D)Down           |");
            Console.WriteLine("+------------------------------+");
            vision();
            Console.WriteLine("Location: " + room.Name);
            Console.WriteLine("Info: " + room.Description);
            Console.WriteLine(" ");
            while (true)
            {
                Console.Write("Enter a Command: ");
                string input = Console.ReadLine();
                if (input == "U")
                {
                    EntertainmentStageRoom();
                }
                if (input == "R")
                {
                    Console.WriteLine("Cant go that direction. Type a different command");
                }
                if (input == "D")
                {
                    Hallway_2();
                }
                if (input == "L")
                {
                    Console.WriteLine("" + puzzle.Interact);
                    string code = Console.ReadLine();
                    if (code == "953")
                    {
                        Elevator();
                    }
                    else
                    {
                        Console.WriteLine("Wrong Input, try again later");
                    }
                }
                if (input == "I")
                {
                    Console.WriteLine("" + room.Interact);
                }
            }
        }

        static void Elevator()
        {
            Console.Clear();
            Room room = new Room();
            room.Name = "Elevator";
            room.Interact = "Are you ready to see what hides below the toy store? Yes(Y) or No(N): ";
            room.Description = "Does this still work?";
            Console.WriteLine("Current Objective: See what lies below");
            Console.WriteLine(" ");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|            (U)Up          (I)|");
            Console.WriteLine("|                  0           |");
            Console.WriteLine("|                +-0-0         |");
            Console.WriteLine("|        0---0---+ | |         |");
            Console.WriteLine("|        |   |     | |0        |");
            Console.WriteLine("|        |   0  *--0 |         |");
            Console.WriteLine("|(L)Left |         | | (R)Right|");
            Console.WriteLine("|        0-----0---0-0         |");
            Console.WriteLine("|        0     |               |");
            Console.WriteLine("|              0               |");
            Console.WriteLine("|            (D)Down           |");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("Vision From enemy: ???");
            Console.WriteLine("Location: " + room.Name);
            Console.WriteLine("Info: " + room.Description);
            Console.WriteLine("");
            while (true)
            {
                Console.Write("Enter a Command: ");
                string input = Console.ReadLine();
                if (input == "U")
                {
                    Console.WriteLine("Cant go that direction. Type a different command");
                }
                if (input == "R")
                {
                    ElevatorHall();
                }
                if (input == "D")
                {
                    Console.WriteLine("Cant go that direction. Type a different command");
                }
                if (input == "L")
                {
                    Console.WriteLine("Cant go that direction. Try intereacting with the elevator");
                }
                if (input == "I")
                {
                    while (true)
                    {
                        Console.Write("" + room.Interact);
                        string answer = Console.ReadLine();
                        if (answer == "Y")
                        {
                            SoundPlayer musicplayer = new SoundPlayer();
                            musicplayer.SoundLocation = "Pizza Tower OST - Tunnely Shimbers (Don't Make A Sound).wav";
                            musicplayer.Stop();
                            Console.Clear();
                            ending_2_Secret();
                        }
                        if (answer == "N")
                        {
                            Console.WriteLine("*You Proceed to not go in yet*");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Not an invalid answer");
                        }
                    }
                }
            }
        }

        static void Hallway_2()
        {
            Console.Clear();
            Room room = new Room();
            room.Name = "Long Hall";
            room.Interact = "Nothing for you to Interact";
            room.Description = "Why the long directions in this place?";
            Console.WriteLine("Current Objective: Find the Evidence, and leave");
            Console.WriteLine(" ");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|            (U)Up          (I)|");
            Console.WriteLine("|                  0           |");
            Console.WriteLine("|                +-0-0         |");
            Console.WriteLine("|        0---0---+ | |         |");
            Console.WriteLine("|        |   |     | |0        |");
            Console.WriteLine("|        |   0  0--0 |         |");
            Console.WriteLine("|(L)Left |         | | (R)Right|");
            Console.WriteLine("|        0-----0---*-0         |");
            Console.WriteLine("|        0     |               |");
            Console.WriteLine("|              0               |");
            Console.WriteLine("|            (D)Down           |");
            Console.WriteLine("+------------------------------+");
            vision();
            Console.WriteLine("Location: " + room.Name);
            Console.WriteLine("Info: " + room.Description);
            Console.WriteLine(" ");
            while (true)
            {
                Console.Write("Enter a Command: ");
                string input = Console.ReadLine();
                if (input == "U")
                {
                    ElevatorHall();
                }
                if (input == "R")
                {
                    PosterHallBack();
                }
                if (input == "D")
                {
                    Console.WriteLine("Cant go that direction. Type a different command");
                }
                if (input == "L")
                {
                    entranceHall();
                }
                if (input == "I")
                {
                    Console.WriteLine("" + room.Interact);
                }
            }
        }

        static void PosterHallFront()
        {
            Console.Clear();
            Room room = new Room();
            room.Name = "Poster Hall Front";
            room.Interact = "You see a group of posters. Looks like someone tainted them";
            room.Description = "Colorful, yet looks destroyed";
            Console.WriteLine("Current Objective: Find the Evidence, and leave");
            Console.WriteLine(" ");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|            (U)Up          (I)|");
            Console.WriteLine("|                  0           |");
            Console.WriteLine("|                +-0-*         |");
            Console.WriteLine("|        0---0---+ | |         |");
            Console.WriteLine("|        |   |     | |0        |");
            Console.WriteLine("|        |   0  0--0 |         |");
            Console.WriteLine("|(L)Left |         | | (R)Right|");
            Console.WriteLine("|        0-----0---0-0         |");
            Console.WriteLine("|        0     |               |");
            Console.WriteLine("|              0               |");
            Console.WriteLine("|            (D)Down           |");
            Console.WriteLine("+------------------------------+");
            vision();
            Console.WriteLine("Location: " + room.Name);
            Console.WriteLine("Info: " + room.Description);
            Console.WriteLine(" ");
            while (true)
            {
                Console.Write("Enter a Command: ");
                string input = Console.ReadLine();
                if (input == "U")
                {
                    Console.WriteLine("Cant go that direction. Type a different command");
                }
                if (input == "R")
                {
                    PartsAndService();
                }
                if (input == "D")
                {
                    PosterHallBack();
                }
                if (input == "L")
                {
                    EntertainmentStageRoom();
                }
                if (input == "I")
                {
                    Console.WriteLine("" + room.Interact);
                }
            }
        }

        static void PartsAndService()
        {
            Console.Clear();
            Room room = new Room();
            room.Name = "Parts And Service";
            room.Interact = "You see a robotic arm with a tringale number '9'. Maybe thats used for a code?";
            room.Description = "A bunch of parts all over the place. Why is there metal inside of a puppet?";
            Console.WriteLine("Current Objective: Find the Evidence, and leave");
            Console.WriteLine(" ");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|            (U)Up          (I)|");
            Console.WriteLine("|                  0           |");
            Console.WriteLine("|                +-0-0         |");
            Console.WriteLine("|        0---0---+ | |         |");
            Console.WriteLine("|        |   |     | |*        |");
            Console.WriteLine("|        |   0  0--0 |         |");
            Console.WriteLine("|(L)Left |         | | (R)Right|");
            Console.WriteLine("|        0-----0---0-0         |");
            Console.WriteLine("|        0     |               |");
            Console.WriteLine("|              0               |");
            Console.WriteLine("|            (D)Down           |");
            Console.WriteLine("+------------------------------+");
            vision();
            Console.WriteLine("Location: " + room.Name);
            Console.WriteLine("Info: " + room.Description);
            Console.WriteLine(" ");
            while (true)
            {
                Console.Write("Enter a Command: ");
                string input = Console.ReadLine();
                if (input == "U")
                {
                    PosterHallFront();
                }
                if (input == "R")
                {
                    Console.WriteLine("Cant go that direction. Type a different command");
                }
                if (input == "D")
                {
                    PosterHallBack();
                }
                if (input == "L")
                {
                    Console.WriteLine("Cant go that direction. Type a different command");
                }
                if (input == "I")
                {
                    Console.WriteLine("" + room.Interact);
                }
            }
        }

        static void PosterHallBack()
        {
            Console.Clear();
            Room room = new Room();
            room.Name = "Poster Hall Back";
            room.Interact = "You see a group of posters behind you, with all the characters and their phrases: fun, joy, entertain!";
            room.Description = "Colorful, yet destroyed";
            Console.WriteLine("Current Objective: Find the Evidence, and leave");
            Console.WriteLine(" ");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|            (U)Up          (I)|");
            Console.WriteLine("|                  0           |");
            Console.WriteLine("|                +-0-0         |");
            Console.WriteLine("|        0---0---+ | |         |");
            Console.WriteLine("|        |   |     | |0        |");
            Console.WriteLine("|        |   0  0--0 |         |");
            Console.WriteLine("|(L)Left |         | | (R)Right|");
            Console.WriteLine("|        0-----0---0-*         |");
            Console.WriteLine("|        0     |               |");
            Console.WriteLine("|              0               |");
            Console.WriteLine("|            (D)Down           |");
            Console.WriteLine("+------------------------------+");
            vision();
            Console.WriteLine("Location: " + room.Name);
            Console.WriteLine("Info: " + room.Description);
            Console.WriteLine(" ");
            while (true)
            {
                Console.Write("Enter a Command: ");
                string input = Console.ReadLine();
                if (input == "U")
                {
                    PosterHallFront();
                }
                if (input == "R")
                {
                    PartsAndService();
                }
                if (input == "D")
                {
                    Console.WriteLine("Cant go that direction. Type a different command");
                }
                if (input == "L")
                {
                    entranceHall();
                }
                if (input == "I")
                {
                    Console.WriteLine("" + room.Interact);
                }
            }
        }

        static void SecretRoom()
        {
            Console.Clear();
            Room room = new Room();
            room.Name = "???";
            room.Interact = "F O U R S I D E S . N U M B E R T H R E E";
            room.Description = "NULL";
            Console.WriteLine("Current Objective: Find the Evidence");
            Console.WriteLine(" ");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|                              |");
            Console.WriteLine("|                              |");
            Console.WriteLine("|                              |");
            Console.WriteLine("|                              |");
            Console.WriteLine("|                              |");
            Console.WriteLine("|                              |");
            Console.WriteLine("|                              |");
            Console.WriteLine("|                              |");
            Console.WriteLine("|                              |");
            Console.WriteLine("|                              |");
            Console.WriteLine("|                              |");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("Vision from Enemy: N U L L");
            Console.WriteLine("Location: " + room.Name);
            Console.WriteLine("Info: " + room.Description);
            Console.WriteLine(" ");
            while (true)
            {
                Console.Write("Enter a Command: ");
                string input = Console.ReadLine();
                if (input == "U")
                {
                    Console.WriteLine("Cant go that direction. Type a different command");
                }
                if (input == "R")
                {
                    Console.WriteLine("Cant go that direction. Type a different command");
                }
                if (input == "D")
                {
                    Hallway_1();
                }
                if (input == "L")
                {
                    Console.WriteLine("Cant go that direction. Type a different command");
                }
                if (input == "I")
                {
                    Console.WriteLine("" + room.Interact);
                }
            }
        }

        static void ending_1_Normal()
        {
            Console.Clear();
            Console.WriteLine("...");
            Console.ReadLine();
            Console.WriteLine("SO, YOU TRY TO ESCAPED...");
            Console.ReadLine();
            Console.WriteLine("INTERESTING");
            Console.ReadLine();
            Console.WriteLine("IT WONT BE LONG BEFORE IM DONE WITH YOU, MY PRE...");
            Console.ReadLine();
            Console.WriteLine("*Gun shots*");
            Console.ReadLine();
            Console.WriteLine("Cop 1: Get Down!!!");
            Console.ReadLine();
            Console.WriteLine("Cop 1: Your not suppose to be in here! How the hell did you...?");
            Console.ReadLine();
            Console.WriteLine("Cop 2: Not now sir, lets get him safe and shut this place down!");
            Console.WriteLine("-Press Enter to Proceed-");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|         NEWS REPORT          |");
            Console.WriteLine("|______________________________|");
            Console.WriteLine("|       Teen Boy Rescued       |");
            Console.WriteLine("|     From Robotic Puppet      |");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("Ending 1/2: The Normal Ending");
            Console.WriteLine("-Press Enter to Proceed-");
            Console.ReadLine();
            Environment.Exit(1);
        }

        static void ending_2_Secret()
        {
            Console.Clear();
            Console.WriteLine("*Evevator Closes*");
            Console.ReadLine();
            Console.WriteLine("...");
            Console.ReadLine();
            Console.WriteLine("*Evevator Goes Down*");
            Console.ReadLine();
            Console.WriteLine("...");
            Console.ReadLine();
            Console.WriteLine("*Evevator Opens*");
            Console.ReadLine();
            Console.WriteLine("*Slowly walks out*");
            Console.ReadLine();
            Console.WriteLine("What is this place?");
            Console.ReadLine();
            Console.WriteLine("...");
            Console.ReadLine();
            Console.WriteLine("I never... *Looks at the middle of the room*");
            Console.ReadLine();
            Console.WriteLine("No... i-it cant be!?");
            Console.ReadLine();
            Console.WriteLine("Why would they do this?");
            Console.ReadLine();
            Console.WriteLine("I WOULDNT ASK THAT QUESTION IF I WERE YOU, DYLAN");
            Console.ReadLine();
            Console.Clear();
            finalBattle();
        }

        static void finalBattle()
        {
            SoundPlayer musicplayer = new SoundPlayer();
            musicplayer.SoundLocation = "Terraria Calamity Mod Music - ＂UNIVERSAL COLLAPSE＂ - Theme of Devourer of Gods (Final Form) (1).wav";
            musicplayer.Play();
            Player player = new Player();
            Enemy puppet = new Enemy();
            HealthItem healthItem = new HealthItem();
            healthItem.HealingAmount = 10;
            attackItem attack = new attackItem();
            attack.damage = 25;
            puppet.strength = 10;
            puppet.health = 100;
            player.health = 50;
            player.damage = 5;
            while (true)
            {
                Console.WriteLine("Current Objective: Kill the Puppet");
                Console.WriteLine("");
                Console.WriteLine("+-------------------+");
                Console.WriteLine("| +---+       +---+ |");
                Console.WriteLine("| |   |       |   | |");
                Console.WriteLine("| | 0 |       | 0 | |");
                Console.WriteLine("| +---+       +---+ |");
                Console.WriteLine("|  +      *      +  |");
                Console.WriteLine("|   0    ***    0   |");
                Console.WriteLine("|    0    *    0    |");
                Console.WriteLine("|     000000000     |");
                Console.WriteLine("+-------------------+");
                Console.WriteLine("Puppeter: " + puppet.health);
                Console.WriteLine("You: " + player.health);
                Console.WriteLine("");
                Console.WriteLine("(A) Attack, (D) Dodge, (I) Item, (N) Nothing");
                Console.Write("Your Turn: ");
                string turn = Console.ReadLine();
                if (turn == "A")
                {
                    Console.WriteLine("You attack the Puppeter");
                    Console.ReadLine();
                    puppet.health = puppet.health - player.damage;
                    Console.WriteLine("Puppet's Turn");
                    Random rnd = new Random();
                    int number = rnd.Next(1, 4);
                    if (number == 1 || number == 2)
                    {
                        Console.WriteLine("Puppet attacked you");
                        player.health = player.health - puppet.strength;
                    }
                    if (number == 3 || number == 4)
                    {
                        Console.WriteLine("Puppet Missed You");
                    }
                    Console.ReadLine();
                    Console.Clear();
                }
                if (turn == "D")
                {
                    Console.WriteLine("You Increase your chance of Doging for this turn.");
                    Console.ReadLine();
                    Console.WriteLine("Puppet's Turn");
                    Random rnd = new Random();
                    int number = rnd.Next(1, 5);
                    if (number == 1 || number == 2 || number == 3 || number == 4)
                    {
                        Console.WriteLine("Puppet Missed You");
                    }
                    if (number == 5)
                    {
                        Console.WriteLine("Puppet's attack you");
                        player.health = player.health - puppet.strength;
                    }
                    Console.ReadLine();
                    Console.Clear();
                }
                if (turn == "I")
                {
                    Random rnd = new Random();
                    int item = rnd.Next(1, 3);
                    if (item == 1)
                    {
                        Console.WriteLine("You used an healing item");
                        Console.ReadLine();
                        player.health = player.health + healthItem.HealingAmount;
                        Console.WriteLine("Puppet's Turn");
                        int number = rnd.Next(1, 4);
                        if (number == 1 || number == 2)
                        {
                            Console.WriteLine("Puppet attacked you");
                            player.health = player.health - puppet.strength;
                        }
                        if (number == 3 || number == 4)
                        {
                            Console.WriteLine("Puppet Missed You");
                        }
                        Console.ReadLine();
                        Console.Clear();
                    }
                    if (item == 2)
                    {
                        Console.WriteLine("You used an damage item");
                        Console.ReadLine();
                        puppet.health = puppet.health - attack.damage;
                        Console.WriteLine("Puppet's Turn");
                        int number = rnd.Next(1, 4);
                        if (number == 1 || number == 2)
                        {
                            Console.WriteLine("Puppet attacked you");
                            player.health = player.health - puppet.strength;
                        }
                        if (number == 3 || number == 4)
                        {
                            Console.WriteLine("Puppet Missed You");
                        }
                        Console.ReadLine();
                        Console.Clear();
                    }
                    if (item == 3)
                    {
                        Console.WriteLine("You used a nothing item");
                        Console.ReadLine();
                        Console.WriteLine("Puppet's Turn");
                        int number = rnd.Next(1, 4);
                        if (number == 1 || number == 2)
                        {
                            Console.WriteLine("Puppet attacked you");
                            player.health = player.health - puppet.strength;
                        }
                        if (number == 3 || number == 4)
                        {
                            Console.WriteLine("Puppet Missed You");
                        }
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                if (turn == "N")
                {
                    Console.WriteLine("You do Nothing. Wow ok...");
                    Console.ReadLine();
                    Console.WriteLine("Puppet's Turn");
                    Random rnd = new Random();
                    int number = rnd.Next(1, 4);
                    if (number == 1 || number == 2)
                    {
                        Console.WriteLine("Puppet attacked you");
                        player.health = player.health - puppet.strength;
                    }
                    if (number == 3 || number == 4)
                    {
                        Console.WriteLine("Puppet Missed You");
                    }
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Not an Answer");
                    Console.Clear();
                }

                //When health is low
                if (puppet.health <= 0)
                {
                    musicplayer.Stop();
                    ending_2_part2();
                }
                else if (player.health <= 0)
                {
                    musicplayer.Stop();
                    gameOver();
                }
            }
        }

        static void ending_2_part2()
        {
            Console.Clear();
            Console.WriteLine("GRRR, Stay away from me you twisted metal freak!");
            Console.ReadLine();
            Console.WriteLine("I gotta get the hell out of here, now!");
            Console.ReadLine();
            Console.WriteLine("I seen enough of this, ill tell the others abou...");
            Console.ReadLine();
            Console.WriteLine("*Trips over*");
            Console.ReadLine();
            Console.WriteLine("AHHH!");
            Console.ReadLine();
            Console.WriteLine("???: I wouldnt be so sure");
            Console.ReadLine();
            Console.WriteLine("???: After all, youve only just got here");
            Console.ReadLine();
            Console.WriteLine("???: And now, my experiment shall begin, starting with you");
            Console.ReadLine();
            Console.WriteLine("Who... What the hell you want from me!");
            Console.ReadLine();
            Console.WriteLine("...");
            Console.ReadLine();
            Console.WriteLine("???: Oh my sweet boy, you will know who i am. For I am the creator of fun, the leader of pain");
            Console.ReadLine();
            Console.WriteLine("???: For I am...");
            Console.ReadLine();
            Console.WriteLine("THE TOY MAKER");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|         NEWS REPORT          |");
            Console.WriteLine("|______________________________|");
            Console.WriteLine("|       Teen Boy Missing       |");
            Console.WriteLine("|          for 3 days          |");
            Console.WriteLine("|           Last seen          |");
            Console.WriteLine("|         DSU Toy Store        |");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("Ending 2/2: The Secret True Ending");
            Console.WriteLine("-Press Enter to Proceed-");
            Console.ReadLine();
            Environment.Exit(1);
        }

        static void gameOver()
        {
            Console.Clear();
            Console.WriteLine("Sorry, you died");
            Console.WriteLine("Try again in the next round :)");
            Console.ReadLine();
            Environment.Exit(1);
        }
    }
}
