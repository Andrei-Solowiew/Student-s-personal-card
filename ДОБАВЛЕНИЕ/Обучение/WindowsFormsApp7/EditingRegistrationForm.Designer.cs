
namespace WindowsFormsApp7
{
    partial class EditingRegistrationForm
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
            this.местоРегистрацииСтудентаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet = new WindowsFormsApp7._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet();
            this.место_регистрации_студентаTableAdapter = new WindowsFormsApp7._СР_5_ОПБД_Соловьев_Андрей_П9021DataSetTableAdapters.Место_регистрации_студентаTableAdapter();
            this.бД3DataSet = new WindowsFormsApp7.БД3DataSet();
            this.местоРегистрацииСтудентаBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.место_регистрации_студентаTableAdapter1 = new WindowsFormsApp7.БД3DataSetTableAdapters.Место_регистрации_студентаTableAdapter();
            this.кодРегистрацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.населенныйПунктРегистрацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.улицаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.домDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.квартираDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСтудентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFlat = new System.Windows.Forms.TextBox();
            this.ChangeFlat = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxKod4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxHouse = new System.Windows.Forms.TextBox();
            this.ChangeHouse = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxKod3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.ChangeStreet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKod2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.ChangeCity = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxKod1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.местоРегистрацииСтудентаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.местоРегистрацииСтудентаBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодРегистрацииDataGridViewTextBoxColumn,
            this.населенныйПунктРегистрацииDataGridViewTextBoxColumn,
            this.улицаDataGridViewTextBoxColumn,
            this.домDataGridViewTextBoxColumn,
            this.квартираDataGridViewTextBoxColumn,
            this.кодСтудентаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.местоРегистрацииСтудентаBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(11, 224);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(909, 102);
            this.dataGridView1.TabIndex = 0;
            // 
            // местоРегистрацииСтудентаBindingSource
            // 
            this.местоРегистрацииСтудентаBindingSource.DataMember = "Место регистрации студента";
            this.местоРегистрацииСтудентаBindingSource.DataSource = this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet;
            // 
            // _СР_5_ОПБД_Соловьев_Андрей_П9021DataSet
            // 
            this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.DataSetName = "_СР_5_ОПБД_Соловьев_Андрей_П9021DataSet";
            this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // место_регистрации_студентаTableAdapter
            // 
            this.место_регистрации_студентаTableAdapter.ClearBeforeFill = true;
            // 
            // бД3DataSet
            // 
            this.бД3DataSet.DataSetName = "БД3DataSet";
            this.бД3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // местоРегистрацииСтудентаBindingSource1
            // 
            this.местоРегистрацииСтудентаBindingSource1.DataMember = "Место регистрации студента";
            this.местоРегистрацииСтудентаBindingSource1.DataSource = this.бД3DataSet;
            // 
            // место_регистрации_студентаTableAdapter1
            // 
            this.место_регистрации_студентаTableAdapter1.ClearBeforeFill = true;
            // 
            // кодРегистрацииDataGridViewTextBoxColumn
            // 
            this.кодРегистрацииDataGridViewTextBoxColumn.DataPropertyName = "Код регистрации";
            this.кодРегистрацииDataGridViewTextBoxColumn.HeaderText = "Код регистрации";
            this.кодРегистрацииDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.кодРегистрацииDataGridViewTextBoxColumn.Name = "кодРегистрацииDataGridViewTextBoxColumn";
            this.кодРегистрацииDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодРегистрацииDataGridViewTextBoxColumn.Width = 75;
            // 
            // населенныйПунктРегистрацииDataGridViewTextBoxColumn
            // 
            this.населенныйПунктРегистрацииDataGridViewTextBoxColumn.DataPropertyName = "Населенный пункт регистрации";
            this.населенныйПунктРегистрацииDataGridViewTextBoxColumn.HeaderText = "Населенный пункт регистрации";
            this.населенныйПунктРегистрацииDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.населенныйПунктРегистрацииDataGridViewTextBoxColumn.Name = "населенныйПунктРегистрацииDataGridViewTextBoxColumn";
            this.населенныйПунктРегистрацииDataGridViewTextBoxColumn.ReadOnly = true;
            this.населенныйПунктРегистрацииDataGridViewTextBoxColumn.Width = 150;
            // 
            // улицаDataGridViewTextBoxColumn
            // 
            this.улицаDataGridViewTextBoxColumn.DataPropertyName = "Улица";
            this.улицаDataGridViewTextBoxColumn.HeaderText = "Улица";
            this.улицаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.улицаDataGridViewTextBoxColumn.Name = "улицаDataGridViewTextBoxColumn";
            this.улицаDataGridViewTextBoxColumn.ReadOnly = true;
            this.улицаDataGridViewTextBoxColumn.Width = 150;
            // 
            // домDataGridViewTextBoxColumn
            // 
            this.домDataGridViewTextBoxColumn.DataPropertyName = "Дом";
            this.домDataGridViewTextBoxColumn.HeaderText = "Дом";
            this.домDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.домDataGridViewTextBoxColumn.Name = "домDataGridViewTextBoxColumn";
            this.домDataGridViewTextBoxColumn.ReadOnly = true;
            this.домDataGridViewTextBoxColumn.Width = 150;
            // 
            // квартираDataGridViewTextBoxColumn
            // 
            this.квартираDataGridViewTextBoxColumn.DataPropertyName = "Квартира";
            this.квартираDataGridViewTextBoxColumn.HeaderText = "Квартира";
            this.квартираDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.квартираDataGridViewTextBoxColumn.Name = "квартираDataGridViewTextBoxColumn";
            this.квартираDataGridViewTextBoxColumn.ReadOnly = true;
            this.квартираDataGridViewTextBoxColumn.Width = 150;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(782, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 71;
            this.label5.Text = "Квартира";
            // 
            // textBoxFlat
            // 
            this.textBoxFlat.Location = new System.Drawing.Point(785, 141);
            this.textBoxFlat.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFlat.Name = "textBoxFlat";
            this.textBoxFlat.Size = new System.Drawing.Size(68, 20);
            this.textBoxFlat.TabIndex = 70;
            // 
            // ChangeFlat
            // 
            this.ChangeFlat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeFlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeFlat.Location = new System.Drawing.Point(573, 178);
            this.ChangeFlat.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeFlat.Name = "ChangeFlat";
            this.ChangeFlat.Size = new System.Drawing.Size(280, 32);
            this.ChangeFlat.TabIndex = 69;
            this.ChangeFlat.Text = "Изменить";
            this.ChangeFlat.UseVisualStyleBackColor = true;
            this.ChangeFlat.Click += new System.EventHandler(this.ChangeFlat_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(574, 122);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 17);
            this.label6.TabIndex = 68;
            this.label6.Text = "Код регистрации";
            // 
            // textBoxKod4
            // 
            this.textBoxKod4.Location = new System.Drawing.Point(577, 141);
            this.textBoxKod4.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKod4.Name = "textBoxKod4";
            this.textBoxKod4.Size = new System.Drawing.Size(117, 20);
            this.textBoxKod4.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(335, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 66;
            this.label3.Text = "Дом";
            // 
            // textBoxHouse
            // 
            this.textBoxHouse.Location = new System.Drawing.Point(338, 141);
            this.textBoxHouse.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxHouse.Name = "textBoxHouse";
            this.textBoxHouse.Size = new System.Drawing.Size(33, 20);
            this.textBoxHouse.TabIndex = 65;
            // 
            // ChangeHouse
            // 
            this.ChangeHouse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeHouse.Location = new System.Drawing.Point(91, 178);
            this.ChangeHouse.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeHouse.Name = "ChangeHouse";
            this.ChangeHouse.Size = new System.Drawing.Size(280, 32);
            this.ChangeHouse.TabIndex = 64;
            this.ChangeHouse.Text = "Изменить";
            this.ChangeHouse.UseVisualStyleBackColor = true;
            this.ChangeHouse.Click += new System.EventHandler(this.ChangeHouse_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(92, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 63;
            this.label4.Text = "Код регистрации";
            // 
            // textBoxKod3
            // 
            this.textBoxKod3.Location = new System.Drawing.Point(95, 141);
            this.textBoxKod3.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKod3.Name = "textBoxKod3";
            this.textBoxKod3.Size = new System.Drawing.Size(117, 20);
            this.textBoxKod3.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(804, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 61;
            this.label1.Text = "Улица";
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(807, 29);
            this.textBoxStreet.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(46, 20);
            this.textBoxStreet.TabIndex = 60;
            // 
            // ChangeStreet
            // 
            this.ChangeStreet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeStreet.Location = new System.Drawing.Point(573, 66);
            this.ChangeStreet.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeStreet.Name = "ChangeStreet";
            this.ChangeStreet.Size = new System.Drawing.Size(280, 32);
            this.ChangeStreet.TabIndex = 59;
            this.ChangeStreet.Text = "Изменить";
            this.ChangeStreet.UseVisualStyleBackColor = true;
            this.ChangeStreet.Click += new System.EventHandler(this.ChangeStreet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(574, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 58;
            this.label2.Text = "Код регистрации";
            // 
            // textBoxKod2
            // 
            this.textBoxKod2.Location = new System.Drawing.Point(577, 29);
            this.textBoxKod2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKod2.Name = "textBoxKod2";
            this.textBoxKod2.Size = new System.Drawing.Size(117, 20);
            this.textBoxKod2.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(239, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 17);
            this.label9.TabIndex = 56;
            this.label9.Text = "Населенный пункт";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(242, 29);
            this.textBoxCity.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(129, 20);
            this.textBoxCity.TabIndex = 55;
            // 
            // ChangeCity
            // 
            this.ChangeCity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeCity.Location = new System.Drawing.Point(91, 66);
            this.ChangeCity.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeCity.Name = "ChangeCity";
            this.ChangeCity.Size = new System.Drawing.Size(280, 32);
            this.ChangeCity.TabIndex = 54;
            this.ChangeCity.Text = "Изменить";
            this.ChangeCity.UseVisualStyleBackColor = true;
            this.ChangeCity.Click += new System.EventHandler(this.ChangeCity_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(92, 10);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 17);
            this.label8.TabIndex = 53;
            this.label8.Text = "Код регистрации";
            // 
            // textBoxKod1
            // 
            this.textBoxKod1.Location = new System.Drawing.Point(95, 29);
            this.textBoxKod1.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKod1.Name = "textBoxKod1";
            this.textBoxKod1.Size = new System.Drawing.Size(117, 20);
            this.textBoxKod1.TabIndex = 52;
            // 
            // EditingRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 337);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxFlat);
            this.Controls.Add(this.ChangeFlat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxKod4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxHouse);
            this.Controls.Add(this.ChangeHouse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxKod3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxStreet);
            this.Controls.Add(this.ChangeStreet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxKod2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.ChangeCity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxKod1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditingRegistrationForm";
            this.Text = "EditingRegistrationForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditingRegistrationForm_FormClosing);
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.местоРегистрацииСтудентаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.местоРегистрацииСтудентаBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _СР_5_ОПБД_Соловьев_Андрей_П9021DataSet _СР_5_ОПБД_Соловьев_Андрей_П9021DataSet;
        private System.Windows.Forms.BindingSource местоРегистрацииСтудентаBindingSource;
        private _СР_5_ОПБД_Соловьев_Андрей_П9021DataSetTableAdapters.Место_регистрации_студентаTableAdapter место_регистрации_студентаTableAdapter;
        private БД3DataSet бД3DataSet;
        private System.Windows.Forms.BindingSource местоРегистрацииСтудентаBindingSource1;
        private БД3DataSetTableAdapters.Место_регистрации_студентаTableAdapter место_регистрации_студентаTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодРегистрацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn населенныйПунктРегистрацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn улицаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn домDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn квартираDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСтудентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFlat;
        private System.Windows.Forms.Button ChangeFlat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxKod4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxHouse;
        private System.Windows.Forms.Button ChangeHouse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxKod3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.Button ChangeStreet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKod2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Button ChangeCity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxKod1;
    }
}