using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapa
{
    internal class Enemy
    {
        private string name;
        private int health;
        private int attack;
        

        public Enemy (string name, int health, int attack)
        {
            this.name = name;
            this.health = health;
            this.attack = attack;
            
        }
        public override string ToString()
        {
            return $"{name}, {health} zdravi, {attack}, utok";
        }
    }
    
    
}
