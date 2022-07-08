
namespace KursovaRabota
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonWizard = new System.Windows.Forms.Button();
            this.buttonBoss = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelBossResist = new System.Windows.Forms.Label();
            this.labelBossBoost = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelWizardFlatDamage = new System.Windows.Forms.Label();
            this.labelWizardPercentDamage = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelWizardPierce = new System.Windows.Forms.Label();
            this.comboBoxSpellType = new System.Windows.Forms.ComboBox();
            this.textBoxVariableDamageMin = new System.Windows.Forms.TextBox();
            this.textBoxVariableDamageMax = new System.Windows.Forms.TextBox();
            this.labelVariableDamageMin = new System.Windows.Forms.Label();
            this.labelVariableDamageMax = new System.Windows.Forms.Label();
            this.textBoxFixedDamage = new System.Windows.Forms.TextBox();
            this.labelFixedDamage = new System.Windows.Forms.Label();
            this.textBoxDoTSpellBase = new System.Windows.Forms.TextBox();
            this.textBoxDoTSpellDoT = new System.Windows.Forms.TextBox();
            this.labelDoTSpellBaseDamage = new System.Windows.Forms.Label();
            this.labelDoTSpellDoT = new System.Windows.Forms.Label();
            this.textBoxDPPBaseDamage = new System.Windows.Forms.TextBox();
            this.labelDPPSpellDPP = new System.Windows.Forms.Label();
            this.textBoxDPPSpellPips = new System.Windows.Forms.TextBox();
            this.labelDPPSpellPips = new System.Windows.Forms.Label();
            this.labelDPPSpellEnchantments = new System.Windows.Forms.Label();
            this.comboBoxDPPSpellEnchanments = new System.Windows.Forms.ComboBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.labelLastInput = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxBlades = new System.Windows.Forms.ComboBox();
            this.comboBoxTrap = new System.Windows.Forms.ComboBox();
            this.comboBoxShield = new System.Windows.Forms.ComboBox();
            this.comboBoxWeakness = new System.Windows.Forms.ComboBox();
            this.buttonRemoveLast = new System.Windows.Forms.Button();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.wizardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddWizardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadWizardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bossToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddBossToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadBossToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAddBlade = new System.Windows.Forms.Button();
            this.buttonAddWeakness = new System.Windows.Forms.Button();
            this.buttonAddTrap = new System.Windows.Forms.Button();
            this.buttonAddShield = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.textBoxCritical = new System.Windows.Forms.TextBox();
            this.labelCritical = new System.Windows.Forms.Label();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonWizard
            // 
            this.buttonWizard.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonWizard.Location = new System.Drawing.Point(683, 40);
            this.buttonWizard.Name = "buttonWizard";
            this.buttonWizard.Size = new System.Drawing.Size(101, 37);
            this.buttonWizard.TabIndex = 1;
            this.buttonWizard.Text = "Wizard";
            this.buttonWizard.UseVisualStyleBackColor = true;
            this.buttonWizard.Click += new System.EventHandler(this.buttonWizard_Click);
            // 
            // buttonBoss
            // 
            this.buttonBoss.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBoss.Location = new System.Drawing.Point(7, 40);
            this.buttonBoss.Name = "buttonBoss";
            this.buttonBoss.Size = new System.Drawing.Size(101, 37);
            this.buttonBoss.TabIndex = 2;
            this.buttonBoss.Text = "Boss";
            this.buttonBoss.UseVisualStyleBackColor = true;
            this.buttonBoss.Click += new System.EventHandler(this.buttonBoss_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Boss Stats:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(659, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wizard Stats:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resist:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Boost:";
            // 
            // labelBossResist
            // 
            this.labelBossResist.AutoSize = true;
            this.labelBossResist.Location = new System.Drawing.Point(53, 108);
            this.labelBossResist.Name = "labelBossResist";
            this.labelBossResist.Size = new System.Drawing.Size(13, 15);
            this.labelBossResist.TabIndex = 7;
            this.labelBossResist.Text = "0";
            // 
            // labelBossBoost
            // 
            this.labelBossBoost.AutoSize = true;
            this.labelBossBoost.Location = new System.Drawing.Point(53, 123);
            this.labelBossBoost.Name = "labelBossBoost";
            this.labelBossBoost.Size = new System.Drawing.Size(13, 15);
            this.labelBossBoost.TabIndex = 8;
            this.labelBossBoost.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(682, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Flat Damage:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(691, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "% Damage:";
            // 
            // labelWizardFlatDamage
            // 
            this.labelWizardFlatDamage.AutoSize = true;
            this.labelWizardFlatDamage.Location = new System.Drawing.Point(764, 108);
            this.labelWizardFlatDamage.Name = "labelWizardFlatDamage";
            this.labelWizardFlatDamage.Size = new System.Drawing.Size(13, 15);
            this.labelWizardFlatDamage.TabIndex = 11;
            this.labelWizardFlatDamage.Text = "0";
            // 
            // labelWizardPercentDamage
            // 
            this.labelWizardPercentDamage.AutoSize = true;
            this.labelWizardPercentDamage.Location = new System.Drawing.Point(764, 128);
            this.labelWizardPercentDamage.Name = "labelWizardPercentDamage";
            this.labelWizardPercentDamage.Size = new System.Drawing.Size(13, 15);
            this.labelWizardPercentDamage.TabIndex = 12;
            this.labelWizardPercentDamage.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(716, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Pierce:";
            // 
            // labelWizardPierce
            // 
            this.labelWizardPierce.AutoSize = true;
            this.labelWizardPierce.Location = new System.Drawing.Point(764, 150);
            this.labelWizardPierce.Name = "labelWizardPierce";
            this.labelWizardPierce.Size = new System.Drawing.Size(13, 15);
            this.labelWizardPierce.TabIndex = 14;
            this.labelWizardPierce.Text = "0";
            // 
            // comboBoxSpellType
            // 
            this.comboBoxSpellType.FormattingEnabled = true;
            this.comboBoxSpellType.Items.AddRange(new object[] {
            "Variable Damaged",
            "Fixed Damage",
            "Damage Per Pip",
            "Damage + Overtime"});
            this.comboBoxSpellType.Location = new System.Drawing.Point(316, 40);
            this.comboBoxSpellType.Name = "comboBoxSpellType";
            this.comboBoxSpellType.Size = new System.Drawing.Size(160, 23);
            this.comboBoxSpellType.TabIndex = 15;
            this.comboBoxSpellType.Text = "Select a Spell Type";
            this.comboBoxSpellType.SelectedIndexChanged += new System.EventHandler(this.comboBoxSpellType_SelectedIndexChanged);
            // 
            // textBoxVariableDamageMin
            // 
            this.textBoxVariableDamageMin.Location = new System.Drawing.Point(316, 88);
            this.textBoxVariableDamageMin.Name = "textBoxVariableDamageMin";
            this.textBoxVariableDamageMin.Size = new System.Drawing.Size(160, 23);
            this.textBoxVariableDamageMin.TabIndex = 18;
            this.textBoxVariableDamageMin.Visible = false;
            // 
            // textBoxVariableDamageMax
            // 
            this.textBoxVariableDamageMax.Location = new System.Drawing.Point(316, 120);
            this.textBoxVariableDamageMax.Name = "textBoxVariableDamageMax";
            this.textBoxVariableDamageMax.Size = new System.Drawing.Size(160, 23);
            this.textBoxVariableDamageMax.TabIndex = 19;
            this.textBoxVariableDamageMax.Visible = false;
            // 
            // labelVariableDamageMin
            // 
            this.labelVariableDamageMin.AutoSize = true;
            this.labelVariableDamageMin.Location = new System.Drawing.Point(200, 93);
            this.labelVariableDamageMin.Name = "labelVariableDamageMin";
            this.labelVariableDamageMin.Size = new System.Drawing.Size(110, 15);
            this.labelVariableDamageMin.TabIndex = 20;
            this.labelVariableDamageMin.Text = "Minimum Damage:";
            this.labelVariableDamageMin.Visible = false;
            // 
            // labelVariableDamageMax
            // 
            this.labelVariableDamageMax.AutoSize = true;
            this.labelVariableDamageMax.Location = new System.Drawing.Point(200, 123);
            this.labelVariableDamageMax.Name = "labelVariableDamageMax";
            this.labelVariableDamageMax.Size = new System.Drawing.Size(112, 15);
            this.labelVariableDamageMax.TabIndex = 21;
            this.labelVariableDamageMax.Text = "Maximum Damage:";
            this.labelVariableDamageMax.Visible = false;
            // 
            // textBoxFixedDamage
            // 
            this.textBoxFixedDamage.Location = new System.Drawing.Point(316, 88);
            this.textBoxFixedDamage.Name = "textBoxFixedDamage";
            this.textBoxFixedDamage.Size = new System.Drawing.Size(160, 23);
            this.textBoxFixedDamage.TabIndex = 22;
            this.textBoxFixedDamage.Visible = false;
            // 
            // labelFixedDamage
            // 
            this.labelFixedDamage.AutoSize = true;
            this.labelFixedDamage.Location = new System.Drawing.Point(229, 93);
            this.labelFixedDamage.Name = "labelFixedDamage";
            this.labelFixedDamage.Size = new System.Drawing.Size(81, 15);
            this.labelFixedDamage.TabIndex = 23;
            this.labelFixedDamage.Text = "Base Damage:";
            this.labelFixedDamage.Visible = false;
            // 
            // textBoxDoTSpellBase
            // 
            this.textBoxDoTSpellBase.Location = new System.Drawing.Point(316, 88);
            this.textBoxDoTSpellBase.Name = "textBoxDoTSpellBase";
            this.textBoxDoTSpellBase.Size = new System.Drawing.Size(160, 23);
            this.textBoxDoTSpellBase.TabIndex = 24;
            this.textBoxDoTSpellBase.Visible = false;
            // 
            // textBoxDoTSpellDoT
            // 
            this.textBoxDoTSpellDoT.Location = new System.Drawing.Point(316, 120);
            this.textBoxDoTSpellDoT.Name = "textBoxDoTSpellDoT";
            this.textBoxDoTSpellDoT.Size = new System.Drawing.Size(160, 23);
            this.textBoxDoTSpellDoT.TabIndex = 25;
            this.textBoxDoTSpellDoT.Visible = false;
            // 
            // labelDoTSpellBaseDamage
            // 
            this.labelDoTSpellBaseDamage.AutoSize = true;
            this.labelDoTSpellBaseDamage.Location = new System.Drawing.Point(229, 93);
            this.labelDoTSpellBaseDamage.Name = "labelDoTSpellBaseDamage";
            this.labelDoTSpellBaseDamage.Size = new System.Drawing.Size(81, 15);
            this.labelDoTSpellBaseDamage.TabIndex = 26;
            this.labelDoTSpellBaseDamage.Text = "Base Damage:";
            this.labelDoTSpellBaseDamage.Visible = false;
            // 
            // labelDoTSpellDoT
            // 
            this.labelDoTSpellDoT.AutoSize = true;
            this.labelDoTSpellDoT.Location = new System.Drawing.Point(279, 123);
            this.labelDoTSpellDoT.Name = "labelDoTSpellDoT";
            this.labelDoTSpellDoT.Size = new System.Drawing.Size(31, 15);
            this.labelDoTSpellDoT.TabIndex = 27;
            this.labelDoTSpellDoT.Text = "DoT:";
            this.labelDoTSpellDoT.Visible = false;
            // 
            // textBoxDPPBaseDamage
            // 
            this.textBoxDPPBaseDamage.Location = new System.Drawing.Point(316, 88);
            this.textBoxDPPBaseDamage.Name = "textBoxDPPBaseDamage";
            this.textBoxDPPBaseDamage.Size = new System.Drawing.Size(160, 23);
            this.textBoxDPPBaseDamage.TabIndex = 28;
            this.textBoxDPPBaseDamage.Visible = false;
            // 
            // labelDPPSpellDPP
            // 
            this.labelDPPSpellDPP.AutoSize = true;
            this.labelDPPSpellDPP.Location = new System.Drawing.Point(216, 93);
            this.labelDPPSpellDPP.Name = "labelDPPSpellDPP";
            this.labelDPPSpellDPP.Size = new System.Drawing.Size(94, 15);
            this.labelDPPSpellDPP.TabIndex = 29;
            this.labelDPPSpellDPP.Text = "Damage Per Pip:";
            this.labelDPPSpellDPP.Visible = false;
            // 
            // textBoxDPPSpellPips
            // 
            this.textBoxDPPSpellPips.Location = new System.Drawing.Point(316, 120);
            this.textBoxDPPSpellPips.Name = "textBoxDPPSpellPips";
            this.textBoxDPPSpellPips.Size = new System.Drawing.Size(160, 23);
            this.textBoxDPPSpellPips.TabIndex = 30;
            this.textBoxDPPSpellPips.Visible = false;
            // 
            // labelDPPSpellPips
            // 
            this.labelDPPSpellPips.AutoSize = true;
            this.labelDPPSpellPips.Location = new System.Drawing.Point(278, 123);
            this.labelDPPSpellPips.Name = "labelDPPSpellPips";
            this.labelDPPSpellPips.Size = new System.Drawing.Size(32, 15);
            this.labelDPPSpellPips.TabIndex = 31;
            this.labelDPPSpellPips.Text = "Pips:";
            this.labelDPPSpellPips.Visible = false;
            // 
            // labelDPPSpellEnchantments
            // 
            this.labelDPPSpellEnchantments.AutoSize = true;
            this.labelDPPSpellEnchantments.Location = new System.Drawing.Point(257, 153);
            this.labelDPPSpellEnchantments.Name = "labelDPPSpellEnchantments";
            this.labelDPPSpellEnchantments.Size = new System.Drawing.Size(53, 15);
            this.labelDPPSpellEnchantments.TabIndex = 32;
            this.labelDPPSpellEnchantments.Text = "Enchant:";
            this.labelDPPSpellEnchantments.Visible = false;
            // 
            // comboBoxDPPSpellEnchanments
            // 
            this.comboBoxDPPSpellEnchanments.FormattingEnabled = true;
            this.comboBoxDPPSpellEnchanments.Items.AddRange(new object[] {
            "None",
            "Strong(+100)",
            "Giant(+125)",
            "Monstrous(+175)",
            "Gargantuan(+225)",
            "Colossal(+275)",
            "Epic(+300)"});
            this.comboBoxDPPSpellEnchanments.Location = new System.Drawing.Point(316, 150);
            this.comboBoxDPPSpellEnchanments.Name = "comboBoxDPPSpellEnchanments";
            this.comboBoxDPPSpellEnchanments.Size = new System.Drawing.Size(160, 23);
            this.comboBoxDPPSpellEnchanments.TabIndex = 33;
            this.comboBoxDPPSpellEnchanments.Text = "Select an Enchant";
            this.comboBoxDPPSpellEnchanments.Visible = false;
            this.comboBoxDPPSpellEnchanments.SelectedIndexChanged += new System.EventHandler(this.comboBoxDPPSpellEnchanments_SelectedIndexChanged);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCalculate.Location = new System.Drawing.Point(683, 422);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(101, 37);
            this.buttonCalculate.TabIndex = 34;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(7, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 21);
            this.label8.TabIndex = 36;
            this.label8.Text = "Last Blade/Shield put in:";
            // 
            // labelLastInput
            // 
            this.labelLastInput.AutoSize = true;
            this.labelLastInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLastInput.Location = new System.Drawing.Point(193, 236);
            this.labelLastInput.Name = "labelLastInput";
            this.labelLastInput.Size = new System.Drawing.Size(0, 21);
            this.labelLastInput.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(8, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 21);
            this.label9.TabIndex = 38;
            this.label9.Text = "Blade (+)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(180, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 21);
            this.label10.TabIndex = 39;
            this.label10.Text = "Weakness (-)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(387, 272);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 21);
            this.label11.TabIndex = 40;
            this.label11.Text = "Trap (+)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(560, 274);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 21);
            this.label12.TabIndex = 41;
            this.label12.Text = "Shield (-)";
            // 
            // comboBoxBlades
            // 
            this.comboBoxBlades.FormattingEnabled = true;
            this.comboBoxBlades.Items.AddRange(new object[] {
            "20%",
            "25%",
            "30%",
            "35%",
            "40%",
            "45%",
            "50%",
            "Custom"});
            this.comboBoxBlades.Location = new System.Drawing.Point(8, 315);
            this.comboBoxBlades.Name = "comboBoxBlades";
            this.comboBoxBlades.Size = new System.Drawing.Size(70, 23);
            this.comboBoxBlades.TabIndex = 42;
            this.comboBoxBlades.Text = "---------";
            // 
            // comboBoxTrap
            // 
            this.comboBoxTrap.FormattingEnabled = true;
            this.comboBoxTrap.Items.AddRange(new object[] {
            "30%",
            "40%",
            "70%",
            "75%",
            "80%",
            "Custom"});
            this.comboBoxTrap.Location = new System.Drawing.Point(387, 313);
            this.comboBoxTrap.Name = "comboBoxTrap";
            this.comboBoxTrap.Size = new System.Drawing.Size(65, 23);
            this.comboBoxTrap.TabIndex = 43;
            this.comboBoxTrap.Text = "--------";
            // 
            // comboBoxShield
            // 
            this.comboBoxShield.FormattingEnabled = true;
            this.comboBoxShield.Items.AddRange(new object[] {
            "45%",
            "50%",
            "70%",
            "80%",
            "Custom"});
            this.comboBoxShield.Location = new System.Drawing.Point(560, 315);
            this.comboBoxShield.Name = "comboBoxShield";
            this.comboBoxShield.Size = new System.Drawing.Size(73, 23);
            this.comboBoxShield.TabIndex = 44;
            this.comboBoxShield.Text = "----------";
            // 
            // comboBoxWeakness
            // 
            this.comboBoxWeakness.FormattingEnabled = true;
            this.comboBoxWeakness.Items.AddRange(new object[] {
            "20%",
            "25%",
            "35%",
            "40%",
            "45%",
            "50%",
            "90%",
            "Custom"});
            this.comboBoxWeakness.Location = new System.Drawing.Point(180, 315);
            this.comboBoxWeakness.Name = "comboBoxWeakness";
            this.comboBoxWeakness.Size = new System.Drawing.Size(99, 23);
            this.comboBoxWeakness.TabIndex = 45;
            this.comboBoxWeakness.Text = "-----------------";
            // 
            // buttonRemoveLast
            // 
            this.buttonRemoveLast.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRemoveLast.Location = new System.Drawing.Point(576, 422);
            this.buttonRemoveLast.Name = "buttonRemoveLast";
            this.buttonRemoveLast.Size = new System.Drawing.Size(101, 37);
            this.buttonRemoveLast.TabIndex = 46;
            this.buttonRemoveLast.Text = "Remove Last";
            this.buttonRemoveLast.UseVisualStyleBackColor = true;
            this.buttonRemoveLast.Click += new System.EventHandler(this.buttonRemoveLast_Click);
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonShowAll.Location = new System.Drawing.Point(469, 422);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(101, 37);
            this.buttonShowAll.TabIndex = 47;
            this.buttonShowAll.Text = "Show All";
            this.buttonShowAll.UseVisualStyleBackColor = true;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wizardToolStripMenuItem,
            this.bossToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(796, 24);
            this.menuStripMain.TabIndex = 48;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // wizardToolStripMenuItem
            // 
            this.wizardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddWizardToolStripMenuItem,
            this.loadWizardToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.wizardToolStripMenuItem.Name = "wizardToolStripMenuItem";
            this.wizardToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.wizardToolStripMenuItem.Text = "Wizard";
            // 
            // AddWizardToolStripMenuItem
            // 
            this.AddWizardToolStripMenuItem.Name = "AddWizardToolStripMenuItem";
            this.AddWizardToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.AddWizardToolStripMenuItem.Text = "Add";
            this.AddWizardToolStripMenuItem.Click += new System.EventHandler(this.AddWizardToolStripMenuItem_Click);
            // 
            // loadWizardToolStripMenuItem
            // 
            this.loadWizardToolStripMenuItem.Name = "loadWizardToolStripMenuItem";
            this.loadWizardToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.loadWizardToolStripMenuItem.Text = "Load";
            this.loadWizardToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.loadWizardToolStripMenuItem_DropDownItemClicked);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.deleteToolStripMenuItem_DropDownItemClicked);
            // 
            // bossToolStripMenuItem
            // 
            this.bossToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddBossToolStripMenuItem1,
            this.loadBossToolStripMenuItem1,
            this.deleteToolStripMenuItem1});
            this.bossToolStripMenuItem.Name = "bossToolStripMenuItem";
            this.bossToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.bossToolStripMenuItem.Text = "Boss";
            // 
            // AddBossToolStripMenuItem1
            // 
            this.AddBossToolStripMenuItem1.Name = "AddBossToolStripMenuItem1";
            this.AddBossToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.AddBossToolStripMenuItem1.Text = "Add";
            this.AddBossToolStripMenuItem1.Click += new System.EventHandler(this.AddBossToolStripMenuItem1_Click);
            // 
            // loadBossToolStripMenuItem1
            // 
            this.loadBossToolStripMenuItem1.Name = "loadBossToolStripMenuItem1";
            this.loadBossToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.loadBossToolStripMenuItem1.Text = "Load";
            this.loadBossToolStripMenuItem1.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.loadBossToolStripMenuItem1_DropDownItemClicked);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.deleteToolStripMenuItem1_DropDownItemClicked);
            // 
            // buttonAddBlade
            // 
            this.buttonAddBlade.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddBlade.Location = new System.Drawing.Point(84, 315);
            this.buttonAddBlade.Name = "buttonAddBlade";
            this.buttonAddBlade.Size = new System.Drawing.Size(27, 23);
            this.buttonAddBlade.TabIndex = 49;
            this.buttonAddBlade.Text = "+";
            this.buttonAddBlade.UseVisualStyleBackColor = true;
            this.buttonAddBlade.Click += new System.EventHandler(this.buttonAddBlade_Click);
            // 
            // buttonAddWeakness
            // 
            this.buttonAddWeakness.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddWeakness.Location = new System.Drawing.Point(285, 315);
            this.buttonAddWeakness.Name = "buttonAddWeakness";
            this.buttonAddWeakness.Size = new System.Drawing.Size(27, 23);
            this.buttonAddWeakness.TabIndex = 50;
            this.buttonAddWeakness.Text = "+";
            this.buttonAddWeakness.UseVisualStyleBackColor = true;
            this.buttonAddWeakness.Click += new System.EventHandler(this.buttonAddWeakness_Click);
            // 
            // buttonAddTrap
            // 
            this.buttonAddTrap.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddTrap.Location = new System.Drawing.Point(458, 313);
            this.buttonAddTrap.Name = "buttonAddTrap";
            this.buttonAddTrap.Size = new System.Drawing.Size(27, 23);
            this.buttonAddTrap.TabIndex = 51;
            this.buttonAddTrap.Text = "+";
            this.buttonAddTrap.UseVisualStyleBackColor = true;
            this.buttonAddTrap.Click += new System.EventHandler(this.buttonAddTrap_Click);
            // 
            // buttonAddShield
            // 
            this.buttonAddShield.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddShield.Location = new System.Drawing.Point(639, 315);
            this.buttonAddShield.Name = "buttonAddShield";
            this.buttonAddShield.Size = new System.Drawing.Size(27, 23);
            this.buttonAddShield.TabIndex = 52;
            this.buttonAddShield.Text = "+";
            this.buttonAddShield.UseVisualStyleBackColor = true;
            this.buttonAddShield.Click += new System.EventHandler(this.buttonAddShield_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonReset.Location = new System.Drawing.Point(362, 422);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(101, 37);
            this.buttonReset.TabIndex = 53;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // textBoxCritical
            // 
            this.textBoxCritical.Location = new System.Drawing.Point(699, 183);
            this.textBoxCritical.Name = "textBoxCritical";
            this.textBoxCritical.Size = new System.Drawing.Size(84, 23);
            this.textBoxCritical.TabIndex = 54;
            this.textBoxCritical.Text = "1.00";
            // 
            // labelCritical
            // 
            this.labelCritical.AutoSize = true;
            this.labelCritical.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCritical.Location = new System.Drawing.Point(640, 187);
            this.labelCritical.Name = "labelCritical";
            this.labelCritical.Size = new System.Drawing.Size(53, 19);
            this.labelCritical.TabIndex = 55;
            this.labelCritical.Text = "Critical:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 467);
            this.Controls.Add(this.labelCritical);
            this.Controls.Add(this.textBoxCritical);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonAddShield);
            this.Controls.Add(this.buttonAddTrap);
            this.Controls.Add(this.buttonAddWeakness);
            this.Controls.Add(this.buttonAddBlade);
            this.Controls.Add(this.buttonShowAll);
            this.Controls.Add(this.buttonRemoveLast);
            this.Controls.Add(this.comboBoxWeakness);
            this.Controls.Add(this.comboBoxShield);
            this.Controls.Add(this.comboBoxTrap);
            this.Controls.Add(this.comboBoxBlades);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelLastInput);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.comboBoxDPPSpellEnchanments);
            this.Controls.Add(this.labelDPPSpellEnchantments);
            this.Controls.Add(this.labelDPPSpellPips);
            this.Controls.Add(this.textBoxDPPSpellPips);
            this.Controls.Add(this.labelDPPSpellDPP);
            this.Controls.Add(this.textBoxDPPBaseDamage);
            this.Controls.Add(this.labelDoTSpellDoT);
            this.Controls.Add(this.labelDoTSpellBaseDamage);
            this.Controls.Add(this.textBoxDoTSpellDoT);
            this.Controls.Add(this.textBoxDoTSpellBase);
            this.Controls.Add(this.labelFixedDamage);
            this.Controls.Add(this.textBoxFixedDamage);
            this.Controls.Add(this.labelVariableDamageMax);
            this.Controls.Add(this.labelVariableDamageMin);
            this.Controls.Add(this.textBoxVariableDamageMax);
            this.Controls.Add(this.textBoxVariableDamageMin);
            this.Controls.Add(this.comboBoxSpellType);
            this.Controls.Add(this.labelWizardPierce);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelWizardPercentDamage);
            this.Controls.Add(this.labelWizardFlatDamage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelBossBoost);
            this.Controls.Add(this.labelBossResist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBoss);
            this.Controls.Add(this.buttonWizard);
            this.Controls.Add(this.menuStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "W101 Damage Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonWizard;
        private System.Windows.Forms.Button buttonBoss;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelBossResist;
        private System.Windows.Forms.Label labelBossBoost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelWizardFlatDamage;
        private System.Windows.Forms.Label labelWizardPercentDamage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelWizardPierce;
        private System.Windows.Forms.ComboBox comboBoxSpellType;
        private System.Windows.Forms.TextBox textBoxVariableDamageMin;
        private System.Windows.Forms.TextBox textBoxVariableDamageMax;
        private System.Windows.Forms.Label labelVariableDamageMin;
        private System.Windows.Forms.Label labelVariableDamageMax;
        private System.Windows.Forms.TextBox textBoxFixedDamage;
        private System.Windows.Forms.Label labelFixedDamage;
        private System.Windows.Forms.TextBox textBoxDoTSpellBase;
        private System.Windows.Forms.TextBox textBoxDoTSpellDoT;
        private System.Windows.Forms.Label labelDoTSpellBaseDamage;
        private System.Windows.Forms.Label labelDoTSpellDoT;
        private System.Windows.Forms.TextBox textBoxDPPBaseDamage;
        private System.Windows.Forms.Label labelDPPSpellDPP;
        private System.Windows.Forms.TextBox textBoxDPPSpellPips;
        private System.Windows.Forms.Label labelDPPSpellPips;
        private System.Windows.Forms.Label labelDPPSpellEnchantments;
        private System.Windows.Forms.ComboBox comboBoxDPPSpellEnchanments;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelLastInput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxBlades;
        private System.Windows.Forms.ComboBox comboBoxTrap;
        private System.Windows.Forms.ComboBox comboBoxShield;
        private System.Windows.Forms.ComboBox comboBoxWeakness;
        private System.Windows.Forms.Button buttonRemoveLast;
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem wizardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddWizardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadWizardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bossToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddBossToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadBossToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.Button buttonAddBlade;
        private System.Windows.Forms.Button buttonAddWeakness;
        private System.Windows.Forms.Button buttonAddTrap;
        private System.Windows.Forms.Button buttonAddShield;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.TextBox textBoxCritical;
        private System.Windows.Forms.Label labelCritical;
    }
}

