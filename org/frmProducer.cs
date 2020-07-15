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
    public partial class frmProducer : Form
    {
        public frmProducer()
        {
            InitializeComponent();
        }

        private void frmProducer_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "orgDataSet.Производитель". При необходимости она может быть перемещена или удалена.
            this.производительTableAdapter.Fill(this.orgDataSet.Производитель);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.производительTableAdapter.Fill(this.orgDataSet.Производитель);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            производительTableAdapter.Update(orgDataSet.Производитель);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            производительBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить запись?", "Диалог удаления записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) //Если нажал Да
            {
                производительBindingSource.RemoveCurrent();
            }
        }
    }
}
