using ComponentFactory.Krypton.Toolkit;
using DndHelper.Types;
using dndHelperRefactor;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DndHelper.Utils
{
    public class Utillities
    {
      //methods for buttons

        public static List<Monster> monsters = new List<Monster>();
        public static Dictionary<string, Monster> MonsterCompendium = new Dictionary<string, Monster>();
        public static DataTable monsterTable = Table("Monsters");
        public static List<Spell> spells = new List<Spell>();
        public static DataTable spellTable = Table("Spells");
        public static List<Item> items = new List<Item>();
        public static DataTable itemTable = Table("Items");
        public static DataTable playerTable = new DataTable("Players");
        public static DataTable monsterPoolTable = new DataTable("Monsters");
        //settings utils for loading and populating checkbox lists in settings tab
        public static void PopulateListBox(KryptonCheckedListBox lsb, string Folder, string FileType)
        {
            DirectoryInfo dinfo = new DirectoryInfo(Folder);
            FileInfo[] Files = dinfo.GetFiles(FileType);
            foreach (FileInfo file in Files)
            {
                lsb.Items.Add(file.Name);
            }
            for (int i = 0; i < lsb.Items.Count; i++)
            {
                lsb.SetItemChecked(i, true);
            }
        }
        public static void InitType(string type, KryptonDataGridView view)
        {
            if (type == "monster")
            {
                foreach (Monster mon in monsters)
                {
                    monsterTable.Rows.Add(mon.Name);
                }
                view.DataSource = monsterTable.DefaultView.ToTable(true);
                view.Sort(view.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
            }
            if(type == "spell")
            {
                foreach (Spell spell in spells)
                {
                    spellTable.Rows.Add(spell.Name);
                }
                view.DataSource = spellTable.DefaultView.ToTable(true);
                view.Sort(view.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
            }
            if(type == "item")
            {
                foreach (Item item in items)
                {
                    itemTable.Rows.Add(item.Name);
                }
                view.DataSource = itemTable.DefaultView.ToTable(true);
                view.Sort(view.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
            }

        }
        public static void GridSelectionChanged(KryptonDataGridView view, KryptonTextBox txtbox, string type)
        {
            if (view.SelectedCells.Count > 0)
            {
                int selectedrowindex = view.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = view.Rows[selectedrowindex];
                string a = Convert.ToString(selectedRow.Cells[0].Value);
                txtbox.Text = DisplayDetails(a, type);
            }
        }
        public static void SearchType(KryptonTextBox txtbox, KryptonDataGridView view, string type)
        {
            if (type == "monster")
            {
                DataView DV = new DataView(monsterTable);
                DV.RowFilter = string.Format("Monsters LIKE '%{0}%'", txtbox.Text);
                view.DataSource = DV;
            }
            else if (type == "spell")
            {
                DataView DV = new DataView(spellTable);
                DV.RowFilter = string.Format("Spells LIKE '%{0}%'", txtbox.Text);
                view.DataSource = DV;
            }
            else if (type == "item")
            {
                DataView DV = new DataView(itemTable);
                DV.RowFilter = string.Format("Items LIKE '%{0}%'", txtbox.Text);
                view.DataSource = DV;
            }
        }
        static DataTable Table(params string[] columns)
        {
            DataTable table = new DataTable();
            foreach (string s in columns)
            {
                table.Columns.Add(s, typeof(string));
                table.DefaultView.ToTable(true);
            }
            return table;
        }
        //load method for the display boxes on each tab
        public static string DisplayDetails(string curItem, string type)
        {
            Monster monster = null;
            Spell spell = null;
            Item item = null;
            if (type.ToLower() == "monster")
            {
                monster = MonsterCompendium[curItem];
                if (monster != null)
                {
                    return monster.GetDescDetails();
                }
                else return "";
            }
            if (type.ToLower() == "spell")
            {
                spell = (Spell)GetBaseFinder(curItem, type);
                if (spell != null)
                {
                    return spell.GetDescDetails();
                }
                else return "";
            }
            else if (type.ToLower() == "item")
            {
                item = (Item)GetBaseFinder(curItem, type);
                if (item != null)
                {
                    return item.GetDescDetails();
                }
                else return "";
            }
            else
            {
                return "";
            }
        }
        public static Base GetBaseFinder(string name, string type)
        {
            Monster monster = null;
            Spell spell = null;
            Item item = null;
            //if (type == "monster")
            //{
            //    foreach (Monster m in monsters)
            //    {
            //        if (m.Name == name)
            //        {
            //            monster = m; ;
            //        }
            //    }
            //    return monster;
            //}
            if (type == "spell")
            {
                foreach (Spell s in spells)
                {
                    if (s.Name == name)
                    {
                        spell = s; ;
                    }
                }
                return spell;
            }
            else if (type == "item")
            {
                foreach (Item i in items)
                {
                    if (i.Name == name)
                    {
                        item = i; ;
                    }
                }
                return item;
            }
            return null;
        }
        public static void AddToDataView(DataGridView view, string init, string name, string ac, string mxhp, bool hasRowFive = false)
        {
            DataGridViewRow row = (DataGridViewRow)view.Rows[0].Clone();
            row.Cells[0].Value = int.Parse(init).ToString("00");
            row.Cells[1].Value = name;
            row.Cells[2].Value = ac;
            row.Cells[3].Value = mxhp;
            if(view.Columns.Count > 5)
            {
                row.Cells[4].Value = mxhp;
            }
            if (hasRowFive)
            {
                row.Cells[5].Value = "Healthy";
            }
                view.Rows.Add(row);
                view.Sort(view.Columns[0], System.ComponentModel.ListSortDirection.Descending);          
        }
        public static void AddToDataTable(DataTable table, DataGridView view, int init, string name, string ac, string mxhp, bool hasRowFive = false)
        {
            DataTable tabl = view.DataSource as DataTable;
            DataRow row = table.NewRow();
            row.Table.Rows.Add(init.ToString("00"), name, mxhp, ac.Split('(')[0]);
            table.Rows.Add(row);
            view.Sort(view.Columns[0], System.ComponentModel.ListSortDirection.Descending);
        }

        public static void AddToViewEvent(DataGridView view1, DataGridView view2, DataTable table = null, bool isInitFirstRow = false, bool hasRowFive = false, bool rollInit = false)
        {
            if (view1.SelectedCells.Count > 0)
            {
                int selectedrowindex = view1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = view1.Rows[selectedrowindex];
                string a = "";
                int init = 0;
                if (!isInitFirstRow)
                {
                    a = Convert.ToString(selectedRow.Cells[0].Value);
                }
                else
                {
                    a = Convert.ToString(selectedRow.Cells[1].Value);
                }

                Monster monster = MonsterCompendium[a];
                if (rollInit)
                {
                    int dice = DiceRoller.randInt(1, 20);
                    init = int.Parse(monster.Dex) + dice;
                }
                else
                {
                    init = int.Parse(monster.Dex);
                }
                int hp = monster.RollHealth();
                if(table == null)
                {
                    Utillities.AddToDataView(view2, init.ToString(), monster.Name, monster.Ac, hp.ToString(), hasRowFive);
                }
                else
                {
                    Utillities.AddToDataTable(table,view2, init, monster.Name, monster.Ac, hp.ToString(), hasRowFive);
                }
                view2.Sort(view2.Columns[0], System.ComponentModel.ListSortDirection.Descending);
            }
        }
        public static string SaveFileLocation(string type)
        {
            string location = "";
            //Text Files (.txt)|*.txt
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = type + "|All Files (*.*)|*.*";
            save.FilterIndex = 1;

            // Process input if the user clicked OK.
            if (save.ShowDialog() == DialogResult.OK)
            {
                // Open the selected file to read.
                System.IO.Stream fileStream = save.OpenFile();
                location = save.FileName.ToString();
                fileStream.Close();
            }
            else
            {

            }
            return location;
        }
    }
}
