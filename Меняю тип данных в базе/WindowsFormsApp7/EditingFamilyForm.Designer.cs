
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодСемьиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.полнаяЛиСемьяDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.причинаНеполнотыСемьиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоДетейDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаРожденияКаждогоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.гдеЖивутдомКвартираDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сегодняшняяДатаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСтудентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.семьяBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet = new WindowsFormsApp7._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet();
            this.семьяTableAdapter = new WindowsFormsApp7._СР_5_ОПБД_Соловьев_Андрей_П9021DataSetTableAdapters.СемьяTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxUpdateToday = new System.Windows.Forms.TextBox();
            this.FamilyFormChildrenChange = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxKodStudentChange = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.семьяBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодСемьиDataGridViewTextBoxColumn,
            this.полнаяЛиСемьяDataGridViewCheckBoxColumn,
            this.причинаНеполнотыСемьиDataGridViewTextBoxColumn,
            this.количествоДетейDataGridViewTextBoxColumn,
            this.датаРожденияКаждогоDataGridViewTextBoxColumn,
            this.гдеЖивутдомКвартираDataGridViewTextBoxColumn,
            this.сегодняшняяДатаDataGridViewTextBoxColumn,
            this.кодСтудентаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.семьяBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 301);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1339, 269);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодСемьиDataGridViewTextBoxColumn
            // 
            this.кодСемьиDataGridViewTextBoxColumn.DataPropertyName = "Код семьи";
            this.кодСемьиDataGridViewTextBoxColumn.HeaderText = "Код семьи";
            this.кодСемьиDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.кодСемьиDataGridViewTextBoxColumn.Name = "кодСемьиDataGridViewTextBoxColumn";
            this.кодСемьиDataGridViewTextBoxColumn.Width = 150;
            // 
            // полнаяЛиСемьяDataGridViewCheckBoxColumn
            // 
            this.полнаяЛиСемьяDataGridViewCheckBoxColumn.DataPropertyName = "Полная ли семья";
            this.полнаяЛиСемьяDataGridViewCheckBoxColumn.HeaderText = "Полная ли семья";
            this.полнаяЛиСемьяDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.полнаяЛиСемьяDataGridViewCheckBoxColumn.Name = "полнаяЛиСемьяDataGridViewCheckBoxColumn";
            this.полнаяЛиСемьяDataGridViewCheckBoxColumn.Width = 150;
            // 
            // причинаНеполнотыСемьиDataGridViewTextBoxColumn
            // 
            this.причинаНеполнотыСемьиDataGridViewTextBoxColumn.DataPropertyName = "Причина неполноты семьи";
            this.причинаНеполнотыСемьиDataGridViewTextBoxColumn.HeaderText = "Причина неполноты семьи";
            this.причинаНеполнотыСемьиDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.причинаНеполнотыСемьиDataGridViewTextBoxColumn.Name = "причинаНеполнотыСемьиDataGridViewTextBoxColumn";
            this.причинаНеполнотыСемьиDataGridViewTextBoxColumn.Width = 150;
            // 
            // количествоДетейDataGridViewTextBoxColumn
            // 
            this.количествоДетейDataGridViewTextBoxColumn.DataPropertyName = "Количество детей";
            this.количествоДетейDataGridViewTextBoxColumn.HeaderText = "Количество детей";
            this.количествоДетейDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.количествоДетейDataGridViewTextBoxColumn.Name = "количествоДетейDataGridViewTextBoxColumn";
            this.количествоДетейDataGridViewTextBoxColumn.Width = 150;
            // 
            // датаРожденияКаждогоDataGridViewTextBoxColumn
            // 
            this.датаРожденияКаждогоDataGridViewTextBoxColumn.DataPropertyName = "Дата рождения каждого";
            this.датаРожденияКаждогоDataGridViewTextBoxColumn.HeaderText = "Дата рождения каждого";
            this.датаРожденияКаждогоDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.датаРожденияКаждогоDataGridViewTextBoxColumn.Name = "датаРожденияКаждогоDataGridViewTextBoxColumn";
            this.датаРожденияКаждогоDataGridViewTextBoxColumn.Width = 150;
            // 
            // гдеЖивутдомКвартираDataGridViewTextBoxColumn
            // 
            this.гдеЖивутдомКвартираDataGridViewTextBoxColumn.DataPropertyName = "Где живут(дом, квартира)";
            this.гдеЖивутдомКвартираDataGridViewTextBoxColumn.HeaderText = "Где живут(дом, квартира)";
            this.гдеЖивутдомКвартираDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.гдеЖивутдомКвартираDataGridViewTextBoxColumn.Name = "гдеЖивутдомКвартираDataGridViewTextBoxColumn";
            this.гдеЖивутдомКвартираDataGridViewTextBoxColumn.Width = 150;
            // 
            // сегодняшняяДатаDataGridViewTextBoxColumn
            // 
            this.сегодняшняяДатаDataGridViewTextBoxColumn.DataPropertyName = "Сегодняшняя дата";
            this.сегодняшняяДатаDataGridViewTextBoxColumn.HeaderText = "Сегодняшняя дата";
            this.сегодняшняяДатаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.сегодняшняяДатаDataGridViewTextBoxColumn.Name = "сегодняшняяДатаDataGridViewTextBoxColumn";
            this.сегодняшняяДатаDataGridViewTextBoxColumn.Width = 150;
            // 
            // кодСтудентаDataGridViewTextBoxColumn
            // 
            this.кодСтудентаDataGridViewTextBoxColumn.DataPropertyName = "Код студента";
            this.кодСтудентаDataGridViewTextBoxColumn.HeaderText = "Код студента";
            this.кодСтудентаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.кодСтудентаDataGridViewTextBoxColumn.Name = "кодСтудентаDataGridViewTextBoxColumn";
            this.кодСтудентаDataGridViewTextBoxColumn.Width = 150;
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(240, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 25);
            this.label9.TabIndex = 36;
            this.label9.Text = "Количество детей";
            // 
            // textBoxUpdateToday
            // 
            this.textBoxUpdateToday.Location = new System.Drawing.Point(245, 44);
            this.textBoxUpdateToday.Name = "textBoxUpdateToday";
            this.textBoxUpdateToday.Size = new System.Drawing.Size(112, 26);
            this.textBoxUpdateToday.TabIndex = 35;
            // 
            // FamilyFormChildrenChange
            // 
            this.FamilyFormChildrenChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FamilyFormChildrenChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FamilyFormChildrenChange.Location = new System.Drawing.Point(12, 101);
            this.FamilyFormChildrenChange.Name = "FamilyFormChildrenChange";
            this.FamilyFormChildrenChange.Size = new System.Drawing.Size(494, 49);
            this.FamilyFormChildrenChange.TabIndex = 34;
            this.FamilyFormChildrenChange.Text = "Изменить";
            this.FamilyFormChildrenChange.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(14, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 25);
            this.label8.TabIndex = 33;
            this.label8.Text = "Код семьи";
            // 
            // textBoxKodStudentChange
            // 
            this.textBoxKodStudentChange.Location = new System.Drawing.Point(18, 44);
            this.textBoxKodStudentChange.Name = "textBoxKodStudentChange";
            this.textBoxKodStudentChange.Size = new System.Drawing.Size(112, 26);
            this.textBoxKodStudentChange.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(775, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "Количество детей";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(780, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 26);
            this.textBox1.TabIndex = 40;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(547, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(494, 49);
            this.button1.TabIndex = 39;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(549, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "Код семьи";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(553, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 26);
            this.textBox2.TabIndex = 37;
            // 
            // EditingFamilyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 582);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxUpdateToday);
            this.Controls.Add(this.FamilyFormChildrenChange);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxKodStudentChange);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EditingFamilyForm";
            this.Text = "EditingFamilyForm";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.семьяBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _СР_5_ОПБД_Соловьев_Андрей_П9021DataSet _СР_5_ОПБД_Соловьев_Андрей_П9021DataSet;
        private System.Windows.Forms.BindingSource семьяBindingSource;
        private _СР_5_ОПБД_Соловьев_Андрей_П9021DataSetTableAdapters.СемьяTableAdapter семьяTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСемьиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn полнаяЛиСемьяDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn причинаНеполнотыСемьиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоДетейDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаРожденияКаждогоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn гдеЖивутдомКвартираDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сегодняшняяДатаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСтудентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxUpdateToday;
        private System.Windows.Forms.Button FamilyFormChildrenChange;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxKodStudentChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
    }
}