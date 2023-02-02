﻿
namespace WindowsFormsApp7
{
    partial class SearchDocumentsCollegeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchDocumentsCollegeForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.номерПриказаОЗачисленииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСтудентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаЗаключенияДоговораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаПриказаОЗачисленииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.документыОтКолледжаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бД3DataSet = new WindowsFormsApp7.БД3DataSet();
            this.StudentFormDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxKod = new System.Windows.Forms.TextBox();
            this.документы_от_колледжаTableAdapter = new WindowsFormsApp7.БД3DataSetTableAdapters.Документы_от_колледжаTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.документыОтКолледжаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД3DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерПриказаОЗачисленииDataGridViewTextBoxColumn,
            this.кодСтудентаDataGridViewTextBoxColumn,
            this.датаЗаключенияДоговораDataGridViewTextBoxColumn,
            this.датаПриказаОЗачисленииDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.документыОтКолледжаBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(37, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(808, 224);
            this.dataGridView1.TabIndex = 59;
            // 
            // номерПриказаОЗачисленииDataGridViewTextBoxColumn
            // 
            this.номерПриказаОЗачисленииDataGridViewTextBoxColumn.DataPropertyName = "Номер приказа о зачислении";
            this.номерПриказаОЗачисленииDataGridViewTextBoxColumn.HeaderText = "Номер приказа о зачислении";
            this.номерПриказаОЗачисленииDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерПриказаОЗачисленииDataGridViewTextBoxColumn.Name = "номерПриказаОЗачисленииDataGridViewTextBoxColumn";
            this.номерПриказаОЗачисленииDataGridViewTextBoxColumn.ReadOnly = true;
            this.номерПриказаОЗачисленииDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодСтудентаDataGridViewTextBoxColumn
            // 
            this.кодСтудентаDataGridViewTextBoxColumn.DataPropertyName = "Код студента";
            this.кодСтудентаDataGridViewTextBoxColumn.HeaderText = "Код студента";
            this.кодСтудентаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодСтудентаDataGridViewTextBoxColumn.Name = "кодСтудентаDataGridViewTextBoxColumn";
            this.кодСтудентаDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодСтудентаDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаЗаключенияДоговораDataGridViewTextBoxColumn
            // 
            this.датаЗаключенияДоговораDataGridViewTextBoxColumn.DataPropertyName = "Дата заключения договора";
            this.датаЗаключенияДоговораDataGridViewTextBoxColumn.HeaderText = "Дата заключения договора";
            this.датаЗаключенияДоговораDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаЗаключенияДоговораDataGridViewTextBoxColumn.Name = "датаЗаключенияДоговораDataGridViewTextBoxColumn";
            this.датаЗаключенияДоговораDataGridViewTextBoxColumn.ReadOnly = true;
            this.датаЗаключенияДоговораDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаПриказаОЗачисленииDataGridViewTextBoxColumn
            // 
            this.датаПриказаОЗачисленииDataGridViewTextBoxColumn.DataPropertyName = "Дата приказа о зачислении";
            this.датаПриказаОЗачисленииDataGridViewTextBoxColumn.HeaderText = "Дата приказа о зачислении";
            this.датаПриказаОЗачисленииDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаПриказаОЗачисленииDataGridViewTextBoxColumn.Name = "датаПриказаОЗачисленииDataGridViewTextBoxColumn";
            this.датаПриказаОЗачисленииDataGridViewTextBoxColumn.ReadOnly = true;
            this.датаПриказаОЗачисленииDataGridViewTextBoxColumn.Width = 125;
            // 
            // документыОтКолледжаBindingSource
            // 
            this.документыОтКолледжаBindingSource.DataMember = "Документы от колледжа";
            this.документыОтКолледжаBindingSource.DataSource = this.бД3DataSet;
            // 
            // бД3DataSet
            // 
            this.бД3DataSet.DataSetName = "БД3DataSet";
            this.бД3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // StudentFormDelete
            // 
            this.StudentFormDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StudentFormDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentFormDelete.Location = new System.Drawing.Point(37, 97);
            this.StudentFormDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StudentFormDelete.Name = "StudentFormDelete";
            this.StudentFormDelete.Size = new System.Drawing.Size(191, 36);
            this.StudentFormDelete.TabIndex = 58;
            this.StudentFormDelete.Text = "Найти";
            this.StudentFormDelete.UseVisualStyleBackColor = true;
            this.StudentFormDelete.Click += new System.EventHandler(this.StudentFormDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(34, 36);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 17);
            this.label7.TabIndex = 57;
            this.label7.Text = "Код студента";
            // 
            // textBoxKod
            // 
            this.textBoxKod.Location = new System.Drawing.Point(37, 54);
            this.textBoxKod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxKod.Name = "textBoxKod";
            this.textBoxKod.Size = new System.Drawing.Size(92, 20);
            this.textBoxKod.TabIndex = 56;
            // 
            // документы_от_колледжаTableAdapter
            // 
            this.документы_от_колледжаTableAdapter.ClearBeforeFill = true;
            // 
            // SearchDocumentsCollegeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 413);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.StudentFormDelete);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxKod);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SearchDocumentsCollegeForm";
            this.Text = "SearchDocumentsCollegeForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchDocumentsCollegeForm_FormClosing);
            this.Load += new System.EventHandler(this.SearchDocumentsCollegeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.документыОтКолледжаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД3DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button StudentFormDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxKod;
        private БД3DataSet бД3DataSet;
        private System.Windows.Forms.BindingSource документыОтКолледжаBindingSource;
        private БД3DataSetTableAdapters.Документы_от_колледжаTableAdapter документы_от_колледжаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерПриказаОЗачисленииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСтудентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаЗаключенияДоговораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаПриказаОЗачисленииDataGridViewTextBoxColumn;
    }
}