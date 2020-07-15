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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "orgDataSet.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.orgDataSet.Сотрудник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "orgDataSet.Пользователь". При необходимости она может быть перемещена или удалена.
            this.пользовательTableAdapter.Fill(this.orgDataSet.Пользователь);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.пользовательTableAdapter.Fill(this.orgDataSet.Пользователь);
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            пользовательTableAdapter.Update(orgDataSet.Пользователь);
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            пользовательBindingSource.AddNew();
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить запись?", "Диалог удаления записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) //Если нажал Да
            {
                пользовательBindingSource.RemoveCurrent();
            }
        }
    }
}
