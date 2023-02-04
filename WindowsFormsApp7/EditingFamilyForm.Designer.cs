
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditingFamilyForm));
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
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxUpdateToday = new System.Windows.Forms.TextBox();
            this.FamilyFormChangeComp = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxKodStudentChange = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxReason = new System.Windows.Forms.TextBox();
            this.FamilyFormChangeReason = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKodFamily1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxChildren = new System.Windows.Forms.TextBox();
            this.ChangeChildren = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxKod3 = new System.Windows.Forms.TextBox();
            this.ChangeToday = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPlace = new System.Windows.Forms.TextBox();
            this.ChangePlace = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxKod5 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxChildrenDate = new System.Windows.Forms.TextBox();
            this.ChangeChildrenDate = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxKod4 = new System.Windows.Forms.TextBox();
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
            this.dataGridView1.DataSource = this.семьяBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 354);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(889, 245);
            this.dataGridView1.TabIndex = 100;
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(164, 20);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 17);
            this.label9.TabIndex = 36;
            this.label9.Text = "Полная ли семья";
            // 
            // textBoxUpdateToday
            // 
            this.textBoxUpdateToday.Location = new System.Drawing.Point(167, 39);
            this.textBoxUpdateToday.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUpdateToday.Name = "textBoxUpdateToday";
            this.textBoxUpdateToday.Size = new System.Drawing.Size(118, 20);
            this.textBoxUpdateToday.TabIndex = 2;
            this.textBoxUpdateToday.TextChanged += new System.EventHandler(this.textBoxUpdateToday_TextChanged);
            // 
            // FamilyFormChangeComp
            // 
            this.FamilyFormChangeComp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FamilyFormChangeComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FamilyFormChangeComp.Location = new System.Drawing.Point(12, 76);
            this.FamilyFormChangeComp.Margin = new System.Windows.Forms.Padding(2);
            this.FamilyFormChangeComp.Name = "FamilyFormChangeComp";
            this.FamilyFormChangeComp.Size = new System.Drawing.Size(273, 32);
            this.FamilyFormChangeComp.TabIndex = 3;
            this.FamilyFormChangeComp.Text = "Изменить";
            this.FamilyFormChangeComp.UseVisualStyleBackColor = true;
            this.FamilyFormChangeComp.Click += new System.EventHandler(this.FamilyFormChangeComp_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(13, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Код семьи";
            // 
            // textBoxKodStudentChange
            // 
            this.textBoxKodStudentChange.Location = new System.Drawing.Point(16, 39);
            this.textBoxKodStudentChange.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKodStudentChange.Name = "textBoxKodStudentChange";
            this.textBoxKodStudentChange.Size = new System.Drawing.Size(73, 20);
            this.textBoxKodStudentChange.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(451, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "Причина неполноты";
            // 
            // textBoxReason
            // 
            this.textBoxReason.Location = new System.Drawing.Point(454, 39);
            this.textBoxReason.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxReason.Name = "textBoxReason";
            this.textBoxReason.Size = new System.Drawing.Size(140, 20);
            this.textBoxReason.TabIndex = 5;
            // 
            // FamilyFormChangeReason
            // 
            this.FamilyFormChangeReason.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FamilyFormChangeReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FamilyFormChangeReason.Location = new System.Drawing.Point(321, 76);
            this.FamilyFormChangeReason.Margin = new System.Windows.Forms.Padding(2);
            this.FamilyFormChangeReason.Name = "FamilyFormChangeReason";
            this.FamilyFormChangeReason.Size = new System.Drawing.Size(273, 32);
            this.FamilyFormChangeReason.TabIndex = 6;
            this.FamilyFormChangeReason.Text = "Изменить";
            this.FamilyFormChangeReason.UseVisualStyleBackColor = true;
            this.FamilyFormChangeReason.Click += new System.EventHandler(this.FamilyFormChangeReason_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(322, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Код семьи";
            // 
            // textBoxKodFamily1
            // 
            this.textBoxKodFamily1.Location = new System.Drawing.Point(325, 39);
            this.textBoxKodFamily1.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKodFamily1.Name = "textBoxKodFamily1";
            this.textBoxKodFamily1.Size = new System.Drawing.Size(73, 20);
            this.textBoxKodFamily1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(772, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 46;
            this.label3.Text = "Количество детей";
            // 
            // textBoxChildren
            // 
            this.textBoxChildren.Location = new System.Drawing.Point(775, 39);
            this.textBoxChildren.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxChildren.Name = "textBoxChildren";
            this.textBoxChildren.Size = new System.Drawing.Size(126, 20);
            this.textBoxChildren.TabIndex = 8;
            // 
            // ChangeChildren
            // 
            this.ChangeChildren.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeChildren.Location = new System.Drawing.Point(628, 76);
            this.ChangeChildren.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeChildren.Name = "ChangeChildren";
            this.ChangeChildren.Size = new System.Drawing.Size(273, 32);
            this.ChangeChildren.TabIndex = 9;
            this.ChangeChildren.Text = "Изменить";
            this.ChangeChildren.UseVisualStyleBackColor = true;
            this.ChangeChildren.Click += new System.EventHandler(this.ChangeChildren_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(629, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "Код семьи";
            // 
            // textBoxKod3
            // 
            this.textBoxKod3.Location = new System.Drawing.Point(632, 39);
            this.textBoxKod3.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKod3.Name = "textBoxKod3";
            this.textBoxKod3.Size = new System.Drawing.Size(73, 20);
            this.textBoxKod3.TabIndex = 7;
            // 
            // ChangeToday
            // 
            this.ChangeToday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeToday.Location = new System.Drawing.Point(321, 269);
            this.ChangeToday.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeToday.Name = "ChangeToday";
            this.ChangeToday.Size = new System.Drawing.Size(273, 32);
            this.ChangeToday.TabIndex = 18;
            this.ChangeToday.Text = "Изменить сегодняшнюю дату ";
            this.ChangeToday.UseVisualStyleBackColor = true;
            this.ChangeToday.Click += new System.EventHandler(this.ChangeToday_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(663, 144);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 56;
            this.label7.Text = "Где живут";
            // 
            // textBoxPlace
            // 
            this.textBoxPlace.Location = new System.Drawing.Point(666, 163);
            this.textBoxPlace.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPlace.Name = "textBoxPlace";
            this.textBoxPlace.Size = new System.Drawing.Size(71, 20);
            this.textBoxPlace.TabIndex = 14;
            // 
            // ChangePlace
            // 
            this.ChangePlace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangePlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangePlace.Location = new System.Drawing.Point(464, 200);
            this.ChangePlace.Margin = new System.Windows.Forms.Padding(2);
            this.ChangePlace.Name = "ChangePlace";
            this.ChangePlace.Size = new System.Drawing.Size(273, 32);
            this.ChangePlace.TabIndex = 15;
            this.ChangePlace.Text = "Изменить";
            this.ChangePlace.UseVisualStyleBackColor = true;
            this.ChangePlace.Click += new System.EventHandler(this.ChangePlace_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(465, 144);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 17);
            this.label10.TabIndex = 53;
            this.label10.Text = "Код семьи";
            // 
            // textBoxKod5
            // 
            this.textBoxKod5.Location = new System.Drawing.Point(468, 163);
            this.textBoxKod5.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKod5.Name = "textBoxKod5";
            this.textBoxKod5.Size = new System.Drawing.Size(73, 20);
            this.textBoxKod5.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(260, 144);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 17);
            this.label11.TabIndex = 51;
            this.label11.Text = "Дата рождения каждого";
            // 
            // textBoxChildrenDate
            // 
            this.textBoxChildrenDate.Location = new System.Drawing.Point(263, 163);
            this.textBoxChildrenDate.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxChildrenDate.Name = "textBoxChildrenDate";
            this.textBoxChildrenDate.Size = new System.Drawing.Size(165, 20);
            this.textBoxChildrenDate.TabIndex = 11;
            // 
            // ChangeChildrenDate
            // 
            this.ChangeChildrenDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeChildrenDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeChildrenDate.Location = new System.Drawing.Point(155, 200);
            this.ChangeChildrenDate.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeChildrenDate.Name = "ChangeChildrenDate";
            this.ChangeChildrenDate.Size = new System.Drawing.Size(273, 32);
            this.ChangeChildrenDate.TabIndex = 12;
            this.ChangeChildrenDate.Text = "Изменить";
            this.ChangeChildrenDate.UseVisualStyleBackColor = true;
            this.ChangeChildrenDate.Click += new System.EventHandler(this.ChangeChildrenDate_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(156, 144);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 17);
            this.label12.TabIndex = 48;
            this.label12.Text = "Код семьи";
            // 
            // textBoxKod4
            // 
            this.textBoxKod4.Location = new System.Drawing.Point(159, 163);
            this.textBoxKod4.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKod4.Name = "textBoxKod4";
            this.textBoxKod4.Size = new System.Drawing.Size(73, 20);
            this.textBoxKod4.TabIndex = 10;
            // 
            // EditingFamilyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 611);
            this.Controls.Add(this.ChangeToday);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxPlace);
            this.Controls.Add(this.ChangePlace);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxKod5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxChildrenDate);
            this.Controls.Add(this.ChangeChildrenDate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxKod4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxChildren);
            this.Controls.Add(this.ChangeChildren);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxKod3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxReason);
            this.Controls.Add(this.FamilyFormChangeReason);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxKodFamily1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxUpdateToday);
            this.Controls.Add(this.FamilyFormChangeComp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxKodStudentChange);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditingFamilyForm";
            this.Text = "EditingFamilyForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditingFamilyForm_FormClosing);
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.семьяBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.семьяBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.семьяBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxUpdateToday;
        private System.Windows.Forms.Button FamilyFormChangeComp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxKodStudentChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxReason;
        private System.Windows.Forms.Button FamilyFormChangeReason;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKodFamily1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxChildren;
        private System.Windows.Forms.Button ChangeChildren;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxKod3;
        private System.Windows.Forms.Button ChangeToday;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPlace;
        private System.Windows.Forms.Button ChangePlace;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxKod5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxChildrenDate;
        private System.Windows.Forms.Button ChangeChildrenDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxKod4;
    }
}