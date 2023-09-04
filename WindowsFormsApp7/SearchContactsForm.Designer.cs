
namespace WindowsFormsApp7
{
    partial class SearchContactsForm
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
            this.StudentFormDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxKod = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.бД3DataSet = new WindowsFormsApp7.БД3DataSet();
            this.контактныеДанныеСтудентаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.контактные_данные_студентаTableAdapter = new WindowsFormsApp7.БД3DataSetTableAdapters.Контактные_данные_студентаTableAdapter();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСтудентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имейлDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.контактныеДанныеСтудентаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentFormDelete
            // 
            this.StudentFormDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StudentFormDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentFormDelete.Location = new System.Drawing.Point(34, 98);
            this.StudentFormDelete.Margin = new System.Windows.Forms.Padding(2);
            this.StudentFormDelete.Name = "StudentFormDelete";
            this.StudentFormDelete.Size = new System.Drawing.Size(191, 36);
            this.StudentFormDelete.TabIndex = 61;
            this.StudentFormDelete.Text = "Найти";
            this.StudentFormDelete.UseVisualStyleBackColor = true;
            this.StudentFormDelete.Click += new System.EventHandler(this.StudentFormDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(31, 37);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 17);
            this.label7.TabIndex = 60;
            this.label7.Text = "Код студента";
            // 
            // textBoxKod
            // 
            this.textBoxKod.Location = new System.Drawing.Point(34, 55);
            this.textBoxKod.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKod.Name = "textBoxKod";
            this.textBoxKod.Size = new System.Drawing.Size(92, 20);
            this.textBoxKod.TabIndex = 59;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.телефонDataGridViewTextBoxColumn,
            this.кодСтудентаDataGridViewTextBoxColumn,
            this.имейлDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.контактныеДанныеСтудентаBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(34, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(734, 150);
            this.dataGridView1.TabIndex = 62;
            // 
            // бД3DataSet
            // 
            this.бД3DataSet.DataSetName = "БД3DataSet";
            this.бД3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // контактныеДанныеСтудентаBindingSource
            // 
            this.контактныеДанныеСтудентаBindingSource.DataMember = "Контактные данные студента";
            this.контактныеДанныеСтудентаBindingSource.DataSource = this.бД3DataSet;
            // 
            // контактные_данные_студентаTableAdapter
            // 
            this.контактные_данные_студентаTableAdapter.ClearBeforeFill = true;
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            // 
            // кодСтудентаDataGridViewTextBoxColumn
            // 
            this.кодСтудентаDataGridViewTextBoxColumn.DataPropertyName = "Код студента";
            this.кодСтудентаDataGridViewTextBoxColumn.HeaderText = "Код студента";
            this.кодСтудентаDataGridViewTextBoxColumn.Name = "кодСтудентаDataGridViewTextBoxColumn";
            // 
            // имейлDataGridViewTextBoxColumn
            // 
            this.имейлDataGridViewTextBoxColumn.DataPropertyName = "Имейл";
            this.имейлDataGridViewTextBoxColumn.HeaderText = "Имейл";
            this.имейлDataGridViewTextBoxColumn.Name = "имейлDataGridViewTextBoxColumn";
            // 
            // SearchContactsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.StudentFormDelete);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxKod);
            this.Name = "SearchContactsForm";
            this.Text = "SearchContactsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchContactsForm_FormClosing);
            this.Load += new System.EventHandler(this.SearchContactsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.контактныеДанныеСтудентаBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StudentFormDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxKod;
        private System.Windows.Forms.DataGridView dataGridView1;
        private БД3DataSet бД3DataSet;
        private System.Windows.Forms.BindingSource контактныеДанныеСтудентаBindingSource;
        private БД3DataSetTableAdapters.Контактные_данные_студентаTableAdapter контактные_данные_студентаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСтудентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имейлDataGridViewTextBoxColumn;
    }
}