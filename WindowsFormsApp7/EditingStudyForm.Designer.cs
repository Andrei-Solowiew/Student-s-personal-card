
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditingStudyForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодОбученияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.формаОбученияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.форматОбученияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.группаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.срокОбученияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСтудентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.обучениеСтудентаBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.бД3DataSet = new WindowsFormsApp7.БД3DataSet();
            this.обучениеСтудентаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet = new WindowsFormsApp7._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet();
            this.обучение_студентаTableAdapter = new WindowsFormsApp7._СР_5_ОПБД_Соловьев_Андрей_П9021DataSetTableAdapters.Обучение_студентаTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxForm = new System.Windows.Forms.TextBox();
            this.ChangeForm = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxKod1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFormat = new System.Windows.Forms.TextBox();
            this.ChangeFormat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKod2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxGroup = new System.Windows.Forms.TextBox();
            this.ChangeGroup = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxKod3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTerm = new System.Windows.Forms.TextBox();
            this.ChangeTerm = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxKod4 = new System.Windows.Forms.TextBox();
            this.обучение_студентаTableAdapter1 = new WindowsFormsApp7.БД3DataSetTableAdapters.Обучение_студентаTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.обучениеСтудентаBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.обучениеСтудентаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодОбученияDataGridViewTextBoxColumn,
            this.формаОбученияDataGridViewTextBoxColumn,
            this.форматОбученияDataGridViewTextBoxColumn,
            this.группаDataGridViewTextBoxColumn,
            this.срокОбученияDataGridViewTextBoxColumn,
            this.кодСтудентаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.обучениеСтудентаBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(8, 237);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(904, 146);
            this.dataGridView1.TabIndex = 100;
            // 
            // кодОбученияDataGridViewTextBoxColumn
            // 
            this.кодОбученияDataGridViewTextBoxColumn.DataPropertyName = "Код обучения";
            this.кодОбученияDataGridViewTextBoxColumn.HeaderText = "Код обучения";
            this.кодОбученияDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.кодОбученияDataGridViewTextBoxColumn.Name = "кодОбученияDataGridViewTextBoxColumn";
            this.кодОбученияDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодОбученияDataGridViewTextBoxColumn.Width = 75;
            // 
            // формаОбученияDataGridViewTextBoxColumn
            // 
            this.формаОбученияDataGridViewTextBoxColumn.DataPropertyName = "Форма обучения";
            this.формаОбученияDataGridViewTextBoxColumn.HeaderText = "Форма обучения";
            this.формаОбученияDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.формаОбученияDataGridViewTextBoxColumn.Name = "формаОбученияDataGridViewTextBoxColumn";
            this.формаОбученияDataGridViewTextBoxColumn.ReadOnly = true;
            this.формаОбученияDataGridViewTextBoxColumn.Width = 150;
            // 
            // форматОбученияDataGridViewTextBoxColumn
            // 
            this.форматОбученияDataGridViewTextBoxColumn.DataPropertyName = "Формат обучения";
            this.форматОбученияDataGridViewTextBoxColumn.HeaderText = "Формат обучения";
            this.форматОбученияDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.форматОбученияDataGridViewTextBoxColumn.Name = "форматОбученияDataGridViewTextBoxColumn";
            this.форматОбученияDataGridViewTextBoxColumn.ReadOnly = true;
            this.форматОбученияDataGridViewTextBoxColumn.Width = 150;
            // 
            // группаDataGridViewTextBoxColumn
            // 
            this.группаDataGridViewTextBoxColumn.DataPropertyName = "Группа";
            this.группаDataGridViewTextBoxColumn.HeaderText = "Группа";
            this.группаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.группаDataGridViewTextBoxColumn.Name = "группаDataGridViewTextBoxColumn";
            this.группаDataGridViewTextBoxColumn.ReadOnly = true;
            this.группаDataGridViewTextBoxColumn.Width = 150;
            // 
            // срокОбученияDataGridViewTextBoxColumn
            // 
            this.срокОбученияDataGridViewTextBoxColumn.DataPropertyName = "Срок обучения";
            this.срокОбученияDataGridViewTextBoxColumn.HeaderText = "Срок обучения";
            this.срокОбученияDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.срокОбученияDataGridViewTextBoxColumn.Name = "срокОбученияDataGridViewTextBoxColumn";
            this.срокОбученияDataGridViewTextBoxColumn.ReadOnly = true;
            this.срокОбученияDataGridViewTextBoxColumn.Width = 150;
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
            // обучениеСтудентаBindingSource1
            // 
            this.обучениеСтудентаBindingSource1.DataMember = "Обучение студента";
            this.обучениеСтудентаBindingSource1.DataSource = this.бД3DataSet;
            // 
            // бД3DataSet
            // 
            this.бД3DataSet.DataSetName = "БД3DataSet";
            this.бД3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(231, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 17);
            this.label9.TabIndex = 36;
            this.label9.Text = "Форма обучения";
            // 
            // textBoxForm
            // 
            this.textBoxForm.Location = new System.Drawing.Point(234, 28);
            this.textBoxForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxForm.Name = "textBoxForm";
            this.textBoxForm.Size = new System.Drawing.Size(118, 20);
            this.textBoxForm.TabIndex = 2;
            // 
            // ChangeForm
            // 
            this.ChangeForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeForm.Location = new System.Drawing.Point(72, 65);
            this.ChangeForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChangeForm.Name = "ChangeForm";
            this.ChangeForm.Size = new System.Drawing.Size(280, 32);
            this.ChangeForm.TabIndex = 3;
            this.ChangeForm.Text = "Изменить";
            this.ChangeForm.UseVisualStyleBackColor = true;
            this.ChangeForm.Click += new System.EventHandler(this.ChangeForm_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(73, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Код обучения";
            // 
            // textBoxKod1
            // 
            this.textBoxKod1.Location = new System.Drawing.Point(76, 28);
            this.textBoxKod1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxKod1.Name = "textBoxKod1";
            this.textBoxKod1.Size = new System.Drawing.Size(97, 20);
            this.textBoxKod1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(706, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "Формат обучения";
            // 
            // textBoxFormat
            // 
            this.textBoxFormat.Location = new System.Drawing.Point(709, 28);
            this.textBoxFormat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFormat.Name = "textBoxFormat";
            this.textBoxFormat.Size = new System.Drawing.Size(125, 20);
            this.textBoxFormat.TabIndex = 5;
            // 
            // ChangeFormat
            // 
            this.ChangeFormat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeFormat.Location = new System.Drawing.Point(554, 65);
            this.ChangeFormat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChangeFormat.Name = "ChangeFormat";
            this.ChangeFormat.Size = new System.Drawing.Size(280, 32);
            this.ChangeFormat.TabIndex = 6;
            this.ChangeFormat.Text = "Изменить";
            this.ChangeFormat.UseVisualStyleBackColor = true;
            this.ChangeFormat.Click += new System.EventHandler(this.ChangeFormat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(555, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Код обучения";
            // 
            // textBoxKod2
            // 
            this.textBoxKod2.Location = new System.Drawing.Point(558, 28);
            this.textBoxKod2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxKod2.Name = "textBoxKod2";
            this.textBoxKod2.Size = new System.Drawing.Size(97, 20);
            this.textBoxKod2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(297, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 46;
            this.label3.Text = "Группа";
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.Location = new System.Drawing.Point(300, 140);
            this.textBoxGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.Size = new System.Drawing.Size(52, 20);
            this.textBoxGroup.TabIndex = 8;
            // 
            // ChangeGroup
            // 
            this.ChangeGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeGroup.Location = new System.Drawing.Point(72, 177);
            this.ChangeGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChangeGroup.Name = "ChangeGroup";
            this.ChangeGroup.Size = new System.Drawing.Size(280, 32);
            this.ChangeGroup.TabIndex = 9;
            this.ChangeGroup.Text = "Изменить";
            this.ChangeGroup.UseVisualStyleBackColor = true;
            this.ChangeGroup.Click += new System.EventHandler(this.ChangeGroup_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(73, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "Код обучения";
            // 
            // textBoxKod3
            // 
            this.textBoxKod3.Location = new System.Drawing.Point(76, 140);
            this.textBoxKod3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxKod3.Name = "textBoxKod3";
            this.textBoxKod3.Size = new System.Drawing.Size(97, 20);
            this.textBoxKod3.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(727, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 51;
            this.label5.Text = "Срок обучения";
            // 
            // textBoxTerm
            // 
            this.textBoxTerm.Location = new System.Drawing.Point(730, 140);
            this.textBoxTerm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTerm.Name = "textBoxTerm";
            this.textBoxTerm.Size = new System.Drawing.Size(104, 20);
            this.textBoxTerm.TabIndex = 11;
            // 
            // ChangeTerm
            // 
            this.ChangeTerm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeTerm.Location = new System.Drawing.Point(554, 177);
            this.ChangeTerm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChangeTerm.Name = "ChangeTerm";
            this.ChangeTerm.Size = new System.Drawing.Size(280, 32);
            this.ChangeTerm.TabIndex = 12;
            this.ChangeTerm.Text = "Изменить";
            this.ChangeTerm.UseVisualStyleBackColor = true;
            this.ChangeTerm.Click += new System.EventHandler(this.ChangeTerm_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(555, 121);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 48;
            this.label6.Text = "Код обучения";
            // 
            // textBoxKod4
            // 
            this.textBoxKod4.Location = new System.Drawing.Point(558, 140);
            this.textBoxKod4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxKod4.Name = "textBoxKod4";
            this.textBoxKod4.Size = new System.Drawing.Size(97, 20);
            this.textBoxKod4.TabIndex = 10;
            // 
            // обучение_студентаTableAdapter1
            // 
            this.обучение_студентаTableAdapter1.ClearBeforeFill = true;
            // 
            // EditingStudyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 394);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTerm);
            this.Controls.Add(this.ChangeTerm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxKod4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxGroup);
            this.Controls.Add(this.ChangeGroup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxKod3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFormat);
            this.Controls.Add(this.ChangeFormat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxKod2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxForm);
            this.Controls.Add(this.ChangeForm);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxKod1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditingStudyForm";
            this.Text = "EditingStudyForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditingStudyForm_FormClosing);
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.обучениеСтудентаBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.обучениеСтудентаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxForm;
        private System.Windows.Forms.Button ChangeForm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxKod1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFormat;
        private System.Windows.Forms.Button ChangeFormat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKod2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxGroup;
        private System.Windows.Forms.Button ChangeGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxKod3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTerm;
        private System.Windows.Forms.Button ChangeTerm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxKod4;
        private БД3DataSet бД3DataSet;
        private System.Windows.Forms.BindingSource обучениеСтудентаBindingSource1;
        private БД3DataSetTableAdapters.Обучение_студентаTableAdapter обучение_студентаTableAdapter1;
    }
}