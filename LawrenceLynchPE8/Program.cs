using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawrenceLynchPE8
{
    class Program
    {
        static void Main(string[] args)
        {
            Potion myCustomPotion = new Potion("Passing Grade", 90, "Red", "To pass this class", 20);
            Potion defaultPotion = new Potion();
            myCustomPotion.PrintPotion();
            defaultPotion.PrintPotion();

            myCustomPotion.UsePotion();
            myCustomPotion.PrintPotion();
        }
    }

   
}
