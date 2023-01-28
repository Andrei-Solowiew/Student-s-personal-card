
namespace WindowsFormsApp7
{
    partial class AddStudentForm
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
            this.Add = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAddToday = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAddBirthday = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAddNameFather = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAddName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAddSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAddKod = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.бД3DataSet = new WindowsFormsApp7.БД3DataSet();
            this.студентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.студентTableAdapter = new WindowsFormsApp7.БД3DataSetTableAdapters.СтудентTableAdapter();
            this.кодСтудентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияСтудентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяСтудентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоСтудентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаРожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сегодняшняяДатаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.Location = new System.Drawing.Point(256, 78);
            this.Add.Margin = new System.Windows.Forms.Padding(2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(329, 32);
            this.Add.TabIndex = 28;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(665, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Сегодняшняя дата";
            // 
            // textBoxAddToday
            // 
            this.textBoxAddToday.Location = new System.Drawing.Point(668, 35);
            this.textBoxAddToday.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAddToday.Name = "textBoxAddToday";
            this.textBoxAddToday.Size = new System.Drawing.Size(129, 20);
            this.textBoxAddToday.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(541, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Дата рождения";
            // 
            // textBoxAddBirthday
            // 
            this.textBoxAddBirthday.Location = new System.Drawing.Point(545, 35);
            this.textBoxAddBirthday.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAddBirthday.Name = "textBoxAddBirthday";
            this.textBoxAddBirthday.Size = new System.Drawing.Size(104, 20);
            this.textBoxAddBirthday.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(388, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Отчество студента";
            // 
            // textBoxAddNameFather
            // 
            this.textBoxAddNameFather.Location = new System.Drawing.Point(391, 35);
            this.textBoxAddNameFather.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAddNameFather.Name = "textBoxAddNameFather";
            this.textBoxAddNameFather.Size = new System.Drawing.Size(129, 20);
            this.textBoxAddNameFather.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(272, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Имя студента";
            // 
            // textBoxAddName
            // 
            this.textBoxAddName.Location = new System.Drawing.Point(275, 35);
            this.textBoxAddName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAddName.Name = "textBoxAddName";
            this.textBoxAddName.Size = new System.Drawing.Size(92, 20);
            this.textBoxAddName.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(124, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Фамилия студента";
            // 
            // textBoxAddSurname
            // 
            this.textBoxAddSurname.Location = new System.Drawing.Point(127, 35);
            this.textBoxAddSurname.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAddSurname.Name = "textBoxAddSurname";
            this.textBoxAddSurname.Size = new System.Drawing.Size(126, 20);
            this.textBoxAddSurname.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Код студента";
            // 
            // textBoxAddKod
            // 
            this.textBoxAddKod.Location = new System.Drawing.Point(19, 35);
            this.textBoxAddKod.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAddKod.Name = "textBoxAddKod";
            this.textBoxAddKod.Size = new System.Drawing.Size(94, 20);
            this.textBoxAddKod.TabIndex = 16;
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
            this.dataGridView1.DataSource = this.студентBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(19, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(778, 264);
            this.dataGridView1.TabIndex = 29;
            // 
            // бД3DataSet
            // 
            this.бД3DataSet.DataSetName = "БД3DataSet";
            this.бД3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // студентBindingSource
            // 
            this.студентBindingSource.DataMember = "Студент";
            this.студентBindingSource.DataSource = this.бД3DataSet;
            // 
            // студентTableAdapter
            // 
            this.студентTableAdapter.ClearBeforeFill = true;
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
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxAddToday);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxAddBirthday);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAddNameFather);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAddName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAddSurname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAddKod);
            this.Name = "AddStudentForm";
            this.Text = "AddStudentForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddStudentForm_FormClosing);
            this.Load += new System.EventHandler(this.AddStudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAddToday;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAddBirthday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAddNameFather;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAddName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAddSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAddKod;
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