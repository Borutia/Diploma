using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace org
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout newForm = new frmAbout();
            newForm.Show();
        }

        private void товарToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMerch newForm = new frmMerch();
            newForm.Show();
        }

        private void категорииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategory newForm = new frmCategory();
            newForm.Show();
        }

        private void приходныеНакладныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIncome newForm = new frmIncome();
            newForm.Show();
        }

        private void расходныеНакладныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExpense newForm = new frmExpense();
            newForm.Show();
        }

        private void накладныеСписанияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeduction newForm = new frmDeduction();
            newForm.Show();
        }

        private void накладныеПоОстаткамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStore newForm = new frmStore();
            newForm.Show();
        }
    }
}
