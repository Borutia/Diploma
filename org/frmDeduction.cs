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
    public partial class frmDeduction : Form
    {
        public frmDeduction()
        {
            InitializeComponent();
        }

        private void frmDeduction_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "orgDataSet.Остаток". При необходимости она может быть перемещена или удалена.
            this.остатокTableAdapter.Fill(this.orgDataSet.Остаток);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "orgDataSet.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.orgDataSet.Сотрудник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "orgDataSet.СоставСписания". При необходимости она может быть перемещена или удалена.
            this.составСписанияTableAdapter.Fill(this.orgDataSet.СоставСписания);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "orgDataSet.Списание". При необходимости она может быть перемещена или удалена.
            this.списаниеTableAdapter.Fill(this.orgDataSet.Списание);
            dataGridView1_Click(sender, e);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.списаниеTableAdapter.Fill(this.orgDataSet.Списание);
            dataGridView1_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            списаниеTableAdapter.Update(orgDataSet.Списание);
            button4_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            списаниеBindingSource.AddNew();
            dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value = Convert.ToInt32(Options.FIO);
            dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value = DateTime.Today;
            dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value = "Нет";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить запись?", "Диалог удаления записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) //Если нажал Да
            {
                списаниеBindingSource.RemoveCurrent();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value = "Да";
            Validate();
            списаниеBindingSource.EndEdit();
            списаниеTableAdapter.Update(orgDataSet.Списание);
         

            int i, CountRow, IdStore, CountStore;

            CountRow = dataGridView2.RowCount - 1;
            for (i = 0; i < CountRow; i++)
            {
                IdStore = (int)dataGridView2.Rows[i].Cells[1].Value;
                CountStore = (int)dataGridView2.Rows[i].Cells[2].Value;
                остатокTableAdapter.UPD_STORE(CountStore, IdStore);
            }

            списаниеTableAdapter.Fill(this.orgDataSet.Списание);
            dataGridView1_Click(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.составСписанияTableAdapter.Fill(this.orgDataSet.СоставСписания);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DataRowView drw = составСписанияBindingSource.Current as DataRowView;
            drw["СписаниеНомер"] = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value;
            составСписанияTableAdapter.Update(orgDataSet.СоставСписания);
            button5_Click(sender, e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            составСписанияBindingSource.AddNew();
            DataRowView drw = составСписанияBindingSource.Current as DataRowView;
            drw["СписаниеНомер"] = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить запись?", "Диалог удаления записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) //Если нажал Да
            {
                составСписанияBindingSource.RemoveCurrent();
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                составСписанияBindingSource.Filter = "СписаниеНомер=" + (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
                if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString() == "Да")
                {
                    dataGridView2.Enabled = false;
                    button9.Enabled = false;
                    button7.Enabled = false;
                    button6.Enabled = false;
                    button8.Enabled = false;
                    button5.Enabled = false;
                }
                else
                {
                    dataGridView2.Enabled = true;
                    button9.Enabled = true;
                    button7.Enabled = true;
                    button6.Enabled = true;
                    button8.Enabled = true;
                    button5.Enabled = true;

                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            {

                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                app.Workbooks.Open(@"C:\Users\Win\Desktop\orgWIN-ПК\org\Шаблоны\накладная_списания.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                      Type.Missing, Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = (Microsoft.Office.Interop.Excel._Worksheet)app.ActiveSheet;
                //номер документа
                worksheet.Cells[17, 51] = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].FormattedValue.ToString();
                worksheet.Cells[11, 70] = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].FormattedValue.ToString();
                //дата
                worksheet.Cells[17, 57] = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].FormattedValue.ToString();
                worksheet.Cells[13, 70] = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].FormattedValue.ToString();

                worksheet.Cells[7, 1] = "Atlanset";

                //Причина
                worksheet.Cells[12, 18] = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].FormattedValue.ToString();
                //вся сумма
                worksheet.Cells[33, 14] = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].FormattedValue.ToString();

                int rowcount = dataGridView2.RowCount;

                for (int i = 0; i < rowcount; i++)
                {
                    worksheet.Cells[i + 24, 1] = dataGridView2.Rows[i].Cells[1].FormattedValue.ToString();
                    worksheet.Cells[i + 24, 20] = dataGridView2.Rows[i].Cells[2].FormattedValue.ToString();
                }

            }
        }
    }
}
