namespace org
{
    partial class frmIncome
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.поставщикBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orgDataSet = new org.orgDataSet();
            this.сотрудникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.приходBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.составНомерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ТоварНомерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ТоварBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.приходНомерDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.составПриходаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.приходTableAdapter = new org.orgDataSetTableAdapters.ПриходTableAdapter();
            this.поставщикTableAdapter = new org.orgDataSetTableAdapters.ПоставщикTableAdapter();
            this.сотрудникTableAdapter = new org.orgDataSetTableAdapters.СотрудникTableAdapter();
            this.составПриходаTableAdapter = new org.orgDataSetTableAdapters.СоставПриходаTableAdapter();
            this.ТоварTableAdapter = new org.orgDataSetTableAdapters.ТоварTableAdapter();
            this.приходНомерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.поставщикНомерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.сотрудникНомерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.суммаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.проведеноDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orgDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.приходBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ТоварBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.составПриходаBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(745, 473);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.приходНомерDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.поставщикНомерDataGridViewTextBoxColumn,
            this.сотрудникНомерDataGridViewTextBoxColumn,
            this.суммаDataGridViewTextBoxColumn,
            this.проведеноDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.приходBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 219);
            this.dataGridView1.TabIndex = 60;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // поставщикBindingSource
            // 
            this.поставщикBindingSource.DataMember = "Поставщик";
            this.поставщикBindingSource.DataSource = this.orgDataSet;
            // 
            // orgDataSet
            // 
            this.orgDataSet.DataSetName = "orgDataSet";
            this.orgDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сотрудникBindingSource
            // 
            this.сотрудникBindingSource.DataMember = "Сотрудник";
            this.сотрудникBindingSource.DataSource = this.orgDataSet;
            // 
            // приходBindingSource
            // 
            this.приходBindingSource.DataMember = "Приход";
            this.приходBindingSource.DataSource = this.orgDataSet;
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
            this.panel2.Location = new System.Drawing.Point(0, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(745, 42);
            this.panel2.TabIndex = 2;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(407, 6);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 11;
            this.button10.Text = "Печать";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(326, 6);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 10;
            this.button9.Text = "Провести";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
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
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 261);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(745, 212);
            this.panel3.TabIndex = 0;
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
            this.ТоварНомерDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.приходНомерDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.составПриходаBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(745, 179);
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
            // ТоварНомерDataGridViewTextBoxColumn
            // 
            this.ТоварНомерDataGridViewTextBoxColumn.DataPropertyName = "ТоварНомер";
            this.ТоварНомерDataGridViewTextBoxColumn.DataSource = this.ТоварBindingSource;
            this.ТоварНомерDataGridViewTextBoxColumn.DisplayMember = "Наименование";
            this.ТоварНомерDataGridViewTextBoxColumn.HeaderText = "Товар";
            this.ТоварНомерDataGridViewTextBoxColumn.Name = "ТоварНомерDataGridViewTextBoxColumn";
            this.ТоварНомерDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ТоварНомерDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ТоварНомерDataGridViewTextBoxColumn.ValueMember = "ТоварНомер";
            // 
            // ТоварBindingSource
            // 
            this.ТоварBindingSource.DataMember = "Товар";
            this.ТоварBindingSource.DataSource = this.orgDataSet;
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            // 
            // приходНомерDataGridViewTextBoxColumn1
            // 
            this.приходНомерDataGridViewTextBoxColumn1.DataPropertyName = "ПриходНомер";
            this.приходНомерDataGridViewTextBoxColumn1.HeaderText = "ПриходНомер";
            this.приходНомерDataGridViewTextBoxColumn1.Name = "приходНомерDataGridViewTextBoxColumn1";
            this.приходНомерDataGridViewTextBoxColumn1.Visible = false;
            // 
            // составПриходаBindingSource
            // 
            this.составПриходаBindingSource.DataMember = "СоставПрихода";
            this.составПриходаBindingSource.DataSource = this.orgDataSet;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.button7);
            this.panel4.Controls.Add(this.button8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 179);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(745, 33);
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
            // приходTableAdapter
            // 
            this.приходTableAdapter.ClearBeforeFill = true;
            // 
            // поставщикTableAdapter
            // 
            this.поставщикTableAdapter.ClearBeforeFill = true;
            // 
            // сотрудникTableAdapter
            // 
            this.сотрудникTableAdapter.ClearBeforeFill = true;
            // 
            // составПриходаTableAdapter
            // 
            this.составПриходаTableAdapter.ClearBeforeFill = true;
            // 
            // ТоварTableAdapter
            // 
            this.ТоварTableAdapter.ClearBeforeFill = true;
            // 
            // приходНомерDataGridViewTextBoxColumn
            // 
            this.приходНомерDataGridViewTextBoxColumn.DataPropertyName = "ПриходНомер";
            this.приходНомерDataGridViewTextBoxColumn.HeaderText = "ПриходНомер";
            this.приходНомерDataGridViewTextBoxColumn.Name = "приходНомерDataGridViewTextBoxColumn";
            this.приходНомерDataGridViewTextBoxColumn.ReadOnly = true;
            this.приходНомерDataGridViewTextBoxColumn.Visible = false;
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            // 
            // поставщикНомерDataGridViewTextBoxColumn
            // 
            this.поставщикНомерDataGridViewTextBoxColumn.DataPropertyName = "ПоставщикНомер";
            this.поставщикНомерDataGridViewTextBoxColumn.DataSource = this.поставщикBindingSource;
            this.поставщикНомерDataGridViewTextBoxColumn.DisplayMember = "Наименование";
            this.поставщикНомерDataGridViewTextBoxColumn.HeaderText = "Поставщик";
            this.поставщикНомерDataGridViewTextBoxColumn.Name = "поставщикНомерDataGridViewTextBoxColumn";
            this.поставщикНомерDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.поставщикНомерDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.поставщикНомерDataGridViewTextBoxColumn.ValueMember = "ПоставщикНомер";
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
            // frmIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 473);
            this.Controls.Add(this.panel1);
            this.Name = "frmIncome";
            this.Text = "Приходные накладные";
            this.Load += new System.EventHandler(this.frmIncome_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orgDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.приходBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ТоварBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.составПриходаBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private orgDataSet orgDataSet;
        private System.Windows.Forms.BindingSource приходBindingSource;
        private orgDataSetTableAdapters.ПриходTableAdapter приходTableAdapter;
        private System.Windows.Forms.BindingSource поставщикBindingSource;
        private orgDataSetTableAdapters.ПоставщикTableAdapter поставщикTableAdapter;
        private System.Windows.Forms.BindingSource сотрудникBindingSource;
        private orgDataSetTableAdapters.СотрудникTableAdapter сотрудникTableAdapter;
        private System.Windows.Forms.BindingSource составПриходаBindingSource;
        private orgDataSetTableAdapters.СоставПриходаTableAdapter составПриходаTableAdapter;
        private System.Windows.Forms.BindingSource ТоварBindingSource;
        private orgDataSetTableAdapters.ТоварTableAdapter ТоварTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn составНомерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ТоварНомерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn приходНомерDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.DataGridViewTextBoxColumn приходНомерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn поставщикНомерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn сотрудникНомерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn проведеноDataGridViewTextBoxColumn;
    }
}