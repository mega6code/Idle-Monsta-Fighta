
using System.Drawing;

namespace OOP2_MidtermPractice_2.Classes
{
    public class MonsterGenerator
    {
        public Monster MakeNuggyat()
        {
            return new Monster("Nuggyat", 2, 400, ConsoleColor.Red, "Got dat shaz on do", "FugdeYallBirchAzBrothers",);
        }
        public Monster MakeFuPaa()
        {
            return new Monster("FuPaa", 30, 15, ConsoleColor.Magenta, "WetNGushy!!!", "Bring a bucket a mop ");
        }
        public Monster MakeFuPab() 
        { 
        }
        public Monster MakeFuPac() 
        { 
        }
        public Monster Argrizema()
        {
            return new Monster("Argrizema", 100, 10,  ConsoleColor.White,"*scoffs* ...looks like.....ur cooked kid *attacks with edge*", "*gets KO'd with egde*");
        }
        public Monster Gapananus()
        {

        }
    }
}
