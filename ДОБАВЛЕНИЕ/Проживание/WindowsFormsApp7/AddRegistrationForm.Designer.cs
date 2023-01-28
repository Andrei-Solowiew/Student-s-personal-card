
namespace WindowsFormsApp7
{
    partial class AddRegistrationForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxKodStudent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFlat = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxHouse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKodRegistration = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.бД3DataSet = new WindowsFormsApp7.БД3DataSet();
            this.местоРегистрацииСтудентаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.место_регистрации_студентаTableAdapter = new WindowsFormsApp7.БД3DataSetTableAdapters.Место_регистрации_студентаTableAdapter();
            this.кодРегистрацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.населенныйПунктРегистрацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.улицаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.домDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.квартираDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСтудентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.местоРегистрацииСтудентаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(652, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 75;
            this.label6.Text = "Код студента";
            // 
            // textBoxKodStudent
            // 
            this.textBoxKodStudent.Location = new System.Drawing.Point(655, 44);
            this.textBoxKodStudent.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKodStudent.Name = "textBoxKodStudent";
            this.textBoxKodStudent.Size = new System.Drawing.Size(94, 20);
            this.textBoxKodStudent.TabIndex = 74;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(535, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 73;
            this.label5.Text = "Квартира";
            // 
            // textBoxFlat
            // 
            this.textBoxFlat.Location = new System.Drawing.Point(538, 44);
            this.textBoxFlat.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFlat.Name = "textBoxFlat";
            this.textBoxFlat.Size = new System.Drawing.Size(68, 20);
            this.textBoxFlat.TabIndex = 72;
            // 
            // Add
            // 
            this.Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.Location = new System.Drawing.Point(236, 107);
            this.Add.Margin = new System.Windows.Forms.Padding(2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(329, 32);
            this.Add.TabIndex = 71;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(456, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 70;
            this.label4.Text = "Дом";
            // 
            // textBoxHouse
            // 
            this.textBoxHouse.Location = new System.Drawing.Point(459, 44);
            this.textBoxHouse.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxHouse.Name = "textBoxHouse";
            this.textBoxHouse.Size = new System.Drawing.Size(33, 20);
            this.textBoxHouse.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(368, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 68;
            this.label3.Text = "Улица";
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(371, 44);
            this.textBoxStreet.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(46, 20);
            this.textBoxStreet.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(199, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 66;
            this.label2.Text = "Населенный пункт";
            // 
            // textBoxSity
            // 
            this.textBoxSity.Location = new System.Drawing.Point(202, 44);
            this.textBoxSity.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSity.Name = "textBoxSity";
            this.textBoxSity.Size = new System.Drawing.Size(129, 20);
            this.textBoxSity.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(36, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 64;
            this.label1.Text = "Код регистрации";
            // 
            // textBoxKodRegistration
            // 
            this.textBoxKodRegistration.Location = new System.Drawing.Point(39, 44);
            this.textBoxKodRegistration.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKodRegistration.Name = "textBoxKodRegistration";
            this.textBoxKodRegistration.Size = new System.Drawing.Size(117, 20);
            this.textBoxKodRegistration.TabIndex = 63;
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
            this.dataGridView1.DataSource = this.местоРегистрацииСтудентаBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(39, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(710, 236);
            this.dataGridView1.TabIndex = 76;
            // 
            // бД3DataSet
            // 
            this.бД3DataSet.DataSetName = "БД3DataSet";
            this.бД3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // местоРегистрацииСтудентаBindingSource
            // 
            this.местоРегистрацииСтудентаBindingSource.DataMember = "Место регистрации студента";
            this.местоРегистрацииСтудентаBindingSource.DataSource = this.бД3DataSet;
            // 
            // место_регистрации_студентаTableAdapter
            // 
            this.место_регистрации_студентаTableAdapter.ClearBeforeFill = true;
            // 
            // кодРегистрацииDataGridViewTextBoxColumn
            // 
            this.кодРегистрацииDataGridViewTextBoxColumn.DataPropertyName = "Код регистрации";
            this.кодРегистрацииDataGridViewTextBoxColumn.HeaderText = "Код регистрации";
            this.кодРегистрацииDataGridViewTextBoxColumn.Name = "кодРегистрацииDataGridViewTextBoxColumn";
            this.кодРегистрацииDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // населенныйПунктРегистрацииDataGridViewTextBoxColumn
            // 
            this.населенныйПунктРегистрацииDataGridViewTextBoxColumn.DataPropertyName = "Населенный пункт регистрации";
            this.населенныйПунктРегистрацииDataGridViewTextBoxColumn.HeaderText = "Населенный пункт регистрации";
            this.населенныйПунктРегистрацииDataGridViewTextBoxColumn.Name = "населенныйПунктРегистрацииDataGridViewTextBoxColumn";
            this.населенныйПунктРегистрацииDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // улицаDataGridViewTextBoxColumn
            // 
            this.улицаDataGridViewTextBoxColumn.DataPropertyName = "Улица";
            this.улицаDataGridViewTextBoxColumn.HeaderText = "Улица";
            this.улицаDataGridViewTextBoxColumn.Name = "улицаDataGridViewTextBoxColumn";
            this.улицаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // домDataGridViewTextBoxColumn
            // 
            this.домDataGridViewTextBoxColumn.DataPropertyName = "Дом";
            this.домDataGridViewTextBoxColumn.HeaderText = "Дом";
            this.домDataGridViewTextBoxColumn.Name = "домDataGridViewTextBoxColumn";
            this.домDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // квартираDataGridViewTextBoxColumn
            // 
            this.квартираDataGridViewTextBoxColumn.DataPropertyName = "Квартира";
            this.квартираDataGridViewTextBoxColumn.HeaderText = "Квартира";
            this.квартираDataGridViewTextBoxColumn.Name = "квартираDataGridViewTextBoxColumn";
            this.квартираDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кодСтудентаDataGridViewTextBoxColumn
            // 
            this.кодСтудентаDataGridViewTextBoxColumn.DataPropertyName = "Код студента";
            this.кодСтудентаDataGridViewTextBoxColumn.HeaderText = "Код студента";
            this.кодСтудентаDataGridViewTextBoxColumn.Name = "кодСтудентаDataGridViewTextBoxColumn";
            this.кодСтудентаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AddRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxKodStudent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxFlat);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxHouse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxStreet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKodRegistration);
            this.Name = "AddRegistrationForm";
            this.Text = "AddRegistrationForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddRegistrationForm_FormClosing);
            this.Load += new System.EventHandler(this.AddRegistrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.местоРегистрацииСтудентаBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxKodStudent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFlat;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxHouse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKodRegistration;
        private System.Windows.Forms.DataGridView dataGridView1;
        private БД3DataSet бД3DataSet;
        private System.Windows.Forms.BindingSource местоРегистрацииСтудентаBindingSource;
        private БД3DataSetTableAdapters.Место_регистрации_студентаTableAdapter место_регистрации_студентаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодРегистрацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn населенныйПунктРегистрацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn улицаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn домDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn квартираDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСтудентаDataGridViewTextBoxColumn;
    }
}