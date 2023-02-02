
namespace WindowsFormsApp7
{
    partial class AddFamilyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFamilyForm));
            this.Add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxChildren = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxReason = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCompleteness = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKodFamily = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDataChildren = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPlace = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxToday = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxKodStudenta = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодСемьиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.полнаяЛиСемьяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.причинаНеполнотыСемьиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоДетейDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаРожденияКаждогоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.гдеЖивутдомКвартираDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сегодняшняяДатаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСтудентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.семьяBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бД3DataSet = new WindowsFormsApp7.БД3DataSet();
            this.семьяTableAdapter = new WindowsFormsApp7.БД3DataSetTableAdapters.СемьяTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.семьяBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД3DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.Location = new System.Drawing.Point(319, 132);
            this.Add.Margin = new System.Windows.Forms.Padding(2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(329, 32);
            this.Add.TabIndex = 9;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(425, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Количество детей";
            // 
            // textBoxChildren
            // 
            this.textBoxChildren.Location = new System.Drawing.Point(428, 34);
            this.textBoxChildren.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxChildren.Name = "textBoxChildren";
            this.textBoxChildren.Size = new System.Drawing.Size(129, 20);
            this.textBoxChildren.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(234, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Причина неплноты семьи";
            // 
            // textBoxReason
            // 
            this.textBoxReason.Location = new System.Drawing.Point(237, 34);
            this.textBoxReason.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxReason.Name = "textBoxReason";
            this.textBoxReason.Size = new System.Drawing.Size(175, 20);
            this.textBoxReason.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(100, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Полная ли семья";
            // 
            // textBoxCompleteness
            // 
            this.textBoxCompleteness.Location = new System.Drawing.Point(103, 34);
            this.textBoxCompleteness.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCompleteness.Name = "textBoxCompleteness";
            this.textBoxCompleteness.Size = new System.Drawing.Size(118, 20);
            this.textBoxCompleteness.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Код семьи";
            // 
            // textBoxKodFamily
            // 
            this.textBoxKodFamily.Location = new System.Drawing.Point(11, 34);
            this.textBoxKodFamily.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKodFamily.Name = "textBoxKodFamily";
            this.textBoxKodFamily.Size = new System.Drawing.Size(73, 20);
            this.textBoxKodFamily.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(567, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "Дата рождения каждого";
            // 
            // textBoxDataChildren
            // 
            this.textBoxDataChildren.Location = new System.Drawing.Point(570, 34);
            this.textBoxDataChildren.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDataChildren.Name = "textBoxDataChildren";
            this.textBoxDataChildren.Size = new System.Drawing.Size(165, 20);
            this.textBoxDataChildren.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(745, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 17);
            this.label6.TabIndex = 45;
            this.label6.Text = "Где живут(дом, квартира)";
            // 
            // textBoxPlace
            // 
            this.textBoxPlace.Location = new System.Drawing.Point(748, 34);
            this.textBoxPlace.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPlace.Name = "textBoxPlace";
            this.textBoxPlace.Size = new System.Drawing.Size(173, 20);
            this.textBoxPlace.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(335, 69);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 17);
            this.label7.TabIndex = 47;
            this.label7.Text = "Сегодняшняя дата";
            // 
            // textBoxToday
            // 
            this.textBoxToday.Location = new System.Drawing.Point(338, 87);
            this.textBoxToday.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxToday.Name = "textBoxToday";
            this.textBoxToday.Size = new System.Drawing.Size(129, 20);
            this.textBoxToday.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(515, 69);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 17);
            this.label8.TabIndex = 49;
            this.label8.Text = "Код студента";
            // 
            // textBoxKodStudenta
            // 
            this.textBoxKodStudenta.Location = new System.Drawing.Point(518, 87);
            this.textBoxKodStudenta.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKodStudenta.Name = "textBoxKodStudenta";
            this.textBoxKodStudenta.Size = new System.Drawing.Size(94, 20);
            this.textBoxKodStudenta.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодСемьиDataGridViewTextBoxColumn,
            this.полнаяЛиСемьяDataGridViewTextBoxColumn,
            this.причинаНеполнотыСемьиDataGridViewTextBoxColumn,
            this.количествоДетейDataGridViewTextBoxColumn,
            this.датаРожденияКаждогоDataGridViewTextBoxColumn,
            this.гдеЖивутдомКвартираDataGridViewTextBoxColumn,
            this.сегодняшняяДатаDataGridViewTextBoxColumn,
            this.кодСтудентаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.семьяBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(888, 217);
            this.dataGridView1.TabIndex = 500;
            // 
            // кодСемьиDataGridViewTextBoxColumn
            // 
            this.кодСемьиDataGridViewTextBoxColumn.DataPropertyName = "Код семьи";
            this.кодСемьиDataGridViewTextBoxColumn.HeaderText = "Код семьи";
            this.кодСемьиDataGridViewTextBoxColumn.Name = "кодСемьиDataGridViewTextBoxColumn";
            this.кодСемьиDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодСемьиDataGridViewTextBoxColumn.Width = 75;
            // 
            // полнаяЛиСемьяDataGridViewTextBoxColumn
            // 
            this.полнаяЛиСемьяDataGridViewTextBoxColumn.DataPropertyName = "Полная ли семья";
            this.полнаяЛиСемьяDataGridViewTextBoxColumn.HeaderText = "Полная ли семья";
            this.полнаяЛиСемьяDataGridViewTextBoxColumn.Name = "полнаяЛиСемьяDataGridViewTextBoxColumn";
            this.полнаяЛиСемьяDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // причинаНеполнотыСемьиDataGridViewTextBoxColumn
            // 
            this.причинаНеполнотыСемьиDataGridViewTextBoxColumn.DataPropertyName = "Причина неполноты семьи";
            this.причинаНеполнотыСемьиDataGridViewTextBoxColumn.HeaderText = "Причина неполноты семьи";
            this.причинаНеполнотыСемьиDataGridViewTextBoxColumn.Name = "причинаНеполнотыСемьиDataGridViewTextBoxColumn";
            this.причинаНеполнотыСемьиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // количествоДетейDataGridViewTextBoxColumn
            // 
            this.количествоДетейDataGridViewTextBoxColumn.DataPropertyName = "Количество детей";
            this.количествоДетейDataGridViewTextBoxColumn.HeaderText = "Количество детей";
            this.количествоДетейDataGridViewTextBoxColumn.Name = "количествоДетейDataGridViewTextBoxColumn";
            this.количествоДетейDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаРожденияКаждогоDataGridViewTextBoxColumn
            // 
            this.датаРожденияКаждогоDataGridViewTextBoxColumn.DataPropertyName = "Дата рождения каждого";
            this.датаРожденияКаждогоDataGridViewTextBoxColumn.HeaderText = "Дата рождения каждого";
            this.датаРожденияКаждогоDataGridViewTextBoxColumn.Name = "датаРожденияКаждогоDataGridViewTextBoxColumn";
            this.датаРожденияКаждогоDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // гдеЖивутдомКвартираDataGridViewTextBoxColumn
            // 
            this.гдеЖивутдомКвартираDataGridViewTextBoxColumn.DataPropertyName = "Где живут(дом, квартира)";
            this.гдеЖивутдомКвартираDataGridViewTextBoxColumn.HeaderText = "Где живут(дом, квартира)";
            this.гдеЖивутдомКвартираDataGridViewTextBoxColumn.Name = "гдеЖивутдомКвартираDataGridViewTextBoxColumn";
            this.гдеЖивутдомКвартираDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // сегодняшняяДатаDataGridViewTextBoxColumn
            // 
            this.сегодняшняяДатаDataGridViewTextBoxColumn.DataPropertyName = "Сегодняшняя дата";
            this.сегодняшняяДатаDataGridViewTextBoxColumn.HeaderText = "Сегодняшняя дата";
            this.сегодняшняяДатаDataGridViewTextBoxColumn.Name = "сегодняшняяДатаDataGridViewTextBoxColumn";
            this.сегодняшняяДатаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кодСтудентаDataGridViewTextBoxColumn
            // 
            this.кодСтудентаDataGridViewTextBoxColumn.DataPropertyName = "Код студента";
            this.кодСтудентаDataGridViewTextBoxColumn.HeaderText = "Код студента";
            this.кодСтудентаDataGridViewTextBoxColumn.Name = "кодСтудентаDataGridViewTextBoxColumn";
            this.кодСтудентаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // семьяBindingSource
            // 
            this.семьяBindingSource.DataMember = "Семья";
            this.семьяBindingSource.DataSource = this.бД3DataSet;
            // 
            // бД3DataSet
            // 
            this.бД3DataSet.DataSetName = "БД3DataSet";
            this.бД3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // семьяTableAdapter
            // 
            this.семьяTableAdapter.ClearBeforeFill = true;
            // 
            // AddFamilyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxKodStudenta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxToday);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPlace);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDataChildren);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxChildren);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxReason);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCompleteness);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKodFamily);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddFamilyForm";
            this.Text = "AddFamilyForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddFamilyForm_FormClosing);
            this.Load += new System.EventHandler(this.AddFamilyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.семьяBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД3DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxChildren;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxReason;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCompleteness;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKodFamily;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDataChildren;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPlace;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxToday;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxKodStudenta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private БД3DataSet бД3DataSet;
        private System.Windows.Forms.BindingSource семьяBindingSource;
        private БД3DataSetTableAdapters.СемьяTableAdapter семьяTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСемьиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn полнаяЛиСемьяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn причинаНеполнотыСемьиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоДетейDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаРожденияКаждогоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn гдеЖивутдомКвартираDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сегодняшняяДатаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСтудентаDataGridViewTextBoxColumn;
    }
}