
using System.Drawing;

namespace OOP2_MidtermPractice_2.Classes
{
    public static class MonsterGenerator
    {
        public static Monster MakeNuggyat()
        {
            return new Monster("Nuggyat", 2, 100, 100, ConsoleColor.Red, "Got dat shaz on do", "FugdeYallBirchAzBrothers", "Close one ma broda", crit_chance: 1, c_d_percent: 50, dodge_chance: 50);
        }
        public static Monster MakeFuPaa()
        {
            return new Monster("FuPaa", 101, 50, 30, ConsoleColor.Magenta, "SPICE BROS 4 LIFEEEEEEE", "NOOOOOOOOOOOOOOOOOOOOOOO", "That almost hit my brobowl");
        }
        public static Monster MakeFuPab() 
        {
            return new Monster("FuPab", 51, 30, 100, ConsoleColor.Magenta, "POULET ROUGEEEEEEEEE", "MY FREE WATER NOOOOOOOOOOOO", "", crit_chance: 50, c_d_percent: 150, dodge_chance: 33);
        }
        public static Monster MakeFuPac()
        {
            return new Monster("FuPac", 31, 100, 50, ConsoleColor.Magenta, "WetNGushy!!!", "Bring a bucket a mop ", crit_chance: 10, c_d_percent: 75, dodge_chance: 90);
        }
        public static Monster MakeArgrizema()
        {
            return new Monster("Argrizema", 100, 10, 85, ConsoleColor.White, "*scoffs* ...looks like.....ur cooked kid *attacks with edge*", "*gets KO'd with egde*", "if only you were stronger.....then maybe you can land a hit *sigma chad mog face*",
                crit_chance: 70, dodge_chance: 25);
        }
        public static Monster MakeGapananus()
        {
            return new Monster("Gapananus", 1,1, 15, ConsoleColor.Magenta, "WetNGushy!!!", "Bring a bucket a mop ", c_d_percent: 150, dodge_chance: 40);
        }
    }
}
