using KursovaLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KursovaRabota
{
    public partial class ListForm : Form
    {
        public List<DamageModificator> dm;

        public ListForm()
        {
            InitializeComponent();
        }

        private void ListForm_Load(object sender, EventArgs e)
        {
            dm.Reverse();
            foreach (var damagemod in dm)
                listBoxDMs.Items.Add(damagemod);

        }       

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonRemoveWeakness_Click(object sender, EventArgs e)
        {
            dm = dm.Where(a => !(a is Weakness)).ToList();
            RefreshList();
        }

        private void buttonRemoveTraps_Click(object sender, EventArgs e)
        {
            dm = dm.Where(a => !(a is Trap)).ToList();
            RefreshList();
        }

        private void buttonRemoveShields_Click(object sender, EventArgs e)
        {
            dm = dm.Where(a => !(a is Shield)).ToList();
            RefreshList();
        }

        private void buttonRemoveSelected_Click(object sender, EventArgs e)
        {
            if (listBoxDMs.SelectedIndex != -1)
            {
                dm = dm.Where(a => !(a == listBoxDMs.SelectedItem)).ToList();
                RefreshList();
                
            }
            else
                MessageBox.Show("There is nothing selected");
        }

        private void buttonRemoveBlades_Click(object sender, EventArgs e)
        {
            dm = dm.Where(a => !(a is Blade)).ToList();
            RefreshList();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void RefreshList()
        {
            listBoxDMs.Items.Clear();
            foreach (var damagemod in dm)
                listBoxDMs.Items.Add(damagemod);
        }

        private void ListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            dm.Reverse();
        }
    }
}
