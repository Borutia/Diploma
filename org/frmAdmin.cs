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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCaterer newForm = new frmCaterer();
            newForm.Show();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWorker newForm = new frmWorker();
            newForm.Show();
        }

        private void производительToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProducer newForm = new frmProducer();
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

        private void приходнаяНакладнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIncome newForm = new frmIncome();
            newForm.Show();
        }

        private void расходнаяНакладнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExpense newForm = new frmExpense();
            newForm.Show();
        }

        private void накладныеСписанияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeduction newForm = new frmDeduction();
            newForm.Show();
        }

        private void остаткиНаСкладеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStore newForm = new frmStore();
            newForm.Show();
        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUser newForm = new frmUser();
            newForm.Show();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout newForm = new frmAbout();
            newForm.Show();
        }

    }
}
