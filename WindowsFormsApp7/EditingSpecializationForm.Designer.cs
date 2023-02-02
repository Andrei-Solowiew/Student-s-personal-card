
namespace WindowsFormsApp7
{
    partial class EditingSpecializationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditingSpecializationForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодСпециальностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.специальностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСтудентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.специальностьBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.бД3DataSet = new WindowsFormsApp7.БД3DataSet();
            this.специальностьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet = new WindowsFormsApp7._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet();
            this.специальностьTableAdapter = new WindowsFormsApp7._СР_5_ОПБД_Соловьев_Андрей_П9021DataSetTableAdapters.СпециальностьTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxUpdateToday = new System.Windows.Forms.TextBox();
            this.SpecualizationFormChange = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxKodStudentChange = new System.Windows.Forms.TextBox();
            this.специальностьTableAdapter1 = new WindowsFormsApp7.БД3DataSetTableAdapters.СпециальностьTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.специальностьBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.специальностьBindingSource)).BeginInit();
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
            this.кодСпециальностиDataGridViewTextBoxColumn,
            this.специальностьDataGridViewTextBoxColumn,
            this.кодСтудентаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.специальностьBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(11, 132);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(871, 230);
            this.dataGridView1.TabIndex = 100;
            // 
            // кодСпециальностиDataGridViewTextBoxColumn
            // 
            this.кодСпециальностиDataGridViewTextBoxColumn.DataPropertyName = "Код специальности";
            this.кодСпециальностиDataGridViewTextBoxColumn.HeaderText = "Код специальности";
            this.кодСпециальностиDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.кодСпециальностиDataGridViewTextBoxColumn.Name = "кодСпециальностиDataGridViewTextBoxColumn";
            this.кодСпециальностиDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодСпециальностиDataGridViewTextBoxColumn.Width = 150;
            // 
            // специальностьDataGridViewTextBoxColumn
            // 
            this.специальностьDataGridViewTextBoxColumn.DataPropertyName = "Специальность";
            this.специальностьDataGridViewTextBoxColumn.HeaderText = "Специальность";
            this.специальностьDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.специальностьDataGridViewTextBoxColumn.Name = "специальностьDataGridViewTextBoxColumn";
            this.специальностьDataGridViewTextBoxColumn.ReadOnly = true;
            this.специальностьDataGridViewTextBoxColumn.Width = 150;
            // 
            // кодСтудентаDataGridViewTextBoxColumn
            // 
            this.кодСтудентаDataGridViewTextBoxColumn.DataPropertyName = "Код студента";
            this.кодСтудентаDataGridViewTextBoxColumn.HeaderText = "Код студента";
            this.кодСтудентаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.кодСтудентаDataGridViewTextBoxColumn.Name = "кодСтудентаDataGridViewTextBoxColumn";
            this.кодСтудентаDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодСтудентаDataGridViewTextBoxColumn.Width = 150;
            // 
            // специальностьBindingSource1
            // 
            this.специальностьBindingSource1.DataMember = "Специальность";
            this.специальностьBindingSource1.DataSource = this.бД3DataSet;
            // 
            // бД3DataSet
            // 
            this.бД3DataSet.DataSetName = "БД3DataSet";
            this.бД3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // специальностьBindingSource
            // 
            this.специальностьBindingSource.DataMember = "Специальность";
            this.специальностьBindingSource.DataSource = this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet;
            // 
            // _СР_5_ОПБД_Соловьев_Андрей_П9021DataSet
            // 
            this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.DataSetName = "_СР_5_ОПБД_Соловьев_Андрей_П9021DataSet";
            this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // специальностьTableAdapter
            // 
            this.специальностьTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(163, 15);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 17);
            this.label9.TabIndex = 31;
            this.label9.Text = "Специальность";
            // 
            // textBoxUpdateToday
            // 
            this.textBoxUpdateToday.Location = new System.Drawing.Point(166, 34);
            this.textBoxUpdateToday.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxUpdateToday.Name = "textBoxUpdateToday";
            this.textBoxUpdateToday.Size = new System.Drawing.Size(76, 20);
            this.textBoxUpdateToday.TabIndex = 28;
            // 
            // SpecualizationFormChange
            // 
            this.SpecualizationFormChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SpecualizationFormChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpecualizationFormChange.Location = new System.Drawing.Point(11, 71);
            this.SpecualizationFormChange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SpecualizationFormChange.Name = "SpecualizationFormChange";
            this.SpecualizationFormChange.Size = new System.Drawing.Size(329, 32);
            this.SpecualizationFormChange.TabIndex = 29;
            this.SpecualizationFormChange.Text = "Изменить";
            this.SpecualizationFormChange.UseVisualStyleBackColor = true;
            this.SpecualizationFormChange.Click += new System.EventHandler(this.SpecualizationFormChange_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 15);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "Код специальности";
            // 
            // textBoxKodStudentChange
            // 
            this.textBoxKodStudentChange.Location = new System.Drawing.Point(15, 34);
            this.textBoxKodStudentChange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxKodStudentChange.Name = "textBoxKodStudentChange";
            this.textBoxKodStudentChange.Size = new System.Drawing.Size(76, 20);
            this.textBoxKodStudentChange.TabIndex = 27;
            // 
            // специальностьTableAdapter1
            // 
            this.специальностьTableAdapter1.ClearBeforeFill = true;
            // 
            // EditingSpecializationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 373);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxUpdateToday);
            this.Controls.Add(this.SpecualizationFormChange);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxKodStudentChange);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditingSpecializationForm";
            this.Text = "EditingSpecializationForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditingSpecializationForm_FormClosing);
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.специальностьBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.специальностьBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _СР_5_ОПБД_Соловьев_Андрей_П9021DataSet _СР_5_ОПБД_Соловьев_Андрей_П9021DataSet;
        private System.Windows.Forms.BindingSource специальностьBindingSource;
        private _СР_5_ОПБД_Соловьев_Андрей_П9021DataSetTableAdapters.СпециальностьTableAdapter специальностьTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСпециальностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn специальностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСтудентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxUpdateToday;
        private System.Windows.Forms.Button SpecualizationFormChange;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxKodStudentChange;
        private БД3DataSet бД3DataSet;
        private System.Windows.Forms.BindingSource специальностьBindingSource1;
        private БД3DataSetTableAdapters.СпециальностьTableAdapter специальностьTableAdapter1;
    }
}