
namespace WindowsFormsApp7
{
    partial class EditingStudyForm
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
            this.кодОбученияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.формаОбученияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.форматОбученияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.группаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.срокОбученияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСтудентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.обучениеСтудентаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet = new WindowsFormsApp7._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet();
            this.обучение_студентаTableAdapter = new WindowsFormsApp7._СР_5_ОПБД_Соловьев_Андрей_П9021DataSetTableAdapters.Обучение_студентаTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.обучениеСтудентаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
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
            this.dataGridView1.Location = new System.Drawing.Point(8, -2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(748, 275);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодОбученияDataGridViewTextBoxColumn
            // 
            this.кодОбученияDataGridViewTextBoxColumn.DataPropertyName = "Код обучения";
            this.кодОбученияDataGridViewTextBoxColumn.HeaderText = "Код обучения";
            this.кодОбученияDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.кодОбученияDataGridViewTextBoxColumn.Name = "кодОбученияDataGridViewTextBoxColumn";
            this.кодОбученияDataGridViewTextBoxColumn.Width = 150;
            // 
            // формаОбученияDataGridViewTextBoxColumn
            // 
            this.формаОбученияDataGridViewTextBoxColumn.DataPropertyName = "Форма обучения";
            this.формаОбученияDataGridViewTextBoxColumn.HeaderText = "Форма обучения";
            this.формаОбученияDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.формаОбученияDataGridViewTextBoxColumn.Name = "формаОбученияDataGridViewTextBoxColumn";
            this.формаОбученияDataGridViewTextBoxColumn.Width = 150;
            // 
            // форматОбученияDataGridViewTextBoxColumn
            // 
            this.форматОбученияDataGridViewTextBoxColumn.DataPropertyName = "Формат обучения";
            this.форматОбученияDataGridViewTextBoxColumn.HeaderText = "Формат обучения";
            this.форматОбученияDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.форматОбученияDataGridViewTextBoxColumn.Name = "форматОбученияDataGridViewTextBoxColumn";
            this.форматОбученияDataGridViewTextBoxColumn.Width = 150;
            // 
            // группаDataGridViewTextBoxColumn
            // 
            this.группаDataGridViewTextBoxColumn.DataPropertyName = "Группа";
            this.группаDataGridViewTextBoxColumn.HeaderText = "Группа";
            this.группаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.группаDataGridViewTextBoxColumn.Name = "группаDataGridViewTextBoxColumn";
            this.группаDataGridViewTextBoxColumn.Width = 150;
            // 
            // срокОбученияDataGridViewTextBoxColumn
            // 
            this.срокОбученияDataGridViewTextBoxColumn.DataPropertyName = "Срок обучения";
            this.срокОбученияDataGridViewTextBoxColumn.HeaderText = "Срок обучения";
            this.срокОбученияDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.срокОбученияDataGridViewTextBoxColumn.Name = "срокОбученияDataGridViewTextBoxColumn";
            this.срокОбученияDataGridViewTextBoxColumn.Width = 150;
            // 
            // кодСтудентаDataGridViewTextBoxColumn
            // 
            this.кодСтудентаDataGridViewTextBoxColumn.DataPropertyName = "Код студента";
            this.кодСтудентаDataGridViewTextBoxColumn.HeaderText = "Код студента";
            this.кодСтудентаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.кодСтудентаDataGridViewTextBoxColumn.Name = "кодСтудентаDataGridViewTextBoxColumn";
            this.кодСтудентаDataGridViewTextBoxColumn.Width = 150;
            // 
            // обучениеСтудентаBindingSource
            // 
            this.обучениеСтудентаBindingSource.DataMember = "Обучение студента";
            this.обучениеСтудентаBindingSource.DataSource = this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet;
            // 
            // _СР_5_ОПБД_Соловьев_Андрей_П9021DataSet
            // 
            this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.DataSetName = "_СР_5_ОПБД_Соловьев_Андрей_П9021DataSet";
            this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // обучение_студентаTableAdapter
            // 
            this.обучение_студентаTableAdapter.ClearBeforeFill = true;
            // 
            // EditingStudyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 292);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditingStudyForm";
            this.Text = "EditingStudyForm";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.обучениеСтудентаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _СР_5_ОПБД_Соловьев_Андрей_П9021DataSet _СР_5_ОПБД_Соловьев_Андрей_П9021DataSet;
        private System.Windows.Forms.BindingSource обучениеСтудентаBindingSource;
        private _СР_5_ОПБД_Соловьев_Андрей_П9021DataSetTableAdapters.Обучение_студентаTableAdapter обучение_студентаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодОбученияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn формаОбученияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn форматОбученияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn группаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn срокОбученияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСтудентаDataGridViewTextBoxColumn;
    }
}