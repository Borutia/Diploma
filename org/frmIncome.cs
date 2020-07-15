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
    public partial class frmIncome : Form
    {
        public frmIncome()
        {
            InitializeComponent();
        }

        private void frmIncome_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "orgDataSet.Товар". При необходимости она может быть перемещена или удалена.
            this.ТоварTableAdapter.Fill(this.orgDataSet.Товар);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "orgDataSet.СоставПрихода". При необходимости она может быть перемещена или удалена.
            this.составПриходаTableAdapter.Fill(this.orgDataSet.СоставПрихода);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "orgDataSet.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.orgDataSet.Сотрудник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "orgDataSet.Поставщик". При необходимости она может быть перемещена или удалена.
            this.поставщикTableAdapter.Fill(this.orgDataSet.Поставщик);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "orgDataSet.Приход". При необходимости она может быть перемещена или удалена.
            this.приходTableAdapter.Fill(this.orgDataSet.Приход);
            dataGridView1_Click(sender, e);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.приходTableAdapter.Fill(this.orgDataSet.Приход);
            dataGridView1_Click(sender, e);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            приходTableAdapter.Update(orgDataSet.Приход);
            button4_Click(sender, e);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            приходBindingSource.AddNew();
            dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value = DateTime.Today;
            dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value = Convert.ToInt32(Options.FIO);
            dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value = 0;
            dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value = "Нет";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить запись?", "Диалог удаления записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) //Если нажал Да
            {
                приходBindingSource.RemoveCurrent();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value = "Да";
            Validate();
            приходBindingSource.EndEdit();
            приходTableAdapter.Update(orgDataSet.Приход);
            приходTableAdapter.UPD_INCSUM((int)dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            приходTableAdapter.INS_STORE((int)dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            приходTableAdapter.Fill(this.orgDataSet.Приход);
            dataGridView1_Click(sender, e);
            

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                составПриходаBindingSource.Filter = "ПриходНомер=" + (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
                if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString() == "Да")
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

        private void button8_Click(object sender, EventArgs e)
        {
            DataRowView drw = составПриходаBindingSource.Current as DataRowView;
            drw["ПриходНомер"] = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value;
            составПриходаTableAdapter.Update(orgDataSet.СоставПрихода);
            button5_Click(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.составПриходаTableAdapter.Fill(this.orgDataSet.СоставПрихода);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            составПриходаBindingSource.AddNew();
            DataRowView drw = составПриходаBindingSource.Current as DataRowView;
            drw["ПриходНомер"] = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить запись?", "Диалог удаления записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) //Если нажал Да
            {
                составПриходаBindingSource.RemoveCurrent();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                app.Workbooks.Open(@"C:\Users\Win\Desktop\orgWIN-ПК\org\Шаблоны\приходная_накладная.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                      Type.Missing, Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = (Microsoft.Office.Interop.Excel._Worksheet)app.ActiveSheet;
                //номер документа
                worksheet.Cells[26,50] = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].FormattedValue.ToString();
                worksheet.Cells[19, 84] = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].FormattedValue.ToString();
                //дата
                worksheet.Cells[26, 61] = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].FormattedValue.ToString();
                worksheet.Cells[20, 84] = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].FormattedValue.ToString();

                worksheet.Cells[14, 9] = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].FormattedValue.ToString();
                worksheet.Cells[12, 12] = "Atlanset";
                worksheet.Cells[16, 9] = "Atlanset";
                //вся сумма
                worksheet.Cells[33, 14] = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].FormattedValue.ToString();
                //сотрудник
                worksheet.Cells[35, 77] = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].FormattedValue.ToString();

                int rowcount = dataGridView2.RowCount;

                for (int i = 0; i < rowcount; i++)
                {
                    worksheet.Cells[i + 29, 1] = dataGridView2.Rows[i].Cells[1].FormattedValue.ToString();
                    worksheet.Cells[i + 29, 21] = dataGridView2.Rows[i].Cells[2].FormattedValue.ToString();
                    worksheet.Cells[i + 29, 31] = dataGridView2.Rows[i].Cells[3].FormattedValue.ToString();
                    worksheet.Cells[i + 29, 40] = (Convert.ToInt32(dataGridView2.Rows[i].Cells[2].FormattedValue.ToString()) * Convert.ToInt32(dataGridView2.Rows[i].Cells[3].FormattedValue.ToString())).ToString();
                }

            }
        }
    }
}
