using KursovaLibrary;
using System;
using System.Windows.Forms;

namespace KursovaRabota
{
    public partial class FormWizard : Form
    {
        private Wizard _wizard;

        public Wizard Wizard
        {
            get
            {
                return _wizard;
            }

            set
            {
                _wizard = value;
                textBoxFlatDamage.Text = _wizard.FlatDamage.ToString();
                textBoxPierce.Text = _wizard.Pierce.ToString();
                textBoxPercentDamage.Text = _wizard.PercentDamage.ToString();
            }
        }


        public FormWizard()
        {
            InitializeComponent();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            try
            {
                Wizard.FlatDamage = FormMain.CorrectInput(textBoxFlatDamage.Text);
                Wizard.PercentDamage = FormMain.CorrectInput(textBoxPercentDamage.Text);
                Wizard.Pierce = FormMain.CorrectInput(textBoxPierce.Text);
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
