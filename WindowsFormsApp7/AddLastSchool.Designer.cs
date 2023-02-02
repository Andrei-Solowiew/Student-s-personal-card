
namespace WindowsFormsApp7
{
    partial class AddLastSchool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddLastSchool));
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxEdLevel = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUZ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKodLast = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxKodStudent = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодКонтактныхДанныхОПрошломУЗDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.учебноеЗаведениеУЗDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годОкончанияУЗDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.уровеньОбразованияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСтудентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.данныеОПрошломУЗBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бД3DataSet = new WindowsFormsApp7.БД3DataSet();
            this.данные_о_прошлом_УЗTableAdapter = new WindowsFormsApp7.БД3DataSetTableAdapters.Данные_о_прошлом_УЗTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.данныеОПрошломУЗBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД3DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(358, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 112;
            this.label3.Text = "Год окончания";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(361, 44);
            this.textBoxYear.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(104, 20);
            this.textBoxYear.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(481, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 17);
            this.label6.TabIndex = 110;
            this.label6.Text = "Уровен образования";
            // 
            // textBoxEdLevel
            // 
            this.textBoxEdLevel.Location = new System.Drawing.Point(484, 44);
            this.textBoxEdLevel.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEdLevel.Name = "textBoxEdLevel";
            this.textBoxEdLevel.Size = new System.Drawing.Size(143, 20);
            this.textBoxEdLevel.TabIndex = 4;
            // 
            // Add
            // 
            this.Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.Location = new System.Drawing.Point(227, 108);
            this.Add.Margin = new System.Windows.Forms.Padding(2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(329, 32);
            this.Add.TabIndex = 6;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(200, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 107;
            this.label2.Text = "Учебное заведение";
            // 
            // textBoxUZ
            // 
            this.textBoxUZ.Location = new System.Drawing.Point(203, 44);
            this.textBoxUZ.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUZ.Name = "textBoxUZ";
            this.textBoxUZ.Size = new System.Drawing.Size(136, 20);
            this.textBoxUZ.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(55, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 105;
            this.label1.Text = "Код прошлого УЗ";
            // 
            // textBoxKodLast
            // 
            this.textBoxKodLast.Location = new System.Drawing.Point(58, 44);
            this.textBoxKodLast.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKodLast.Name = "textBoxKodLast";
            this.textBoxKodLast.Size = new System.Drawing.Size(120, 20);
            this.textBoxKodLast.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(644, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 114;
            this.label4.Text = "Код студента";
            // 
            // textBoxKodStudent
            // 
            this.textBoxKodStudent.Location = new System.Drawing.Point(647, 44);
            this.textBoxKodStudent.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKodStudent.Name = "textBoxKodStudent";
            this.textBoxKodStudent.Size = new System.Drawing.Size(94, 20);
            this.textBoxKodStudent.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодКонтактныхДанныхОПрошломУЗDataGridViewTextBoxColumn,
            this.учебноеЗаведениеУЗDataGridViewTextBoxColumn,
            this.годОкончанияУЗDataGridViewTextBoxColumn,
            this.уровеньОбразованияDataGridViewTextBoxColumn,
            this.кодСтудентаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.данныеОПрошломУЗBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(58, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(683, 212);
            this.dataGridView1.TabIndex = 115;
            // 
            // кодКонтактныхДанныхОПрошломУЗDataGridViewTextBoxColumn
            // 
            this.кодКонтактныхДанныхОПрошломУЗDataGridViewTextBoxColumn.DataPropertyName = "Код контактных данных о прошлом УЗ";
            this.кодКонтактныхДанныхОПрошломУЗDataGridViewTextBoxColumn.HeaderText = "Код контактных данных о прошлом УЗ";
            this.кодКонтактныхДанныхОПрошломУЗDataGridViewTextBoxColumn.Name = "кодКонтактныхДанныхОПрошломУЗDataGridViewTextBoxColumn";
            this.кодКонтактныхДанныхОПрошломУЗDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодКонтактныхДанныхОПрошломУЗDataGridViewTextBoxColumn.Width = 200;
            // 
            // учебноеЗаведениеУЗDataGridViewTextBoxColumn
            // 
            this.учебноеЗаведениеУЗDataGridViewTextBoxColumn.DataPropertyName = "Учебное заведение(УЗ)";
            this.учебноеЗаведениеУЗDataGridViewTextBoxColumn.HeaderText = "Учебное заведение(УЗ)";
            this.учебноеЗаведениеУЗDataGridViewTextBoxColumn.Name = "учебноеЗаведениеУЗDataGridViewTextBoxColumn";
            this.учебноеЗаведениеУЗDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // годОкончанияУЗDataGridViewTextBoxColumn
            // 
            this.годОкончанияУЗDataGridViewTextBoxColumn.DataPropertyName = "Год окончания УЗ";
            this.годОкончанияУЗDataGridViewTextBoxColumn.HeaderText = "Год окончания УЗ";
            this.годОкончанияУЗDataGridViewTextBoxColumn.Name = "годОкончанияУЗDataGridViewTextBoxColumn";
            this.годОкончанияУЗDataGridViewTextBoxColumn.ReadOnly = true;
            this.годОкончанияУЗDataGridViewTextBoxColumn.Width = 125;
            // 
            // уровеньОбразованияDataGridViewTextBoxColumn
            // 
            this.уровеньОбразованияDataGridViewTextBoxColumn.DataPropertyName = "Уровень образования";
            this.уровеньОбразованияDataGridViewTextBoxColumn.HeaderText = "Уровень образования";
            this.уровеньОбразованияDataGridViewTextBoxColumn.Name = "уровеньОбразованияDataGridViewTextBoxColumn";
            this.уровеньОбразованияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кодСтудентаDataGridViewTextBoxColumn
            // 
            this.кодСтудентаDataGridViewTextBoxColumn.DataPropertyName = "Код студента";
            this.кодСтудентаDataGridViewTextBoxColumn.HeaderText = "Код студента";
            this.кодСтудентаDataGridViewTextBoxColumn.Name = "кодСтудентаDataGridViewTextBoxColumn";
            this.кодСтудентаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // данныеОПрошломУЗBindingSource
            // 
            this.данныеОПрошломУЗBindingSource.DataMember = "Данные о прошлом УЗ";
            this.данныеОПрошломУЗBindingSource.DataSource = this.бД3DataSet;
            // 
            // бД3DataSet
            // 
            this.бД3DataSet.DataSetName = "БД3DataSet";
            this.бД3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // данные_о_прошлом_УЗTableAdapter
            // 
            this.данные_о_прошлом_УЗTableAdapter.ClearBeforeFill = true;
            // 
            // AddLastSchool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxKodStudent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxEdLevel);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxUZ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKodLast);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddLastSchool";
            this.Text = "AddLastSchool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddLastSchool_FormClosing);
            this.Load += new System.EventHandler(this.AddLastSchool_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.данныеОПрошломУЗBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД3DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxEdLevel;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUZ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKodLast;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxKodStudent;
        private System.Windows.Forms.DataGridView dataGridView1;
        private БД3DataSet бД3DataSet;
        private System.Windows.Forms.BindingSource данныеОПрошломУЗBindingSource;
        private БД3DataSetTableAdapters.Данные_о_прошлом_УЗTableAdapter данные_о_прошлом_УЗTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКонтактныхДанныхОПрошломУЗDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn учебноеЗаведениеУЗDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn годОкончанияУЗDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn уровеньОбразованияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСтудентаDataGridViewTextBoxColumn;
    }
}