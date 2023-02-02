
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
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
            this.dataGridView1.Location = new System.Drawing.Point(-2, 424);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1912, 249);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.label1.Location = new System.Drawing.Point(923, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "Количество детей";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(928, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 26);
            this.textBox1.TabIndex = 40;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(695, 101);
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
            this.label2.Location = new System.Drawing.Point(697, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "Код семьи";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(701, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 26);
            this.textBox2.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(923, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 25);
            this.label3.TabIndex = 51;
            this.label3.Text = "Количество детей";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(928, 250);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(112, 26);
            this.textBox3.TabIndex = 50;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(695, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(494, 49);
            this.button2.TabIndex = 49;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(697, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 25);
            this.label4.TabIndex = 48;
            this.label4.Text = "Код семьи";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(701, 250);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(112, 26);
            this.textBox4.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(240, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 25);
            this.label5.TabIndex = 46;
            this.label5.Text = "Количество детей";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(245, 250);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(112, 26);
            this.textBox5.TabIndex = 45;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(12, 307);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(494, 49);
            this.button3.TabIndex = 44;
            this.button3.Text = "Изменить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(14, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 25);
            this.label6.TabIndex = 43;
            this.label6.Text = "Код семьи";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(18, 250);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(112, 26);
            this.textBox6.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(1623, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 25);
            this.label7.TabIndex = 61;
            this.label7.Text = "Количество детей";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(1628, 250);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(112, 26);
            this.textBox7.TabIndex = 60;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(1395, 307);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(494, 49);
            this.button4.TabIndex = 59;
            this.button4.Text = "Изменить";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(1397, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 25);
            this.label10.TabIndex = 58;
            this.label10.Text = "Код семьи";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(1401, 250);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(112, 26);
            this.textBox8.TabIndex = 57;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(1623, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(193, 25);
            this.label11.TabIndex = 56;
            this.label11.Text = "Количество детей";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(1628, 44);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(112, 26);
            this.textBox9.TabIndex = 55;
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(1395, 101);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(494, 49);
            this.button5.TabIndex = 54;
            this.button5.Text = "Изменить";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(1397, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 25);
            this.label12.TabIndex = 53;
            this.label12.Text = "Код семьи";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(1401, 44);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(112, 26);
            this.textBox10.TabIndex = 52;
            // 
            // EditingFamilyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1922, 673);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox6);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox10;
    }
}