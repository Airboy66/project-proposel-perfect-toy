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
            while (true)
            {
                Console.WriteLine("+--------------------+");
                Console.WriteLine("|    Perfect Toy     |");
                Console.WriteLine("+--------------------+");
                Console.WriteLine("Start Game (S)");
                Console.WriteLine("Instructions (I)");
                Console.WriteLine("Exit (E)");
                Console.WriteLine(" ");
                Console.WriteLine("V0.5 DEMO VERSION");
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
                    Console.WriteLine("I mean, you herard about the officer that worked at the night shift here??");
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
                else
                {
                    Console.Clear();
                    Console.WriteLine("Command input incorrect");
                }
            }
        }

        Player player = new Player();
        

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
                            Console.Clear();
                            Entrance();
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

        static void backpack()
        {
            Console.WriteLine("(1): This is a test");
            Console.WriteLine("(2): This is a test");
            Console.WriteLine("(3): This is a test");
            Console.WriteLine("(4): This is a test");
            Console.WriteLine("(5): This is a test");
            Console.WriteLine("(6): This is a test");
            Console.WriteLine("(7): This is a test");
            Console.WriteLine("(8): This is a test");
            Console.WriteLine("What would you like to do?");
            Console.Write("Enter a Command: ");
            string pack = Console.ReadLine();
            if (pack == "1")
            {

            }
            if (pack == "2")
            {

            }
            if (pack == "3")
            {

            }
            if (pack == "4")
            {

            }
            if (pack == "5")
            {

            }
            if (pack == "6")
            {

            }
            if (pack == "7")
            {

            }
            if (pack == "8")
            {

            }
        }

        static void Entrance()
        {
            Console.Clear();
            Room room = new Room();
            room.Name = "Entrance";
            room.Interact = "Nothing for you to Interact";
            room.Description = "Old, but Fresh";
            Console.WriteLine("Current Objective: Find the Evidence");
            Console.WriteLine(" ");
            Console.WriteLine("Health: ");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|(B)         (U)Up          (I)|");
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
            Console.WriteLine("Vision from Enemy: ");
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
                    ending_1_Normal();
                }
                if (input == "B")
                {
                    backpack();
                }
            }
        }

        static void entranceHall()
        {
            Console.Clear();
            Room room = new Room();
            Item item = new Item();
            room.Name = "Entrance Hall";
            room.Interact = "Nothing for you to Interact";
            room.Description = "Looks Bigger than expected!!";
            Console.WriteLine("Current Objective: Find the Evidence");
            Console.WriteLine(" ");
            Console.WriteLine("Health: ");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|(B)         (U)Up          (I)|");
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
            Console.WriteLine("Vision from Enemy: ");
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
                if (input == "B")
                {
                    backpack();
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
            Console.WriteLine("Current Objective: Find the Evidence");
            Console.WriteLine(" ");
            Console.WriteLine("Health: ");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|(B)         (U)Up          (I)|");
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
            Console.WriteLine("Vision from Enemy: ");
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
                    Console.WriteLine(" " + room.Interact);
                }
                if (input == "B")
                {
                    Console.WriteLine("Progress");
                }
            }
        }

        static void DiningCloset()
        {
            Console.Clear();
            Room room = new Room();
            puzzleItem item = new puzzleItem();
            room.Name = "Toy Closet";
            room.Interact = "You see a circle with a number (5) behind a stack of toys. Must be used for a code";
            room.Description = "Cluster of dolls and puppets";
            Console.WriteLine("Current Objective: Find the Evidence");
            Console.WriteLine(" ");
            Console.WriteLine("Health: ");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|(B)         (U)Up          (I)|");
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
            Console.WriteLine("Vision from Enemy: ");
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
                    Console.WriteLine(" " + room.Interact);
                }
                if (input == "B")
                {
                    Console.WriteLine("Progress");
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
            Console.WriteLine("Current Objective: Find the Evidence");
            Console.WriteLine(" ");
            Console.WriteLine("Health: ");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|(B)         (U)Up          (I)|");
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
            Console.WriteLine("Vision from Enemy: ");
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
                    Console.WriteLine(" " + room.Interact);
                }
                if (input == "B")
                {
                    Console.WriteLine("Progress");
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
            Console.WriteLine("Current Objective: Find the Evidence");
            Console.WriteLine(" ");
            Console.WriteLine("Health: ");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|(B)         (U)Up          (I)|");
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
            Console.WriteLine("Vision from Enemy: ");
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
                    Console.WriteLine(" " + room.Interact);
                }
                if (input == "B")
                {
                    Console.WriteLine("Progress");
                }
            }
        }

        static void EngineerRoom()
        {
            Console.Clear();
            Room room = new Room();
            room.Name = "Engineer Room";
            room.Interact = "You find a crowbar, maybe this can be used for something";
            room.Description = "Cobwebs everywhere, but still functional";
            Console.WriteLine("Current Objective: Find the Evidence");
            Console.WriteLine(" ");
            Console.WriteLine("Health: ");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|(B)         (U)Up          (I)|");
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
            Console.WriteLine("Vision from Enemy: ");
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
                    Console.WriteLine(" " + room.Interact);
                }
                if (input == "B")
                {
                    Console.WriteLine("Progress");
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
            Console.WriteLine("Current Objective: Find the Evidence");
            Console.WriteLine(" ");
            Console.WriteLine("Health: ");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|(B)         (U)Up          (I)|");
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
            Console.WriteLine("Vision from Enemy: ");
            Console.WriteLine("Location: " + room.Name);
            Console.WriteLine("Info: " + room.Description);
            Console.WriteLine(" ");
            while (true)
            {
                Console.Write("Enter a Command: ");
                string input = Console.ReadLine();
                if (input == "U")
                {
                    BackStageRoom();
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
                    Console.WriteLine(" " + room.Interact);
                }
                if (input == "B")
                {
                    Console.WriteLine("Progress");
                }
            }
        }

        static void BackStageRoom()
        {
            Console.Clear();
            Room room = new Room();
            room.Name = "BackStage Room";
            room.Interact = "You found the evidence you need, now get out for HE comes for you";
            room.Description = "Nothing but a destroyed human. Gone but his skin, nailed in the wall";
            Console.WriteLine("Current Objective: Find the Evidence");
            Console.WriteLine(" ");
            Console.WriteLine("Health: ");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|(B)         (U)Up          (I)|");
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
            Console.WriteLine("Vision from Enemy: ");
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
                    Console.WriteLine(" " + room.Interact);
                }
                if (input == "B")
                {
                    Console.WriteLine("Progress");
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
            Console.WriteLine("Current Objective: Find the Evidence");
            Console.WriteLine(" ");
            Console.WriteLine("Health: ");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|(B)         (U)Up          (I)|");
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
            Console.WriteLine("Vision from Enemy: ");
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
                if (input == "B")
                {
                    Console.WriteLine("Progress");
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
            Console.WriteLine("Current Objective: Find the Evidence");
            Console.WriteLine(" ");
            Console.WriteLine("Health: ");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|(B)         (U)Up          (I)|");
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
            Console.WriteLine("Vision from Enemy: ");
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
                if (input == "B")
                {
                    Console.WriteLine("Progress");
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
            Console.WriteLine("Current Objective: Find the Evidence");
            Console.WriteLine(" ");
            Console.WriteLine("Health: ");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|(B)         (U)Up          (I)|");
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
            Console.WriteLine("Vision from Enemy: ");
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
                    Console.WriteLine(" " + room.Interact);
                }
                if (input == "B")
                {
                    Console.WriteLine("Progress");
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
            Console.WriteLine("Current Objective: Find the Evidence");
            Console.WriteLine(" ");
            Console.WriteLine("Health: ");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|(B)         (U)Up          (I)|");
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
            Console.WriteLine("Vision from Enemy: ");
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
                    Console.WriteLine(" " + room.Interact);
                }
                if (input == "B")
                {
                    Console.WriteLine("Progress");
                }
            }
        }

        static void PartsAndService()
        {
            Console.Clear();
            Room room = new Room();
            room.Name = "Parts And Service";
            room.Interact = "You picked up a robotic arm with a tringale number '9'";
            room.Description = "A bunch of parts all over the place. Why is there metal inside of a puppet?";
            Console.WriteLine("Current Objective: Find the Evidence");
            Console.WriteLine(" ");
            Console.WriteLine("Health: ");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|(B)         (U)Up          (I)|");
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
            Console.WriteLine("Vision from Enemy: ");
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
                    Console.WriteLine(" " + room.Interact);
                }
                if (input == "B")
                {
                    Console.WriteLine("Progress");
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
            Console.WriteLine("Current Objective: Find the Evidence");
            Console.WriteLine(" ");
            Console.WriteLine("Health: ");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|(B)         (U)Up          (I)|");
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
            Console.WriteLine("Vision from Enemy: ");
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
                    Console.WriteLine(" " + room.Interact);
                }
                if (input == "B")
                {
                    Console.WriteLine("Progress");
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
            Console.WriteLine("Health: ");
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
            Console.WriteLine("Vision from Enemy: NULL");
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
                if (input == "B")
                {
                    Console.WriteLine("Progress");
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
            Console.WriteLine("-Press Enter to Proceed-");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("STATS");
            Console.WriteLine("Ending 1/2: The Normal Ending");
            Console.WriteLine("Times you moved: ");
            Console.WriteLine("Health Left: ");
            Console.WriteLine("Rank: ");
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
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|         NEWS REPORT          |");
            Console.WriteLine("|______________________________|");
            Console.WriteLine("|       Teen Boy Missing       |");
            Console.WriteLine("|          for 3 days          |");
            Console.WriteLine("|           Last seen          |");
            Console.WriteLine("|         DSU Toy Store        |");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("-Press Enter to Proceed-");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("STATS");
            Console.WriteLine("Ending 2/2: The Secret True Ending");
            Console.WriteLine("Times you moved: ");
            Console.WriteLine("Health Left: ");
            Console.WriteLine("Rank: ");
            Console.WriteLine("-Press Enter to Proceed-");
            Console.ReadLine();
            Environment.Exit(1);
        }
    }
}
