using KursovaLibrary;
using KursovaLibrary.Characters.Base_Character;
using System;
using System.Windows.Forms;

namespace KursovaRabota.Forms
{
    public partial class FormCustomCharacterCreation : Form
    {
        public Character newchar;
        public FormCustomCharacterCreation(Character c)
        {
            InitializeComponent();
            if (c is Wizard)
            {
                labelStat1.Text = "Flat Damage:";
                labelStat2.Text = "Percent Damage:";
                labelStat3.Text = "Pierce:";
                newchar = new Wizard("Char", 0, 0, 0, 0);
            }
            else
            {
                labelStat1.Text = "Resist:";
                labelStat2.Text = "Boost:";
                labelStat3.Visible = false;
                textBoxStat3.Visible = false;
                newchar = new Boss("Char", 0, 0, 0);
            }
                    
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            newchar.Name = textBoxName.Text;
            newchar.ID = 0;

            if (newchar is Wizard)
            {
                try
                {
                    ((Wizard)newchar).FlatDamage = FormMain.CorrectInput(textBoxStat1.Text);
                    ((Wizard)newchar).PercentDamage = FormMain.CorrectInput(textBoxStat2.Text);
                    ((Wizard)newchar).Pierce = FormMain.CorrectInput(textBoxStat3.Text);
                    DialogResult = DialogResult.OK;
                }
                catch(FormatException)
                {
                    MessageBox.Show("Incorrect input format detected. Please put in only whole positive numbers.", "Invalid Input");
                    DialogResult = DialogResult.Cancel;
                }               
            }
            else
            {
                try
                {
                    ((Boss)newchar).Resist = FormMain.CorrectInput(textBoxStat1.Text);
                    ((Boss)newchar).Boost = FormMain.CorrectInput(textBoxStat2.Text);
                    DialogResult = DialogResult.OK;
                }
                catch(FormatException)
                {
                    MessageBox.Show("Incorrect input format detected. Please put in only whole positive numbers.", "Invalid Input");
                    DialogResult = DialogResult.Cancel;
                }
                
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
