using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapa
{


    internal class lokalizace
    {
        private string nazev;
        private string text;
        private lokalizace jih, sever, vychod, zapad;
        private Enemy enemy;

        public lokalizace(string nazev, string text)
        {
            this.nazev = nazev;
            this.text = text;
            jih = null;
            sever = null;
            vychod = null;
            zapad = null;
            enemy = null;
        }
        public void setenemy(Enemy enemy)
        {
            this.enemy = enemy;
        }
        public void nastavLokaci(string jakou, lokalizace lokace)
        {
            switch (jakou)
            {
                case "jih": jih = lokace; break;
                case "sever": sever = lokace; break;
                case "vychod": vychod = lokace; break;
                case "zapad": zapad = lokace; break;
                default:
                    Console.WriteLine("to je kudy?");
                    break;
            }
        }
        public override string ToString()
        {
            string enemyoutput = string.Empty;
            if (enemy != null)
                enemyoutput = enemy.ToString();
            return "\n" + nazev + "\n" + text + "\n"+ enemyoutput ;
        }
        public lokalizace provedpresun(string smer, lokalizace aktivnilokace)
        {
            switch (smer)
            {
                case "jih":
                    if (aktivnilokace.jih != null)
                        return aktivnilokace.jih;
                    break;
                case "sever":
                    if (aktivnilokace.sever != null) ;
                        return aktivnilokace.sever;
                    break;
                case "západ":
                    if(aktivnilokace.zapad != null);
                        return aktivnilokace.zapad;
                    break;
                case "vychod":
                    if (aktivnilokace.vychod != null)
                        return aktivnilokace.vychod;
                        break;
            }
            return aktivnilokace;
        }
    }
}
