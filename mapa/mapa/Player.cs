using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapa
{
    internal class Player
    {
        private string name;
        private int health;
        private int strenght;
        private int attack;
        private int defense;

        public Player(string name)
        {
            this.name = name;
            health = 100;
            strenght = 10;
            attack = 0;
            defense = 0;

        }
        public override string ToString()
        {
            return $"{name}, máš {health} zdraví, {strenght} síli, {attack} útok a {defense} obrany.";
        }
    }
}
