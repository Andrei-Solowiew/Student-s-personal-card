
namespace WindowsFormsApp7
{
    partial class AddDocumetsCollege
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDocumetsCollege));
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxKodStudent = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDataContract = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDataOrder = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.номерПриказаОЗачисленииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСтудентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаЗаключенияДоговораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаПриказаОЗачисленииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.документыОтКолледжаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бД3DataSet = new WindowsFormsApp7.БД3DataSet();
            this.документы_от_колледжаTableAdapter = new WindowsFormsApp7.БД3DataSetTableAdapters.Документы_от_колледжаTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.документыОтКолледжаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД3DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(249, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 101;
            this.label6.Text = "Код студента";
            // 
            // textBoxKodStudent
            // 
            this.textBoxKodStudent.Location = new System.Drawing.Point(252, 43);
            this.textBoxKodStudent.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKodStudent.Name = "textBoxKodStudent";
            this.textBoxKodStudent.Size = new System.Drawing.Size(94, 20);
            this.textBoxKodStudent.TabIndex = 2;
            // 
            // Add
            // 
            this.Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.Location = new System.Drawing.Point(227, 106);
            this.Add.Margin = new System.Windows.Forms.Padding(2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(329, 32);
            this.Add.TabIndex = 5;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(365, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 17);
            this.label2.TabIndex = 92;
            this.label2.Text = "Дата заключения договора";
            // 
            // textBoxDataContract
            // 
            this.textBoxDataContract.Location = new System.Drawing.Point(368, 43);
            this.textBoxDataContract.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDataContract.Name = "textBoxDataContract";
            this.textBoxDataContract.Size = new System.Drawing.Size(187, 20);
            this.textBoxDataContract.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 17);
            this.label1.TabIndex = 90;
            this.label1.Text = "Номер приказа о зачислении";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(30, 43);
            this.textBoxNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(200, 20);
            this.textBoxNumber.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(575, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 17);
            this.label3.TabIndex = 103;
            this.label3.Text = "Дата приказа о зачислении";
            // 
            // textBoxDataOrder
            // 
            this.textBoxDataOrder.Location = new System.Drawing.Point(578, 43);
            this.textBoxDataOrder.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDataOrder.Name = "textBoxDataOrder";
            this.textBoxDataOrder.Size = new System.Drawing.Size(191, 20);
            this.textBoxDataOrder.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерПриказаОЗачисленииDataGridViewTextBoxColumn,
            this.кодСтудентаDataGridViewTextBoxColumn,
            this.датаЗаключенияДоговораDataGridViewTextBoxColumn,
            this.датаПриказаОЗачисленииDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.документыОтКолледжаBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(739, 225);
            this.dataGridView1.TabIndex = 104;
            // 
            // номерПриказаОЗачисленииDataGridViewTextBoxColumn
            // 
            this.номерПриказаОЗачисленииDataGridViewTextBoxColumn.DataPropertyName = "Номер приказа о зачислении";
            this.номерПриказаОЗачисленииDataGridViewTextBoxColumn.HeaderText = "Номер приказа о зачислении";
            this.номерПриказаОЗачисленииDataGridViewTextBoxColumn.Name = "номерПриказаОЗачисленииDataGridViewTextBoxColumn";
            this.номерПриказаОЗачисленииDataGridViewTextBoxColumn.ReadOnly = true;
            this.номерПриказаОЗачисленииDataGridViewTextBoxColumn.Width = 200;
            // 
            // кодСтудентаDataGridViewTextBoxColumn
            // 
            this.кодСтудентаDataGridViewTextBoxColumn.DataPropertyName = "Код студента";
            this.кодСтудентаDataGridViewTextBoxColumn.HeaderText = "Код студента";
            this.кодСтудентаDataGridViewTextBoxColumn.Name = "кодСтудентаDataGridViewTextBoxColumn";
            this.кодСтудентаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаЗаключенияДоговораDataGridViewTextBoxColumn
            // 
            this.датаЗаключенияДоговораDataGridViewTextBoxColumn.DataPropertyName = "Дата заключения договора";
            this.датаЗаключенияДоговораDataGridViewTextBoxColumn.HeaderText = "Дата заключения договора";
            this.датаЗаключенияДоговораDataGridViewTextBoxColumn.Name = "датаЗаключенияДоговораDataGridViewTextBoxColumn";
            this.датаЗаключенияДоговораDataGridViewTextBoxColumn.ReadOnly = true;
            this.датаЗаключенияДоговораDataGridViewTextBoxColumn.Width = 175;
            // 
            // датаПриказаОЗачисленииDataGridViewTextBoxColumn
            // 
            this.датаПриказаОЗачисленииDataGridViewTextBoxColumn.DataPropertyName = "Дата приказа о зачислении";
            this.датаПриказаОЗачисленииDataGridViewTextBoxColumn.HeaderText = "Дата приказа о зачислении";
            this.датаПриказаОЗачисленииDataGridViewTextBoxColumn.Name = "датаПриказаОЗачисленииDataGridViewTextBoxColumn";
            this.датаПриказаОЗачисленииDataGridViewTextBoxColumn.ReadOnly = true;
            this.датаПриказаОЗачисленииDataGridViewTextBoxColumn.Width = 175;
            // 
            // документыОтКолледжаBindingSource
            // 
            this.документыОтКолледжаBindingSource.DataMember = "Документы от колледжа";
            this.документыОтКолледжаBindingSource.DataSource = this.бД3DataSet;
            // 
            // бД3DataSet
            // 
            this.бД3DataSet.DataSetName = "БД3DataSet";
            this.бД3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // документы_от_колледжаTableAdapter
            // 
            this.документы_от_колледжаTableAdapter.ClearBeforeFill = true;
            // 
            // AddDocumetsCollege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDataOrder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxKodStudent);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDataContract);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddDocumetsCollege";
            this.Text = "AddDocumetsCollege";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddDocumetsCollege_FormClosing);
            this.Load += new System.EventHandler(this.AddDocumetsCollege_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.документыОтКолледжаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД3DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxKodStudent;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDataContract;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDataOrder;
        private System.Windows.Forms.DataGridView dataGridView1;
        private БД3DataSet бД3DataSet;
        private System.Windows.Forms.BindingSource документыОтКолледжаBindingSource;
        private БД3DataSetTableAdapters.Документы_от_колледжаTableAdapter документы_от_колледжаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерПриказаОЗачисленииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСтудентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаЗаключенияДоговораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаПриказаОЗачисленииDataGridViewTextBoxColumn;
    }
}