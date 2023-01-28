
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодПотребностейDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.языкDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.потребностьВОбщежитииDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.кодСтудентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.потребностиСтудентаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet = new WindowsFormsApp7._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet();
            this.потребности_студентаTableAdapter = new WindowsFormsApp7._СР_5_ОПБД_Соловьев_Андрей_П9021DataSetTableAdapters.Потребности_студентаTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.потребностиСтудентаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодПотребностейDataGridViewTextBoxColumn,
            this.языкDataGridViewTextBoxColumn,
            this.потребностьВОбщежитииDataGridViewCheckBoxColumn,
            this.кодСтудентаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.потребностиСтудентаBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, -1);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(752, 292);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодПотребностейDataGridViewTextBoxColumn
            // 
            this.кодПотребностейDataGridViewTextBoxColumn.DataPropertyName = "Код потребностей";
            this.кодПотребностейDataGridViewTextBoxColumn.HeaderText = "Код потребностей";
            this.кодПотребностейDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.кодПотребностейDataGridViewTextBoxColumn.Name = "кодПотребностейDataGridViewTextBoxColumn";
            this.кодПотребностейDataGridViewTextBoxColumn.Width = 150;
            // 
            // языкDataGridViewTextBoxColumn
            // 
            this.языкDataGridViewTextBoxColumn.DataPropertyName = "Язык";
            this.языкDataGridViewTextBoxColumn.HeaderText = "Язык";
            this.языкDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.языкDataGridViewTextBoxColumn.Name = "языкDataGridViewTextBoxColumn";
            this.языкDataGridViewTextBoxColumn.Width = 150;
            // 
            // потребностьВОбщежитииDataGridViewCheckBoxColumn
            // 
            this.потребностьВОбщежитииDataGridViewCheckBoxColumn.DataPropertyName = "Потребность в общежитии";
            this.потребностьВОбщежитииDataGridViewCheckBoxColumn.HeaderText = "Потребность в общежитии";
            this.потребностьВОбщежитииDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.потребностьВОбщежитииDataGridViewCheckBoxColumn.Name = "потребностьВОбщежитииDataGridViewCheckBoxColumn";
            this.потребностьВОбщежитииDataGridViewCheckBoxColumn.Width = 150;
            // 
            // кодСтудентаDataGridViewTextBoxColumn
            // 
            this.кодСтудентаDataGridViewTextBoxColumn.DataPropertyName = "Код студента";
            this.кодСтудентаDataGridViewTextBoxColumn.HeaderText = "Код студента";
            this.кодСтудентаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.кодСтудентаDataGridViewTextBoxColumn.Name = "кодСтудентаDataGridViewTextBoxColumn";
            this.кодСтудентаDataGridViewTextBoxColumn.Width = 150;
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
            // EditingNeedsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 292);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditingNeedsForm";
            this.Text = "EditingNeedsForm";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.потребностиСтудентаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _СР_5_ОПБД_Соловьев_Андрей_П9021DataSet _СР_5_ОПБД_Соловьев_Андрей_П9021DataSet;
        private System.Windows.Forms.BindingSource потребностиСтудентаBindingSource;
        private _СР_5_ОПБД_Соловьев_Андрей_П9021DataSetTableAdapters.Потребности_студентаTableAdapter потребности_студентаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПотребностейDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn языкDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn потребностьВОбщежитииDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСтудентаDataGridViewTextBoxColumn;
    }
}