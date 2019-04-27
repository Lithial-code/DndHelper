using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndHelper.Types
{
    public class Spell:Base
    {
        private string school,level,time,range,components,duration,classes,text,ritual;
        public Spell(string name,string level, string school, string time, string range, string components, string duration, string classes, string text, string ritual)
        {
            Name = name;
            Level = level;
            School = GetCorrectSchool(school); 
            Time = time;
            Range = range;
            Components = components;
            Duration = duration;
            Classes = classes;
            Text = text;
            Ritual = ritual;
        }
        public string GetDescDetails()
        {
            string nl = Environment.NewLine;
            string[] keywords = {"Name", "Level", "School", "Time", "Range", "Components", "Duration", "Classes","Ritual","Description"};
            string[] variables = {Name,Level,School,Time,Range,Components,Duration,Classes,Ritual,Text };
            string ret = "";
            for (int i = 0; i < keywords.Length; i++)
            {
                if(variables[i] != "")
                {
                    ret += keywords[i] + ": " + variables[i] + nl;
                }
            }
            return ret;
        }
        public string GetCorrectSchool(string school)
        {
            string ret = "";
            switch (school)
            {
                case "EV": ret = "Evocation"; break;
                case "A": ret = "Abjuration"; break;
                case "N": ret = "Necromancy"; break;
                case "C": ret = "Conjuration"; break;
                case "I": ret = "Illusion"; break;
                case "D": ret = "Divination"; break;
                case "T": ret = "Transmutation"; break;
                case "EN": ret = "Enchantment"; break;
                default: ret = school; break;
            }
            return ret;
        }
        #region variables
        public string Classes
        {
            get
            {
                return classes;
            }

            set
            {
                classes = value;
            }
        }

        public string Components
        {
            get
            {
                return components;
            }

            set
            {
                components = value;
            }
        }

        public string Duration
        {
            get
            {
                return duration;
            }

            set
            {
                duration = value;
            }
        }

        public string Level
        {
            get
            {
                return level;
            }

            set
            {
                level = value;
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

        public string Ritual
        {
            get
            {
                return ritual;
            }

            set
            {
                ritual = value;
            }
        }

        public string School
        {
            get
            {
                return school;
            }

            set
            {
                school = value;
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

        public string Time
        {
            get
            {
                return time;
            }

            set
            {
                time = value;
            }
        }
        #endregion
    }

}
