using System;
using ComponentFactory.Krypton.Toolkit;
using System.Windows.Forms;
using dndHelperRefactor;
using System.Linq;
using DndHelper.Utils;
using System.IO;
using DndHelper.Types;
using System.Data;
using System.Drawing;

namespace DndHelper
{
    public partial class DndHelperForm : KryptonForm
    {
        public DndHelperForm()
        {
            InitializeComponent();
            XmlReader.TypeSpecificLoad(Utillities.monsters, @"\xmlFiles\Monsters\", "monster");
            Utillities.InitType("monster", monster_gridView);
            XmlReader.TypeSpecificLoad(Utillities.monsters, @"\xmlFiles\Spells\", "spell");
            Utillities.InitType("spell", spell_gridView);
            XmlReader.TypeSpecificLoad(Utillities.monsters, @"\xmlFiles\Items\", "item");
            Utillities.InitType("item", item_gridView);
            XmlReader.InitPlayers();
            XmlReader.LoadEncounter(Directory.GetCurrentDirectory() + @"\xmlFiles\Players\",XmlReader.playerDefaults,Utillities.playerTable);
            player_gridView.DataSource = Utillities.playerTable;
            player_gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            XmlReader.InitMonsterPool();
            monsterPool_gridView.DataSource = Utillities.monsterPoolTable;
            monsterPool_gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Settings_Tree.ExpandAll();

        }
        DiceRoller roller = new DiceRoller();
        private void btn_wildmagic_Click(object sender, EventArgs e)
        {
            var button = (KryptonButton)sender;
            Console.WriteLine(button.Text);
            if (button.Text.ToLower().Contains("wild magic")) { txtbox_wildMagic.Text = Utils.RollTable.WildCast(); }
            if (button.Text.ToLower().Contains("world event")) { txtbox_wildMagic.Text = Utils.RollTable.WorldEvent(); }
            if (button.Text.ToLower().Contains("slashing")) { txtbox_wildMagic.Text = Utils.RollTable.SlashingCrit(); }
            if (button.Text.ToLower().Contains("piercing")) { txtbox_wildMagic.Text = Utils.RollTable.PiercingCrit(); }
            if (button.Text.ToLower().Contains("blugeoning")) { txtbox_wildMagic.Text = Utils.RollTable.BludgeoningCrit(); }
            if (button.Text.ToLower() == ("magic")) { txtbox_wildMagic.Text = Utils.RollTable.MagicCrit(); }
        }
        private void btn_number_click(object sender, EventArgs e)
        {
            var button = (KryptonButton)sender;
            if (button.Text.Contains("D"))
            {
                if (txtbox_diceRoller.Text == null || txtbox_diceRoller.Text == "")
                {
                    txtbox_diceRoller.Text = "1";
                }
                if (txtbox_diceRoller.Lines.Any())
                {
                    txtbox_diceRoller.Text += roller.DButtonMethod(txtbox_diceRoller.Lines[txtbox_diceRoller.Lines.Length - 1], button.Text.Substring(button.Text.IndexOf('D') + 1));
                }
                else
                {
                    txtbox_diceRoller.Text += roller.DButtonMethod(txtbox_diceRoller.Text, button.Text.Substring(button.Text.IndexOf('D') + 1));
                }
            }
            else
            {
                txtbox_diceRoller.Text += button.Text;
            }
        }
        private void Confirm_Click(object sender, EventArgs e)
        {
            if(txtbox_diceRoller.Lines.Length > 0)
            txtbox_diceRoller.Text += roller.ConfirmButtonMethod(txtbox_diceRoller.Lines.Last());
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            txtbox_diceRoller.Text = "";
            DiceRoller.Total = 0;
        }
        private void gridview_SelectionChanged(object sender, EventArgs e)
        {
            var view = (KryptonDataGridView)sender;
            if (view.Name.Contains("monster"))
            {
                Utillities.GridSelectionChanged(monster_gridView, txtbox_monsterDetails, "monster");
            }
            else if (view.Name.Contains("spell"))
            {
                Utillities.GridSelectionChanged(spell_gridView, txtbox_spellDetails, "spell");
            }
            else if (view.Name.Contains("item"))
            {
                Utillities.GridSelectionChanged(item_gridView, txtbox_itemDetails, "item");
            }
        }
        private void gridview_KeyPress_Event(object sender, KeyPressEventArgs e)
        {
            var txtbox = (KryptonTextBox)sender;
            if (txtbox.Name.Contains("monster"))
            {
                Utillities.SearchType(txtbox_monsterSearchBox, monster_gridView,"monster");
            }
           else if(txtbox.Name.Contains("spell"))
            {
                Utillities.SearchType(txtbox_spellSearchBox, spell_gridView,"spell");
            }
            else if (txtbox.Name.Contains("item"))
            {
                Utillities.SearchType(txtbox_itemSearchBox, item_gridView, "item");
            }

        }
        private void SettingsNode_ClickEvent(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode node = e.Node;
            if (node.Text != "Settings")
            {
                Settings_CheckBoxList.Items.Clear();
                Console.WriteLine(node.Text);
                string location = Directory.GetCurrentDirectory() + @"\xmlFiles\" + node.Text + @"\";
                Utillities.PopulateListBox(Settings_CheckBoxList, location, "*.xml");
           }
        }
        private void btn_ConfirmXmls_Click(object sender, EventArgs e)
        {
            TreeNode node = Settings_Tree.SelectedNode;
            if(node.Text != "Settings")
            {
                string[] temp = new string[Settings_CheckBoxList.Items.Count];
                for (int i = 0; i < Settings_CheckBoxList.Items.Count; i++)
                    if (Settings_CheckBoxList.GetItemChecked(i))
                    {
                        temp[i] = Settings_CheckBoxList.Items[i].ToString();
                    }
                    // Do selected stuff
                    else
                    {
                        // Do unselected stuff
                    }
                temp = temp.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                if(node.Text == "Monsters")
                {
                    Utillities.monsterTable.Clear();
                    Utillities.monsters.Clear();
                    XmlReader.monsterDefaults = temp;
                    XmlReader.TypeSpecificLoad(Utillities.monsters, @"\xmlFiles\Monsters\", "monster");
                    Utillities.InitType("monster", monster_gridView);
                }
                if (node.Text == "Spells")
                {
                    Utillities.spellTable.Clear();
                    Utillities.spells.Clear();
                    XmlReader.spellDefaults = temp;
                    XmlReader.TypeSpecificLoad(Utillities.monsters, @"\xmlFiles\Spells\", "spell");
                    Utillities.InitType("spell", spell_gridView);
                }
                if (node.Text == "Items")
                {
                    Utillities.itemTable.Clear();
                    Utillities.items.Clear();
                    XmlReader.itemDefaults = temp;
                    XmlReader.TypeSpecificLoad(Utillities.monsters, @"\xmlFiles\Items\", "item");
                    Utillities.InitType("item", item_gridView);
                }
                if(node.Text == "Players")
                {
                    Utillities.playerTable.Clear();
                    XmlReader.playerDefaults = temp;
                    XmlReader.LoadEncounter(Directory.GetCurrentDirectory() + @"\xmlFiles\Players\", XmlReader.playerDefaults, Utillities.playerTable);
                }
                if (node.Text == "Encounters")
                {
                    Utillities.monsterPoolTable.Clear();
                    XmlReader.monsterPoolDefaults = temp;
                    XmlReader.LoadEncounter(Directory.GetCurrentDirectory() + @"\xmlFiles\Encounters\", XmlReader.monsterPoolDefaults, Utillities.monsterPoolTable);
                }
            }
        }
        private void btn_clearTicks_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Settings_CheckBoxList.Items.Count; i++)
            {
                Settings_CheckBoxList.SetItemChecked(i, false);
            }
        }
        private void ViewDoubleClickEvent(object sender, MouseEventArgs e)
        {
            var gridView = (DataGridView)sender;
            if(gridView.Name == "monsterPool_gridView")
            {
                Utillities.AddToViewEvent(monsterPool_gridView, init_gridView,null,true,true,true);
            }
           else if(gridView.Name == "monster_gridView")
            {
                Utillities.AddToViewEvent(monster_gridView, monsterPool_gridView,Utillities.monsterPoolTable);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            var button = (KryptonButton)sender;
            if (button.Name.Contains("player"))
            {
                XmlReader.SaveEncounter(Utillities.SaveFileLocation("Xml Files(.xml) | *.xml"), Utillities.playerTable);
            }
            if (button.Name.Contains("monster"))
            {
                XmlReader.SaveEncounter(Utillities.SaveFileLocation("Xml Files(.xml) | *.xml"), Utillities.monsterPoolTable);
            }

        }

        private void init_gridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                m.MenuItems.Add(new MenuItem("Display"));
                int currentMouseOverRow = 0;
                if (init_gridView.HitTest(e.X, e.Y).RowIndex != -1)
                {
                    currentMouseOverRow = init_gridView.HitTest(e.X, e.Y).RowIndex;
                }
                m.Show(init_gridView, new Point(e.X, e.Y));

                if (Utillities.MonsterCompendium[init_gridView.Rows[currentMouseOverRow].Cells[1].Value.ToString()] != null)
                {
                    Monster mon = Utillities.MonsterCompendium[init_gridView.Rows[currentMouseOverRow].Cells[1].Value.ToString()];
                    MessageBox.Show(mon.GetDescDetails());
                }
            }
        }
    }
}
