/* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0
 */
using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using dndHelperRefactor;

namespace DndHelper
{
    [XmlRoot(ElementName = "legendary")]
    public class Legendary
    {
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "text")]
        public List<string> Text { get; set; }
        [XmlElement(ElementName = "attack")]
        public List<string> Attack { get; set; }
    }

    [XmlRoot(ElementName = "reaction")]
    public class Reaction
    {
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "text")]
        public List<string> Text { get; set; }
        [XmlElement(ElementName = "attack")]
        public string Attack { get; set; }
    }

    [XmlRoot(ElementName = "compendium")]
    public class Compendium
    {
        [XmlElement(ElementName = "monster")]
        public List<Monster> Monster { get; set; }
        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
    }
    [XmlRoot(ElementName = "trait")]
    public class Trait
    {
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "text")]
        public List<string> Text { get; set; }
        [XmlElement(ElementName = "attack")]
        public List<string> Attack { get; set; }
    }

    [XmlRoot(ElementName = "action")]
    public class Action
    {
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "text")]
        public List<string> Text { get; set; }
        [XmlElement(ElementName = "attack")]
        public List<string> Attack { get; set; }
    }

    [XmlRoot(ElementName = "monster")]
    public class Monster
    {
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "size")]
        public string Size { get; set; }
        [XmlElement(ElementName = "type")]
        public string Type { get; set; }
        [XmlElement(ElementName = "alignment")]
        public string Alignment { get; set; }
        [XmlElement(ElementName = "ac")]
        public string Ac { get; set; }
        [XmlElement(ElementName = "hp")]
        public string Hp { get; set; }
        [XmlElement(ElementName = "speed")]
        public string Speed { get; set; }
        [XmlElement(ElementName = "str")]
        public string Str { get; set; }
        [XmlElement(ElementName = "dex")]
        public string Dex { get; set; }
        [XmlElement(ElementName = "con")]
        public string Con { get; set; }
        [XmlElement(ElementName = "int")]
        public string Int { get; set; }
        [XmlElement(ElementName = "wis")]
        public string Wis { get; set; }
        [XmlElement(ElementName = "cha")]
        public string Cha { get; set; }
        [XmlElement(ElementName = "skill")]
        public List<string> Skill { get; set; }
        [XmlElement(ElementName = "passive")]
        public string Passive { get; set; }
        [XmlElement(ElementName = "languages")]
        public string Languages { get; set; }
        [XmlElement(ElementName = "cr")]
        public string Cr { get; set; }
        [XmlElement(ElementName = "trait")]
        public List<Trait> Trait { get; set; }
        [XmlElement(ElementName = "action")]
        public List<Action> Action { get; set; }
        [XmlElement(ElementName = "save")]
        public string Save { get; set; }
        [XmlElement(ElementName = "resist")]
        public string Resist { get; set; }
        [XmlElement(ElementName = "vulnerable")]
        public string Vulnerable { get; set; }
        [XmlElement(ElementName = "immune")]
        public string Immune { get; set; }
        [XmlElement(ElementName = "conditionImmune")]
        public string ConditionImmune { get; set; }
        [XmlElement(ElementName = "senses")]
        public string Senses { get; set; }
        [XmlElement(ElementName = "spells")]
        public string Spells { get; set; }
        [XmlElement(ElementName = "slots")]
        public string Slots { get; set; }
        [XmlElement(ElementName = "legendary")]
        public List<Legendary> Legendary { get; set; }
        [XmlElement(ElementName = "description")]
        public string Description { get; set; }
        [XmlElement(ElementName = "reaction")]
        public List<Reaction> Reaction { get; set; }
        public string GetCRXPConvertion(string cr)
        {
            string ret = "";
            string[] challenge = {"0", "1/8", "1/4", "1/2", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
            "11","12","13","14","15","16","17","18","19","20","21","22","23","24","25","26","27","28","29","30"};
            string[] xp = {"10", "25", "50", "100", "200", "450", "700", "1100", "1800", "2300", "2900", "3900", "5000", "5900",
            "7200","8400","10000","11500","13000","15000","18000","20000","22000","25000","33000","41000","50000","62000","75000",
                "90000","105000","120000","135000","155000" };
            for (int i = 0; i < challenge.Length; i++)
            {
                if (challenge[i] == cr)
                {
                    ret = xp[i];
                }
            }
            return cr + " (" + ret + ")";
        }
        public string GetStats()
        {
            string stats = "Str: " + Str +
            " Dex: " + Dex +
            " Con: " + Con +
            " Int: " + Int +
            " Wis: " + Wis +
            " Cha: " + Cha;
            return stats;
        }
        public int RollHealth()
        {
            int dice = 0;
            if (Hp != "0")
            {
                string[] ret = Hp.Split('(', 'd', '+', '-');
                for (int i = 0; i < int.Parse(ret[1]); i++)
                {
                    dice += DiceRoller.randInt(1, int.Parse((ret[2]).TrimEnd(')')));
                }
                if (ret.Length == 4)
                {
                    if (Hp.Contains("+"))
                    {
                        dice += int.Parse((ret[3].TrimEnd(')')));

                    }
                    else if (Hp.Contains("-"))
                    {
                        dice -= int.Parse((ret[3].TrimEnd(')')));
                    }
                }

            }
            return dice;
        }
        public string GetAttMod(int num)
        {
            decimal n = num;
            int ret = (int)Math.Floor(n / 2 - 5);
            return " (" + ret.ToString() + ") ";
        }
        public int GetAttModInt(int num)
        {
            int n = num;
            int ret = (int)Math.Floor((decimal)n / 2 - 5);
            return ret;
        }
        public string GetDescDetails()
        {

            string nl = Environment.NewLine;
            string ret = "";
            string[] keywords = {"Name", "Hp", "Ac", "", "Size", "Type", "Alignment", "Speed", "Vunerabillities",
                "Damage Resistances", "Damage Immunities", "Condition Immunities", "Senses", "Passive"
              , "Skills", "Saves", "Languages", "Cr", "Description", "Spells"};
            string[] weirdKeyWords = { "Abillities", "Actions", "Legendary Actions", "Reactions" };

            string[] variables = {Name,Hp, Ac,GetStats(),Size,Type,Alignment,Speed,Vulnerable,Resist,Immune,ConditionImmune,Senses,Passive,
            Skill[0],Save,Languages,GetCRXPConvertion(Cr),Description,Spells};

            for (int i = 0; i < keywords.Length; i++)
            {
                if (variables[i] != null)
                {
                    ret += (keywords[i] + ": " + variables[i] + nl).TrimStart(':', ' ');
                }
            }
            List<Action> actionList = new List<Action>();
            List<Reaction> reactionList = new List<Reaction>();
            List<Legendary> legendaryActionList = new List<Legendary>();
            List<Trait> TraitList = new List<Trait>();
            if (Trait.Count != 0)
            {
                ret+= Environment.NewLine + "TRAITS" + Environment.NewLine;
                foreach (Trait mont in Trait)
                {
                    TraitList.Add(mont);
                    ret += mont.Name + Environment.NewLine;
                    foreach (string item in mont.Text)
                    {
                        ret += item + Environment.NewLine;
                    }
                }
            }
            if (Action.Count != 0)
            {
                ret += Environment.NewLine + "ACTIONS" + Environment.NewLine;
                foreach (Action mont in Action)
                {
                    actionList.Add(mont);
                    ret += mont.Name + Environment.NewLine;
                    foreach (string item in mont.Text)
                    {
                        ret += item + Environment.NewLine;
                    }
                }
            }
            if (Legendary.Count != 0)
            {
                ret += Environment.NewLine + "LEGENDARY ACTIONS" + Environment.NewLine;
                foreach (Legendary mont in Legendary)
                {
                    legendaryActionList.Add(mont);
                    ret += mont.Name + Environment.NewLine;
                    foreach (string item in mont.Text)
                    {
                        ret += item + Environment.NewLine;
                    }
                }
            }
            if (Reaction.Count != 0)
            {
                ret += Environment.NewLine + " LEGENDARY REACTIONS" + Environment.NewLine;
                foreach (Reaction mont in Reaction)
                {
                    reactionList.Add(mont);
                    ret += mont.Name + Environment.NewLine;
                    foreach (string item in mont.Text)
                    {
                        ret += item + Environment.NewLine;
                    }
                }
            }
            return ret;
        }
    }
}