using ComponentFactory.Krypton.Toolkit;
using DndHelper.Types;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace DndHelper.Utils
{
    
    public class XmlReader
    {
        public static string[] monsterDefaults = {"Bestiary Compendium.xml" };
        public static string[] spellDefaults = { "PHB Spells 3.7.2.xml", "EE Spells 2.5.xml", "SCAG Spells 1.1.xml" };
        public static string[] itemDefaults = { "Mundane Items 2.6.1.xml", "Magic Items 4.9.xml", "Renaissance Items 1.3.xml", "Valuable Items 1.1.1.xml" };
        public static string[] playerDefaults = {"Bator.xml"};
        public static string[] monsterPoolDefaults = { };
        public static void InitPlayers()
        {
            Utillities.playerTable.Columns.Add(new DataColumn("Name", typeof(string)));
            Utillities.playerTable.Columns.Add(new DataColumn("Ac", typeof(int)));
            Utillities.playerTable.Columns.Add(new DataColumn("Hp", typeof(int)));
            Utillities.playerTable.Columns.Add(new DataColumn("Init", typeof(int)));
            Utillities.playerTable.Columns.Add(new DataColumn("Xp", typeof(int)));
            Utillities.playerTable.Columns.Add(new DataColumn("Level", typeof(int)));       
       }
        public static void InitMonsterPool()
        {
            Utillities.monsterPoolTable.Columns.Add(new DataColumn("Init", typeof(int)));
            Utillities.monsterPoolTable.Columns.Add(new DataColumn("Name", typeof(string)));
            Utillities.monsterPoolTable.Columns.Add(new DataColumn("Hp", typeof(int)));
            Utillities.monsterPoolTable.Columns.Add(new DataColumn("Ac", typeof(int)));
        }
        public static void LoadEncounter(string location, string[] defaults, DataTable table)
        {
            foreach (string s in defaults)
            {
                table.ReadXml(location + s);
            }
        }
 
        public static void SaveEncounter(string location, DataTable table)
        {
            if(location != null)
            {
                table.WriteXml(location, XmlWriteMode.WriteSchema);
            }
        }
        public static void TypeSpecificLoad<T>(List<T> list, string location, string type)
        {
            string[] variables = null;
            //monster variables
            string[] monsterKeyWords = { "name", "size", "type", "alignment", "ac", "hp", "speed", "str", "dex", "con", "int", "wis", "cha", "passive", "vunerable", "description", "save", "cr", "senses", "immune", "resist", "conditionImmune", "languages", "skill" };
            string[] weirdMonKeywords = { "trait", "action", "legendary", "reaction" };
            //spell variables
            string[] spellKeyWords = { "name", "level", "school", "time", "range", "components", "duration", "classes", "text","ritual" };
            //itemvariables
            string[] itemKeyWords = {"name", "type", "weight", "ac", "stealth", "strength", "dmg1", "dmg2", "property", "dmgType", "range"};
            string[] itemWeirdKeywords = {"text" };

            string path = (Directory.GetCurrentDirectory() + location);

            if (type == "monster")
            {

                XmlDocument doc = new XmlDocument();
                foreach (string m in monsterDefaults)
                {
                    doc.Load(path + m);
                    Compendium compendium = new Compendium();
                    XmlSerializer serializer = new XmlSerializer(typeof(Compendium));
                    StreamReader reader = new StreamReader(path + m);
                    compendium = (Compendium)serializer.Deserialize(reader);
                    reader.Close();

                    Utillities.monsters = compendium.Monster;
                    foreach (Monster item in compendium.Monster)
                    {
                        Utillities.MonsterCompendium[item.Name] = item;
                    }
                }
                // variables = new string[monsterKeyWords.Length + 4];
                //LoadXmlToList(list, location, monsterDefaults, monsterKeyWords, variables, type, weirdMonKeywords);
            }
            if (type == "spell")
            {
                variables = new string[spellKeyWords.Length];
                foreach (string s in spellDefaults)
                {
                    Console.WriteLine(s);
                }
                LoadXmlToList(list, location, spellDefaults, spellKeyWords, variables, type);
            }
            if(type == "item")
            {
                variables = new string[itemKeyWords.Length+1];
                LoadXmlToList(list, location, itemDefaults, itemKeyWords, variables, type,itemWeirdKeywords);
            }
        }
        public static void LoadXmlToList<T>(List<T> list, string location, string[] defaults, string[] keywords, string[] variables, string type, string[] weirdKeywords = null)
        {

            XmlDocument doc = new XmlDocument();
            Monster monster = null;
            Spell spell = null;
            Item item = null;
            int count = 0;
            string path = (Directory.GetCurrentDirectory() + location);
            foreach (string m in defaults)
            {
                doc.Load(path + m);
                foreach (XmlNode node in doc.SelectNodes("compendium/" + type))
                {
                    foreach (string s in keywords)
                    {
                        if (node.SelectSingleNode(s) != null)
                        {
                            variables[count] = node.SelectSingleNode(s).InnerXml;
                            count++;
                        }
                        else
                        {
                            variables[count] = "";
                            count++;
                        }
                    }
                    count = 0;
                    //if (type == "monster")
                    //{
                    //    //make lists
                     
                    //    List<MonsterBase> TraitList = new List<MonsterBase>();
                    //    List<MonsterBase> ActionList = new List<MonsterBase>();
                    //    List<MonsterBase> LegendaryList = new List<MonsterBase>();
                    //    List<MonsterBase> ReactionList = new List<MonsterBase>();
                       
                    //    if (weirdKeywords != null)
                    //    {
                    //        int index = 0;
                    //        foreach (string s in weirdKeywords)
                    //        {
                    //            string name = "";
                    //            string text = "";
                    //            foreach (XmlNode node1 in node.SelectNodes(s))
                    //            {
                    //                name = "";
                    //                text = "";
                    //               name= node1.SelectSingleNode("name").InnerXml + Environment.NewLine;
                    //                foreach (XmlNode nodes  in node1.SelectNodes("text"))
                    //                {
                    //                    text += nodes.InnerXml + Environment.NewLine;
                    //                } 
                    //                index = 0;
                    //                MonsterBase monBase = new MonsterBase(name,text);
                    //                if(s == "action")
                    //                {
                    //                    ActionList.Add(monBase);
                    //                }
                    //                if (s == "trait")
                    //                {
                    //                    TraitList.Add(monBase);
                    //                }
                    //                if (s == "legendary")
                    //                {
                    //                    LegendaryList.Add(monBase);
                    //                }
                    //                if (s == "reaction")
                    //                {
                    //                    ReactionList.Add(monBase);
                    //                }
                    //            }
                              
                    //        }
                    //    }
                    //    try
                    //    {
                    //        monster = new Monster(variables[0], variables[1], variables[2], variables[3], variables[4], variables[5], variables[6], int.Parse(variables[7]), int.Parse(variables[8]), int.Parse(variables[9]), int.Parse(variables[10]), int.Parse(variables[11]), int.Parse(variables[12]), variables[13], variables[14], variables[15], variables[16], variables[17], variables[18], variables[19], variables[20], variables[21], variables[22], variables[23], variables[24], TraitList.ToArray(), ActionList.ToArray(), LegendaryList.ToArray(), ReactionList.ToArray());
                    //    }
                    //    catch (Exception e)
                    //    {
                    //        Console.WriteLine(variables[0]);
                    //        Console.WriteLine(e);
                    //    }
                        
                    //    Utillities.monsters.Add(monster);
                    //}
                    if (type == "spell")
                    {
                        spell = new Spell(variables[0], variables[1], variables[2], variables[3], variables[4], variables[5], variables[6], variables[7], variables[8], variables[9]);
                        Utillities.spells.Add(spell);
                    }
                    if(type == "item")
                    {
                        if (weirdKeywords != null)
                        {
                            string text = "";
                            foreach (string s in weirdKeywords)
                            {
                                foreach (XmlNode node1 in node.SelectNodes(s))
                                {
                                    text += (node1.InnerXml.TrimStart('\t')) + Environment.NewLine;                           
                                }
                            }
                            variables[11] = text;
                        }

                        item = new Item(variables[0], variables[1], variables[2], variables[3], variables[4], variables[5], variables[6], variables[7], variables[8], variables[9], variables[10], variables[11]);
                        Utillities.items.Add(item);
                    }
                }
            }
        }
    }
}
