using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Game
    {
        Player player;
        public Game()
        {
            player = new Player();
            player.setColor(player.AskPlayerColor());
        }
        public void RunGame()
        {
            Console.WriteLine(Knight());
            pickWeapon();
            Console.WriteLine(firstDragon());
            endGame();
        }
        public void endGame()
        {
            while (player.IsAlive())
            {
                Console.WriteLine(secondDragon());
                if (player.IsAlive())
                {
                    Console.WriteLine("Congratulations!! You won the game!!");
                    break;
                }
            }
            Console.WriteLine("THE END\npress enter to exit");
            Console.ReadLine();
        }

        public void pickWeapon()
        {
            Console.WriteLine("Dragons have been spotted throughout the land. It is up to you to kill them all. \nEach dragon has a weakness. Good luck!");
            Console.WriteLine("First we head up into the mountains to face the Ruby Dragon. \nPick your weapon of choice: (sword, spear, or wand)");
            player.setWeapon(Console.ReadLine());
        }
        public string Knight()
        {
            switch (player.getColor())
            {
                case "red":
                    return "You are the Fierce Knight of Fire.";
                case "black":
                    return "You are the Dank Knight of Dark.";
                case "white":
                    return "You are the Heavenly Knight of Holy.";
                default:
                    player.setColor("red");
                    return "You do not know how to type so I selected the Red Knight for you.";
            }
        }
        public string firstDragon()
        {
            if (player.getWeapon() == "sword")
            {
                player.setAlive(false);
                return "You swing your sword, but hardly do any damage. Ultimately, the Ruby Dragons claws are too long and you are killed.";
            }
            else if (player.getWeapon() == "wand")
            {
                player.setAlive(false);
                return "You throw spells at the Ruby Dragon, but this dragon is immune to such attacks. You are quickly killed.";
            }
            else if (player.getWeapon() == "spear")
            {
                return "You thrust the spear passed the Ruby Dragon's large claws and deal a fatal blow. \nCongratulations, the Ruby Dragon is dead.";
            }
            else
            {
                player.setAlive(false);
                return "Since you do not know how to pick a weapon, you go into the fight with the Ruby Dragon empty handed and are killed quickly.";
            }

        }
        public string secondDragon()
        {
            if (player.IsAlive() == true)
            {
                Console.WriteLine("One dragon down and one to go.\nWe next head to the desert to face the Sand Dragon.\nWhat weapon will you choose next: (sword or wand)");
                player.setWeapon(Console.ReadLine());
                switch (player.getWeapon())
                {
                    case "sword":
                        player.setAlive(false);
                        return "Swinging the sword with all your might does very little damage to the Sand Dragon and you are killed.";
                    case "wand":
                        return "You throw wicked spells at the Sand Dragon and take him down after battling for hours. \nYou have killed all the dragons!!";
                    default:
                        player.setAlive(false);
                        return "Since you do not know how to pick a weapon, you go into the fight with the Sand Dragon empty handed and are killed quickly.";
                }
            }
            else {
                return " ";
            }
            }
        }
    }

