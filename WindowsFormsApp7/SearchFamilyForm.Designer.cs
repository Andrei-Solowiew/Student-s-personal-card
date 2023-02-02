
namespace WindowsFormsApp7
{
    partial class SearchFamilyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchFamilyForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодСемьиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.полнаяЛиСемьяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.причинаНеполнотыСемьиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоДетейDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаРожденияКаждогоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.гдеЖивутдомКвартираDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сегодняшняяДатаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСтудентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.семьяBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бД3DataSet = new WindowsFormsApp7.БД3DataSet();
            this.StudentFormDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxKod = new System.Windows.Forms.TextBox();
            this.семьяTableAdapter = new WindowsFormsApp7.БД3DataSetTableAdapters.СемьяTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.семьяBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД3DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
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
            this.dataGridView1.DataSource = this.семьяBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(34, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(808, 224);
            this.dataGridView1.TabIndex = 31;
            // 
            // кодСемьиDataGridViewTextBoxColumn
            // 
            this.кодСемьиDataGridViewTextBoxColumn.DataPropertyName = "Код семьи";
            this.кодСемьиDataGridViewTextBoxColumn.HeaderText = "Код семьи";
            this.кодСемьиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодСемьиDataGridViewTextBoxColumn.Name = "кодСемьиDataGridViewTextBoxColumn";
            this.кодСемьиDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодСемьиDataGridViewTextBoxColumn.Width = 125;
            // 
            // полнаяЛиСемьяDataGridViewTextBoxColumn
            // 
            this.полнаяЛиСемьяDataGridViewTextBoxColumn.DataPropertyName = "Полная ли семья";
            this.полнаяЛиСемьяDataGridViewTextBoxColumn.HeaderText = "Полная ли семья";
            this.полнаяЛиСемьяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.полнаяЛиСемьяDataGridViewTextBoxColumn.Name = "полнаяЛиСемьяDataGridViewTextBoxColumn";
            this.полнаяЛиСемьяDataGridViewTextBoxColumn.ReadOnly = true;
            this.полнаяЛиСемьяDataGridViewTextBoxColumn.Width = 125;
            // 
            // причинаНеполнотыСемьиDataGridViewTextBoxColumn
            // 
            this.причинаНеполнотыСемьиDataGridViewTextBoxColumn.DataPropertyName = "Причина неполноты семьи";
            this.причинаНеполнотыСемьиDataGridViewTextBoxColumn.HeaderText = "Причина неполноты семьи";
            this.причинаНеполнотыСемьиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.причинаНеполнотыСемьиDataGridViewTextBoxColumn.Name = "причинаНеполнотыСемьиDataGridViewTextBoxColumn";
            this.причинаНеполнотыСемьиDataGridViewTextBoxColumn.ReadOnly = true;
            this.причинаНеполнотыСемьиDataGridViewTextBoxColumn.Width = 125;
            // 
            // количествоДетейDataGridViewTextBoxColumn
            // 
            this.количествоДетейDataGridViewTextBoxColumn.DataPropertyName = "Количество детей";
            this.количествоДетейDataGridViewTextBoxColumn.HeaderText = "Количество детей";
            this.количествоДетейDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.количествоДетейDataGridViewTextBoxColumn.Name = "количествоДетейDataGridViewTextBoxColumn";
            this.количествоДетейDataGridViewTextBoxColumn.ReadOnly = true;
            this.количествоДетейDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаРожденияКаждогоDataGridViewTextBoxColumn
            // 
            this.датаРожденияКаждогоDataGridViewTextBoxColumn.DataPropertyName = "Дата рождения каждого";
            this.датаРожденияКаждогоDataGridViewTextBoxColumn.HeaderText = "Дата рождения каждого";
            this.датаРожденияКаждогоDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаРожденияКаждогоDataGridViewTextBoxColumn.Name = "датаРожденияКаждогоDataGridViewTextBoxColumn";
            this.датаРожденияКаждогоDataGridViewTextBoxColumn.ReadOnly = true;
            this.датаРожденияКаждогоDataGridViewTextBoxColumn.Width = 125;
            // 
            // гдеЖивутдомКвартираDataGridViewTextBoxColumn
            // 
            this.гдеЖивутдомКвартираDataGridViewTextBoxColumn.DataPropertyName = "Где живут(дом, квартира)";
            this.гдеЖивутдомКвартираDataGridViewTextBoxColumn.HeaderText = "Где живут(дом, квартира)";
            this.гдеЖивутдомКвартираDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.гдеЖивутдомКвартираDataGridViewTextBoxColumn.Name = "гдеЖивутдомКвартираDataGridViewTextBoxColumn";
            this.гдеЖивутдомКвартираDataGridViewTextBoxColumn.ReadOnly = true;
            this.гдеЖивутдомКвартираDataGridViewTextBoxColumn.Width = 125;
            // 
            // сегодняшняяДатаDataGridViewTextBoxColumn
            // 
            this.сегодняшняяДатаDataGridViewTextBoxColumn.DataPropertyName = "Сегодняшняя дата";
            this.сегодняшняяДатаDataGridViewTextBoxColumn.HeaderText = "Сегодняшняя дата";
            this.сегодняшняяДатаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.сегодняшняяДатаDataGridViewTextBoxColumn.Name = "сегодняшняяДатаDataGridViewTextBoxColumn";
            this.сегодняшняяДатаDataGridViewTextBoxColumn.ReadOnly = true;
            this.сегодняшняяДатаDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодСтудентаDataGridViewTextBoxColumn
            // 
            this.кодСтудентаDataGridViewTextBoxColumn.DataPropertyName = "Код студента";
            this.кодСтудентаDataGridViewTextBoxColumn.HeaderText = "Код студента";
            this.кодСтудентаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодСтудентаDataGridViewTextBoxColumn.Name = "кодСтудентаDataGridViewTextBoxColumn";
            this.кодСтудентаDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодСтудентаDataGridViewTextBoxColumn.Width = 125;
            // 
            // семьяBindingSource
            // 
            this.семьяBindingSource.DataMember = "Семья";
            this.семьяBindingSource.DataSource = this.бД3DataSet;
            // 
            // бД3DataSet
            // 
            this.бД3DataSet.DataSetName = "БД3DataSet";
            this.бД3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // StudentFormDelete
            // 
            this.StudentFormDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StudentFormDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentFormDelete.Location = new System.Drawing.Point(34, 97);
            this.StudentFormDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StudentFormDelete.Name = "StudentFormDelete";
            this.StudentFormDelete.Size = new System.Drawing.Size(191, 36);
            this.StudentFormDelete.TabIndex = 30;
            this.StudentFormDelete.Text = "Найти";
            this.StudentFormDelete.UseVisualStyleBackColor = true;
            this.StudentFormDelete.Click += new System.EventHandler(this.StudentFormDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(31, 36);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Код студента";
            // 
            // textBoxKod
            // 
            this.textBoxKod.Location = new System.Drawing.Point(34, 54);
            this.textBoxKod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxKod.Name = "textBoxKod";
            this.textBoxKod.Size = new System.Drawing.Size(92, 20);
            this.textBoxKod.TabIndex = 28;
            // 
            // семьяTableAdapter
            // 
            this.семьяTableAdapter.ClearBeforeFill = true;
            // 
            // SearchFamilyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 413);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.StudentFormDelete);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxKod);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SearchFamilyForm";
            this.Text = "SearchFamilyForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchFamilyForm_FormClosing);
            this.Load += new System.EventHandler(this.SearchFamilyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.семьяBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД3DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button StudentFormDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxKod;
        private БД3DataSet бД3DataSet;
        private System.Windows.Forms.BindingSource семьяBindingSource;
        private БД3DataSetTableAdapters.СемьяTableAdapter семьяTableAdapter;
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