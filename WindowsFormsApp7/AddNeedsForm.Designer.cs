
namespace WindowsFormsApp7
{
    partial class AddNeedsForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxKodStudent = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLanguage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKodNeeds = new System.Windows.Forms.TextBox();
            this.checkBoxNeeds = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.бД3DataSet = new WindowsFormsApp7.БД3DataSet();
            this.потребностиСтудентаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.потребности_студентаTableAdapter = new WindowsFormsApp7.БД3DataSetTableAdapters.Потребности_студентаTableAdapter();
            this.кодПотребностейDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.языкDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.потребностьВОбщежитииDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.кодСтудентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.потребностиСтудентаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(444, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 112;
            this.label3.Text = "Код студента";
            // 
            // textBoxKodStudent
            // 
            this.textBoxKodStudent.Location = new System.Drawing.Point(447, 42);
            this.textBoxKodStudent.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKodStudent.Name = "textBoxKodStudent";
            this.textBoxKodStudent.Size = new System.Drawing.Size(94, 20);
            this.textBoxKodStudent.TabIndex = 111;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(175, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 110;
            this.label6.Text = "Язык";
            // 
            // Add
            // 
            this.Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.Location = new System.Drawing.Point(114, 103);
            this.Add.Margin = new System.Windows.Forms.Padding(2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(329, 32);
            this.Add.TabIndex = 108;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(250, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 17);
            this.label2.TabIndex = 107;
            this.label2.Text = "Потребность в общежитии";
            // 
            // textBoxLanguage
            // 
            this.textBoxLanguage.Location = new System.Drawing.Point(178, 42);
            this.textBoxLanguage.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLanguage.Name = "textBoxLanguage";
            this.textBoxLanguage.Size = new System.Drawing.Size(39, 20);
            this.textBoxLanguage.TabIndex = 106;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 105;
            this.label1.Text = "Код потребностей";
            // 
            // textBoxKodNeeds
            // 
            this.textBoxKodNeeds.Location = new System.Drawing.Point(30, 42);
            this.textBoxKodNeeds.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKodNeeds.Name = "textBoxKodNeeds";
            this.textBoxKodNeeds.Size = new System.Drawing.Size(127, 20);
            this.textBoxKodNeeds.TabIndex = 104;
            // 
            // checkBoxNeeds
            // 
            this.checkBoxNeeds.AutoSize = true;
            this.checkBoxNeeds.Location = new System.Drawing.Point(334, 48);
            this.checkBoxNeeds.Name = "checkBoxNeeds";
            this.checkBoxNeeds.Size = new System.Drawing.Size(15, 14);
            this.checkBoxNeeds.TabIndex = 114;
            this.checkBoxNeeds.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодПотребностейDataGridViewTextBoxColumn,
            this.языкDataGridViewTextBoxColumn,
            this.потребностьВОбщежитииDataGridViewCheckBoxColumn,
            this.кодСтудентаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.потребностиСтудентаBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(736, 228);
            this.dataGridView1.TabIndex = 115;
            // 
            // бД3DataSet
            // 
            this.бД3DataSet.DataSetName = "БД3DataSet";
            this.бД3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // потребностиСтудентаBindingSource
            // 
            this.потребностиСтудентаBindingSource.DataMember = "Потребности студента";
            this.потребностиСтудентаBindingSource.DataSource = this.бД3DataSet;
            // 
            // потребности_студентаTableAdapter
            // 
            this.потребности_студентаTableAdapter.ClearBeforeFill = true;
            // 
            // кодПотребностейDataGridViewTextBoxColumn
            // 
            this.кодПотребностейDataGridViewTextBoxColumn.DataPropertyName = "Код потребностей";
            this.кодПотребностейDataGridViewTextBoxColumn.HeaderText = "Код потребностей";
            this.кодПотребностейDataGridViewTextBoxColumn.Name = "кодПотребностейDataGridViewTextBoxColumn";
            this.кодПотребностейDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодПотребностейDataGridViewTextBoxColumn.Width = 150;
            // 
            // языкDataGridViewTextBoxColumn
            // 
            this.языкDataGridViewTextBoxColumn.DataPropertyName = "Язык";
            this.языкDataGridViewTextBoxColumn.HeaderText = "Язык";
            this.языкDataGridViewTextBoxColumn.Name = "языкDataGridViewTextBoxColumn";
            this.языкDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // потребностьВОбщежитииDataGridViewCheckBoxColumn
            // 
            this.потребностьВОбщежитииDataGridViewCheckBoxColumn.DataPropertyName = "Потребность в общежитии";
            this.потребностьВОбщежитииDataGridViewCheckBoxColumn.HeaderText = "Потребность в общежитии";
            this.потребностьВОбщежитииDataGridViewCheckBoxColumn.Name = "потребностьВОбщежитииDataGridViewCheckBoxColumn";
            this.потребностьВОбщежитииDataGridViewCheckBoxColumn.ReadOnly = true;
            this.потребностьВОбщежитииDataGridViewCheckBoxColumn.Width = 200;
            // 
            // кодСтудентаDataGridViewTextBoxColumn
            // 
            this.кодСтудентаDataGridViewTextBoxColumn.DataPropertyName = "Код студента";
            this.кодСтудентаDataGridViewTextBoxColumn.HeaderText = "Код студента";
            this.кодСтудентаDataGridViewTextBoxColumn.Name = "кодСтудентаDataGridViewTextBoxColumn";
            this.кодСтудентаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AddNeedsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkBoxNeeds);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxKodStudent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLanguage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKodNeeds);
            this.Name = "AddNeedsForm";
            this.Text = "AddNeedsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddNeedsForm_FormClosing);
            this.Load += new System.EventHandler(this.AddNeedsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.потребностиСтудентаBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxKodStudent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLanguage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKodNeeds;
        private System.Windows.Forms.CheckBox checkBoxNeeds;
        private System.Windows.Forms.DataGridView dataGridView1;
        private БД3DataSet бД3DataSet;
        private System.Windows.Forms.BindingSource потребностиСтудентаBindingSource;
        private БД3DataSetTableAdapters.Потребности_студентаTableAdapter потребности_студентаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПотребностейDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn языкDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn потребностьВОбщежитииDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСтудентаDataGridViewTextBoxColumn;
    }
}