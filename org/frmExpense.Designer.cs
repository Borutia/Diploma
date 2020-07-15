namespace org
{
    partial class frmExpense
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.составНомерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ОстатокНомер = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.остатокBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orgDataSet = new org.orgDataSet();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.расходНомерDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.составРасходаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.сотрудникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.расходBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.расходTableAdapter = new org.orgDataSetTableAdapters.РасходTableAdapter();
            this.составРасходаTableAdapter = new org.orgDataSetTableAdapters.СоставРасходаTableAdapter();
            this.сотрудникTableAdapter = new org.orgDataSetTableAdapters.СотрудникTableAdapter();
            this.остатокTableAdapter = new org.orgDataSetTableAdapters.ОстатокTableAdapter();
            this.расходНомерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сотрудникНомерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.суммаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.проведеноDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.остатокBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orgDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.составРасходаBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.расходBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.button7);
            this.panel4.Controls.Add(this.button8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 194);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(629, 33);
            this.panel4.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(5, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Обновить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(245, 6);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(164, 6);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 5;
            this.button7.Text = "Добавить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(84, 6);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 4;
            this.button8.Text = "Сохранить";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Запись учеников на занятие:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(5, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Обновить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(245, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.составНомерDataGridViewTextBoxColumn,
            this.ОстатокНомер,
            this.ценаDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.расходНомерDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.составРасходаBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(629, 194);
            this.dataGridView2.TabIndex = 61;
            // 
            // составНомерDataGridViewTextBoxColumn
            // 
            this.составНомерDataGridViewTextBoxColumn.DataPropertyName = "СоставНомер";
            this.составНомерDataGridViewTextBoxColumn.HeaderText = "СоставНомер";
            this.составНомерDataGridViewTextBoxColumn.Name = "составНомерDataGridViewTextBoxColumn";
            this.составНомерDataGridViewTextBoxColumn.ReadOnly = true;
            this.составНомерDataGridViewTextBoxColumn.Visible = false;
            // 
            // ОстатокНомер
            // 
            this.ОстатокНомер.DataPropertyName = "ОстатокНомер";
            this.ОстатокНомер.DataSource = this.остатокBindingSource;
            this.ОстатокНомер.DisplayMember = "Наименование";
            this.ОстатокНомер.HeaderText = "Товар";
            this.ОстатокНомер.Name = "ОстатокНомер";
            this.ОстатокНомер.ValueMember = "ОстатокНомер";
            // 
            // остатокBindingSource
            // 
            this.остатокBindingSource.DataMember = "Остаток";
            this.остатокBindingSource.DataSource = this.orgDataSet;
            // 
            // orgDataSet
            // 
            this.orgDataSet.DataSetName = "orgDataSet";
            this.orgDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            // 
            // расходНомерDataGridViewTextBoxColumn1
            // 
            this.расходНомерDataGridViewTextBoxColumn1.DataPropertyName = "РасходНомер";
            this.расходНомерDataGridViewTextBoxColumn1.HeaderText = "РасходНомер";
            this.расходНомерDataGridViewTextBoxColumn1.Name = "расходНомерDataGridViewTextBoxColumn1";
            this.расходНомерDataGridViewTextBoxColumn1.Visible = false;
            // 
            // составРасходаBindingSource
            // 
            this.составРасходаBindingSource.DataMember = "СоставРасхода";
            this.составРасходаBindingSource.DataSource = this.orgDataSet;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 296);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(629, 227);
            this.panel3.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 523);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.расходНомерDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.сотрудникНомерDataGridViewTextBoxColumn,
            this.суммаDataGridViewTextBoxColumn,
            this.проведеноDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.расходBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(629, 254);
            this.dataGridView1.TabIndex = 60;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // сотрудникBindingSource
            // 
            this.сотрудникBindingSource.DataMember = "Сотрудник";
            this.сотрудникBindingSource.DataSource = this.orgDataSet;
            // 
            // расходBindingSource
            // 
            this.расходBindingSource.DataMember = "Расход";
            this.расходBindingSource.DataSource = this.orgDataSet;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 254);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(629, 42);
            this.panel2.TabIndex = 2;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(407, 6);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 12;
            this.button10.Text = "Печать";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(326, 6);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 9;
            this.button9.Text = "Провести";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(164, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // расходTableAdapter
            // 
            this.расходTableAdapter.ClearBeforeFill = true;
            // 
            // составРасходаTableAdapter
            // 
            this.составРасходаTableAdapter.ClearBeforeFill = true;
            // 
            // сотрудникTableAdapter
            // 
            this.сотрудникTableAdapter.ClearBeforeFill = true;
            // 
            // остатокTableAdapter
            // 
            this.остатокTableAdapter.ClearBeforeFill = true;
            // 
            // расходНомерDataGridViewTextBoxColumn
            // 
            this.расходНомерDataGridViewTextBoxColumn.DataPropertyName = "РасходНомер";
            this.расходНомерDataGridViewTextBoxColumn.HeaderText = "РасходНомер";
            this.расходНомерDataGridViewTextBoxColumn.Name = "расходНомерDataGridViewTextBoxColumn";
            this.расходНомерDataGridViewTextBoxColumn.ReadOnly = true;
            this.расходНомерDataGridViewTextBoxColumn.Visible = false;
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            // 
            // сотрудникНомерDataGridViewTextBoxColumn
            // 
            this.сотрудникНомерDataGridViewTextBoxColumn.DataPropertyName = "СотрудникНомер";
            this.сотрудникНомерDataGridViewTextBoxColumn.DataSource = this.сотрудникBindingSource;
            this.сотрудникНомерDataGridViewTextBoxColumn.DisplayMember = "Фамилия";
            this.сотрудникНомерDataGridViewTextBoxColumn.HeaderText = "Сотрудник";
            this.сотрудникНомерDataGridViewTextBoxColumn.Name = "сотрудникНомерDataGridViewTextBoxColumn";
            this.сотрудникНомерDataGridViewTextBoxColumn.ReadOnly = true;
            this.сотрудникНомерDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.сотрудникНомерDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.сотрудникНомерDataGridViewTextBoxColumn.ValueMember = "СотрудникНомер";
            // 
            // суммаDataGridViewTextBoxColumn
            // 
            this.суммаDataGridViewTextBoxColumn.DataPropertyName = "Сумма";
            this.суммаDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.суммаDataGridViewTextBoxColumn.Name = "суммаDataGridViewTextBoxColumn";
            this.суммаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // проведеноDataGridViewTextBoxColumn
            // 
            this.проведеноDataGridViewTextBoxColumn.DataPropertyName = "Проведено";
            this.проведеноDataGridViewTextBoxColumn.HeaderText = "Проведено";
            this.проведеноDataGridViewTextBoxColumn.Name = "проведеноDataGridViewTextBoxColumn";
            this.проведеноDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 523);
            this.Controls.Add(this.panel1);
            this.Name = "frmExpense";
            this.Text = "Расходные накладные";
            this.Load += new System.EventHandler(this.frmExpense_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.остатокBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orgDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.составРасходаBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.расходBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private orgDataSet orgDataSet;
        private System.Windows.Forms.BindingSource расходBindingSource;
        private orgDataSetTableAdapters.РасходTableAdapter расходTableAdapter;
        private System.Windows.Forms.BindingSource составРасходаBindingSource;
        private orgDataSetTableAdapters.СоставРасходаTableAdapter составРасходаTableAdapter;

        private System.Windows.Forms.BindingSource сотрудникBindingSource;
        private orgDataSetTableAdapters.СотрудникTableAdapter сотрудникTableAdapter;
        private System.Windows.Forms.BindingSource остатокBindingSource;
        private orgDataSetTableAdapters.ОстатокTableAdapter остатокTableAdapter;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.DataGridViewComboBoxColumn подразделениеНомерDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.DataGridViewTextBoxColumn составНомерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ОстатокНомер;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn расходНомерDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn расходНомерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn сотрудникНомерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn проведеноDataGridViewTextBoxColumn;
    }
}