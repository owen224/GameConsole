using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCharacter owen = new PlayerCharacter(new DiamondSkinDefence())
            {
                Name = "Owen"
            };

            PlayerCharacter hank = new PlayerCharacter(SpecialDefence.Null)
            {
                Name = "Hank"
            };

            PlayerCharacter sandra = new PlayerCharacter(SpecialDefence.Null)
            {
                Name = "Sandra"
            };

            owen.Hit(10);
            hank.Hit(10);
            sandra.Hit(10);

            Console.ReadLine();
        }
    }
}
