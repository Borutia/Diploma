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
    public partial class frmStore : Form
    {
        public frmStore()
        {
            InitializeComponent();
        }

        private void frmStore_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "orgDataSet.Приход". При необходимости она может быть перемещена или удалена.
            this.приходTableAdapter.Fill(this.orgDataSet.Приход);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "orgDataSet.Товар". При необходимости она может быть перемещена или удалена.
            this.ТоварTableAdapter.Fill(this.orgDataSet.Товар);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "orgDataSet.Остаток". При необходимости она может быть перемещена или удалена.
            this.остатокTableAdapter.Fill(this.orgDataSet.Остаток);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.остатокTableAdapter.Fill(this.orgDataSet.Остаток);
        }
    }
}
