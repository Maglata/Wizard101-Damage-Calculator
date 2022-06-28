using KursovaLibrary;
using System;
using System.Windows.Forms;

namespace KursovaRabota
{
    public partial class FormBoss : Form
    {
        private Boss _boss;

        public Boss Boss
        {
            get
            {
                return _boss;
            }

            set
            {
                _boss = value;
                textBoxBossResist.Text = _boss.Resist.ToString();
                textBoxBossBoost.Text = _boss.Boost.ToString();
            }
        }


        public FormBoss()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                _boss.Boost = FormMain.CorrectInput(textBoxBossBoost.Text);
                _boss.Resist = FormMain.CorrectInput(textBoxBossResist.Text);
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
