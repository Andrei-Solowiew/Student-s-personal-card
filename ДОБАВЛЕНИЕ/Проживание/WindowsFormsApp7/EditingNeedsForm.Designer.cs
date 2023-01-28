
namespace WindowsFormsApp7
{
    partial class EditingNeedsForm
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
            this.потребностиСтудентаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet = new WindowsFormsApp7._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet();
            this.потребности_студентаTableAdapter = new WindowsFormsApp7._СР_5_ОПБД_Соловьев_Андрей_П9021DataSetTableAdapters.Потребности_студентаTableAdapter();
            this.бД3DataSet = new WindowsFormsApp7.БД3DataSet();
            this.родителиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.родителиTableAdapter = new WindowsFormsApp7.БД3DataSetTableAdapters.РодителиTableAdapter();
            this.родителиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.потребностиСтудентаBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.потребности_студентаTableAdapter1 = new WindowsFormsApp7.БД3DataSetTableAdapters.Потребности_студентаTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодПотребностейDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.языкDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.потребностьВОбщежитииDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.кодСтудентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.Change = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxKodNeed = new System.Windows.Forms.TextBox();
            this.checkBoxNeed = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.потребностиСтудентаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.родителиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.родителиBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.потребностиСтудентаBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // потребностиСтудентаBindingSource
            // 
            this.потребностиСтудентаBindingSource.DataMember = "Потребности студента";
            this.потребностиСтудентаBindingSource.DataSource = this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet;
            // 
            // _СР_5_ОПБД_Соловьев_Андрей_П9021DataSet
            // 
            this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.DataSetName = "_СР_5_ОПБД_Соловьев_Андрей_П9021DataSet";
            this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // потребности_студентаTableAdapter
            // 
            this.потребности_студентаTableAdapter.ClearBeforeFill = true;
            // 
            // бД3DataSet
            // 
            this.бД3DataSet.DataSetName = "БД3DataSet";
            this.бД3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // родителиBindingSource
            // 
            this.родителиBindingSource.DataMember = "Родители";
            this.родителиBindingSource.DataSource = this.бД3DataSet;
            // 
            // родителиTableAdapter
            // 
            this.родителиTableAdapter.ClearBeforeFill = true;
            // 
            // родителиBindingSource1
            // 
            this.родителиBindingSource1.DataMember = "Родители";
            this.родителиBindingSource1.DataSource = this.бД3DataSet;
            // 
            // потребностиСтудентаBindingSource1
            // 
            this.потребностиСтудентаBindingSource1.DataMember = "Потребности студента";
            this.потребностиСтудентаBindingSource1.DataSource = this.бД3DataSet;
            // 
            // потребности_студентаTableAdapter1
            // 
            this.потребности_студентаTableAdapter1.ClearBeforeFill = true;
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
            this.dataGridView1.DataSource = this.потребностиСтудентаBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(735, 153);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодПотребностейDataGridViewTextBoxColumn
            // 
            this.кодПотребностейDataGridViewTextBoxColumn.DataPropertyName = "Код потребностей";
            this.кодПотребностейDataGridViewTextBoxColumn.HeaderText = "Код потребностей";
            this.кодПотребностейDataGridViewTextBoxColumn.Name = "кодПотребностейDataGridViewTextBoxColumn";
            // 
            // языкDataGridViewTextBoxColumn
            // 
            this.языкDataGridViewTextBoxColumn.DataPropertyName = "Язык";
            this.языкDataGridViewTextBoxColumn.HeaderText = "Язык";
            this.языкDataGridViewTextBoxColumn.Name = "языкDataGridViewTextBoxColumn";
            // 
            // потребностьВОбщежитииDataGridViewCheckBoxColumn
            // 
            this.потребностьВОбщежитииDataGridViewCheckBoxColumn.DataPropertyName = "Потребность в общежитии";
            this.потребностьВОбщежитииDataGridViewCheckBoxColumn.HeaderText = "Потребность в общежитии";
            this.потребностьВОбщежитииDataGridViewCheckBoxColumn.Name = "потребностьВОбщежитииDataGridViewCheckBoxColumn";
            // 
            // кодСтудентаDataGridViewTextBoxColumn
            // 
            this.кодСтудентаDataGridViewTextBoxColumn.DataPropertyName = "Код студента";
            this.кодСтудентаDataGridViewTextBoxColumn.HeaderText = "Код студента";
            this.кодСтудентаDataGridViewTextBoxColumn.Name = "кодСтудентаDataGridViewTextBoxColumn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(164, 11);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 17);
            this.label9.TabIndex = 36;
            this.label9.Text = "Потребность в общежитии";
            // 
            // Change
            // 
            this.Change.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Change.Location = new System.Drawing.Point(12, 67);
            this.Change.Margin = new System.Windows.Forms.Padding(2);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(329, 32);
            this.Change.TabIndex = 34;
            this.Change.Text = "Изменить";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(13, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Код потребностей";
            // 
            // textBoxKodNeed
            // 
            this.textBoxKodNeed.Location = new System.Drawing.Point(16, 30);
            this.textBoxKodNeed.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKodNeed.Name = "textBoxKodNeed";
            this.textBoxKodNeed.Size = new System.Drawing.Size(76, 20);
            this.textBoxKodNeed.TabIndex = 32;
            // 
            // checkBoxNeed
            // 
            this.checkBoxNeed.AutoSize = true;
            this.checkBoxNeed.Location = new System.Drawing.Point(242, 33);
            this.checkBoxNeed.Name = "checkBoxNeed";
            this.checkBoxNeed.Size = new System.Drawing.Size(15, 14);
            this.checkBoxNeed.TabIndex = 37;
            this.checkBoxNeed.UseVisualStyleBackColor = true;
            // 
            // EditingNeedsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 292);
            this.Controls.Add(this.checkBoxNeed);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxKodNeed);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditingNeedsForm";
            this.Text = "EditingNeedsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditingNeedsForm_FormClosing);
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.потребностиСтудентаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.родителиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.родителиBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.потребностиСтудентаBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private _СР_5_ОПБД_Соловьев_Андрей_П9021DataSet _СР_5_ОПБД_Соловьев_Андрей_П9021DataSet;
        private System.Windows.Forms.BindingSource потребностиСтудентаBindingSource;
        private _СР_5_ОПБД_Соловьев_Андрей_П9021DataSetTableAdapters.Потребности_студентаTableAdapter потребности_студентаTableAdapter;
        private БД3DataSet бД3DataSet;
        private System.Windows.Forms.BindingSource родителиBindingSource;
        private БД3DataSetTableAdapters.РодителиTableAdapter родителиTableAdapter;
        private System.Windows.Forms.BindingSource родителиBindingSource1;
        private System.Windows.Forms.BindingSource потребностиСтудентаBindingSource1;
        private БД3DataSetTableAdapters.Потребности_студентаTableAdapter потребности_студентаTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПотребностейDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn языкDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn потребностьВОбщежитииDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСтудентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxKodNeed;
        private System.Windows.Forms.CheckBox checkBoxNeed;
    }
}