using KursovaLibrary;
using System;
using System.Windows.Forms;

namespace KursovaRabota
{
    public partial class FormCustomDamageModificator : Form
    {
        public DamageModificator damagemod; 

        public FormCustomDamageModificator(DamageModificator dm)
        {
            InitializeComponent();

            switch (dm)
            {
                case Blade:
                    damagemod = new Blade { Damage = 0 };
                    label1.Text = "Enter a value for the Blade:";
                    return;

                case Weakness:
                    damagemod = new Weakness { Damage = 0 };
                    label1.Text = "Enter a value for the Weakness:";
                    return;

                case Trap:
                    damagemod = new Trap { Damage = 0 };
                    label1.Text = "Enter a value for the Trap:";
                    return;

                case Shield:
                    damagemod = new Shield { Damage = 0 };
                    label1.Text = "Enter a value for the Shield:";
                    return;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                damagemod.Damage = FormMain.CorrectInput(textBoxCustomDamageModificator.Text);
                DialogResult = DialogResult.OK;
            }
            catch (FormatException)
            {
                MessageBox.Show("Incorrect input format detected. Please put in only whole positive numbers.", "Invalid Input");

                DialogResult = DialogResult.Cancel;
            }
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
