
namespace WindowsFormsApp7
{
    partial class EditingLastSchoolForm
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
            this.кодКонтактныхДанныхОПрошломУЗDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.учебноеЗаведениеУЗDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годОкончанияУЗDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.уровеньОбразованияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСтудентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.данныеОПрошломУЗBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet = new WindowsFormsApp7._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet();
            this.данные_о_прошлом_УЗTableAdapter = new WindowsFormsApp7._СР_5_ОПБД_Соловьев_Андрей_П9021DataSetTableAdapters.Данные_о_прошлом_УЗTableAdapter();
            this.бД3DataSet = new WindowsFormsApp7.БД3DataSet();
            this.данныеОПрошломУЗBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.данные_о_прошлом_УЗTableAdapter1 = new WindowsFormsApp7.БД3DataSetTableAdapters.Данные_о_прошлом_УЗTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.данныеОПрошломУЗBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.данныеОПрошломУЗBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.DataSource = this.данныеОПрошломУЗBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(11, 168);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(863, 113);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодКонтактныхДанныхОПрошломУЗDataGridViewTextBoxColumn
            // 
            this.кодКонтактныхДанныхОПрошломУЗDataGridViewTextBoxColumn.DataPropertyName = "Код контактных данных о прошлом УЗ";
            this.кодКонтактныхДанныхОПрошломУЗDataGridViewTextBoxColumn.HeaderText = "Код контактных данных о прошлом УЗ";
            this.кодКонтактныхДанныхОПрошломУЗDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.кодКонтактныхДанныхОПрошломУЗDataGridViewTextBoxColumn.Name = "кодКонтактныхДанныхОПрошломУЗDataGridViewTextBoxColumn";
            this.кодКонтактныхДанныхОПрошломУЗDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодКонтактныхДанныхОПрошломУЗDataGridViewTextBoxColumn.Width = 150;
            // 
            // учебноеЗаведениеУЗDataGridViewTextBoxColumn
            // 
            this.учебноеЗаведениеУЗDataGridViewTextBoxColumn.DataPropertyName = "Учебное заведение(УЗ)";
            this.учебноеЗаведениеУЗDataGridViewTextBoxColumn.HeaderText = "Учебное заведение(УЗ)";
            this.учебноеЗаведениеУЗDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.учебноеЗаведениеУЗDataGridViewTextBoxColumn.Name = "учебноеЗаведениеУЗDataGridViewTextBoxColumn";
            this.учебноеЗаведениеУЗDataGridViewTextBoxColumn.ReadOnly = true;
            this.учебноеЗаведениеУЗDataGridViewTextBoxColumn.Width = 150;
            // 
            // годОкончанияУЗDataGridViewTextBoxColumn
            // 
            this.годОкончанияУЗDataGridViewTextBoxColumn.DataPropertyName = "Год окончания УЗ";
            this.годОкончанияУЗDataGridViewTextBoxColumn.HeaderText = "Год окончания УЗ";
            this.годОкончанияУЗDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.годОкончанияУЗDataGridViewTextBoxColumn.Name = "годОкончанияУЗDataGridViewTextBoxColumn";
            this.годОкончанияУЗDataGridViewTextBoxColumn.ReadOnly = true;
            this.годОкончанияУЗDataGridViewTextBoxColumn.Width = 150;
            // 
            // уровеньОбразованияDataGridViewTextBoxColumn
            // 
            this.уровеньОбразованияDataGridViewTextBoxColumn.DataPropertyName = "Уровень образования";
            this.уровеньОбразованияDataGridViewTextBoxColumn.HeaderText = "Уровень образования";
            this.уровеньОбразованияDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.уровеньОбразованияDataGridViewTextBoxColumn.Name = "уровеньОбразованияDataGridViewTextBoxColumn";
            this.уровеньОбразованияDataGridViewTextBoxColumn.ReadOnly = true;
            this.уровеньОбразованияDataGridViewTextBoxColumn.Width = 150;
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
            // данныеОПрошломУЗBindingSource
            // 
            this.данныеОПрошломУЗBindingSource.DataMember = "Данные о прошлом УЗ";
            this.данныеОПрошломУЗBindingSource.DataSource = this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet;
            // 
            // _СР_5_ОПБД_Соловьев_Андрей_П9021DataSet
            // 
            this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.DataSetName = "_СР_5_ОПБД_Соловьев_Андрей_П9021DataSet";
            this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // данные_о_прошлом_УЗTableAdapter
            // 
            this.данные_о_прошлом_УЗTableAdapter.ClearBeforeFill = true;
            // 
            // бД3DataSet
            // 
            this.бД3DataSet.DataSetName = "БД3DataSet";
            this.бД3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // данныеОПрошломУЗBindingSource1
            // 
            this.данныеОПрошломУЗBindingSource1.DataMember = "Данные о прошлом УЗ";
            this.данныеОПрошломУЗBindingSource1.DataSource = this.бД3DataSet;
            // 
            // данные_о_прошлом_УЗTableAdapter1
            // 
            this.данные_о_прошлом_УЗTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(190, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Данная функция не предусмотрена для этой таблицы";
            // 
            // EditingLastSchoolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 292);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditingLastSchoolForm";
            this.Text = "EditingLastSchoolForm";
            this.Load += new System.EventHandler(this.Form14_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.данныеОПрошломУЗBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.данныеОПрошломУЗBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _СР_5_ОПБД_Соловьев_Андрей_П9021DataSet _СР_5_ОПБД_Соловьев_Андрей_П9021DataSet;
        private System.Windows.Forms.BindingSource данныеОПрошломУЗBindingSource;
        private _СР_5_ОПБД_Соловьев_Андрей_П9021DataSetTableAdapters.Данные_о_прошлом_УЗTableAdapter данные_о_прошлом_УЗTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКонтактныхДанныхОПрошломУЗDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn учебноеЗаведениеУЗDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn годОкончанияУЗDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn уровеньОбразованияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСтудентаDataGridViewTextBoxColumn;
        private БД3DataSet бД3DataSet;
        private System.Windows.Forms.BindingSource данныеОПрошломУЗBindingSource1;
        private БД3DataSetTableAdapters.Данные_о_прошлом_УЗTableAdapter данные_о_прошлом_УЗTableAdapter1;
        private System.Windows.Forms.Label label1;
    }
}