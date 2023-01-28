
namespace WindowsFormsApp7
{
    partial class EditingStudentDocumetsForm
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
            this.паспортDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСтудентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.аттестатDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.гражданствоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.документыСтудентаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet = new WindowsFormsApp7._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet();
            this.документы_студентаTableAdapter = new WindowsFormsApp7._СР_5_ОПБД_Соловьев_Андрей_П9021DataSetTableAdapters.Документы_студентаTableAdapter();
            this.бД3DataSet = new WindowsFormsApp7.БД3DataSet();
            this.документыСтудентаBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.документы_студентаTableAdapter1 = new WindowsFormsApp7.БД3DataSetTableAdapters.Документы_студентаTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.документыСтудентаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.документыСтудентаBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.паспортDataGridViewTextBoxColumn,
            this.кодСтудентаDataGridViewTextBoxColumn,
            this.аттестатDataGridViewTextBoxColumn,
            this.гражданствоDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.документыСтудентаBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(11, 135);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(739, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // паспортDataGridViewTextBoxColumn
            // 
            this.паспортDataGridViewTextBoxColumn.DataPropertyName = "Паспорт";
            this.паспортDataGridViewTextBoxColumn.HeaderText = "Паспорт";
            this.паспортDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.паспортDataGridViewTextBoxColumn.Name = "паспортDataGridViewTextBoxColumn";
            this.паспортDataGridViewTextBoxColumn.ReadOnly = true;
            this.паспортDataGridViewTextBoxColumn.Width = 150;
            // 
            // кодСтудентаDataGridViewTextBoxColumn
            // 
            this.кодСтудентаDataGridViewTextBoxColumn.DataPropertyName = "Код студента";
            this.кодСтудентаDataGridViewTextBoxColumn.HeaderText = "Код студента";
            this.кодСтудентаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.кодСтудентаDataGridViewTextBoxColumn.Name = "кодСтудентаDataGridViewTextBoxColumn";
            this.кодСтудентаDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодСтудентаDataGridViewTextBoxColumn.Width = 150;
            // 
            // аттестатDataGridViewTextBoxColumn
            // 
            this.аттестатDataGridViewTextBoxColumn.DataPropertyName = "Аттестат";
            this.аттестатDataGridViewTextBoxColumn.HeaderText = "Аттестат";
            this.аттестатDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.аттестатDataGridViewTextBoxColumn.Name = "аттестатDataGridViewTextBoxColumn";
            this.аттестатDataGridViewTextBoxColumn.ReadOnly = true;
            this.аттестатDataGridViewTextBoxColumn.Width = 150;
            // 
            // гражданствоDataGridViewTextBoxColumn
            // 
            this.гражданствоDataGridViewTextBoxColumn.DataPropertyName = "Гражданство";
            this.гражданствоDataGridViewTextBoxColumn.HeaderText = "Гражданство";
            this.гражданствоDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.гражданствоDataGridViewTextBoxColumn.Name = "гражданствоDataGridViewTextBoxColumn";
            this.гражданствоDataGridViewTextBoxColumn.ReadOnly = true;
            this.гражданствоDataGridViewTextBoxColumn.Width = 150;
            // 
            // документыСтудентаBindingSource
            // 
            this.документыСтудентаBindingSource.DataMember = "Документы студента";
            this.документыСтудентаBindingSource.DataSource = this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet;
            // 
            // _СР_5_ОПБД_Соловьев_Андрей_П9021DataSet
            // 
            this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.DataSetName = "_СР_5_ОПБД_Соловьев_Андрей_П9021DataSet";
            this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // документы_студентаTableAdapter
            // 
            this.документы_студентаTableAdapter.ClearBeforeFill = true;
            // 
            // бД3DataSet
            // 
            this.бД3DataSet.DataSetName = "БД3DataSet";
            this.бД3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // документыСтудентаBindingSource1
            // 
            this.документыСтудентаBindingSource1.DataMember = "Документы студента";
            this.документыСтудентаBindingSource1.DataSource = this.бД3DataSet;
            // 
            // документы_студентаTableAdapter1
            // 
            this.документы_студентаTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(115, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Данная функция не предусмотрена для этой таблицы";
            // 
            // EditingStudentDocumetsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 292);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditingStudentDocumetsForm";
            this.Text = "EditingStudentDocumetsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditingStudentDocumetsForm_FormClosing);
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.документыСтудентаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.документыСтудентаBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _СР_5_ОПБД_Соловьев_Андрей_П9021DataSet _СР_5_ОПБД_Соловьев_Андрей_П9021DataSet;
        private System.Windows.Forms.BindingSource документыСтудентаBindingSource;
        private _СР_5_ОПБД_Соловьев_Андрей_П9021DataSetTableAdapters.Документы_студентаTableAdapter документы_студентаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn паспортDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСтудентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn аттестатDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn гражданствоDataGridViewTextBoxColumn;
        private БД3DataSet бД3DataSet;
        private System.Windows.Forms.BindingSource документыСтудентаBindingSource1;
        private БД3DataSetTableAdapters.Документы_студентаTableAdapter документы_студентаTableAdapter1;
        private System.Windows.Forms.Label label1;
    }
}