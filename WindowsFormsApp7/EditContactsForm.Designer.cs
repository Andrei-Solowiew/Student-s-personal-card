
namespace WindowsFormsApp7
{
    partial class EditContactsForm
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
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСтудентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имейлDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.контактныеДанныеСтудентаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бД3DataSet = new WindowsFormsApp7.БД3DataSet();
            this.EditPhone = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.контактные_данные_студентаTableAdapter = new WindowsFormsApp7.БД3DataSetTableAdapters.Контактные_данные_студентаTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.контактныеДанныеСтудентаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД3DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.телефонDataGridViewTextBoxColumn,
            this.кодСтудентаDataGridViewTextBoxColumn,
            this.имейлDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.контактныеДанныеСтудентаBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(54, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(688, 150);
            this.dataGridView1.TabIndex = 134;
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            // 
            // кодСтудентаDataGridViewTextBoxColumn
            // 
            this.кодСтудентаDataGridViewTextBoxColumn.DataPropertyName = "Код студента";
            this.кодСтудентаDataGridViewTextBoxColumn.HeaderText = "Код студента";
            this.кодСтудентаDataGridViewTextBoxColumn.Name = "кодСтудентаDataGridViewTextBoxColumn";
            // 
            // имейлDataGridViewTextBoxColumn
            // 
            this.имейлDataGridViewTextBoxColumn.DataPropertyName = "Имейл";
            this.имейлDataGridViewTextBoxColumn.HeaderText = "Имейл";
            this.имейлDataGridViewTextBoxColumn.Name = "имейлDataGridViewTextBoxColumn";
            // 
            // контактныеДанныеСтудентаBindingSource
            // 
            this.контактныеДанныеСтудентаBindingSource.DataMember = "Контактные данные студента";
            this.контактныеДанныеСтудентаBindingSource.DataSource = this.бД3DataSet;
            // 
            // бД3DataSet
            // 
            this.бД3DataSet.DataSetName = "БД3DataSet";
            this.бД3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EditPhone
            // 
            this.EditPhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditPhone.Location = new System.Drawing.Point(54, 90);
            this.EditPhone.Margin = new System.Windows.Forms.Padding(2);
            this.EditPhone.Name = "EditPhone";
            this.EditPhone.Size = new System.Drawing.Size(266, 32);
            this.EditPhone.TabIndex = 4;
            this.EditPhone.Text = "Изменить";
            this.EditPhone.UseVisualStyleBackColor = true;
            this.EditPhone.Click += new System.EventHandler(this.EditPhone_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(73, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 131;
            this.label1.Text = "Телефон";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(54, 55);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(120, 20);
            this.textBoxPhone.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(234, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 138;
            this.label5.Text = "Имейл";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(200, 55);
            this.textBoxMail.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(120, 20);
            this.textBoxMail.TabIndex = 3;
            // 
            // контактные_данные_студентаTableAdapter
            // 
            this.контактные_данные_студентаTableAdapter.ClearBeforeFill = true;
            // 
            // EditContactsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.EditPhone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPhone);
            this.Name = "EditContactsForm";
            this.Text = "EditContactsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditContactsForm_FormClosing);
            this.Load += new System.EventHandler(this.EditContactsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.контактныеДанныеСтудентаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД3DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button EditPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMail;
        private БД3DataSet бД3DataSet;
        private System.Windows.Forms.BindingSource контактныеДанныеСтудентаBindingSource;
        private БД3DataSetTableAdapters.Контактные_данные_студентаTableAdapter контактные_данные_студентаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСтудентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имейлDataGridViewTextBoxColumn;
    }
}