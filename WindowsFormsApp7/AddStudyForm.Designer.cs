
namespace WindowsFormsApp7
{
    partial class AddStudyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudyForm));
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTerm = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxGroup = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFormat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxForm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKodStudy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxKodStudent = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодОбученияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.формаОбученияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.форматОбученияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.группаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.срокОбученияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСтудентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.обучениеСтудентаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бД3DataSet = new WindowsFormsApp7.БД3DataSet();
            this.обучение_студентаTableAdapter = new WindowsFormsApp7.БД3DataSetTableAdapters.Обучение_студентаTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.обучениеСтудентаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД3DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(616, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 60;
            this.label5.Text = "Срок обучения";
            // 
            // textBoxTerm
            // 
            this.textBoxTerm.Location = new System.Drawing.Point(619, 43);
            this.textBoxTerm.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTerm.Name = "textBoxTerm";
            this.textBoxTerm.Size = new System.Drawing.Size(104, 20);
            this.textBoxTerm.TabIndex = 5;
            // 
            // Add
            // 
            this.Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.Location = new System.Drawing.Point(323, 105);
            this.Add.Margin = new System.Windows.Forms.Padding(2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(329, 32);
            this.Add.TabIndex = 7;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(527, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 57;
            this.label4.Text = "Группа";
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.Location = new System.Drawing.Point(530, 43);
            this.textBoxGroup.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.Size = new System.Drawing.Size(52, 20);
            this.textBoxGroup.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(352, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 55;
            this.label3.Text = "Формат обучения";
            // 
            // textBoxFormat
            // 
            this.textBoxFormat.Location = new System.Drawing.Point(355, 43);
            this.textBoxFormat.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFormat.Name = "textBoxFormat";
            this.textBoxFormat.Size = new System.Drawing.Size(125, 20);
            this.textBoxFormat.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(187, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 53;
            this.label2.Text = "Форма обучения";
            // 
            // textBoxForm
            // 
            this.textBoxForm.Location = new System.Drawing.Point(190, 43);
            this.textBoxForm.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxForm.Name = "textBoxForm";
            this.textBoxForm.Size = new System.Drawing.Size(118, 20);
            this.textBoxForm.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(44, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 51;
            this.label1.Text = "Код обучения";
            // 
            // textBoxKodStudy
            // 
            this.textBoxKodStudy.Location = new System.Drawing.Point(47, 43);
            this.textBoxKodStudy.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKodStudy.Name = "textBoxKodStudy";
            this.textBoxKodStudy.Size = new System.Drawing.Size(97, 20);
            this.textBoxKodStudy.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(758, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 62;
            this.label6.Text = "Код студента";
            // 
            // textBoxKodStudent
            // 
            this.textBoxKodStudent.Location = new System.Drawing.Point(761, 43);
            this.textBoxKodStudent.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKodStudent.Name = "textBoxKodStudent";
            this.textBoxKodStudent.Size = new System.Drawing.Size(94, 20);
            this.textBoxKodStudent.TabIndex = 6;
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
            this.dataGridView1.Location = new System.Drawing.Point(47, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(808, 227);
            this.dataGridView1.TabIndex = 63;
            // 
            // кодОбученияDataGridViewTextBoxColumn
            // 
            this.кодОбученияDataGridViewTextBoxColumn.DataPropertyName = "Код обучения";
            this.кодОбученияDataGridViewTextBoxColumn.HeaderText = "Код обучения";
            this.кодОбученияDataGridViewTextBoxColumn.Name = "кодОбученияDataGridViewTextBoxColumn";
            this.кодОбученияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // формаОбученияDataGridViewTextBoxColumn
            // 
            this.формаОбученияDataGridViewTextBoxColumn.DataPropertyName = "Форма обучения";
            this.формаОбученияDataGridViewTextBoxColumn.HeaderText = "Форма обучения";
            this.формаОбученияDataGridViewTextBoxColumn.Name = "формаОбученияDataGridViewTextBoxColumn";
            this.формаОбученияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // форматОбученияDataGridViewTextBoxColumn
            // 
            this.форматОбученияDataGridViewTextBoxColumn.DataPropertyName = "Формат обучения";
            this.форматОбученияDataGridViewTextBoxColumn.HeaderText = "Формат обучения";
            this.форматОбученияDataGridViewTextBoxColumn.Name = "форматОбученияDataGridViewTextBoxColumn";
            this.форматОбученияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // группаDataGridViewTextBoxColumn
            // 
            this.группаDataGridViewTextBoxColumn.DataPropertyName = "Группа";
            this.группаDataGridViewTextBoxColumn.HeaderText = "Группа";
            this.группаDataGridViewTextBoxColumn.Name = "группаDataGridViewTextBoxColumn";
            this.группаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // срокОбученияDataGridViewTextBoxColumn
            // 
            this.срокОбученияDataGridViewTextBoxColumn.DataPropertyName = "Срок обучения";
            this.срокОбученияDataGridViewTextBoxColumn.HeaderText = "Срок обучения";
            this.срокОбученияDataGridViewTextBoxColumn.Name = "срокОбученияDataGridViewTextBoxColumn";
            this.срокОбученияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кодСтудентаDataGridViewTextBoxColumn
            // 
            this.кодСтудентаDataGridViewTextBoxColumn.DataPropertyName = "Код студента";
            this.кодСтудентаDataGridViewTextBoxColumn.HeaderText = "Код студента";
            this.кодСтудентаDataGridViewTextBoxColumn.Name = "кодСтудентаDataGridViewTextBoxColumn";
            this.кодСтудентаDataGridViewTextBoxColumn.ReadOnly = true;
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
            // обучение_студентаTableAdapter
            // 
            this.обучение_студентаTableAdapter.ClearBeforeFill = true;
            // 
            // AddStudyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxKodStudent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTerm);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxGroup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFormat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKodStudy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddStudyForm";
            this.Text = "AddStudyForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddStudyForm_FormClosing);
            this.Load += new System.EventHandler(this.AddStudyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.обучениеСтудентаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД3DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTerm;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFormat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKodStudy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxKodStudent;
        private System.Windows.Forms.DataGridView dataGridView1;
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