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
    public partial class frmWorker : Form
    {
        public frmWorker()
        {
            InitializeComponent();
        }

        private void frmWorker_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "orgDataSet.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.orgDataSet.Сотрудник);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.сотрудникTableAdapter.Fill(this.orgDataSet.Сотрудник);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            сотрудникTableAdapter.Update(orgDataSet.Сотрудник);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            сотрудникBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить запись?", "Диалог удаления записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) //Если нажал Да
            {
                сотрудникBindingSource.RemoveCurrent();
            }
        }
    }
}
