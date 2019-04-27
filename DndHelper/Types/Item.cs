using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndHelper.Types
{
    public class Item:Base
    {       
        private string text,type,weight,ac,stealth,strength,dmg1,dmg2,property,damageType,range;
        public Item(string name, string type, string weight, string ac, string stealth, string strength, string dmg1, string dmg2, string property, string damageType, string range,string text)
        {
            Name = name;
            Text = text;
            Type = type;
            Weight = weight;
            Ac = ac;
            Stealth = stealth;
            Strength = strength;
            Dmg1 = dmg1;
            Dmg2 = dmg2;
            Property = property;
            DamageType = damageType;
            Range = range;
 
        }
        public string GetDescDetails()
        {
            string nl = Environment.NewLine;
            string ret = "";

            string[] keywords = {"Name", "Type", "Weight", "Armor Class", "Stealth Disadvantage", "Strength", "Damage", "Damage Type", "Properties", "Range", "Text"};
            string[] variables = {Name,Type,Weight,Ac,Stealth,Strength, DamageString(), DamageType,Property,Range,Text};

            for (int i = 0; i < keywords.Length; i++)
            {
                if (variables[i] != "")
                {
                    ret += keywords[i] + ": " + variables[i] + nl;
                }
            }
            return ret;
        }

        public string DamageString()
        {
            if (Dmg2 == "") { Dmg2 = ""; } else Dmg2 = "(" + Dmg2 + ")";
            return Dmg1 + Dmg2;
        }
        #region variables
        public string Ac
        {
            get
            {
                return ac;
            }

            set
            {
                ac = value;
            }
        }

        public string DamageType
        {
            get
            {
                return damageType;
            }

            set
            {
                damageType = value;
            }
        }

        public string Dmg1
        {
            get
            {
                return dmg1;
            }

            set
            {
                dmg1 = value;
            }
        }

        public string Dmg2
        {
            get
            {
                return dmg2;
            }

            set
            {
                dmg2 = value;
            }
        }

        public string Property
        {
            get
            {
                return property;
            }

            set
            {
                property = value;
            }
        }

        public string Range
        {
            get
            {
                return range;
            }

            set
            {
                range = value;
            }
        }

        public string Stealth
        {
            get
            {
                return stealth;
            }

            set
            {
                stealth = value;
            }
        }

        public string Strength
        {
            get
            {
                return strength;
            }

            set
            {
                strength = value;
            }
        }

        public string Text
        {
            get
            {
                return text;
            }

            set
            {
                text = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public string Weight
        {
            get
            {
                return weight;
            }

            set
            {
                weight = value;
            }
        }
        #endregion
        
    }
}
