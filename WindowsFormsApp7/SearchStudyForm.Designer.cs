
namespace WindowsFormsApp7
{
    partial class SearchStudyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchStudyForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодОбученияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.формаОбученияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.форматОбученияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.группаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.срокОбученияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСтудентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.обучениеСтудентаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бД3DataSet = new WindowsFormsApp7.БД3DataSet();
            this.StudentFormDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxKod = new System.Windows.Forms.TextBox();
            this.обучение_студентаTableAdapter = new WindowsFormsApp7.БД3DataSetTableAdapters.Обучение_студентаTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.обучениеСтудентаBindingSource)).BeginInit();
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
            this.кодОбученияDataGridViewTextBoxColumn,
            this.формаОбученияDataGridViewTextBoxColumn,
            this.форматОбученияDataGridViewTextBoxColumn,
            this.группаDataGridViewTextBoxColumn,
            this.срокОбученияDataGridViewTextBoxColumn,
            this.кодСтудентаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.обучениеСтудентаBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(37, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(808, 224);
            this.dataGridView1.TabIndex = 39;
            // 
            // кодОбученияDataGridViewTextBoxColumn
            // 
            this.кодОбученияDataGridViewTextBoxColumn.DataPropertyName = "Код обучения";
            this.кодОбученияDataGridViewTextBoxColumn.HeaderText = "Код обучения";
            this.кодОбученияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодОбученияDataGridViewTextBoxColumn.Name = "кодОбученияDataGridViewTextBoxColumn";
            this.кодОбученияDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодОбученияDataGridViewTextBoxColumn.Width = 125;
            // 
            // формаОбученияDataGridViewTextBoxColumn
            // 
            this.формаОбученияDataGridViewTextBoxColumn.DataPropertyName = "Форма обучения";
            this.формаОбученияDataGridViewTextBoxColumn.HeaderText = "Форма обучения";
            this.формаОбученияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.формаОбученияDataGridViewTextBoxColumn.Name = "формаОбученияDataGridViewTextBoxColumn";
            this.формаОбученияDataGridViewTextBoxColumn.ReadOnly = true;
            this.формаОбученияDataGridViewTextBoxColumn.Width = 125;
            // 
            // форматОбученияDataGridViewTextBoxColumn
            // 
            this.форматОбученияDataGridViewTextBoxColumn.DataPropertyName = "Формат обучения";
            this.форматОбученияDataGridViewTextBoxColumn.HeaderText = "Формат обучения";
            this.форматОбученияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.форматОбученияDataGridViewTextBoxColumn.Name = "форматОбученияDataGridViewTextBoxColumn";
            this.форматОбученияDataGridViewTextBoxColumn.ReadOnly = true;
            this.форматОбученияDataGridViewTextBoxColumn.Width = 125;
            // 
            // группаDataGridViewTextBoxColumn
            // 
            this.группаDataGridViewTextBoxColumn.DataPropertyName = "Группа";
            this.группаDataGridViewTextBoxColumn.HeaderText = "Группа";
            this.группаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.группаDataGridViewTextBoxColumn.Name = "группаDataGridViewTextBoxColumn";
            this.группаDataGridViewTextBoxColumn.ReadOnly = true;
            this.группаDataGridViewTextBoxColumn.Width = 125;
            // 
            // срокОбученияDataGridViewTextBoxColumn
            // 
            this.срокОбученияDataGridViewTextBoxColumn.DataPropertyName = "Срок обучения";
            this.срокОбученияDataGridViewTextBoxColumn.HeaderText = "Срок обучения";
            this.срокОбученияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.срокОбученияDataGridViewTextBoxColumn.Name = "срокОбученияDataGridViewTextBoxColumn";
            this.срокОбученияDataGridViewTextBoxColumn.ReadOnly = true;
            this.срокОбученияDataGridViewTextBoxColumn.Width = 125;
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
            // обучениеСтудентаBindingSource
            // 
            this.обучениеСтудентаBindingSource.DataMember = "Обучение студента";
            this.обучениеСтудентаBindingSource.DataSource = this.бД3DataSet;
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
            this.StudentFormDelete.TabIndex = 38;
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
            this.label7.TabIndex = 37;
            this.label7.Text = "Код студента";
            // 
            // textBoxKod
            // 
            this.textBoxKod.Location = new System.Drawing.Point(37, 54);
            this.textBoxKod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxKod.Name = "textBoxKod";
            this.textBoxKod.Size = new System.Drawing.Size(92, 20);
            this.textBoxKod.TabIndex = 36;
            // 
            // обучение_студентаTableAdapter
            // 
            this.обучение_студентаTableAdapter.ClearBeforeFill = true;
            // 
            // SearchStudyForm
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
            this.Name = "SearchStudyForm";
            this.Text = "SearchStudyForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchStudyForm_FormClosing);
            this.Load += new System.EventHandler(this.SearchStudyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.обучениеСтудентаBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource обучениеСтудентаBindingSource;
        private БД3DataSetTableAdapters.Обучение_студентаTableAdapter обучение_студентаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодОбученияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn формаОбученияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn форматОбученияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn группаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn срокОбученияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСтудентаDataGridViewTextBoxColumn;
    }
}