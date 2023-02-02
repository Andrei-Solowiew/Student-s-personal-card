
namespace WindowsFormsApp7
{
    partial class SearchStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchStudentForm));
            this.label1 = new System.Windows.Forms.Label();
            this.StudentFormDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодСтудентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияСтудентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяСтудентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоСтудентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаРожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сегодняшняяДатаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.студентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бД3DataSet = new WindowsFormsApp7.БД3DataSet();
            this.студентTableAdapter = new WindowsFormsApp7.БД3DataSetTableAdapters.СтудентTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД3DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(-134, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 26);
            this.label1.TabIndex = 3;
            // 
            // StudentFormDelete
            // 
            this.StudentFormDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StudentFormDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentFormDelete.Location = new System.Drawing.Point(33, 99);
            this.StudentFormDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StudentFormDelete.Name = "StudentFormDelete";
            this.StudentFormDelete.Size = new System.Drawing.Size(191, 36);
            this.StudentFormDelete.TabIndex = 22;
            this.StudentFormDelete.Text = "Найти";
            this.StudentFormDelete.UseVisualStyleBackColor = true;
            this.StudentFormDelete.Click += new System.EventHandler(this.StudentFormDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(30, 38);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Фамилия студента";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(33, 57);
            this.textBoxSurname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(127, 20);
            this.textBoxSurname.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодСтудентаDataGridViewTextBoxColumn,
            this.фамилияСтудентаDataGridViewTextBoxColumn,
            this.имяСтудентаDataGridViewTextBoxColumn,
            this.отчествоСтудентаDataGridViewTextBoxColumn,
            this.датаРожденияDataGridViewTextBoxColumn,
            this.сегодняшняяДатаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.студентBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(33, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(739, 224);
            this.dataGridView1.TabIndex = 23;
            // 
            // кодСтудентаDataGridViewTextBoxColumn
            // 
            this.кодСтудентаDataGridViewTextBoxColumn.DataPropertyName = "Код студента";
            this.кодСтудентаDataGridViewTextBoxColumn.HeaderText = "Код студента";
            this.кодСтудентаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодСтудентаDataGridViewTextBoxColumn.Name = "кодСтудентаDataGridViewTextBoxColumn";
            this.кодСтудентаDataGridViewTextBoxColumn.Width = 125;
            // 
            // фамилияСтудентаDataGridViewTextBoxColumn
            // 
            this.фамилияСтудентаDataGridViewTextBoxColumn.DataPropertyName = "Фамилия студента";
            this.фамилияСтудентаDataGridViewTextBoxColumn.HeaderText = "Фамилия студента";
            this.фамилияСтудентаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фамилияСтудентаDataGridViewTextBoxColumn.Name = "фамилияСтудентаDataGridViewTextBoxColumn";
            this.фамилияСтудентаDataGridViewTextBoxColumn.Width = 125;
            // 
            // имяСтудентаDataGridViewTextBoxColumn
            // 
            this.имяСтудентаDataGridViewTextBoxColumn.DataPropertyName = "Имя студента";
            this.имяСтудентаDataGridViewTextBoxColumn.HeaderText = "Имя студента";
            this.имяСтудентаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.имяСтудентаDataGridViewTextBoxColumn.Name = "имяСтудентаDataGridViewTextBoxColumn";
            this.имяСтудентаDataGridViewTextBoxColumn.Width = 125;
            // 
            // отчествоСтудентаDataGridViewTextBoxColumn
            // 
            this.отчествоСтудентаDataGridViewTextBoxColumn.DataPropertyName = "Отчество студента";
            this.отчествоСтудентаDataGridViewTextBoxColumn.HeaderText = "Отчество студента";
            this.отчествоСтудентаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.отчествоСтудентаDataGridViewTextBoxColumn.Name = "отчествоСтудентаDataGridViewTextBoxColumn";
            this.отчествоСтудентаDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаРожденияDataGridViewTextBoxColumn
            // 
            this.датаРожденияDataGridViewTextBoxColumn.DataPropertyName = "Дата рождения";
            this.датаРожденияDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.датаРожденияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаРожденияDataGridViewTextBoxColumn.Name = "датаРожденияDataGridViewTextBoxColumn";
            this.датаРожденияDataGridViewTextBoxColumn.Width = 125;
            // 
            // сегодняшняяДатаDataGridViewTextBoxColumn
            // 
            this.сегодняшняяДатаDataGridViewTextBoxColumn.DataPropertyName = "Сегодняшняя дата";
            this.сегодняшняяДатаDataGridViewTextBoxColumn.HeaderText = "Сегодняшняя дата";
            this.сегодняшняяДатаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.сегодняшняяДатаDataGridViewTextBoxColumn.Name = "сегодняшняяДатаDataGridViewTextBoxColumn";
            this.сегодняшняяДатаDataGridViewTextBoxColumn.Width = 125;
            // 
            // студентBindingSource
            // 
            this.студентBindingSource.DataMember = "Студент";
            this.студентBindingSource.DataSource = this.бД3DataSet;
            // 
            // бД3DataSet
            // 
            this.бД3DataSet.DataSetName = "БД3DataSet";
            this.бД3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // студентTableAdapter
            // 
            this.студентTableAdapter.ClearBeforeFill = true;
            // 
            // SearchStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 413);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.StudentFormDelete);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SearchStudentForm";
            this.Text = "Search_form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Search_form_FormClosing);
            this.Load += new System.EventHandler(this.Search_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД3DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StudentFormDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private БД3DataSet бД3DataSet;
        private System.Windows.Forms.BindingSource студентBindingSource;
        private БД3DataSetTableAdapters.СтудентTableAdapter студентTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСтудентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияСтудентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяСтудентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоСтудентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаРожденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сегодняшняяДатаDataGridViewTextBoxColumn;
    }
}