using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace dndHelperRefactor
{
    class DiceRoller
    {
        private static int total = 0; 
        static Random rand = new Random();

        public static int Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }
        public static int randInt(int min, int max)
        {
            int randomNum = rand.Next((max - min) + 1) + min;
            return randomNum;
        }
        public string ConfirmButtonMethod(string input)
        {
            int temp = 0;
            string s = "";
            if (input.Contains('='))
            {
                s = input.Split('=')[1];
            }
            else
            {
                s = input;
            }
            if (s.Contains('+'))
            {
                string[] a = s.Split('+');
                temp = int.Parse(a[0])+int.Parse(a[1]);
            }
            else if (s.Contains('-'))
            {
                string[] a = s.Split('-');
                temp = int.Parse(a[0]) - int.Parse(a[1]);
            }
            return "= " + temp + Environment.NewLine;
       }
        public string DButtonMethod(string input, string number)
        {
            string retur = "d" + number + "(";
            int total = 0;
            int temp;
            Console.WriteLine(input);
            if(input.Contains('d'))
            {
                return "";
            }
            if (input != null || input != "")
            {
                if(input == "")
                {
                    input = "1";
                }
                for (int i = 0; i < int.Parse(input); i++)
                {
                    temp = DiceRoller.randInt(1, int.Parse(number));
                    retur += temp + ",";
                    total += temp;
                }
                if (input == "1" && retur[0] != '1')
                {
                    retur = "1" + retur;
                }
                retur = retur.Trim(',') + ") = " + total;
        
            }
            return retur;
        }
 
    }
}

