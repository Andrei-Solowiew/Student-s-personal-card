
namespace WindowsFormsApp7
{
    partial class EditingCollegeDocumetsForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.номерПриказаОЗачисленииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСтудентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаЗаключенияДоговораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаПриказаОЗачисленииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.документыОтКолледжаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet = new WindowsFormsApp7._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet();
            this.документы_от_колледжаTableAdapter = new WindowsFormsApp7._СР_5_ОПБД_Соловьев_Андрей_П9021DataSetTableAdapters.Документы_от_колледжаTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.документыОтКолледжаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерПриказаОЗачисленииDataGridViewTextBoxColumn,
            this.кодСтудентаDataGridViewTextBoxColumn,
            this.датаЗаключенияДоговораDataGridViewTextBoxColumn,
            this.датаПриказаОЗачисленииDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.документыОтКолледжаBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, -1);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(674, 285);
            this.dataGridView1.TabIndex = 0;
            // 
            // номерПриказаОЗачисленииDataGridViewTextBoxColumn
            // 
            this.номерПриказаОЗачисленииDataGridViewTextBoxColumn.DataPropertyName = "Номер приказа о зачислении";
            this.номерПриказаОЗачисленииDataGridViewTextBoxColumn.HeaderText = "Номер приказа о зачислении";
            this.номерПриказаОЗачисленииDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.номерПриказаОЗачисленииDataGridViewTextBoxColumn.Name = "номерПриказаОЗачисленииDataGridViewTextBoxColumn";
            this.номерПриказаОЗачисленииDataGridViewTextBoxColumn.Width = 150;
            // 
            // кодСтудентаDataGridViewTextBoxColumn
            // 
            this.кодСтудентаDataGridViewTextBoxColumn.DataPropertyName = "Код студента";
            this.кодСтудентаDataGridViewTextBoxColumn.HeaderText = "Код студента";
            this.кодСтудентаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.кодСтудентаDataGridViewTextBoxColumn.Name = "кодСтудентаDataGridViewTextBoxColumn";
            this.кодСтудентаDataGridViewTextBoxColumn.Width = 150;
            // 
            // датаЗаключенияДоговораDataGridViewTextBoxColumn
            // 
            this.датаЗаключенияДоговораDataGridViewTextBoxColumn.DataPropertyName = "Дата заключения договора";
            this.датаЗаключенияДоговораDataGridViewTextBoxColumn.HeaderText = "Дата заключения договора";
            this.датаЗаключенияДоговораDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.датаЗаключенияДоговораDataGridViewTextBoxColumn.Name = "датаЗаключенияДоговораDataGridViewTextBoxColumn";
            this.датаЗаключенияДоговораDataGridViewTextBoxColumn.Width = 150;
            // 
            // датаПриказаОЗачисленииDataGridViewTextBoxColumn
            // 
            this.датаПриказаОЗачисленииDataGridViewTextBoxColumn.DataPropertyName = "Дата приказа о зачислении";
            this.датаПриказаОЗачисленииDataGridViewTextBoxColumn.HeaderText = "Дата приказа о зачислении";
            this.датаПриказаОЗачисленииDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.датаПриказаОЗачисленииDataGridViewTextBoxColumn.Name = "датаПриказаОЗачисленииDataGridViewTextBoxColumn";
            this.датаПриказаОЗачисленииDataGridViewTextBoxColumn.Width = 150;
            // 
            // документыОтКолледжаBindingSource
            // 
            this.документыОтКолледжаBindingSource.DataMember = "Документы от колледжа";
            this.документыОтКолледжаBindingSource.DataSource = this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet;
            // 
            // _СР_5_ОПБД_Соловьев_Андрей_П9021DataSet
            // 
            this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.DataSetName = "_СР_5_ОПБД_Соловьев_Андрей_П9021DataSet";
            this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // документы_от_колледжаTableAdapter
            // 
            this.документы_от_колледжаTableAdapter.ClearBeforeFill = true;
            // 
            // EditingCollegeDocumetsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 292);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditingCollegeDocumetsForm";
            this.Text = "EditingCollegeDocumetsForm";
            this.Load += new System.EventHandler(this.Form13_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.документыОтКолледжаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _СР_5_ОПБД_Соловьев_Андрей_П9021DataSet _СР_5_ОПБД_Соловьев_Андрей_П9021DataSet;
        private System.Windows.Forms.BindingSource документыОтКолледжаBindingSource;
        private _СР_5_ОПБД_Соловьев_Андрей_П9021DataSetTableAdapters.Документы_от_колледжаTableAdapter документы_от_колледжаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерПриказаОЗачисленииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСтудентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаЗаключенияДоговораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаПриказаОЗачисленииDataGridViewTextBoxColumn;
    }
}