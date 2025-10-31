using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OOP2_MidtermPractice_2.Classes
{
    public static class DataRW 
    {
        static string filep = "..\\..\\..\\Data\\Data3.xml";
        static string filepp = "..\\..\\..\\Data\\Data.txt";
        static List<Monster> monster_list = new List<Monster>();
        public static void SaveSettings() 
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.NewLineOnAttributes = true;
        }

        public static void Save()
        {
            monster_list.Add(MonsterGenerator.MakeNuggyat());
            monster_list.Add(MonsterGenerator.MakeNuggyat());
            monster_list.Add(MonsterGenerator.MakeNuggyat());
            monster_list.Add(MonsterGenerator.MakeNuggyat());

            XmlWriter writer = XmlWriter.Create(filep);
            writer.WriteString(monster_list.ToString());

            FileStream filestrm = File.Open(filepp, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
        }

    }
}
