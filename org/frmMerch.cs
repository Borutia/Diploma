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
    public partial class frmMerch : Form
    {
        public frmMerch()
        {
            InitializeComponent();
        }

        private void frmMerch_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "orgDataSet.Производитель". При необходимости она может быть перемещена или удалена.
            this.производительTableAdapter.Fill(this.orgDataSet.Производитель);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "orgDataSet.Категория". При необходимости она может быть перемещена или удалена.
            this.категорияTableAdapter.Fill(this.orgDataSet.Категория);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "orgDataSet.Товар". При необходимости она может быть перемещена или удалена.
            this.ТоварTableAdapter.Fill(this.orgDataSet.Товар);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.ТоварTableAdapter.Fill(this.orgDataSet.Товар);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ТоварTableAdapter.Update(orgDataSet.Товар);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ТоварBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить запись?", "Диалог удаления записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) //Если нажал Да
            {
                ТоварBindingSource.RemoveCurrent();
            }
        }
    }
}
