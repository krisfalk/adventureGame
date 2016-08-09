using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Player
    {
        string color;
        string weapon;
        bool alive;

        public Player()
        {
            alive = true;
        }
        public void setWeapon(string weapon)
        {
            this.weapon = weapon;
        }
        public string getWeapon()
        {
            return weapon;
        }
        public string getColor()
        {
            return color;
        }
        public void setColor(string color)
        {
            this.color = color;
        }
        public bool IsAlive()
        {
            return alive;
        }
        public void setAlive(bool alive)
        {
            this.alive = alive;
        }
        public string AskPlayerColor()
        {
            Console.WriteLine("Welcome to my Choose Your Own Adventure Story!!\nChoose the color of your knight: (red, black or white)");
            return Console.ReadLine();
        }
    }
}
