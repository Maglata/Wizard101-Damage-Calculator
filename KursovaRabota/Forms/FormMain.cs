using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Linq;
using KursovaRabota.Forms;
using KursovaLibrary;
using KursovaLibrary.Characters.Base_Character;

namespace KursovaRabota
{

    public partial class FormMain : Form
    {

        private Wizard wizard = new Wizard("Starter", 0, 0, 0, 0);

        private Boss boss = new Boss("Starter", 0, 0, 0);

        private Spell spell;

        private double enchant;

        private double critical;

        private List<DamageModificator> _dm = new List<DamageModificator>();

        private List<Character> _characters = new List<Character>();

        public FormMain()
        {
            InitializeComponent();

            // 1 Wizard and 4 Bosses that are static and should be always present
            // Hence why in most cases we skip the first 5 characters in the list.

            var staticwizard = new Wizard("Stephen DragonGiver", 1, 0, 100, 25);

            var staticboss1 = new Boss("Malistaire", 2, 80, 50);

            var staticboss2 = new Boss("Krokopatra", 3, 70, 40);

            var staticboss3 = new Boss("Jade Oni", 4, 80, 50);

            var staticboss4 = new Boss("Queen Calypso", 5, 80, 35);

            _characters.Add(staticwizard);
            _characters.Add(staticboss1);
            _characters.Add(staticboss2);
            _characters.Add(staticboss3);
            _characters.Add(staticboss4);

            LoadData();

            foreach (Character ch in _characters)
                AddToLoadStrip(ch);

            LoadDeleteable();
        }      

        // Boss Editing
        private void buttonBoss_Click(object sender, EventArgs e)
        {
            var fb = new FormBoss();
            fb.Boss = boss;
            fb.ShowDialog();

            ChangeLabelText(labelBossBoost, boss.Boost.ToString());
            ChangeLabelText(labelBossResist, boss.Resist.ToString());
        }

        // Wizard Editing
        private void buttonWizard_Click(object sender, EventArgs e)
        {         
            var fw = new FormWizard();
            fw.Wizard = wizard;
            fw.ShowDialog();

            ChangeLabelText(labelWizardFlatDamage, wizard.FlatDamage.ToString());
            ChangeLabelText(labelWizardPercentDamage, wizard.PercentDamage.ToString());
            ChangeLabelText(labelWizardPierce, wizard.Pierce.ToString());
        }

        // Spell Selection
        private void comboBoxSpellType_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBoxSpellType.SelectedIndex)
            {
                case 0:
                    // Variable Damaged
                    CleanComboBox();
                    labelVariableDamageMax.Visible = true;
                    labelVariableDamageMin.Visible = true;
                    textBoxVariableDamageMax.Visible = true;
                    textBoxVariableDamageMin.Visible = true;

                    spell = new VariableSpell();
                    break;

                case 1:
                    // Fixed Damage
                    CleanComboBox();
                    labelFixedDamage.Visible = true;
                    textBoxFixedDamage.Visible = true;

                    spell = new FlatDamageSpell();
                    break;

                case 2:
                    // Damage Per Pip
                    CleanComboBox();
                    labelDPPSpellDPP.Visible = true;
                    labelDPPSpellEnchantments.Visible = true;
                    labelDPPSpellPips.Visible = true;
                    textBoxDPPBaseDamage.Visible = true;
                    textBoxDPPSpellPips.Visible = true;
                    comboBoxDPPSpellEnchanments.Visible = true;

                    spell = new DPPSpell();
                    break;

                case 3:
                    // Damage + Overtime
                    CleanComboBox();
                    labelDoTSpellBaseDamage.Visible = true;
                    labelDoTSpellDoT.Visible = true;
                    textBoxDoTSpellBase.Visible = true;
                    textBoxDoTSpellDoT.Visible = true;

                    spell = new DoTSpell();
                    break;

                default:
                    break;
            }
        }      

        // Enchant Selection
        private void comboBoxDPPSpellEnchanments_SelectedIndexChanged(object sender, EventArgs e) 
        {
            switch (comboBoxDPPSpellEnchanments.SelectedIndex)
            {
                case 0: // None
                    break;
                case 1: //Strong(+100)
                    enchant = 100;
                    break;

                case 2: //Giant(+125)
                    enchant = 125;
                    break;

                case 3: //Monstrous(+175)
                    enchant = 175;
                    break;

                case 4: //Gargantuan(+225)
                    enchant = 225;
                    break;

                case 5: //Colossal(+275)
                    enchant = 275;
                    break;

                case 6: //Epic(+300)
                    enchant = 300;
                    break;

                default:
                    break;
            }
        } 

        // Calculation of the Spell
        private void buttonCalculate_Click(object sender, EventArgs e)
        {        
            try
            {
                // Critical Check
                if (!double.TryParse(textBoxCritical.Text, out _) || double.Parse(textBoxCritical.Text) < 0 || double.Parse(textBoxCritical.Text) < 1)
                {
                    throw new FormatException();
                }
                critical = double.Parse(textBoxCritical.Text);

                switch (spell)
                {
                    case VariableSpell:
                        var VarSpell = (VariableSpell)spell;
                        VarSpell.BaseDamage = CorrectInput(textBoxVariableDamageMin.Text);
                        VarSpell.MaxDamage = CorrectInput(textBoxVariableDamageMax.Text);
                        MessageBox.Show(VarSpell.CalculateDamage(_dm, wizard, boss, enchant, critical), "Potential Damage");
                        break;

                    case FlatDamageSpell:
                        var FlatSpell = (FlatDamageSpell)spell;
                        FlatSpell.BaseDamage = CorrectInput(textBoxFixedDamage.Text);
                        MessageBox.Show(FlatSpell.CalculateDamage(_dm, wizard, boss, enchant, critical),"Potential Damage");
                        break;

                    case DPPSpell:
                        var dPPSpell = (DPPSpell)spell;
                        dPPSpell.BaseDamage = CorrectInput(textBoxDPPBaseDamage.Text);
                        if (CorrectInput(textBoxDPPSpellPips.Text) == 0)
                        {
                            dPPSpell.Pips = 1;
                            MessageBox.Show("You have entered a value lower or equal to 0. The Pips are set to 1.");
                        }   
                        else
                            dPPSpell.Pips = CorrectInput(textBoxDPPSpellPips.Text);
                        MessageBox.Show(dPPSpell.CalculateDamage(_dm, wizard, boss, enchant, critical), "Potential Damage");
                        break;

                    case DoTSpell:
                        var doTSpell = (DoTSpell)spell;
                        doTSpell.BaseDamage = CorrectInput(textBoxDoTSpellBase.Text);
                        doTSpell.DoT = CorrectInput(textBoxDoTSpellDoT.Text);
                        MessageBox.Show(doTSpell.CalculateDamage(_dm, wizard, boss, enchant, critical), "Potential Damage");
                        break;

                    default:
                        MessageBox.Show("No Spell Selected", "Error");
                        break;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Incorrect input format detected. Please put in only whole positive numbers or positive numbers above 1,00 for Critical.", "Invalid Input");
            }
            
        }

        // Allow the User to quickly remove their last input.
        private void buttonRemoveLast_Click(object sender, EventArgs e)
        {
            if (_dm.Count != 0)
            {
                _dm.Reverse();
                MessageBox.Show($"{_dm[0]} was removed");
                _dm.RemoveAt(0);
                _dm.Reverse();

                ChangeLastInput();
            }
            else
                MessageBox.Show("Empty Queue");

        }

        // A function to add a character to their respective Loading ToolStrip
        private void AddToLoadStrip(Character ch)
        {
            if (ch is Wizard)
                loadWizardToolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem(ch.Name));
            else
                loadBossToolStripMenuItem1.DropDownItems.Add(new ToolStripMenuItem(ch.Name));
        }

        // Refreshes the Load Toolstip Option
        private void RefreshLoadable()
        {
            // Clears all the items in both Load Options
            loadWizardToolStripMenuItem.DropDownItems.Clear();
            loadBossToolStripMenuItem1.DropDownItems.Clear();

            foreach (Character c in _characters)
            {
                if (c is Wizard)
                {
                    loadWizardToolStripMenuItem.DropDownItems.Add(c.Name);
                }
                else
                {
                    loadBossToolStripMenuItem1.DropDownItems.Add(c.Name);
                }
            }

        }

        // Refreshes the Delete Toolstip Option
        private void LoadDeleteable()
        {
            // Clears all the items in both Delete Options
            deleteToolStripMenuItem.DropDownItems.Clear();
            deleteToolStripMenuItem1.DropDownItems.Clear();

            foreach (Character c in _characters.Skip(5))
            {
                if(c is Wizard)
                {
                    deleteToolStripMenuItem.DropDownItems.Add(c.Name);
                }
                else
                {
                    deleteToolStripMenuItem1.DropDownItems.Add(c.Name);
                }
            }         
        }            

        // Reset Button
        private void buttonReset_Click(object sender, EventArgs e)
        {
            _dm.Clear();
            CleanComboBox();
            textBoxCritical.Clear();
            ChangeLastInput();
            MessageBox.Show("Successful Reset", "Reset");
        }

        // Blade Selection
        private void buttonAddBlade_Click(object sender, EventArgs e)
        {
            switch (comboBoxBlades.SelectedIndex)
            {
                case 0: // 20 %
                    var blade20 = new Blade { Damage = 20 };
                    _dm.Add(blade20);
                    ChangeLastInput();
                    break;

                case 1: // 25 %
                    var blade25 = new Blade { Damage = 25 };
                    _dm.Add(blade25);
                    ChangeLastInput();
                    break;

                case 2: // 30 %
                    var blade30 = new Blade { Damage = 30 };
                    _dm.Add(blade30);
                    ChangeLastInput();
                    break;

                case 3: // 35 %
                    var blade35 = new Blade { Damage = 35 };
                    _dm.Add(blade35);
                    ChangeLastInput();
                    break;

                case 4: // 40 %
                    var blade40 = new Blade { Damage = 40 };
                    _dm.Add(blade40);
                    ChangeLastInput();
                    break;

                case 5: // 45 %
                    var blade45 = new Blade { Damage = 45 };
                    _dm.Add(blade45);
                    ChangeLastInput();
                    break;

                case 6: // 50 %
                    var blade50 = new Blade { Damage = 50 };
                    _dm.Add(blade50);
                    ChangeLastInput();
                    break;

                case 7: // Custom
                    var customblade = new Blade { Damage = 0 };
                    var cdm = new FormCustomDamageModificator(customblade);
                    cdm.ShowDialog();
                    if(cdm.DialogResult == DialogResult.OK)
                    {
                        _dm.Add(cdm.damagemod);
                        ChangeLastInput();
                    }
                    break;

                default:
                    break;
            }
        }

        // Weakness Selection
        private void buttonAddWeakness_Click(object sender, EventArgs e)
        {
            switch (comboBoxWeakness.SelectedIndex)
            {
                case 0: // 20 %
                    var weakness20 = new Weakness { Damage = 20 };
                    _dm.Add(weakness20);
                    ChangeLastInput();
                    break;

                case 1: // 25 %
                    var weakness25 = new Weakness { Damage = 25 };
                    _dm.Add(weakness25);
                    ChangeLastInput();
                    break;

                case 2: // 35 %
                    var weakness35 = new Weakness { Damage = 35 };
                    _dm.Add(weakness35);
                    ChangeLastInput();
                    break;

                case 3: // 40 %
                    var weakness40 = new Weakness { Damage = 40 };
                    _dm.Add(weakness40);
                    ChangeLastInput();
                    break;

                case 4: // 45 %
                    var weakness45 = new Weakness { Damage = 45 };
                    _dm.Add(weakness45);
                    ChangeLastInput();
                    break;

                case 5: // 50 %
                    var weakness50 = new Weakness { Damage = 50 };
                    _dm.Add(weakness50);
                    ChangeLastInput();
                    break;

                case 6: // 90 %
                    var weakness90 = new Weakness { Damage = 90 };
                    _dm.Add(weakness90);
                    ChangeLastInput();
                    break;

                case 7: // Custom
                    var customweakness = new Weakness { Damage = 0 };
                    var cdm = new FormCustomDamageModificator(customweakness);
                    cdm.ShowDialog();
                    if (cdm.DialogResult == DialogResult.OK)
                    {
                        _dm.Add(cdm.damagemod);
                        ChangeLastInput();
                    }
                    break;

                default:
                    break;
            }
        }

        // Trap Selection
        private void buttonAddTrap_Click(object sender, EventArgs e)
        {
            switch (comboBoxTrap.SelectedIndex)
            {
                case 0: // 30 %
                    var trap30 = new Trap { Damage = 30 };
                    _dm.Add(trap30);
                    ChangeLastInput();
                    break;

                case 1: // 40 %
                    var trap40 = new Trap { Damage = 40 };
                    _dm.Add(trap40);
                    ChangeLastInput();
                    break;

                case 2: // 70 %
                    var trap70 = new Trap { Damage = 70 };
                    _dm.Add(trap70);
                    ChangeLastInput();
                    break;

                case 3: // 75 %
                    var trap75 = new Trap { Damage = 75 };
                    _dm.Add(trap75);
                    ChangeLastInput();
                    break;

                case 4: // 80 %
                    var trap80 = new Trap { Damage = 80 };
                    _dm.Add(trap80);
                    ChangeLastInput();
                    break;

                case 5: // Custom
                    var customtrap = new Trap { Damage = 0 };
                    var cdm = new FormCustomDamageModificator(customtrap);
                    cdm.ShowDialog();
                    if (cdm.DialogResult == DialogResult.OK)
                    {
                        _dm.Add(cdm.damagemod);
                        ChangeLastInput();
                    }
                    break;

                default:
                    break;
            }
        }

        // Shield Selection
        private void buttonAddShield_Click(object sender, EventArgs e)
        {
            switch (comboBoxShield.SelectedIndex)
            {
                case 0: // 45 %
                    var shield45 = new Shield { Damage = 45 };
                    _dm.Add(shield45);
                    ChangeLastInput();
                    break;

                case 1: // 50 %
                    var shield50 = new Shield { Damage = 50 };
                    _dm.Add(shield50);
                    ChangeLastInput();
                    break;

                case 2: // 70 %
                    var shield70 = new Shield { Damage = 70 };
                    _dm.Add(shield70);
                    ChangeLastInput();
                    break;

                case 3: // 80 %
                    var shield80 = new Shield { Damage = 80 };
                    _dm.Add(shield80);
                    ChangeLastInput();
                    break;

                case 4: // Custom
                    var customshield = new Shield { Damage = 0 };
                    var cdm = new FormCustomDamageModificator(customshield);
                    cdm.ShowDialog();
                    if (cdm.DialogResult == DialogResult.OK)
                    {
                        _dm.Add(cdm.damagemod);
                        ChangeLastInput();
                    }
                    break;

                default:
                    break;
            }
        }

        // Showing the Stack
        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            if (_dm.Count != 0)
            {
                var lf = new ListForm();
                var _dm2 = new List<DamageModificator>(_dm);
                lf.dm = _dm2;
                lf.ShowDialog();

                if(lf.DialogResult == DialogResult.OK)
                {
                    _dm = lf.dm;                  
                }
                
                ChangeLastInput();
            }
            else
                MessageBox.Show("There are no Blades/Shields");   
        }      

        // Loading a Wizard
        private void loadWizardToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            int index = loadWizardToolStripMenuItem.DropDownItems.IndexOf(e.ClickedItem);

            var wizards = _characters
                                .Where(w => w is Wizard);

            wizard = (Wizard)wizards.ElementAt(index);
            MessageBox.Show($"{wizard.Name} was loaded.");

            ChangeLabelText(labelWizardFlatDamage, wizard.FlatDamage.ToString());
            ChangeLabelText(labelWizardPercentDamage, wizard.PercentDamage.ToString());
            ChangeLabelText(labelWizardPierce, wizard.Pierce.ToString());
        }

        // Loading a Boss
        private void loadBossToolStripMenuItem1_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            int index = loadBossToolStripMenuItem1.DropDownItems.IndexOf(e.ClickedItem);

            var bosses = _characters
                                .Where(b => b is Boss);

            boss = (Boss)bosses.ElementAt(index);
            MessageBox.Show($"{boss.Name} was loaded.");

            ChangeLabelText(labelBossBoost, boss.Boost.ToString());
            ChangeLabelText(labelBossResist, boss.Resist.ToString());
        }

        // Saving a Wizard
        private void AddWizardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cc = new FormCustomCharacterCreation(wizard);
            cc.ShowDialog();
            if (cc.DialogResult == DialogResult.OK)
            {
                cc.newchar.ID = SetID();
                _characters.Add(cc.newchar);
                AddToLoadStrip(cc.newchar);
                LoadDeleteable();
                MessageBox.Show($"{cc.newchar.Name} was added.");
            }
        }

        // Saving a Boss
        private void AddBossToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var cc = new FormCustomCharacterCreation(boss);
            cc.ShowDialog();
            if (cc.DialogResult == DialogResult.OK)
            {
                cc.newchar.ID = SetID();
                _characters.Add(cc.newchar);
                AddToLoadStrip(cc.newchar);
                LoadDeleteable();
                MessageBox.Show($"{cc.newchar.Name} was added.");
            }
        }                         

        // Deleting a Wizard
        private void deleteToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            int index = deleteToolStripMenuItem.DropDownItems.IndexOf(e.ClickedItem);
            var _wizards = _characters.Skip(5).Where(w => w is Wizard).ToList();
            MessageBox.Show($"{_wizards.ElementAt(index).Name} was removed");
            _characters.
                Remove(_wizards.
                            SingleOrDefault
                                (w => w.ID == _wizards.ElementAt(index).ID));
            LoadDeleteable();
            RefreshLoadable();
        }

        // Deleting a Boss
        private void deleteToolStripMenuItem1_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            int index = deleteToolStripMenuItem1.DropDownItems.IndexOf(e.ClickedItem);
            var _bosses = _characters.Skip(5).Where(b => b is Boss).ToList();
            MessageBox.Show($"{_bosses.ElementAt(index).Name} was removed");
            _characters.
                Remove(_bosses.
                            SingleOrDefault
                                (b => b.ID == _bosses.ElementAt(index).ID));
            LoadDeleteable();
            RefreshLoadable();
        }

        // ID setter
        private int SetID() => _characters.Max(i => i.ID) + 1;     

        // A function that clears all the Spell Combo/Text Boxes
        private void CleanComboBox()
        {
            labelDPPSpellDPP.Visible = false;
            labelDPPSpellEnchantments.Visible = false;
            labelDPPSpellPips.Visible = false;
            textBoxDPPBaseDamage.Visible = false;
            textBoxDPPSpellPips.Visible = false;
            comboBoxDPPSpellEnchanments.Visible = false;
            labelVariableDamageMax.Visible = false;
            labelVariableDamageMin.Visible = false;
            textBoxVariableDamageMax.Visible = false;
            textBoxVariableDamageMin.Visible = false;
            labelFixedDamage.Visible = false;
            textBoxFixedDamage.Visible = false;
            labelDoTSpellBaseDamage.Visible = false;
            labelDoTSpellDoT.Visible = false;
            textBoxDoTSpellBase.Visible = false;
            textBoxDoTSpellDoT.Visible = false;

            textBoxDoTSpellBase.Clear();
            textBoxDoTSpellDoT.Clear();
            textBoxDPPBaseDamage.Clear();
            textBoxDPPSpellPips.Clear();
            textBoxFixedDamage.Clear();
            textBoxVariableDamageMax.Clear();
            textBoxVariableDamageMin.Clear();
        }

        // A way to easily change the label text
        void ChangeLabelText(Label label, string text) => label.Text = text;

        // Updates the label for the latest Input
        void ChangeLastInput()
        {
            if (_dm.Count != 0)
            {
                _dm.Reverse();
                labelLastInput.Text = _dm[0].ToString();
                _dm.Reverse();
            }
            else
                labelLastInput.Text = "";
        }

        // A modified Parse that throws an exception when the value is negative or cannot be Parsed
        public static double CorrectInput(string input)
        {
            if (!double.TryParse(input, out _) || double.Parse(input) < 0 || !int.TryParse(input, out _))
            {
                throw new FormatException();
            }
            return double.Parse(input);
        }

        // Saving Characters
        public void SaveData()
        {
            IFormatter formatter = new BinaryFormatter();

            using (var fs = new FileStream("data", FileMode.Create))
#pragma warning disable SYSLIB0011 // Type or member is obsolete
                formatter.Serialize(fs, _characters.Skip(5).ToList());
#pragma warning restore SYSLIB0011 // Type or member is obsolete

        }

        // Loading Characters
        public void LoadData()
        {
            if (File.Exists("data"))
            {
                IFormatter formatter = new BinaryFormatter();

                using (var fs = new FileStream("data", FileMode.Open))

                    foreach (var c in (List<Character>)formatter.Deserialize(fs))
                        _characters.Add(c);

            }
        }
        
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }
       
    }
}