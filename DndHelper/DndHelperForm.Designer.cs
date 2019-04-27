namespace DndHelper
{
    partial class DndHelperForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Encounters");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Items");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Monsters");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Players");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Spells");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Settings", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DndHelperForm));
            this.TabsDmHelper = new ComponentFactory.Krypton.Docking.KryptonDockableNavigator();
            this.WildMagicTab = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.btn_magic = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_piercing = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_worldEvent = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_bludgeoning = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_slashing = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtbox_wildMagic = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btn_wildmagic = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.InitTab = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonSplitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.init_gridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.InitiativeTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InitNameTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InitAcTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InitMaxHpTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InitHpTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InitStatusTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InitConcentratingTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InitNotesTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonsterTab = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.txtbox_monsterDetails = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.MonsterPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.MonsterSearchSplitContainer = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.txtbox_monsterSearchBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.monster_gridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.SpellTab = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.txtbox_spellDetails = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.SpellPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.SpellSearchSpiltContainer = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.txtbox_spellSearchBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.spell_gridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.ItemTab = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.txtbox_itemDetails = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ItemPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.ItemSearchSplitContainer = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.txtbox_itemSearchBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.item_gridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.SettingTab = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.btn_clearTicks = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_ConfirmXmls = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Settings_CheckBoxList = new ComponentFactory.Krypton.Toolkit.KryptonCheckedListBox();
            this.Settings_Tree = new ComponentFactory.Krypton.Toolkit.KryptonTreeView();
            this.DiceRollerForm = new ComponentFactory.Krypton.Docking.KryptonDockableNavigator();
            this.DiceRollerTab = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.DiceRollerGridLayout = new System.Windows.Forms.TableLayoutPanel();
            this.btn_d100 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_d12 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_d8 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_d5 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_d3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_d20 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_minus = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_0 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_plus = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_d10 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_9 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_8 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_7 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_d6 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_6 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_5 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_4 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_d4 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_d2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_equals = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_c = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtbox_diceRoller = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.MonsterPoolTab = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.mosterPoolViewButtonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btn_monsterSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.monsterPool_gridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.PlayerPoolTab = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_playerSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.player_gridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.MainSplitContainer = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.TabsDmHelper)).BeginInit();
            this.TabsDmHelper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WildMagicTab)).BeginInit();
            this.WildMagicTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InitTab)).BeginInit();
            this.InitTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).BeginInit();
            this.kryptonSplitContainer1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).BeginInit();
            this.kryptonSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.init_gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonsterTab)).BeginInit();
            this.MonsterTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MonsterPanel)).BeginInit();
            this.MonsterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MonsterSearchSplitContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonsterSearchSplitContainer.Panel1)).BeginInit();
            this.MonsterSearchSplitContainer.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MonsterSearchSplitContainer.Panel2)).BeginInit();
            this.MonsterSearchSplitContainer.Panel2.SuspendLayout();
            this.MonsterSearchSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monster_gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpellTab)).BeginInit();
            this.SpellTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpellPanel)).BeginInit();
            this.SpellPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpellSearchSpiltContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpellSearchSpiltContainer.Panel1)).BeginInit();
            this.SpellSearchSpiltContainer.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpellSearchSpiltContainer.Panel2)).BeginInit();
            this.SpellSearchSpiltContainer.Panel2.SuspendLayout();
            this.SpellSearchSpiltContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spell_gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemTab)).BeginInit();
            this.ItemTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPanel)).BeginInit();
            this.ItemPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemSearchSplitContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemSearchSplitContainer.Panel1)).BeginInit();
            this.ItemSearchSplitContainer.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemSearchSplitContainer.Panel2)).BeginInit();
            this.ItemSearchSplitContainer.Panel2.SuspendLayout();
            this.ItemSearchSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.item_gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingTab)).BeginInit();
            this.SettingTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiceRollerForm)).BeginInit();
            this.DiceRollerForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiceRollerTab)).BeginInit();
            this.DiceRollerTab.SuspendLayout();
            this.DiceRollerGridLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MonsterPoolTab)).BeginInit();
            this.MonsterPoolTab.SuspendLayout();
            this.mosterPoolViewButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monsterPool_gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPoolTab)).BeginInit();
            this.PlayerPoolTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player_gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer.Panel1)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer.Panel2)).BeginInit();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabsDmHelper
            // 
            this.TabsDmHelper.AutoSize = true;
            this.TabsDmHelper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TabsDmHelper.Bar.BarMinimumHeight = 40;
            this.TabsDmHelper.Bar.ItemMinimumSize = new System.Drawing.Size(40, 40);
            this.TabsDmHelper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabsDmHelper.Location = new System.Drawing.Point(0, 0);
            this.TabsDmHelper.Name = "TabsDmHelper";
            this.TabsDmHelper.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.WildMagicTab,
            this.InitTab,
            this.MonsterTab,
            this.SpellTab,
            this.ItemTab,
            this.SettingTab});
            this.TabsDmHelper.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.TabsDmHelper.SelectedIndex = 4;
            this.TabsDmHelper.Size = new System.Drawing.Size(588, 543);
            this.TabsDmHelper.TabIndex = 0;
            // 
            // WildMagicTab
            // 
            this.WildMagicTab.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.WildMagicTab.Controls.Add(this.btn_magic);
            this.WildMagicTab.Controls.Add(this.btn_piercing);
            this.WildMagicTab.Controls.Add(this.btn_worldEvent);
            this.WildMagicTab.Controls.Add(this.btn_bludgeoning);
            this.WildMagicTab.Controls.Add(this.btn_slashing);
            this.WildMagicTab.Controls.Add(this.txtbox_wildMagic);
            this.WildMagicTab.Controls.Add(this.btn_wildmagic);
            this.WildMagicTab.Flags = 65534;
            this.WildMagicTab.LastVisibleSet = true;
            this.WildMagicTab.MinimumSize = new System.Drawing.Size(50, 50);
            this.WildMagicTab.Name = "WildMagicTab";
            this.WildMagicTab.Size = new System.Drawing.Size(586, 501);
            this.WildMagicTab.Text = "WildMagic/CritTable";
            this.WildMagicTab.ToolTipTitle = "Page ToolTip";
            this.WildMagicTab.UniqueName = "2BE1301764F44C6D069B59DBF12DF7A7";
            // 
            // btn_magic
            // 
            this.btn_magic.Location = new System.Drawing.Point(203, 173);
            this.btn_magic.Name = "btn_magic";
            this.btn_magic.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.btn_magic.Size = new System.Drawing.Size(90, 25);
            this.btn_magic.TabIndex = 6;
            this.btn_magic.Values.Text = "Magic";
            this.btn_magic.Click += new System.EventHandler(this.btn_wildmagic_Click);
            // 
            // btn_piercing
            // 
            this.btn_piercing.Location = new System.Drawing.Point(107, 173);
            this.btn_piercing.Name = "btn_piercing";
            this.btn_piercing.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.btn_piercing.Size = new System.Drawing.Size(90, 25);
            this.btn_piercing.TabIndex = 5;
            this.btn_piercing.Values.Text = "Piercing";
            this.btn_piercing.Click += new System.EventHandler(this.btn_wildmagic_Click);
            // 
            // btn_worldEvent
            // 
            this.btn_worldEvent.Location = new System.Drawing.Point(11, 173);
            this.btn_worldEvent.Name = "btn_worldEvent";
            this.btn_worldEvent.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.btn_worldEvent.Size = new System.Drawing.Size(90, 25);
            this.btn_worldEvent.TabIndex = 4;
            this.btn_worldEvent.Values.Text = "World Event";
            this.btn_worldEvent.Click += new System.EventHandler(this.btn_wildmagic_Click);
            // 
            // btn_bludgeoning
            // 
            this.btn_bludgeoning.Location = new System.Drawing.Point(203, 142);
            this.btn_bludgeoning.Name = "btn_bludgeoning";
            this.btn_bludgeoning.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.btn_bludgeoning.Size = new System.Drawing.Size(90, 25);
            this.btn_bludgeoning.TabIndex = 3;
            this.btn_bludgeoning.Values.Text = "Bludgeoning";
            this.btn_bludgeoning.Click += new System.EventHandler(this.btn_wildmagic_Click);
            // 
            // btn_slashing
            // 
            this.btn_slashing.Location = new System.Drawing.Point(107, 142);
            this.btn_slashing.Name = "btn_slashing";
            this.btn_slashing.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.btn_slashing.Size = new System.Drawing.Size(90, 25);
            this.btn_slashing.TabIndex = 2;
            this.btn_slashing.Values.Text = "Slashing";
            this.btn_slashing.Click += new System.EventHandler(this.btn_wildmagic_Click);
            // 
            // txtbox_wildMagic
            // 
            this.txtbox_wildMagic.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtbox_wildMagic.Location = new System.Drawing.Point(0, 0);
            this.txtbox_wildMagic.Multiline = true;
            this.txtbox_wildMagic.Name = "txtbox_wildMagic";
            this.txtbox_wildMagic.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.txtbox_wildMagic.ReadOnly = true;
            this.txtbox_wildMagic.Size = new System.Drawing.Size(586, 136);
            this.txtbox_wildMagic.TabIndex = 1;
            // 
            // btn_wildmagic
            // 
            this.btn_wildmagic.Location = new System.Drawing.Point(11, 142);
            this.btn_wildmagic.Name = "btn_wildmagic";
            this.btn_wildmagic.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.btn_wildmagic.Size = new System.Drawing.Size(90, 25);
            this.btn_wildmagic.TabIndex = 0;
            this.btn_wildmagic.Values.Text = "Wild Magic";
            this.btn_wildmagic.Click += new System.EventHandler(this.btn_wildmagic_Click);
            // 
            // InitTab
            // 
            this.InitTab.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.InitTab.Controls.Add(this.kryptonSplitContainer1);
            this.InitTab.Flags = 65534;
            this.InitTab.LastVisibleSet = true;
            this.InitTab.MinimumSize = new System.Drawing.Size(50, 50);
            this.InitTab.Name = "InitTab";
            this.InitTab.Size = new System.Drawing.Size(586, 501);
            this.InitTab.Text = "Initiative";
            this.InitTab.ToolTipTitle = "Page ToolTip";
            this.InitTab.UniqueName = "66E71B4C404845E7799D0748C8437DAC";
            // 
            // kryptonSplitContainer1
            // 
            this.kryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.kryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.kryptonSplitContainer1.Name = "kryptonSplitContainer1";
            this.kryptonSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.kryptonSplitContainer1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            // 
            // kryptonSplitContainer1.Panel1
            // 
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.init_gridView);
            // 
            // kryptonSplitContainer1.Panel2
            // 
            this.kryptonSplitContainer1.Panel2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.kryptonSplitContainer1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile;
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(586, 501);
            this.kryptonSplitContainer1.SplitterDistance = 387;
            this.kryptonSplitContainer1.TabIndex = 1;
            // 
            // init_gridView
            // 
            this.init_gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InitiativeTab,
            this.InitNameTab,
            this.InitAcTab,
            this.InitMaxHpTab,
            this.InitHpTab,
            this.InitStatusTab,
            this.InitConcentratingTab,
            this.InitNotesTab});
            this.init_gridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.init_gridView.Location = new System.Drawing.Point(0, 0);
            this.init_gridView.Name = "init_gridView";
            this.init_gridView.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.init_gridView.RowHeadersWidth = 20;
            this.init_gridView.Size = new System.Drawing.Size(586, 387);
            this.init_gridView.TabIndex = 0;
            this.init_gridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.init_gridView_MouseClick);
            this.init_gridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ViewDoubleClickEvent);
            // 
            // InitiativeTab
            // 
            this.InitiativeTab.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InitiativeTab.HeaderText = "Initiative";
            this.InitiativeTab.Name = "InitiativeTab";
            // 
            // InitNameTab
            // 
            this.InitNameTab.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InitNameTab.HeaderText = "Name";
            this.InitNameTab.Name = "InitNameTab";
            // 
            // InitAcTab
            // 
            this.InitAcTab.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InitAcTab.HeaderText = "AC";
            this.InitAcTab.Name = "InitAcTab";
            // 
            // InitMaxHpTab
            // 
            this.InitMaxHpTab.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InitMaxHpTab.HeaderText = "MaxHP";
            this.InitMaxHpTab.Name = "InitMaxHpTab";
            // 
            // InitHpTab
            // 
            this.InitHpTab.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InitHpTab.HeaderText = "Hp";
            this.InitHpTab.Name = "InitHpTab";
            // 
            // InitStatusTab
            // 
            this.InitStatusTab.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InitStatusTab.HeaderText = "Status";
            this.InitStatusTab.Name = "InitStatusTab";
            // 
            // InitConcentratingTab
            // 
            this.InitConcentratingTab.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InitConcentratingTab.HeaderText = "Is Concentrating";
            this.InitConcentratingTab.Name = "InitConcentratingTab";
            // 
            // InitNotesTab
            // 
            this.InitNotesTab.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InitNotesTab.HeaderText = "Notes";
            this.InitNotesTab.Name = "InitNotesTab";
            // 
            // MonsterTab
            // 
            this.MonsterTab.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.MonsterTab.Controls.Add(this.txtbox_monsterDetails);
            this.MonsterTab.Controls.Add(this.MonsterPanel);
            this.MonsterTab.Flags = 65534;
            this.MonsterTab.LastVisibleSet = true;
            this.MonsterTab.MinimumSize = new System.Drawing.Size(50, 50);
            this.MonsterTab.Name = "MonsterTab";
            this.MonsterTab.Size = new System.Drawing.Size(586, 501);
            this.MonsterTab.Text = "Monsters";
            this.MonsterTab.ToolTipTitle = "Page ToolTip";
            this.MonsterTab.UniqueName = "AB02285F385B47D8ADA9A4E7CB165F30";
            // 
            // txtbox_monsterDetails
            // 
            this.txtbox_monsterDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_monsterDetails.Location = new System.Drawing.Point(174, 0);
            this.txtbox_monsterDetails.Multiline = true;
            this.txtbox_monsterDetails.Name = "txtbox_monsterDetails";
            this.txtbox_monsterDetails.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.txtbox_monsterDetails.ReadOnly = true;
            this.txtbox_monsterDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbox_monsterDetails.Size = new System.Drawing.Size(412, 501);
            this.txtbox_monsterDetails.StateNormal.Border.Color1 = System.Drawing.Color.White;
            this.txtbox_monsterDetails.StateNormal.Border.Color2 = System.Drawing.Color.White;
            this.txtbox_monsterDetails.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtbox_monsterDetails.TabIndex = 4;
            // 
            // MonsterPanel
            // 
            this.MonsterPanel.Controls.Add(this.MonsterSearchSplitContainer);
            this.MonsterPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MonsterPanel.Location = new System.Drawing.Point(0, 0);
            this.MonsterPanel.Name = "MonsterPanel";
            this.MonsterPanel.Size = new System.Drawing.Size(175, 501);
            this.MonsterPanel.TabIndex = 2;
            // 
            // MonsterSearchSplitContainer
            // 
            this.MonsterSearchSplitContainer.Cursor = System.Windows.Forms.Cursors.Default;
            this.MonsterSearchSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MonsterSearchSplitContainer.IsSplitterFixed = true;
            this.MonsterSearchSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.MonsterSearchSplitContainer.Name = "MonsterSearchSplitContainer";
            this.MonsterSearchSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.MonsterSearchSplitContainer.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            // 
            // MonsterSearchSplitContainer.Panel1
            // 
            this.MonsterSearchSplitContainer.Panel1.Controls.Add(this.txtbox_monsterSearchBox);
            this.MonsterSearchSplitContainer.Panel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.MonsterSearchSplitContainer.Panel1MinSize = 20;
            // 
            // MonsterSearchSplitContainer.Panel2
            // 
            this.MonsterSearchSplitContainer.Panel2.Controls.Add(this.monster_gridView);
            this.MonsterSearchSplitContainer.Panel2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.MonsterSearchSplitContainer.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile;
            this.MonsterSearchSplitContainer.Size = new System.Drawing.Size(175, 501);
            this.MonsterSearchSplitContainer.SplitterDistance = 20;
            this.MonsterSearchSplitContainer.TabIndex = 0;
            // 
            // txtbox_monsterSearchBox
            // 
            this.txtbox_monsterSearchBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbox_monsterSearchBox.Location = new System.Drawing.Point(0, 0);
            this.txtbox_monsterSearchBox.Name = "txtbox_monsterSearchBox";
            this.txtbox_monsterSearchBox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.txtbox_monsterSearchBox.Size = new System.Drawing.Size(175, 20);
            this.txtbox_monsterSearchBox.StateNormal.Border.Color1 = System.Drawing.Color.Black;
            this.txtbox_monsterSearchBox.StateNormal.Border.Color2 = System.Drawing.Color.Black;
            this.txtbox_monsterSearchBox.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtbox_monsterSearchBox.StateNormal.Border.Rounding = 1;
            this.txtbox_monsterSearchBox.StateNormal.Border.Width = 1;
            this.txtbox_monsterSearchBox.TabIndex = 0;
            this.txtbox_monsterSearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gridview_KeyPress_Event);
            // 
            // monster_gridView
            // 
            this.monster_gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.monster_gridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monster_gridView.Location = new System.Drawing.Point(0, 0);
            this.monster_gridView.Name = "monster_gridView";
            this.monster_gridView.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.monster_gridView.RowHeadersVisible = false;
            this.monster_gridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.monster_gridView.Size = new System.Drawing.Size(175, 476);
            this.monster_gridView.TabIndex = 2;
            this.monster_gridView.SelectionChanged += new System.EventHandler(this.gridview_SelectionChanged);
            this.monster_gridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ViewDoubleClickEvent);
            // 
            // SpellTab
            // 
            this.SpellTab.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.SpellTab.Controls.Add(this.txtbox_spellDetails);
            this.SpellTab.Controls.Add(this.SpellPanel);
            this.SpellTab.Flags = 65534;
            this.SpellTab.LastVisibleSet = true;
            this.SpellTab.MinimumSize = new System.Drawing.Size(50, 50);
            this.SpellTab.Name = "SpellTab";
            this.SpellTab.Size = new System.Drawing.Size(586, 501);
            this.SpellTab.Text = "Spells";
            this.SpellTab.ToolTipTitle = "Page ToolTip";
            this.SpellTab.UniqueName = "DD83C1B96FDE4579739A437A204A07A0";
            // 
            // txtbox_spellDetails
            // 
            this.txtbox_spellDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_spellDetails.Location = new System.Drawing.Point(174, 0);
            this.txtbox_spellDetails.Multiline = true;
            this.txtbox_spellDetails.Name = "txtbox_spellDetails";
            this.txtbox_spellDetails.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.txtbox_spellDetails.ReadOnly = true;
            this.txtbox_spellDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbox_spellDetails.Size = new System.Drawing.Size(412, 501);
            this.txtbox_spellDetails.StateNormal.Border.Color1 = System.Drawing.Color.White;
            this.txtbox_spellDetails.StateNormal.Border.Color2 = System.Drawing.Color.White;
            this.txtbox_spellDetails.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtbox_spellDetails.TabIndex = 3;
            // 
            // SpellPanel
            // 
            this.SpellPanel.Controls.Add(this.SpellSearchSpiltContainer);
            this.SpellPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SpellPanel.Location = new System.Drawing.Point(0, 0);
            this.SpellPanel.Name = "SpellPanel";
            this.SpellPanel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.SpellPanel.Size = new System.Drawing.Size(175, 501);
            this.SpellPanel.TabIndex = 2;
            // 
            // SpellSearchSpiltContainer
            // 
            this.SpellSearchSpiltContainer.Cursor = System.Windows.Forms.Cursors.Default;
            this.SpellSearchSpiltContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpellSearchSpiltContainer.Location = new System.Drawing.Point(0, 0);
            this.SpellSearchSpiltContainer.Name = "SpellSearchSpiltContainer";
            this.SpellSearchSpiltContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.SpellSearchSpiltContainer.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            // 
            // SpellSearchSpiltContainer.Panel1
            // 
            this.SpellSearchSpiltContainer.Panel1.Controls.Add(this.txtbox_spellSearchBox);
            this.SpellSearchSpiltContainer.Panel1MinSize = 20;
            // 
            // SpellSearchSpiltContainer.Panel2
            // 
            this.SpellSearchSpiltContainer.Panel2.Controls.Add(this.spell_gridView);
            this.SpellSearchSpiltContainer.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile;
            this.SpellSearchSpiltContainer.Size = new System.Drawing.Size(175, 501);
            this.SpellSearchSpiltContainer.SplitterDistance = 20;
            this.SpellSearchSpiltContainer.TabIndex = 1;
            // 
            // txtbox_spellSearchBox
            // 
            this.txtbox_spellSearchBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbox_spellSearchBox.Location = new System.Drawing.Point(0, 0);
            this.txtbox_spellSearchBox.Name = "txtbox_spellSearchBox";
            this.txtbox_spellSearchBox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.txtbox_spellSearchBox.Size = new System.Drawing.Size(175, 20);
            this.txtbox_spellSearchBox.TabIndex = 0;
            this.txtbox_spellSearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gridview_KeyPress_Event);
            // 
            // spell_gridView
            // 
            this.spell_gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.spell_gridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spell_gridView.Location = new System.Drawing.Point(0, 0);
            this.spell_gridView.Name = "spell_gridView";
            this.spell_gridView.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.spell_gridView.RowHeadersVisible = false;
            this.spell_gridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.spell_gridView.Size = new System.Drawing.Size(175, 476);
            this.spell_gridView.TabIndex = 1;
            this.spell_gridView.SelectionChanged += new System.EventHandler(this.gridview_SelectionChanged);
            // 
            // ItemTab
            // 
            this.ItemTab.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.ItemTab.Controls.Add(this.txtbox_itemDetails);
            this.ItemTab.Controls.Add(this.ItemPanel);
            this.ItemTab.Flags = 65534;
            this.ItemTab.LastVisibleSet = true;
            this.ItemTab.MinimumSize = new System.Drawing.Size(50, 50);
            this.ItemTab.Name = "ItemTab";
            this.ItemTab.Size = new System.Drawing.Size(586, 501);
            this.ItemTab.Text = "Items";
            this.ItemTab.ToolTipTitle = "Page ToolTip";
            this.ItemTab.UniqueName = "EDCFC9F055C04B82F49BEE24B3E3E551";
            // 
            // txtbox_itemDetails
            // 
            this.txtbox_itemDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_itemDetails.Location = new System.Drawing.Point(174, 0);
            this.txtbox_itemDetails.Multiline = true;
            this.txtbox_itemDetails.Name = "txtbox_itemDetails";
            this.txtbox_itemDetails.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.txtbox_itemDetails.ReadOnly = true;
            this.txtbox_itemDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbox_itemDetails.Size = new System.Drawing.Size(412, 501);
            this.txtbox_itemDetails.StateNormal.Border.Color1 = System.Drawing.Color.White;
            this.txtbox_itemDetails.StateNormal.Border.Color2 = System.Drawing.Color.White;
            this.txtbox_itemDetails.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtbox_itemDetails.TabIndex = 4;
            // 
            // ItemPanel
            // 
            this.ItemPanel.Controls.Add(this.ItemSearchSplitContainer);
            this.ItemPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ItemPanel.Location = new System.Drawing.Point(0, 0);
            this.ItemPanel.Name = "ItemPanel";
            this.ItemPanel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.ItemPanel.Size = new System.Drawing.Size(175, 501);
            this.ItemPanel.TabIndex = 0;
            // 
            // ItemSearchSplitContainer
            // 
            this.ItemSearchSplitContainer.Cursor = System.Windows.Forms.Cursors.Default;
            this.ItemSearchSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemSearchSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.ItemSearchSplitContainer.Name = "ItemSearchSplitContainer";
            this.ItemSearchSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.ItemSearchSplitContainer.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            // 
            // ItemSearchSplitContainer.Panel1
            // 
            this.ItemSearchSplitContainer.Panel1.Controls.Add(this.txtbox_itemSearchBox);
            this.ItemSearchSplitContainer.Panel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.ItemSearchSplitContainer.Panel1MinSize = 20;
            // 
            // ItemSearchSplitContainer.Panel2
            // 
            this.ItemSearchSplitContainer.Panel2.Controls.Add(this.item_gridView);
            this.ItemSearchSplitContainer.Panel2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.ItemSearchSplitContainer.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile;
            this.ItemSearchSplitContainer.Size = new System.Drawing.Size(175, 501);
            this.ItemSearchSplitContainer.SplitterDistance = 20;
            this.ItemSearchSplitContainer.TabIndex = 0;
            // 
            // txtbox_itemSearchBox
            // 
            this.txtbox_itemSearchBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbox_itemSearchBox.Location = new System.Drawing.Point(0, 0);
            this.txtbox_itemSearchBox.Name = "txtbox_itemSearchBox";
            this.txtbox_itemSearchBox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.txtbox_itemSearchBox.Size = new System.Drawing.Size(175, 20);
            this.txtbox_itemSearchBox.TabIndex = 1;
            this.txtbox_itemSearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gridview_KeyPress_Event);
            // 
            // item_gridView
            // 
            this.item_gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.item_gridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.item_gridView.Location = new System.Drawing.Point(0, 0);
            this.item_gridView.Name = "item_gridView";
            this.item_gridView.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.item_gridView.RowHeadersVisible = false;
            this.item_gridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.item_gridView.Size = new System.Drawing.Size(175, 476);
            this.item_gridView.TabIndex = 2;
            this.item_gridView.SelectionChanged += new System.EventHandler(this.gridview_SelectionChanged);
            // 
            // SettingTab
            // 
            this.SettingTab.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.SettingTab.Controls.Add(this.btn_clearTicks);
            this.SettingTab.Controls.Add(this.btn_ConfirmXmls);
            this.SettingTab.Controls.Add(this.Settings_CheckBoxList);
            this.SettingTab.Controls.Add(this.Settings_Tree);
            this.SettingTab.Flags = 65534;
            this.SettingTab.LastVisibleSet = true;
            this.SettingTab.MinimumSize = new System.Drawing.Size(50, 50);
            this.SettingTab.Name = "SettingTab";
            this.SettingTab.Size = new System.Drawing.Size(586, 501);
            this.SettingTab.Text = "Settings";
            this.SettingTab.ToolTipTitle = "Page ToolTip";
            this.SettingTab.UniqueName = "0E15DB39C85F4850C69DCCD5127F2B49";
            // 
            // btn_clearTicks
            // 
            this.btn_clearTicks.Location = new System.Drawing.Point(309, 42);
            this.btn_clearTicks.Name = "btn_clearTicks";
            this.btn_clearTicks.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.btn_clearTicks.Size = new System.Drawing.Size(90, 25);
            this.btn_clearTicks.TabIndex = 3;
            this.btn_clearTicks.Values.Text = "Clear";
            this.btn_clearTicks.Click += new System.EventHandler(this.btn_clearTicks_Click);
            // 
            // btn_ConfirmXmls
            // 
            this.btn_ConfirmXmls.Location = new System.Drawing.Point(309, 11);
            this.btn_ConfirmXmls.Name = "btn_ConfirmXmls";
            this.btn_ConfirmXmls.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.btn_ConfirmXmls.Size = new System.Drawing.Size(90, 25);
            this.btn_ConfirmXmls.TabIndex = 2;
            this.btn_ConfirmXmls.Values.Text = "Confirm";
            this.btn_ConfirmXmls.Click += new System.EventHandler(this.btn_ConfirmXmls_Click);
            // 
            // Settings_CheckBoxList
            // 
            this.Settings_CheckBoxList.Dock = System.Windows.Forms.DockStyle.Left;
            this.Settings_CheckBoxList.Location = new System.Drawing.Point(124, 0);
            this.Settings_CheckBoxList.Name = "Settings_CheckBoxList";
            this.Settings_CheckBoxList.Size = new System.Drawing.Size(179, 501);
            this.Settings_CheckBoxList.TabIndex = 1;
            // 
            // Settings_Tree
            // 
            this.Settings_Tree.Dock = System.Windows.Forms.DockStyle.Left;
            this.Settings_Tree.Location = new System.Drawing.Point(0, 0);
            this.Settings_Tree.Name = "Settings_Tree";
            treeNode1.Name = "Tab_Encounters";
            treeNode1.Text = "Encounters";
            treeNode2.Checked = true;
            treeNode2.Name = "Tab_Items";
            treeNode2.Text = "Items";
            treeNode3.Checked = true;
            treeNode3.Name = "Tab_Monsters";
            treeNode3.Text = "Monsters";
            treeNode4.Name = "Tab_Players";
            treeNode4.Text = "Players";
            treeNode5.Checked = true;
            treeNode5.Name = "Tab_Spells";
            treeNode5.Text = "Spells";
            treeNode6.Checked = true;
            treeNode6.Name = "Tree_Settings";
            treeNode6.Text = "Settings";
            this.Settings_Tree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.Settings_Tree.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.Settings_Tree.Size = new System.Drawing.Size(124, 501);
            this.Settings_Tree.TabIndex = 0;
            this.Settings_Tree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.SettingsNode_ClickEvent);
            // 
            // DiceRollerForm
            // 
            this.DiceRollerForm.AutoSize = true;
            this.DiceRollerForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DiceRollerForm.Bar.BarMinimumHeight = 40;
            this.DiceRollerForm.Bar.ItemMinimumSize = new System.Drawing.Size(40, 40);
            this.DiceRollerForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DiceRollerForm.Location = new System.Drawing.Point(0, 0);
            this.DiceRollerForm.Name = "DiceRollerForm";
            this.DiceRollerForm.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.DiceRollerTab,
            this.MonsterPoolTab,
            this.PlayerPoolTab});
            this.DiceRollerForm.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.DiceRollerForm.SelectedIndex = 2;
            this.DiceRollerForm.Size = new System.Drawing.Size(287, 543);
            this.DiceRollerForm.TabIndex = 1;
            // 
            // DiceRollerTab
            // 
            this.DiceRollerTab.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.DiceRollerTab.Controls.Add(this.DiceRollerGridLayout);
            this.DiceRollerTab.Controls.Add(this.txtbox_diceRoller);
            this.DiceRollerTab.Flags = 65534;
            this.DiceRollerTab.LastVisibleSet = true;
            this.DiceRollerTab.MinimumSize = new System.Drawing.Size(50, 50);
            this.DiceRollerTab.Name = "DiceRollerTab";
            this.DiceRollerTab.Size = new System.Drawing.Size(285, 501);
            this.DiceRollerTab.Text = "Dice Roller";
            this.DiceRollerTab.ToolTipTitle = "Page ToolTip";
            this.DiceRollerTab.UniqueName = "EBA21F5B0B3443E32EBE123CF7C142E3";
            // 
            // DiceRollerGridLayout
            // 
            this.DiceRollerGridLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.DiceRollerGridLayout.ColumnCount = 5;
            this.DiceRollerGridLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.DiceRollerGridLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.DiceRollerGridLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.DiceRollerGridLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.DiceRollerGridLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.DiceRollerGridLayout.Controls.Add(this.btn_d100, 4, 4);
            this.DiceRollerGridLayout.Controls.Add(this.btn_d12, 4, 3);
            this.DiceRollerGridLayout.Controls.Add(this.btn_d8, 4, 2);
            this.DiceRollerGridLayout.Controls.Add(this.btn_d5, 4, 1);
            this.DiceRollerGridLayout.Controls.Add(this.btn_d3, 4, 0);
            this.DiceRollerGridLayout.Controls.Add(this.btn_d20, 3, 4);
            this.DiceRollerGridLayout.Controls.Add(this.btn_minus, 2, 4);
            this.DiceRollerGridLayout.Controls.Add(this.btn_0, 1, 4);
            this.DiceRollerGridLayout.Controls.Add(this.btn_plus, 0, 4);
            this.DiceRollerGridLayout.Controls.Add(this.btn_d10, 3, 3);
            this.DiceRollerGridLayout.Controls.Add(this.btn_9, 2, 3);
            this.DiceRollerGridLayout.Controls.Add(this.btn_8, 1, 3);
            this.DiceRollerGridLayout.Controls.Add(this.btn_7, 0, 3);
            this.DiceRollerGridLayout.Controls.Add(this.btn_d6, 3, 2);
            this.DiceRollerGridLayout.Controls.Add(this.btn_6, 2, 2);
            this.DiceRollerGridLayout.Controls.Add(this.btn_5, 1, 2);
            this.DiceRollerGridLayout.Controls.Add(this.btn_4, 0, 2);
            this.DiceRollerGridLayout.Controls.Add(this.btn_d4, 3, 1);
            this.DiceRollerGridLayout.Controls.Add(this.btn_3, 2, 1);
            this.DiceRollerGridLayout.Controls.Add(this.btn_2, 1, 1);
            this.DiceRollerGridLayout.Controls.Add(this.btn_1, 0, 1);
            this.DiceRollerGridLayout.Controls.Add(this.btn_d2, 3, 0);
            this.DiceRollerGridLayout.Controls.Add(this.btn_equals, 2, 0);
            this.DiceRollerGridLayout.Controls.Add(this.btn_c, 0, 0);
            this.DiceRollerGridLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DiceRollerGridLayout.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.DiceRollerGridLayout.Location = new System.Drawing.Point(0, 136);
            this.DiceRollerGridLayout.Name = "DiceRollerGridLayout";
            this.DiceRollerGridLayout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DiceRollerGridLayout.RowCount = 5;
            this.DiceRollerGridLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.DiceRollerGridLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.DiceRollerGridLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.DiceRollerGridLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.DiceRollerGridLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.DiceRollerGridLayout.Size = new System.Drawing.Size(285, 365);
            this.DiceRollerGridLayout.TabIndex = 3;
            // 
            // btn_d100
            // 
            this.btn_d100.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_d100.Location = new System.Drawing.Point(228, 292);
            this.btn_d100.Name = "btn_d100";
            this.btn_d100.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.btn_d100.Size = new System.Drawing.Size(53, 69);
            this.btn_d100.TabIndex = 24;
            this.btn_d100.Values.Text = "D100";
            this.btn_d100.Click += new System.EventHandler(this.btn_number_click);
            // 
            // btn_d12
            // 
            this.btn_d12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_d12.Location = new System.Drawing.Point(228, 220);
            this.btn_d12.Name = "btn_d12";
            this.btn_d12.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.btn_d12.Size = new System.Drawing.Size(53, 65);
            this.btn_d12.TabIndex = 23;
            this.btn_d12.Values.Text = "D12";
            this.btn_d12.Click += new System.EventHandler(this.btn_number_click);
            // 
            // btn_d8
            // 
            this.btn_d8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_d8.Location = new System.Drawing.Point(228, 148);
            this.btn_d8.Name = "btn_d8";
            this.btn_d8.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.btn_d8.Size = new System.Drawing.Size(53, 65);
            this.btn_d8.TabIndex = 22;
            this.btn_d8.Values.Text = "D8";
            this.btn_d8.Click += new System.EventHandler(this.btn_number_click);
            // 
            // btn_d5
            // 
            this.btn_d5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_d5.Location = new System.Drawing.Point(228, 76);
            this.btn_d5.Name = "btn_d5";
            this.btn_d5.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.btn_d5.Size = new System.Drawing.Size(53, 65);
            this.btn_d5.TabIndex = 21;
            this.btn_d5.Values.Text = "D5";
            this.btn_d5.Click += new System.EventHandler(this.btn_number_click);
            // 
            // btn_d3
            // 
            this.btn_d3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_d3.Location = new System.Drawing.Point(228, 4);
            this.btn_d3.Name = "btn_d3";
            this.btn_d3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.btn_d3.Size = new System.Drawing.Size(53, 65);
            this.btn_d3.TabIndex = 20;
            this.btn_d3.Values.Text = "D3";
            this.btn_d3.Click += new System.EventHandler(this.btn_number_click);
            // 
            // btn_d20
            // 
            this.btn_d20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_d20.Location = new System.Drawing.Point(172, 292);
            this.btn_d20.Name = "btn_d20";
            this.btn_d20.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.btn_d20.Size = new System.Drawing.Size(49, 69);
            this.btn_d20.TabIndex = 19;
            this.btn_d20.Values.Text = "D20";
            this.btn_d20.Click += new System.EventHandler(this.btn_number_click);
            // 
            // btn_minus
            // 
            this.btn_minus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_minus.Location = new System.Drawing.Point(116, 292);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.btn_minus.Size = new System.Drawing.Size(49, 69);
            this.btn_minus.TabIndex = 18;
            this.btn_minus.Values.Text = "-";
            this.btn_minus.Click += new System.EventHandler(this.btn_number_click);
            // 
            // btn_0
            // 
            this.btn_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_0.Location = new System.Drawing.Point(60, 292);
            this.btn_0.Name = "btn_0";
            this.btn_0.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.btn_0.Size = new System.Drawing.Size(49, 69);
            this.btn_0.TabIndex = 17;
            this.btn_0.Values.Text = "0";
            this.btn_0.Click += new System.EventHandler(this.btn_number_click);
            // 
            // btn_plus
            // 
            this.btn_plus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_plus.Location = new System.Drawing.Point(4, 292);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.btn_plus.Size = new System.Drawing.Size(49, 69);
            this.btn_plus.TabIndex = 16;
            this.btn_plus.Values.Text = "+";
            this.btn_plus.Click += new System.EventHandler(this.btn_number_click);
            // 
            // btn_d10
            // 
            this.btn_d10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_d10.Location = new System.Drawing.Point(172, 220);
            this.btn_d10.Name = "btn_d10";
            this.btn_d10.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.btn_d10.Size = new System.Drawing.Size(49, 65);
            this.btn_d10.TabIndex = 15;
            this.btn_d10.Values.Text = "D10";
            this.btn_d10.Click += new System.EventHandler(this.btn_number_click);
            // 
            // btn_9
            // 
            this.btn_9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_9.Location = new System.Drawing.Point(116, 220);
            this.btn_9.Name = "btn_9";
            this.btn_9.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.btn_9.Size = new System.Drawing.Size(49, 65);
            this.btn_9.TabIndex = 14;
            this.btn_9.Values.Text = "9";
            this.btn_9.Click += new System.EventHandler(this.btn_number_click);
            // 
            // btn_8
            // 
            this.btn_8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_8.Location = new System.Drawing.Point(60, 220);
            this.btn_8.Name = "btn_8";
            this.btn_8.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.btn_8.Size = new System.Drawing.Size(49, 65);
            this.btn_8.TabIndex = 13;
            this.btn_8.Values.Text = "8";
            this.btn_8.Click += new System.EventHandler(this.btn_number_click);
            // 
            // btn_7
            // 
            this.btn_7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_7.Location = new System.Drawing.Point(4, 220);
            this.btn_7.Name = "btn_7";
            this.btn_7.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.btn_7.Size = new System.Drawing.Size(49, 65);
            this.btn_7.TabIndex = 12;
            this.btn_7.Values.Text = "7";
            this.btn_7.Click += new System.EventHandler(this.btn_number_click);
            // 
            // btn_d6
            // 
            this.btn_d6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_d6.Location = new System.Drawing.Point(172, 148);
            this.btn_d6.Name = "btn_d6";
            this.btn_d6.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.btn_d6.Size = new System.Drawing.Size(49, 65);
            this.btn_d6.TabIndex = 11;
            this.btn_d6.Values.Text = "D6";
            this.btn_d6.Click += new System.EventHandler(this.btn_number_click);
            // 
            // btn_6
            // 
            this.btn_6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_6.Location = new System.Drawing.Point(116, 148);
            this.btn_6.Name = "btn_6";
            this.btn_6.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.btn_6.Size = new System.Drawing.Size(49, 65);
            this.btn_6.TabIndex = 10;
            this.btn_6.Values.Text = "6";
            this.btn_6.Click += new System.EventHandler(this.btn_number_click);
            // 
            // btn_5
            // 
            this.btn_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_5.Location = new System.Drawing.Point(60, 148);
            this.btn_5.Name = "btn_5";
            this.btn_5.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.btn_5.Size = new System.Drawing.Size(49, 65);
            this.btn_5.TabIndex = 9;
            this.btn_5.Values.Text = "5";
            this.btn_5.Click += new System.EventHandler(this.btn_number_click);
            // 
            // btn_4
            // 
            this.btn_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_4.Location = new System.Drawing.Point(4, 148);
            this.btn_4.Name = "btn_4";
            this.btn_4.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.btn_4.Size = new System.Drawing.Size(49, 65);
            this.btn_4.TabIndex = 8;
            this.btn_4.Values.Text = "4";
            this.btn_4.Click += new System.EventHandler(this.btn_number_click);
            // 
            // btn_d4
            // 
            this.btn_d4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_d4.Location = new System.Drawing.Point(172, 76);
            this.btn_d4.Name = "btn_d4";
            this.btn_d4.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.btn_d4.Size = new System.Drawing.Size(49, 65);
            this.btn_d4.TabIndex = 7;
            this.btn_d4.Values.Text = "D4";
            this.btn_d4.Click += new System.EventHandler(this.btn_number_click);
            // 
            // btn_3
            // 
            this.btn_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_3.Location = new System.Drawing.Point(116, 76);
            this.btn_3.Name = "btn_3";
            this.btn_3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.btn_3.Size = new System.Drawing.Size(49, 65);
            this.btn_3.TabIndex = 6;
            this.btn_3.Values.Text = "3";
            this.btn_3.Click += new System.EventHandler(this.btn_number_click);
            // 
            // btn_2
            // 
            this.btn_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_2.Location = new System.Drawing.Point(60, 76);
            this.btn_2.Name = "btn_2";
            this.btn_2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.btn_2.Size = new System.Drawing.Size(49, 65);
            this.btn_2.TabIndex = 5;
            this.btn_2.Values.Text = "2";
            this.btn_2.Click += new System.EventHandler(this.btn_number_click);
            // 
            // btn_1
            // 
            this.btn_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_1.Location = new System.Drawing.Point(4, 76);
            this.btn_1.Name = "btn_1";
            this.btn_1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.btn_1.Size = new System.Drawing.Size(49, 65);
            this.btn_1.TabIndex = 4;
            this.btn_1.Values.Text = "1";
            this.btn_1.Click += new System.EventHandler(this.btn_number_click);
            // 
            // btn_d2
            // 
            this.btn_d2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_d2.Location = new System.Drawing.Point(172, 4);
            this.btn_d2.Name = "btn_d2";
            this.btn_d2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.btn_d2.Size = new System.Drawing.Size(49, 65);
            this.btn_d2.TabIndex = 3;
            this.btn_d2.Values.Text = "D2";
            this.btn_d2.Click += new System.EventHandler(this.btn_number_click);
            // 
            // btn_equals
            // 
            this.btn_equals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_equals.Location = new System.Drawing.Point(116, 4);
            this.btn_equals.Name = "btn_equals";
            this.btn_equals.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.btn_equals.Size = new System.Drawing.Size(49, 65);
            this.btn_equals.TabIndex = 2;
            this.btn_equals.Values.Text = "=";
            this.btn_equals.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // btn_c
            // 
            this.DiceRollerGridLayout.SetColumnSpan(this.btn_c, 2);
            this.btn_c.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_c.Location = new System.Drawing.Point(4, 4);
            this.btn_c.Name = "btn_c";
            this.btn_c.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.btn_c.Size = new System.Drawing.Size(105, 65);
            this.btn_c.TabIndex = 0;
            this.btn_c.Values.Text = "C";
            this.btn_c.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // txtbox_diceRoller
            // 
            this.txtbox_diceRoller.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtbox_diceRoller.Location = new System.Drawing.Point(0, 0);
            this.txtbox_diceRoller.MinimumSize = new System.Drawing.Size(285, 136);
            this.txtbox_diceRoller.Multiline = true;
            this.txtbox_diceRoller.Name = "txtbox_diceRoller";
            this.txtbox_diceRoller.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.txtbox_diceRoller.ReadOnly = true;
            this.txtbox_diceRoller.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbox_diceRoller.Size = new System.Drawing.Size(285, 136);
            this.txtbox_diceRoller.TabIndex = 2;
            // 
            // MonsterPoolTab
            // 
            this.MonsterPoolTab.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.MonsterPoolTab.Controls.Add(this.mosterPoolViewButtonPanel);
            this.MonsterPoolTab.Controls.Add(this.monsterPool_gridView);
            this.MonsterPoolTab.Flags = 65534;
            this.MonsterPoolTab.LastVisibleSet = true;
            this.MonsterPoolTab.MinimumSize = new System.Drawing.Size(50, 50);
            this.MonsterPoolTab.Name = "MonsterPoolTab";
            this.MonsterPoolTab.Size = new System.Drawing.Size(285, 501);
            this.MonsterPoolTab.Text = "Monster Pool";
            this.MonsterPoolTab.ToolTipTitle = "Page ToolTip";
            this.MonsterPoolTab.UniqueName = "54C795101D7C416713A0A8F0A5AF8404";
            // 
            // mosterPoolViewButtonPanel
            // 
            this.mosterPoolViewButtonPanel.ColumnCount = 1;
            this.mosterPoolViewButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.mosterPoolViewButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.mosterPoolViewButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.mosterPoolViewButtonPanel.Controls.Add(this.btn_monsterSave, 2, 0);
            this.mosterPoolViewButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mosterPoolViewButtonPanel.Location = new System.Drawing.Point(0, 465);
            this.mosterPoolViewButtonPanel.Name = "mosterPoolViewButtonPanel";
            this.mosterPoolViewButtonPanel.RowCount = 1;
            this.mosterPoolViewButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mosterPoolViewButtonPanel.Size = new System.Drawing.Size(285, 36);
            this.mosterPoolViewButtonPanel.TabIndex = 4;
            // 
            // btn_monsterSave
            // 
            this.btn_monsterSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_monsterSave.Location = new System.Drawing.Point(3, 3);
            this.btn_monsterSave.Name = "btn_monsterSave";
            this.btn_monsterSave.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.btn_monsterSave.Size = new System.Drawing.Size(279, 30);
            this.btn_monsterSave.TabIndex = 1;
            this.btn_monsterSave.Values.Text = "Save";
            this.btn_monsterSave.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // monsterPool_gridView
            // 
            this.monsterPool_gridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monsterPool_gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.monsterPool_gridView.Location = new System.Drawing.Point(-1, -1);
            this.monsterPool_gridView.Name = "monsterPool_gridView";
            this.monsterPool_gridView.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.monsterPool_gridView.RowHeadersWidth = 20;
            this.monsterPool_gridView.Size = new System.Drawing.Size(287, 470);
            this.monsterPool_gridView.TabIndex = 0;
            this.monsterPool_gridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ViewDoubleClickEvent);
            // 
            // PlayerPoolTab
            // 
            this.PlayerPoolTab.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.PlayerPoolTab.Controls.Add(this.tableLayoutPanel1);
            this.PlayerPoolTab.Controls.Add(this.player_gridView);
            this.PlayerPoolTab.Flags = 65534;
            this.PlayerPoolTab.LastVisibleSet = true;
            this.PlayerPoolTab.MinimumSize = new System.Drawing.Size(50, 50);
            this.PlayerPoolTab.Name = "PlayerPoolTab";
            this.PlayerPoolTab.Size = new System.Drawing.Size(285, 501);
            this.PlayerPoolTab.Text = "Players";
            this.PlayerPoolTab.ToolTipTitle = "Page ToolTip";
            this.PlayerPoolTab.UniqueName = "7C8A1E4C86834194FA9C87567CF8600D";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btn_playerSave, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 465);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(285, 36);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // btn_playerSave
            // 
            this.btn_playerSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_playerSave.Location = new System.Drawing.Point(3, 3);
            this.btn_playerSave.Name = "btn_playerSave";
            this.btn_playerSave.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.btn_playerSave.Size = new System.Drawing.Size(279, 30);
            this.btn_playerSave.TabIndex = 4;
            this.btn_playerSave.Values.Text = "Save";
            this.btn_playerSave.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // player_gridView
            // 
            this.player_gridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.player_gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.player_gridView.Location = new System.Drawing.Point(-1, -1);
            this.player_gridView.Name = "player_gridView";
            this.player_gridView.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.player_gridView.RowHeadersWidth = 20;
            this.player_gridView.Size = new System.Drawing.Size(287, 470);
            this.player_gridView.TabIndex = 5;
            // 
            // MainSplitContainer
            // 
            this.MainSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainSplitContainer.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainSplitContainer.Location = new System.Drawing.Point(0, -2);
            this.MainSplitContainer.Name = "MainSplitContainer";
            this.MainSplitContainer.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            // 
            // MainSplitContainer.Panel1
            // 
            this.MainSplitContainer.Panel1.Controls.Add(this.TabsDmHelper);
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.Controls.Add(this.DiceRollerForm);
            this.MainSplitContainer.Size = new System.Drawing.Size(880, 543);
            this.MainSplitContainer.SplitterDistance = 588;
            this.MainSplitContainer.TabIndex = 2;
            // 
            // DndHelperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(879, 541);
            this.Controls.Add(this.MainSplitContainer);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DndHelperForm";
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Dm\'s Helper";
            ((System.ComponentModel.ISupportInitialize)(this.TabsDmHelper)).EndInit();
            this.TabsDmHelper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WildMagicTab)).EndInit();
            this.WildMagicTab.ResumeLayout(false);
            this.WildMagicTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InitTab)).EndInit();
            this.InitTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).EndInit();
            this.kryptonSplitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).EndInit();
            this.kryptonSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.init_gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonsterTab)).EndInit();
            this.MonsterTab.ResumeLayout(false);
            this.MonsterTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MonsterPanel)).EndInit();
            this.MonsterPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MonsterSearchSplitContainer.Panel1)).EndInit();
            this.MonsterSearchSplitContainer.Panel1.ResumeLayout(false);
            this.MonsterSearchSplitContainer.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MonsterSearchSplitContainer.Panel2)).EndInit();
            this.MonsterSearchSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MonsterSearchSplitContainer)).EndInit();
            this.MonsterSearchSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.monster_gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpellTab)).EndInit();
            this.SpellTab.ResumeLayout(false);
            this.SpellTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpellPanel)).EndInit();
            this.SpellPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpellSearchSpiltContainer.Panel1)).EndInit();
            this.SpellSearchSpiltContainer.Panel1.ResumeLayout(false);
            this.SpellSearchSpiltContainer.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpellSearchSpiltContainer.Panel2)).EndInit();
            this.SpellSearchSpiltContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpellSearchSpiltContainer)).EndInit();
            this.SpellSearchSpiltContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spell_gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemTab)).EndInit();
            this.ItemTab.ResumeLayout(false);
            this.ItemTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPanel)).EndInit();
            this.ItemPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ItemSearchSplitContainer.Panel1)).EndInit();
            this.ItemSearchSplitContainer.Panel1.ResumeLayout(false);
            this.ItemSearchSplitContainer.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemSearchSplitContainer.Panel2)).EndInit();
            this.ItemSearchSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ItemSearchSplitContainer)).EndInit();
            this.ItemSearchSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.item_gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingTab)).EndInit();
            this.SettingTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DiceRollerForm)).EndInit();
            this.DiceRollerForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DiceRollerTab)).EndInit();
            this.DiceRollerTab.ResumeLayout(false);
            this.DiceRollerTab.PerformLayout();
            this.DiceRollerGridLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MonsterPoolTab)).EndInit();
            this.MonsterPoolTab.ResumeLayout(false);
            this.mosterPoolViewButtonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.monsterPool_gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPoolTab)).EndInit();
            this.PlayerPoolTab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player_gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer.Panel1)).EndInit();
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer.Panel2)).EndInit();
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            this.MainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Docking.KryptonDockableNavigator TabsDmHelper;
        private ComponentFactory.Krypton.Navigator.KryptonPage WildMagicTab;
        private ComponentFactory.Krypton.Navigator.KryptonPage MonsterTab;
        private ComponentFactory.Krypton.Navigator.KryptonPage SpellTab;
        private ComponentFactory.Krypton.Navigator.KryptonPage ItemTab;
        private ComponentFactory.Krypton.Navigator.KryptonPage InitTab;
        private ComponentFactory.Krypton.Navigator.KryptonPage SettingTab;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_magic;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_piercing;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_worldEvent;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_bludgeoning;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_slashing;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtbox_wildMagic;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_wildmagic;
        private ComponentFactory.Krypton.Docking.KryptonDockableNavigator DiceRollerForm;
        private ComponentFactory.Krypton.Navigator.KryptonPage DiceRollerTab;
        private ComponentFactory.Krypton.Navigator.KryptonPage PlayerPoolTab;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer MainSplitContainer;
        private ComponentFactory.Krypton.Navigator.KryptonPage MonsterPoolTab;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtbox_diceRoller;
        private System.Windows.Forms.TableLayoutPanel DiceRollerGridLayout;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_d20;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_minus;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_0;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_plus;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_d10;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_9;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_8;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_7;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_d6;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_6;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_5;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_d4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_d2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_equals;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_c;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_d100;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_d12;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_d8;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_d5;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_d3;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer MonsterSearchSplitContainer;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtbox_monsterSearchBox;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer SpellSearchSpiltContainer;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView spell_gridView;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtbox_spellSearchBox;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel MonsterPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel SpellPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtbox_spellDetails;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView monster_gridView;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtbox_monsterDetails;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel ItemPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer ItemSearchSplitContainer;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtbox_itemSearchBox;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView item_gridView;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtbox_itemDetails;
        private ComponentFactory.Krypton.Toolkit.KryptonTreeView Settings_Tree;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckedListBox Settings_CheckBoxList;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_clearTicks;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_ConfirmXmls;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView init_gridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn InitiativeTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn InitNameTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn InitAcTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn InitMaxHpTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn InitHpTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn InitStatusTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn InitConcentratingTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn InitNotesTab;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView monsterPool_gridView;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_monsterSave;
        private System.Windows.Forms.TableLayoutPanel mosterPoolViewButtonPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_playerSave;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView player_gridView;
    }
}