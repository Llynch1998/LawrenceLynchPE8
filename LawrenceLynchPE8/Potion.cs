using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawrenceLynchPE8
{
    class Potion
    {
        string potionName;
        int strength;
        string color;
        string useage;
        int doses;

        //Constructor w/out parameters
        public Potion()
        {
            potionName = "Potion";
            strength = 50;
            color = "colorless";
            useage = "To cast on person";
            doses = 10;
        }
        //constructor w/ parameters;
        public Potion(string p_potionName, int p_strength, string p_color, string p_useage, int p_doses)
        {
            potionName = p_potionName;
            strength = p_strength;
            color = p_color;
            useage = p_useage;
            doses = p_doses;
        }
        //reduces potion count
        public void UsePotion()
        {
            doses--;
            Console.WriteLine("Using potion, " + doses + " doses left");
        }
        //displays potion attributes
        public void PrintPotion()
        {
            Console.WriteLine("Potion: " + potionName);
            Console.WriteLine("Strength: " + strength);
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Useage: " + useage);
            Console.WriteLine("Doses: " + doses);
        }

    }
}
