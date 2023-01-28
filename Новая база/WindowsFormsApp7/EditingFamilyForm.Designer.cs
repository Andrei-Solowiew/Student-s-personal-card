
namespace WindowsFormsApp7
{
    partial class EditingFamilyForm
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
            this.семьяBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet = new WindowsFormsApp7._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet();
            this.семьяTableAdapter = new WindowsFormsApp7._СР_5_ОПБД_Соловьев_Андрей_П9021DataSetTableAdapters.СемьяTableAdapter();
            this.бД3DataSet = new WindowsFormsApp7.БД3DataSet();
            this.семьяBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.семьяTableAdapter1 = new WindowsFormsApp7.БД3DataSetTableAdapters.СемьяTableAdapter();
            this.семьяBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодСемьиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.полнаяЛиСемьяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.причинаНеполнотыСемьиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоДетейDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаРожденияКаждогоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.гдеЖивутдомКвартираDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сегодняшняяДатаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСтудентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.семьяBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.семьяBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.семьяBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // семьяBindingSource
            // 
            this.семьяBindingSource.DataMember = "Семья";
            this.семьяBindingSource.DataSource = this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet;
            // 
            // _СР_5_ОПБД_Соловьев_Андрей_П9021DataSet
            // 
            this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.DataSetName = "_СР_5_ОПБД_Соловьев_Андрей_П9021DataSet";
            this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // семьяTableAdapter
            // 
            this.семьяTableAdapter.ClearBeforeFill = true;
            // 
            // бД3DataSet
            // 
            this.бД3DataSet.DataSetName = "БД3DataSet";
            this.бД3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // семьяBindingSource1
            // 
            this.семьяBindingSource1.DataMember = "Семья";
            this.семьяBindingSource1.DataSource = this.бД3DataSet;
            // 
            // семьяTableAdapter1
            // 
            this.семьяTableAdapter1.ClearBeforeFill = true;
            // 
            // семьяBindingSource2
            // 
            this.семьяBindingSource2.DataMember = "Семья";
            this.семьяBindingSource2.DataSource = this.бД3DataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодСемьиDataGridViewTextBoxColumn,
            this.полнаяЛиСемьяDataGridViewTextBoxColumn,
            this.причинаНеполнотыСемьиDataGridViewTextBoxColumn,
            this.количествоДетейDataGridViewTextBoxColumn,
            this.датаРожденияКаждогоDataGridViewTextBoxColumn,
            this.гдеЖивутдомКвартираDataGridViewTextBoxColumn,
            this.сегодняшняяДатаDataGridViewTextBoxColumn,
            this.кодСтудентаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.семьяBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(719, 221);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодСемьиDataGridViewTextBoxColumn
            // 
            this.кодСемьиDataGridViewTextBoxColumn.DataPropertyName = "Код семьи";
            this.кодСемьиDataGridViewTextBoxColumn.HeaderText = "Код семьи";
            this.кодСемьиDataGridViewTextBoxColumn.Name = "кодСемьиDataGridViewTextBoxColumn";
            // 
            // полнаяЛиСемьяDataGridViewTextBoxColumn
            // 
            this.полнаяЛиСемьяDataGridViewTextBoxColumn.DataPropertyName = "Полная ли семья";
            this.полнаяЛиСемьяDataGridViewTextBoxColumn.HeaderText = "Полная ли семья";
            this.полнаяЛиСемьяDataGridViewTextBoxColumn.Name = "полнаяЛиСемьяDataGridViewTextBoxColumn";
            // 
            // причинаНеполнотыСемьиDataGridViewTextBoxColumn
            // 
            this.причинаНеполнотыСемьиDataGridViewTextBoxColumn.DataPropertyName = "Причина неполноты семьи";
            this.причинаНеполнотыСемьиDataGridViewTextBoxColumn.HeaderText = "Причина неполноты семьи";
            this.причинаНеполнотыСемьиDataGridViewTextBoxColumn.Name = "причинаНеполнотыСемьиDataGridViewTextBoxColumn";
            // 
            // количествоДетейDataGridViewTextBoxColumn
            // 
            this.количествоДетейDataGridViewTextBoxColumn.DataPropertyName = "Количество детей";
            this.количествоДетейDataGridViewTextBoxColumn.HeaderText = "Количество детей";
            this.количествоДетейDataGridViewTextBoxColumn.Name = "количествоДетейDataGridViewTextBoxColumn";
            // 
            // датаРожденияКаждогоDataGridViewTextBoxColumn
            // 
            this.датаРожденияКаждогоDataGridViewTextBoxColumn.DataPropertyName = "Дата рождения каждого";
            this.датаРожденияКаждогоDataGridViewTextBoxColumn.HeaderText = "Дата рождения каждого";
            this.датаРожденияКаждогоDataGridViewTextBoxColumn.Name = "датаРожденияКаждогоDataGridViewTextBoxColumn";
            // 
            // гдеЖивутдомКвартираDataGridViewTextBoxColumn
            // 
            this.гдеЖивутдомКвартираDataGridViewTextBoxColumn.DataPropertyName = "Где живут(дом, квартира)";
            this.гдеЖивутдомКвартираDataGridViewTextBoxColumn.HeaderText = "Где живут(дом, квартира)";
            this.гдеЖивутдомКвартираDataGridViewTextBoxColumn.Name = "гдеЖивутдомКвартираDataGridViewTextBoxColumn";
            // 
            // сегодняшняяДатаDataGridViewTextBoxColumn
            // 
            this.сегодняшняяДатаDataGridViewTextBoxColumn.DataPropertyName = "Сегодняшняя дата";
            this.сегодняшняяДатаDataGridViewTextBoxColumn.HeaderText = "Сегодняшняя дата";
            this.сегодняшняяДатаDataGridViewTextBoxColumn.Name = "сегодняшняяДатаDataGridViewTextBoxColumn";
            // 
            // кодСтудентаDataGridViewTextBoxColumn
            // 
            this.кодСтудентаDataGridViewTextBoxColumn.DataPropertyName = "Код студента";
            this.кодСтудентаDataGridViewTextBoxColumn.HeaderText = "Код студента";
            this.кодСтудентаDataGridViewTextBoxColumn.Name = "кодСтудентаDataGridViewTextBoxColumn";
            // 
            // EditingFamilyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 292);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditingFamilyForm";
            this.Text = "EditingFamilyForm";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.семьяBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.семьяBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.семьяBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private _СР_5_ОПБД_Соловьев_Андрей_П9021DataSet _СР_5_ОПБД_Соловьев_Андрей_П9021DataSet;
        private System.Windows.Forms.BindingSource семьяBindingSource;
        private _СР_5_ОПБД_Соловьев_Андрей_П9021DataSetTableAdapters.СемьяTableAdapter семьяTableAdapter;
        private БД3DataSet бД3DataSet;
        private System.Windows.Forms.BindingSource семьяBindingSource1;
        private БД3DataSetTableAdapters.СемьяTableAdapter семьяTableAdapter1;
        private System.Windows.Forms.BindingSource семьяBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСемьиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn полнаяЛиСемьяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn причинаНеполнотыСемьиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоДетейDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаРожденияКаждогоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn гдеЖивутдомКвартираDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сегодняшняяДатаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСтудентаDataGridViewTextBoxColumn;
    }
}