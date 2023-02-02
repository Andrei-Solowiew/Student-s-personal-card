
namespace WindowsFormsApp7
{
    partial class AddDocumetsStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDocumetsStudent));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.паспортDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСтудентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.аттестатDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.гражданствоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.документыСтудентаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бД3DataSet = new WindowsFormsApp7.БД3DataSet();
            this.документы_студентаTableAdapter = new WindowsFormsApp7.БД3DataSetTableAdapters.Документы_студентаTableAdapter();
            this.textBoxPasport = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAttestat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCitezenship = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.textBoxKodStudent = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.документыСтудентаBindingSource)).BeginInit();
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
            this.паспортDataGridViewTextBoxColumn,
            this.кодСтудентаDataGridViewTextBoxColumn,
            this.аттестатDataGridViewTextBoxColumn,
            this.гражданствоDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.документыСтудентаBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(37, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(731, 227);
            this.dataGridView1.TabIndex = 102;
            // 
            // паспортDataGridViewTextBoxColumn
            // 
            this.паспортDataGridViewTextBoxColumn.DataPropertyName = "Паспорт";
            this.паспортDataGridViewTextBoxColumn.HeaderText = "Паспорт";
            this.паспортDataGridViewTextBoxColumn.Name = "паспортDataGridViewTextBoxColumn";
            this.паспортDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кодСтудентаDataGridViewTextBoxColumn
            // 
            this.кодСтудентаDataGridViewTextBoxColumn.DataPropertyName = "Код студента";
            this.кодСтудентаDataGridViewTextBoxColumn.HeaderText = "Код студента";
            this.кодСтудентаDataGridViewTextBoxColumn.Name = "кодСтудентаDataGridViewTextBoxColumn";
            this.кодСтудентаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // аттестатDataGridViewTextBoxColumn
            // 
            this.аттестатDataGridViewTextBoxColumn.DataPropertyName = "Аттестат";
            this.аттестатDataGridViewTextBoxColumn.HeaderText = "Аттестат";
            this.аттестатDataGridViewTextBoxColumn.Name = "аттестатDataGridViewTextBoxColumn";
            this.аттестатDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // гражданствоDataGridViewTextBoxColumn
            // 
            this.гражданствоDataGridViewTextBoxColumn.DataPropertyName = "Гражданство";
            this.гражданствоDataGridViewTextBoxColumn.HeaderText = "Гражданство";
            this.гражданствоDataGridViewTextBoxColumn.Name = "гражданствоDataGridViewTextBoxColumn";
            this.гражданствоDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // документыСтудентаBindingSource
            // 
            this.документыСтудентаBindingSource.DataMember = "Документы студента";
            this.документыСтудентаBindingSource.DataSource = this.бД3DataSet;
            // 
            // бД3DataSet
            // 
            this.бД3DataSet.DataSetName = "БД3DataSet";
            this.бД3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // документы_студентаTableAdapter
            // 
            this.документы_студентаTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxPasport
            // 
            this.textBoxPasport.Location = new System.Drawing.Point(37, 41);
            this.textBoxPasport.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPasport.Name = "textBoxPasport";
            this.textBoxPasport.Size = new System.Drawing.Size(61, 20);
            this.textBoxPasport.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(34, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 90;
            this.label1.Text = "Паспорт";
            // 
            // textBoxAttestat
            // 
            this.textBoxAttestat.Location = new System.Drawing.Point(227, 42);
            this.textBoxAttestat.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAttestat.Name = "textBoxAttestat";
            this.textBoxAttestat.Size = new System.Drawing.Size(65, 20);
            this.textBoxAttestat.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(224, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 92;
            this.label2.Text = "Аттестат";
            // 
            // textBoxCitezenship
            // 
            this.textBoxCitezenship.Location = new System.Drawing.Point(308, 41);
            this.textBoxCitezenship.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCitezenship.Name = "textBoxCitezenship";
            this.textBoxCitezenship.Size = new System.Drawing.Size(91, 20);
            this.textBoxCitezenship.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(305, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 94;
            this.label3.Text = "Гражданство";
            // 
            // Add
            // 
            this.Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.Location = new System.Drawing.Point(37, 94);
            this.Add.Margin = new System.Windows.Forms.Padding(2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(362, 32);
            this.Add.TabIndex = 5;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // textBoxKodStudent
            // 
            this.textBoxKodStudent.Location = new System.Drawing.Point(116, 42);
            this.textBoxKodStudent.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKodStudent.Name = "textBoxKodStudent";
            this.textBoxKodStudent.Size = new System.Drawing.Size(94, 20);
            this.textBoxKodStudent.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(113, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 101;
            this.label6.Text = "Код студента";
            // 
            // AddDocumetsStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxKodStudent);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCitezenship);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAttestat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPasport);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddDocumetsStudent";
            this.Text = "AddDocumetsStudent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddDocumetsStudent_FormClosing);
            this.Load += new System.EventHandler(this.AddDocumetsStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.документыСтудентаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД3DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private БД3DataSet бД3DataSet;
        private System.Windows.Forms.BindingSource документыСтудентаBindingSource;
        private БД3DataSetTableAdapters.Документы_студентаTableAdapter документы_студентаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn паспортDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСтудентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn аттестатDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn гражданствоDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBoxPasport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAttestat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCitezenship;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox textBoxKodStudent;
        private System.Windows.Forms.Label label6;
    }
}