
namespace WindowsFormsApp7
{
    partial class EditingLivingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditingLivingForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодПроживанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.населенныйПунктПроживанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.улицаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.домDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.квартираDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСтудентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.местоПроживанияСтудентаBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.бД3DataSet = new WindowsFormsApp7.БД3DataSet();
            this.местоПроживанияСтудентаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet = new WindowsFormsApp7._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet();
            this.место_проживания_студентаTableAdapter = new WindowsFormsApp7._СР_5_ОПБД_Соловьев_Андрей_П9021DataSetTableAdapters.Место_проживания_студентаTableAdapter();
            this.место_проживания_студентаTableAdapter1 = new WindowsFormsApp7.БД3DataSetTableAdapters.Место_проживания_студентаTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.местоПроживанияСтудентаBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.местоПроживанияСтудентаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодПроживанияDataGridViewTextBoxColumn,
            this.населенныйПунктПроживанияDataGridViewTextBoxColumn,
            this.улицаDataGridViewTextBoxColumn,
            this.домDataGridViewTextBoxColumn,
            this.квартираDataGridViewTextBoxColumn,
            this.кодСтудентаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.местоПроживанияСтудентаBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(11, 236);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(902, 269);
            this.dataGridView1.TabIndex = 100;
            // 
            // кодПроживанияDataGridViewTextBoxColumn
            // 
            this.кодПроживанияDataGridViewTextBoxColumn.DataPropertyName = "Код проживания";
            this.кодПроживанияDataGridViewTextBoxColumn.HeaderText = "Код проживания";
            this.кодПроживанияDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.кодПроживанияDataGridViewTextBoxColumn.Name = "кодПроживанияDataGridViewTextBoxColumn";
            this.кодПроживанияDataGridViewTextBoxColumn.Width = 75;
            // 
            // населенныйПунктПроживанияDataGridViewTextBoxColumn
            // 
            this.населенныйПунктПроживанияDataGridViewTextBoxColumn.DataPropertyName = "Населенный пункт проживания";
            this.населенныйПунктПроживанияDataGridViewTextBoxColumn.HeaderText = "Населенный пункт проживания";
            this.населенныйПунктПроживанияDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.населенныйПунктПроживанияDataGridViewTextBoxColumn.Name = "населенныйПунктПроживанияDataGridViewTextBoxColumn";
            this.населенныйПунктПроживанияDataGridViewTextBoxColumn.Width = 150;
            // 
            // улицаDataGridViewTextBoxColumn
            // 
            this.улицаDataGridViewTextBoxColumn.DataPropertyName = "Улица";
            this.улицаDataGridViewTextBoxColumn.HeaderText = "Улица";
            this.улицаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.улицаDataGridViewTextBoxColumn.Name = "улицаDataGridViewTextBoxColumn";
            this.улицаDataGridViewTextBoxColumn.Width = 150;
            // 
            // домDataGridViewTextBoxColumn
            // 
            this.домDataGridViewTextBoxColumn.DataPropertyName = "Дом";
            this.домDataGridViewTextBoxColumn.HeaderText = "Дом";
            this.домDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.домDataGridViewTextBoxColumn.Name = "домDataGridViewTextBoxColumn";
            this.домDataGridViewTextBoxColumn.Width = 150;
            // 
            // квартираDataGridViewTextBoxColumn
            // 
            this.квартираDataGridViewTextBoxColumn.DataPropertyName = "Квартира";
            this.квартираDataGridViewTextBoxColumn.HeaderText = "Квартира";
            this.квартираDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.квартираDataGridViewTextBoxColumn.Name = "квартираDataGridViewTextBoxColumn";
            this.квартираDataGridViewTextBoxColumn.Width = 150;
            // 
            // кодСтудентаDataGridViewTextBoxColumn
            // 
            this.кодСтудентаDataGridViewTextBoxColumn.DataPropertyName = "Код студента";
            this.кодСтудентаDataGridViewTextBoxColumn.HeaderText = "Код студента";
            this.кодСтудентаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.кодСтудентаDataGridViewTextBoxColumn.Name = "кодСтудентаDataGridViewTextBoxColumn";
            this.кодСтудентаDataGridViewTextBoxColumn.Width = 150;
            // 
            // местоПроживанияСтудентаBindingSource1
            // 
            this.местоПроживанияСтудентаBindingSource1.DataMember = "Место проживания студента";
            this.местоПроживанияСтудентаBindingSource1.DataSource = this.бД3DataSet;
            // 
            // бД3DataSet
            // 
            this.бД3DataSet.DataSetName = "БД3DataSet";
            this.бД3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // местоПроживанияСтудентаBindingSource
            // 
            this.местоПроживанияСтудентаBindingSource.DataMember = "Место проживания студента";
            this.местоПроживанияСтудентаBindingSource.DataSource = this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet;
            // 
            // _СР_5_ОПБД_Соловьев_Андрей_П9021DataSet
            // 
            this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.DataSetName = "_СР_5_ОПБД_Соловьев_Андрей_П9021DataSet";
            this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // место_проживания_студентаTableAdapter
            // 
            this.место_проживания_студентаTableAdapter.ClearBeforeFill = true;
            // 
            // место_проживания_студентаTableAdapter1
            // 
            this.место_проживания_студентаTableAdapter1.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(777, 125);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 91;
            this.label5.Text = "Квартира";
            // 
            // textBoxFlat
            // 
            this.textBoxFlat.Location = new System.Drawing.Point(780, 144);
            this.textBoxFlat.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFlat.Name = "textBoxFlat";
            this.textBoxFlat.Size = new System.Drawing.Size(68, 20);
            this.textBoxFlat.TabIndex = 11;
            // 
            // ChangeFlat
            // 
            this.ChangeFlat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeFlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeFlat.Location = new System.Drawing.Point(568, 181);
            this.ChangeFlat.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeFlat.Name = "ChangeFlat";
            this.ChangeFlat.Size = new System.Drawing.Size(280, 32);
            this.ChangeFlat.TabIndex = 12;
            this.ChangeFlat.Text = "Изменить";
            this.ChangeFlat.UseVisualStyleBackColor = true;
            this.ChangeFlat.Click += new System.EventHandler(this.ChangeFlat_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(569, 125);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 88;
            this.label6.Text = "Код проживания";
            // 
            // textBoxKod4
            // 
            this.textBoxKod4.Location = new System.Drawing.Point(572, 144);
            this.textBoxKod4.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKod4.Name = "textBoxKod4";
            this.textBoxKod4.Size = new System.Drawing.Size(117, 20);
            this.textBoxKod4.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(330, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 86;
            this.label3.Text = "Дом";
            // 
            // textBoxHouse
            // 
            this.textBoxHouse.Location = new System.Drawing.Point(333, 144);
            this.textBoxHouse.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxHouse.Name = "textBoxHouse";
            this.textBoxHouse.Size = new System.Drawing.Size(33, 20);
            this.textBoxHouse.TabIndex = 8;
            // 
            // ChangeHouse
            // 
            this.ChangeHouse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeHouse.Location = new System.Drawing.Point(86, 181);
            this.ChangeHouse.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeHouse.Name = "ChangeHouse";
            this.ChangeHouse.Size = new System.Drawing.Size(280, 32);
            this.ChangeHouse.TabIndex = 9;
            this.ChangeHouse.Text = "Изменить";
            this.ChangeHouse.UseVisualStyleBackColor = true;
            this.ChangeHouse.Click += new System.EventHandler(this.ChangeHouse_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(87, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 83;
            this.label4.Text = "Код проживания";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxKod3
            // 
            this.textBoxKod3.Location = new System.Drawing.Point(90, 144);
            this.textBoxKod3.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKod3.Name = "textBoxKod3";
            this.textBoxKod3.Size = new System.Drawing.Size(117, 20);
            this.textBoxKod3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(799, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 81;
            this.label1.Text = "Улица";
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(802, 32);
            this.textBoxStreet.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(46, 20);
            this.textBoxStreet.TabIndex = 5;
            // 
            // ChangeStreet
            // 
            this.ChangeStreet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeStreet.Location = new System.Drawing.Point(568, 69);
            this.ChangeStreet.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeStreet.Name = "ChangeStreet";
            this.ChangeStreet.Size = new System.Drawing.Size(280, 32);
            this.ChangeStreet.TabIndex = 6;
            this.ChangeStreet.Text = "Изменить";
            this.ChangeStreet.UseVisualStyleBackColor = true;
            this.ChangeStreet.Click += new System.EventHandler(this.ChangeStreet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(569, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 78;
            this.label2.Text = "Код проживания";
            // 
            // textBoxKod2
            // 
            this.textBoxKod2.Location = new System.Drawing.Point(572, 32);
            this.textBoxKod2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKod2.Name = "textBoxKod2";
            this.textBoxKod2.Size = new System.Drawing.Size(117, 20);
            this.textBoxKod2.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(234, 12);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 17);
            this.label9.TabIndex = 76;
            this.label9.Text = "Населенный пункт";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(237, 32);
            this.textBoxCity.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(129, 20);
            this.textBoxCity.TabIndex = 2;
            // 
            // ChangeCity
            // 
            this.ChangeCity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeCity.Location = new System.Drawing.Point(86, 69);
            this.ChangeCity.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeCity.Name = "ChangeCity";
            this.ChangeCity.Size = new System.Drawing.Size(280, 32);
            this.ChangeCity.TabIndex = 3;
            this.ChangeCity.Text = "Изменить";
            this.ChangeCity.UseVisualStyleBackColor = true;
            this.ChangeCity.Click += new System.EventHandler(this.ChangeCity_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(87, 13);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 17);
            this.label8.TabIndex = 73;
            this.label8.Text = "Код проживания";
            // 
            // textBoxKod1
            // 
            this.textBoxKod1.Location = new System.Drawing.Point(90, 32);
            this.textBoxKod1.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKod1.Name = "textBoxKod1";
            this.textBoxKod1.Size = new System.Drawing.Size(117, 20);
            this.textBoxKod1.TabIndex = 1;
            // 
            // EditingLivingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 516);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditingLivingForm";
            this.Text = "EditingLivingForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditingLivingForm_FormClosing);
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.местоПроживанияСтудентаBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.местоПроживанияСтудентаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _СР_5_ОПБД_Соловьев_Андрей_П9021DataSet _СР_5_ОПБД_Соловьев_Андрей_П9021DataSet;
        private System.Windows.Forms.BindingSource местоПроживанияСтудентаBindingSource;
        private _СР_5_ОПБД_Соловьев_Андрей_П9021DataSetTableAdapters.Место_проживания_студентаTableAdapter место_проживания_студентаTableAdapter;
        private БД3DataSet бД3DataSet;
        private System.Windows.Forms.BindingSource местоПроживанияСтудентаBindingSource1;
        private БД3DataSetTableAdapters.Место_проживания_студентаTableAdapter место_проживания_студентаTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПроживанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn населенныйПунктПроживанияDataGridViewTextBoxColumn;
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