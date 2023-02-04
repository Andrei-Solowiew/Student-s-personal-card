
namespace WindowsFormsApp7
{
    partial class EditingStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditingStudentForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодСтудентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияСтудентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяСтудентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоСтудентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаРожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сегодняшняяДатаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.студентBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.бД3DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бД3DataSet = new WindowsFormsApp7.БД3DataSet();
            this.студентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet = new WindowsFormsApp7._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet();
            this.студентTableAdapter = new WindowsFormsApp7._СР_5_ОПБД_Соловьев_Андрей_П9021DataSetTableAdapters.СтудентTableAdapter();
            this.StudentFormChange = new System.Windows.Forms.Button();
            this.студентTableAdapter1 = new WindowsFormsApp7.БД3DataSetTableAdapters.СтудентTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД3DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодСтудентаDataGridViewTextBoxColumn,
            this.фамилияСтудентаDataGridViewTextBoxColumn,
            this.имяСтудентаDataGridViewTextBoxColumn,
            this.отчествоСтудентаDataGridViewTextBoxColumn,
            this.датаРожденияDataGridViewTextBoxColumn,
            this.сегодняшняяДатаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.студентBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(11, 144);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(979, 361);
            this.dataGridView1.TabIndex = 100;
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
            // фамилияСтудентаDataGridViewTextBoxColumn
            // 
            this.фамилияСтудентаDataGridViewTextBoxColumn.DataPropertyName = "Фамилия студента";
            this.фамилияСтудентаDataGridViewTextBoxColumn.HeaderText = "Фамилия студента";
            this.фамилияСтудентаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фамилияСтудентаDataGridViewTextBoxColumn.Name = "фамилияСтудентаDataGridViewTextBoxColumn";
            this.фамилияСтудентаDataGridViewTextBoxColumn.ReadOnly = true;
            this.фамилияСтудентаDataGridViewTextBoxColumn.Width = 125;
            // 
            // имяСтудентаDataGridViewTextBoxColumn
            // 
            this.имяСтудентаDataGridViewTextBoxColumn.DataPropertyName = "Имя студента";
            this.имяСтудентаDataGridViewTextBoxColumn.HeaderText = "Имя студента";
            this.имяСтудентаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.имяСтудентаDataGridViewTextBoxColumn.Name = "имяСтудентаDataGridViewTextBoxColumn";
            this.имяСтудентаDataGridViewTextBoxColumn.ReadOnly = true;
            this.имяСтудентаDataGridViewTextBoxColumn.Width = 125;
            // 
            // отчествоСтудентаDataGridViewTextBoxColumn
            // 
            this.отчествоСтудентаDataGridViewTextBoxColumn.DataPropertyName = "Отчество студента";
            this.отчествоСтудентаDataGridViewTextBoxColumn.HeaderText = "Отчество студента";
            this.отчествоСтудентаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.отчествоСтудентаDataGridViewTextBoxColumn.Name = "отчествоСтудентаDataGridViewTextBoxColumn";
            this.отчествоСтудентаDataGridViewTextBoxColumn.ReadOnly = true;
            this.отчествоСтудентаDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаРожденияDataGridViewTextBoxColumn
            // 
            this.датаРожденияDataGridViewTextBoxColumn.DataPropertyName = "Дата рождения";
            this.датаРожденияDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.датаРожденияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаРожденияDataGridViewTextBoxColumn.Name = "датаРожденияDataGridViewTextBoxColumn";
            this.датаРожденияDataGridViewTextBoxColumn.ReadOnly = true;
            this.датаРожденияDataGridViewTextBoxColumn.Width = 125;
            // 
            // сегодняшняяДатаDataGridViewTextBoxColumn
            // 
            this.сегодняшняяДатаDataGridViewTextBoxColumn.DataPropertyName = "Сегодняшняя дата";
            this.сегодняшняяДатаDataGridViewTextBoxColumn.HeaderText = "Сегодняшняя дата";
            this.сегодняшняяДатаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.сегодняшняяДатаDataGridViewTextBoxColumn.Name = "сегодняшняяДатаDataGridViewTextBoxColumn";
            this.сегодняшняяДатаDataGridViewTextBoxColumn.ReadOnly = true;
            this.сегодняшняяДатаDataGridViewTextBoxColumn.Width = 125;
            // 
            // студентBindingSource1
            // 
            this.студентBindingSource1.DataMember = "Студент";
            this.студентBindingSource1.DataSource = this.бД3DataSetBindingSource;
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
            // студентBindingSource
            // 
            this.студентBindingSource.DataMember = "Студент";
            this.студентBindingSource.DataSource = this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet;
            // 
            // _СР_5_ОПБД_Соловьев_Андрей_П9021DataSet
            // 
            this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.DataSetName = "_СР_5_ОПБД_Соловьев_Андрей_П9021DataSet";
            this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // студентTableAdapter
            // 
            this.студентTableAdapter.ClearBeforeFill = true;
            // 
            // StudentFormChange
            // 
            this.StudentFormChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StudentFormChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentFormChange.Location = new System.Drawing.Point(317, 64);
            this.StudentFormChange.Margin = new System.Windows.Forms.Padding(2);
            this.StudentFormChange.Name = "StudentFormChange";
            this.StudentFormChange.Size = new System.Drawing.Size(329, 32);
            this.StudentFormChange.TabIndex = 24;
            this.StudentFormChange.Text = "Изменить сегодняшнюю дату";
            this.StudentFormChange.UseVisualStyleBackColor = true;
            this.StudentFormChange.Click += new System.EventHandler(this.StudentFormChange_Click);
            // 
            // студентTableAdapter1
            // 
            this.студентTableAdapter1.ClearBeforeFill = true;
            // 
            // EditingStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 516);
            this.Controls.Add(this.StudentFormChange);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditingStudentForm";
            this.Text = "EditingStudentForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditingStudentForm_FormClosing);
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД3DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _СР_5_ОПБД_Соловьев_Андрей_П9021DataSet _СР_5_ОПБД_Соловьев_Андрей_П9021DataSet;
        private System.Windows.Forms.BindingSource студентBindingSource;
        private _СР_5_ОПБД_Соловьев_Андрей_П9021DataSetTableAdapters.СтудентTableAdapter студентTableAdapter;
        private System.Windows.Forms.Button StudentFormChange;
        private System.Windows.Forms.BindingSource бД3DataSetBindingSource;
        private БД3DataSet бД3DataSet;
        private System.Windows.Forms.BindingSource студентBindingSource1;
        private БД3DataSetTableAdapters.СтудентTableAdapter студентTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСтудентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияСтудентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяСтудентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоСтудентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаРожденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сегодняшняяДатаDataGridViewTextBoxColumn;
    }
}