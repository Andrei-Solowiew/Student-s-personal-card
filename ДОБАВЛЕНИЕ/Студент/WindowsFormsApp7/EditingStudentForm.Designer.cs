
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
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxUpdateToday = new System.Windows.Forms.TextBox();
            this.StudentFormChange = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxKodStudentChange = new System.Windows.Forms.TextBox();
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
            this.dataGridView1.Size = new System.Drawing.Size(979, 274);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодСтудентаDataGridViewTextBoxColumn
            // 
            this.кодСтудентаDataGridViewTextBoxColumn.DataPropertyName = "Код студента";
            this.кодСтудентаDataGridViewTextBoxColumn.HeaderText = "Код студента";
            this.кодСтудентаDataGridViewTextBoxColumn.Name = "кодСтудентаDataGridViewTextBoxColumn";
            this.кодСтудентаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // фамилияСтудентаDataGridViewTextBoxColumn
            // 
            this.фамилияСтудентаDataGridViewTextBoxColumn.DataPropertyName = "Фамилия студента";
            this.фамилияСтудентаDataGridViewTextBoxColumn.HeaderText = "Фамилия студента";
            this.фамилияСтудентаDataGridViewTextBoxColumn.Name = "фамилияСтудентаDataGridViewTextBoxColumn";
            this.фамилияСтудентаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // имяСтудентаDataGridViewTextBoxColumn
            // 
            this.имяСтудентаDataGridViewTextBoxColumn.DataPropertyName = "Имя студента";
            this.имяСтудентаDataGridViewTextBoxColumn.HeaderText = "Имя студента";
            this.имяСтудентаDataGridViewTextBoxColumn.Name = "имяСтудентаDataGridViewTextBoxColumn";
            this.имяСтудентаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // отчествоСтудентаDataGridViewTextBoxColumn
            // 
            this.отчествоСтудентаDataGridViewTextBoxColumn.DataPropertyName = "Отчество студента";
            this.отчествоСтудентаDataGridViewTextBoxColumn.HeaderText = "Отчество студента";
            this.отчествоСтудентаDataGridViewTextBoxColumn.Name = "отчествоСтудентаDataGridViewTextBoxColumn";
            this.отчествоСтудентаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаРожденияDataGridViewTextBoxColumn
            // 
            this.датаРожденияDataGridViewTextBoxColumn.DataPropertyName = "Дата рождения";
            this.датаРожденияDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.датаРожденияDataGridViewTextBoxColumn.Name = "датаРожденияDataGridViewTextBoxColumn";
            this.датаРожденияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // сегодняшняяДатаDataGridViewTextBoxColumn
            // 
            this.сегодняшняяДатаDataGridViewTextBoxColumn.DataPropertyName = "Сегодняшняя дата";
            this.сегодняшняяДатаDataGridViewTextBoxColumn.HeaderText = "Сегодняшняя дата";
            this.сегодняшняяДатаDataGridViewTextBoxColumn.Name = "сегодняшняяДатаDataGridViewTextBoxColumn";
            this.сегодняшняяДатаDataGridViewTextBoxColumn.ReadOnly = true;
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(136, 13);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Сегодняшняя дата";
            // 
            // textBoxUpdateToday
            // 
            this.textBoxUpdateToday.Location = new System.Drawing.Point(139, 32);
            this.textBoxUpdateToday.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUpdateToday.Name = "textBoxUpdateToday";
            this.textBoxUpdateToday.Size = new System.Drawing.Size(76, 20);
            this.textBoxUpdateToday.TabIndex = 25;
            // 
            // StudentFormChange
            // 
            this.StudentFormChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StudentFormChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentFormChange.Location = new System.Drawing.Point(11, 69);
            this.StudentFormChange.Margin = new System.Windows.Forms.Padding(2);
            this.StudentFormChange.Name = "StudentFormChange";
            this.StudentFormChange.Size = new System.Drawing.Size(329, 32);
            this.StudentFormChange.TabIndex = 24;
            this.StudentFormChange.Text = "Изменить";
            this.StudentFormChange.UseVisualStyleBackColor = true;
            this.StudentFormChange.Click += new System.EventHandler(this.StudentFormChange_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 13);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Код студента";
            // 
            // textBoxKodStudentChange
            // 
            this.textBoxKodStudentChange.Location = new System.Drawing.Point(15, 32);
            this.textBoxKodStudentChange.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKodStudentChange.Name = "textBoxKodStudentChange";
            this.textBoxKodStudentChange.Size = new System.Drawing.Size(76, 20);
            this.textBoxKodStudentChange.TabIndex = 22;
            // 
            // студентTableAdapter1
            // 
            this.студентTableAdapter1.ClearBeforeFill = true;
            // 
            // EditingStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 414);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxUpdateToday);
            this.Controls.Add(this.StudentFormChange);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxKodStudentChange);
            this.Controls.Add(this.dataGridView1);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _СР_5_ОПБД_Соловьев_Андрей_П9021DataSet _СР_5_ОПБД_Соловьев_Андрей_П9021DataSet;
        private System.Windows.Forms.BindingSource студентBindingSource;
        private _СР_5_ОПБД_Соловьев_Андрей_П9021DataSetTableAdapters.СтудентTableAdapter студентTableAdapter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxUpdateToday;
        private System.Windows.Forms.Button StudentFormChange;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxKodStudentChange;
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