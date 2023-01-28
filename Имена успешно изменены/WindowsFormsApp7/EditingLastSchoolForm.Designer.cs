
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.данныеОПрошломУЗBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодКонтактныхДанныхОПрошломУЗDataGridViewTextBoxColumn,
            this.учебноеЗаведениеУЗDataGridViewTextBoxColumn,
            this.годОкончанияУЗDataGridViewTextBoxColumn,
            this.уровеньОбразованияDataGridViewTextBoxColumn,
            this.кодСтудентаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.данныеОПрошломУЗBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-3, 1);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(818, 260);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодКонтактныхДанныхОПрошломУЗDataGridViewTextBoxColumn
            // 
            this.кодКонтактныхДанныхОПрошломУЗDataGridViewTextBoxColumn.DataPropertyName = "Код контактных данных о прошлом УЗ";
            this.кодКонтактныхДанныхОПрошломУЗDataGridViewTextBoxColumn.HeaderText = "Код контактных данных о прошлом УЗ";
            this.кодКонтактныхДанныхОПрошломУЗDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.кодКонтактныхДанныхОПрошломУЗDataGridViewTextBoxColumn.Name = "кодКонтактныхДанныхОПрошломУЗDataGridViewTextBoxColumn";
            this.кодКонтактныхДанныхОПрошломУЗDataGridViewTextBoxColumn.Width = 150;
            // 
            // учебноеЗаведениеУЗDataGridViewTextBoxColumn
            // 
            this.учебноеЗаведениеУЗDataGridViewTextBoxColumn.DataPropertyName = "Учебное заведение(УЗ)";
            this.учебноеЗаведениеУЗDataGridViewTextBoxColumn.HeaderText = "Учебное заведение(УЗ)";
            this.учебноеЗаведениеУЗDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.учебноеЗаведениеУЗDataGridViewTextBoxColumn.Name = "учебноеЗаведениеУЗDataGridViewTextBoxColumn";
            this.учебноеЗаведениеУЗDataGridViewTextBoxColumn.Width = 150;
            // 
            // годОкончанияУЗDataGridViewTextBoxColumn
            // 
            this.годОкончанияУЗDataGridViewTextBoxColumn.DataPropertyName = "Год окончания УЗ";
            this.годОкончанияУЗDataGridViewTextBoxColumn.HeaderText = "Год окончания УЗ";
            this.годОкончанияУЗDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.годОкончанияУЗDataGridViewTextBoxColumn.Name = "годОкончанияУЗDataGridViewTextBoxColumn";
            this.годОкончанияУЗDataGridViewTextBoxColumn.Width = 150;
            // 
            // уровеньОбразованияDataGridViewTextBoxColumn
            // 
            this.уровеньОбразованияDataGridViewTextBoxColumn.DataPropertyName = "Уровень образования";
            this.уровеньОбразованияDataGridViewTextBoxColumn.HeaderText = "Уровень образования";
            this.уровеньОбразованияDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.уровеньОбразованияDataGridViewTextBoxColumn.Name = "уровеньОбразованияDataGridViewTextBoxColumn";
            this.уровеньОбразованияDataGridViewTextBoxColumn.Width = 150;
            // 
            // кодСтудентаDataGridViewTextBoxColumn
            // 
            this.кодСтудентаDataGridViewTextBoxColumn.DataPropertyName = "Код студента";
            this.кодСтудентаDataGridViewTextBoxColumn.HeaderText = "Код студента";
            this.кодСтудентаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.кодСтудентаDataGridViewTextBoxColumn.Name = "кодСтудентаDataGridViewTextBoxColumn";
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
            // EditingLastSchoolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 292);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditingLastSchoolForm";
            this.Text = "EditingLastSchoolForm";
            this.Load += new System.EventHandler(this.Form14_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.данныеОПрошломУЗBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet)).EndInit();
            this.ResumeLayout(false);

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
    }
}