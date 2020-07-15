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
    public partial class frmCaterer : Form
    {
        public frmCaterer()
        {
            InitializeComponent();
        }

        private void frmCaterer_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "orgDataSet.Поставщик". При необходимости она может быть перемещена или удалена.
            this.поставщикTableAdapter.Fill(this.orgDataSet.Поставщик);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.поставщикTableAdapter.Fill(this.orgDataSet.Поставщик);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            поставщикTableAdapter.Update(orgDataSet.Поставщик);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            поставщикBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить запись?", "Диалог удаления записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) //Если нажал Да
            {
                поставщикBindingSource.RemoveCurrent();
            }
        }
    }
}
