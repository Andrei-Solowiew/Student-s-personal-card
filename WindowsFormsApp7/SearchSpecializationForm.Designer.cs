
namespace WindowsFormsApp7
{
    partial class SearchSpecializationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchSpecializationForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодСпециальностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.специальностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСтудентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.специальностьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бД3DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бД3DataSet = new WindowsFormsApp7.БД3DataSet();
            this.StudentFormDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxKod = new System.Windows.Forms.TextBox();
            this.специальностьTableAdapter = new WindowsFormsApp7.БД3DataSetTableAdapters.СпециальностьTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.специальностьBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД3DataSetBindingSource)).BeginInit();
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
            this.кодСпециальностиDataGridViewTextBoxColumn,
            this.специальностьDataGridViewTextBoxColumn,
            this.кодСтудентаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.специальностьBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(34, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(739, 224);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // кодСпециальностиDataGridViewTextBoxColumn
            // 
            this.кодСпециальностиDataGridViewTextBoxColumn.DataPropertyName = "Код специальности";
            this.кодСпециальностиDataGridViewTextBoxColumn.HeaderText = "Код специальности";
            this.кодСпециальностиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодСпециальностиDataGridViewTextBoxColumn.Name = "кодСпециальностиDataGridViewTextBoxColumn";
            this.кодСпециальностиDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодСпециальностиDataGridViewTextBoxColumn.Width = 125;
            // 
            // специальностьDataGridViewTextBoxColumn
            // 
            this.специальностьDataGridViewTextBoxColumn.DataPropertyName = "Специальность";
            this.специальностьDataGridViewTextBoxColumn.HeaderText = "Специальность";
            this.специальностьDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.специальностьDataGridViewTextBoxColumn.Name = "специальностьDataGridViewTextBoxColumn";
            this.специальностьDataGridViewTextBoxColumn.ReadOnly = true;
            this.специальностьDataGridViewTextBoxColumn.Width = 125;
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
            // специальностьBindingSource
            // 
            this.специальностьBindingSource.DataMember = "Специальность";
            this.специальностьBindingSource.DataSource = this.бД3DataSetBindingSource;
            // 
            // бД3DataSetBindingSource
            // 
            this.бД3DataSetBindingSource.DataSource = this.бД3DataSet;
            this.бД3DataSetBindingSource.Position = 0;
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
            this.StudentFormDelete.Location = new System.Drawing.Point(34, 97);
            this.StudentFormDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StudentFormDelete.Name = "StudentFormDelete";
            this.StudentFormDelete.Size = new System.Drawing.Size(191, 36);
            this.StudentFormDelete.TabIndex = 26;
            this.StudentFormDelete.Text = "Найти";
            this.StudentFormDelete.UseVisualStyleBackColor = true;
            this.StudentFormDelete.Click += new System.EventHandler(this.StudentFormDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(31, 36);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Код студента";
            // 
            // textBoxKod
            // 
            this.textBoxKod.Location = new System.Drawing.Point(34, 54);
            this.textBoxKod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxKod.Name = "textBoxKod";
            this.textBoxKod.Size = new System.Drawing.Size(92, 20);
            this.textBoxKod.TabIndex = 24;
            // 
            // специальностьTableAdapter
            // 
            this.специальностьTableAdapter.ClearBeforeFill = true;
            // 
            // SearchSpecializationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 413);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.StudentFormDelete);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxKod);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SearchSpecializationForm";
            this.Text = "SearchSpecializationForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchSpecializationForm_FormClosing);
            this.Load += new System.EventHandler(this.SearchSpecializationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.специальностьBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД3DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД3DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button StudentFormDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxKod;
        private System.Windows.Forms.BindingSource бД3DataSetBindingSource;
        private БД3DataSet бД3DataSet;
        private System.Windows.Forms.BindingSource специальностьBindingSource;
        private БД3DataSetTableAdapters.СпециальностьTableAdapter специальностьTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСпециальностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn специальностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСтудентаDataGridViewTextBoxColumn;
    }
}