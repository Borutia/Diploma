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
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "orgDataSet.Категория". При необходимости она может быть перемещена или удалена.
            this.категорияTableAdapter.Fill(this.orgDataSet.Категория);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.категорияTableAdapter.Fill(this.orgDataSet.Категория);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            категорияTableAdapter.Update(orgDataSet.Категория);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            категорияBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить запись?", "Диалог удаления записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) //Если нажал Да
            {
                категорияBindingSource.RemoveCurrent();
            }
        }
    }
}
