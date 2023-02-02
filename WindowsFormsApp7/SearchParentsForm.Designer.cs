
namespace WindowsFormsApp7
{
    partial class SearchParentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchParentsForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодРодителейDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияМатериDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяМатериDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоМатериDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.местоРаботыМатериDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьМатериDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияОтцаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяОтцаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоОтцаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.местоРаботыОтцаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьОтцаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонМатериDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонОтцаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.почтаРодителейDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияЗаконногоПредставителяЗПDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяЗпDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоЗпDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонЗпDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.местоРаботыЗпDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьЗпDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имейлЗпDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСтудентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.родителиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бД3DataSet = new WindowsFormsApp7.БД3DataSet();
            this.StudentFormDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxKod = new System.Windows.Forms.TextBox();
            this.родителиTableAdapter = new WindowsFormsApp7.БД3DataSetTableAdapters.РодителиTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.родителиBindingSource)).BeginInit();
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
            this.кодРодителейDataGridViewTextBoxColumn,
            this.фамилияМатериDataGridViewTextBoxColumn,
            this.имяМатериDataGridViewTextBoxColumn,
            this.отчествоМатериDataGridViewTextBoxColumn,
            this.местоРаботыМатериDataGridViewTextBoxColumn,
            this.должностьМатериDataGridViewTextBoxColumn,
            this.фамилияОтцаDataGridViewTextBoxColumn,
            this.имяОтцаDataGridViewTextBoxColumn,
            this.отчествоОтцаDataGridViewTextBoxColumn,
            this.местоРаботыОтцаDataGridViewTextBoxColumn,
            this.должностьОтцаDataGridViewTextBoxColumn,
            this.телефонМатериDataGridViewTextBoxColumn,
            this.телефонОтцаDataGridViewTextBoxColumn,
            this.почтаРодителейDataGridViewTextBoxColumn,
            this.фамилияЗаконногоПредставителяЗПDataGridViewTextBoxColumn,
            this.имяЗпDataGridViewTextBoxColumn,
            this.отчествоЗпDataGridViewTextBoxColumn,
            this.телефонЗпDataGridViewTextBoxColumn,
            this.местоРаботыЗпDataGridViewTextBoxColumn,
            this.должностьЗпDataGridViewTextBoxColumn,
            this.имейлЗпDataGridViewTextBoxColumn,
            this.кодСтудентаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.родителиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(37, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(808, 224);
            this.dataGridView1.TabIndex = 51;
            // 
            // кодРодителейDataGridViewTextBoxColumn
            // 
            this.кодРодителейDataGridViewTextBoxColumn.DataPropertyName = "Код родителей";
            this.кодРодителейDataGridViewTextBoxColumn.HeaderText = "Код родителей";
            this.кодРодителейDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодРодителейDataGridViewTextBoxColumn.Name = "кодРодителейDataGridViewTextBoxColumn";
            this.кодРодителейDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодРодителейDataGridViewTextBoxColumn.Width = 125;
            // 
            // фамилияМатериDataGridViewTextBoxColumn
            // 
            this.фамилияМатериDataGridViewTextBoxColumn.DataPropertyName = "Фамилия матери";
            this.фамилияМатериDataGridViewTextBoxColumn.HeaderText = "Фамилия матери";
            this.фамилияМатериDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фамилияМатериDataGridViewTextBoxColumn.Name = "фамилияМатериDataGridViewTextBoxColumn";
            this.фамилияМатериDataGridViewTextBoxColumn.ReadOnly = true;
            this.фамилияМатериDataGridViewTextBoxColumn.Width = 125;
            // 
            // имяМатериDataGridViewTextBoxColumn
            // 
            this.имяМатериDataGridViewTextBoxColumn.DataPropertyName = "Имя матери";
            this.имяМатериDataGridViewTextBoxColumn.HeaderText = "Имя матери";
            this.имяМатериDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.имяМатериDataGridViewTextBoxColumn.Name = "имяМатериDataGridViewTextBoxColumn";
            this.имяМатериDataGridViewTextBoxColumn.ReadOnly = true;
            this.имяМатериDataGridViewTextBoxColumn.Width = 125;
            // 
            // отчествоМатериDataGridViewTextBoxColumn
            // 
            this.отчествоМатериDataGridViewTextBoxColumn.DataPropertyName = "Отчество матери";
            this.отчествоМатериDataGridViewTextBoxColumn.HeaderText = "Отчество матери";
            this.отчествоМатериDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.отчествоМатериDataGridViewTextBoxColumn.Name = "отчествоМатериDataGridViewTextBoxColumn";
            this.отчествоМатериDataGridViewTextBoxColumn.ReadOnly = true;
            this.отчествоМатериDataGridViewTextBoxColumn.Width = 125;
            // 
            // местоРаботыМатериDataGridViewTextBoxColumn
            // 
            this.местоРаботыМатериDataGridViewTextBoxColumn.DataPropertyName = "Место работы матери";
            this.местоРаботыМатериDataGridViewTextBoxColumn.HeaderText = "Место работы матери";
            this.местоРаботыМатериDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.местоРаботыМатериDataGridViewTextBoxColumn.Name = "местоРаботыМатериDataGridViewTextBoxColumn";
            this.местоРаботыМатериDataGridViewTextBoxColumn.ReadOnly = true;
            this.местоРаботыМатериDataGridViewTextBoxColumn.Width = 125;
            // 
            // должностьМатериDataGridViewTextBoxColumn
            // 
            this.должностьМатериDataGridViewTextBoxColumn.DataPropertyName = "Должность матери";
            this.должностьМатериDataGridViewTextBoxColumn.HeaderText = "Должность матери";
            this.должностьМатериDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.должностьМатериDataGridViewTextBoxColumn.Name = "должностьМатериDataGridViewTextBoxColumn";
            this.должностьМатериDataGridViewTextBoxColumn.ReadOnly = true;
            this.должностьМатериDataGridViewTextBoxColumn.Width = 125;
            // 
            // фамилияОтцаDataGridViewTextBoxColumn
            // 
            this.фамилияОтцаDataGridViewTextBoxColumn.DataPropertyName = "Фамилия отца";
            this.фамилияОтцаDataGridViewTextBoxColumn.HeaderText = "Фамилия отца";
            this.фамилияОтцаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фамилияОтцаDataGridViewTextBoxColumn.Name = "фамилияОтцаDataGridViewTextBoxColumn";
            this.фамилияОтцаDataGridViewTextBoxColumn.ReadOnly = true;
            this.фамилияОтцаDataGridViewTextBoxColumn.Width = 125;
            // 
            // имяОтцаDataGridViewTextBoxColumn
            // 
            this.имяОтцаDataGridViewTextBoxColumn.DataPropertyName = "Имя отца";
            this.имяОтцаDataGridViewTextBoxColumn.HeaderText = "Имя отца";
            this.имяОтцаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.имяОтцаDataGridViewTextBoxColumn.Name = "имяОтцаDataGridViewTextBoxColumn";
            this.имяОтцаDataGridViewTextBoxColumn.ReadOnly = true;
            this.имяОтцаDataGridViewTextBoxColumn.Width = 125;
            // 
            // отчествоОтцаDataGridViewTextBoxColumn
            // 
            this.отчествоОтцаDataGridViewTextBoxColumn.DataPropertyName = "Отчество отца";
            this.отчествоОтцаDataGridViewTextBoxColumn.HeaderText = "Отчество отца";
            this.отчествоОтцаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.отчествоОтцаDataGridViewTextBoxColumn.Name = "отчествоОтцаDataGridViewTextBoxColumn";
            this.отчествоОтцаDataGridViewTextBoxColumn.ReadOnly = true;
            this.отчествоОтцаDataGridViewTextBoxColumn.Width = 125;
            // 
            // местоРаботыОтцаDataGridViewTextBoxColumn
            // 
            this.местоРаботыОтцаDataGridViewTextBoxColumn.DataPropertyName = "Место работы отца";
            this.местоРаботыОтцаDataGridViewTextBoxColumn.HeaderText = "Место работы отца";
            this.местоРаботыОтцаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.местоРаботыОтцаDataGridViewTextBoxColumn.Name = "местоРаботыОтцаDataGridViewTextBoxColumn";
            this.местоРаботыОтцаDataGridViewTextBoxColumn.ReadOnly = true;
            this.местоРаботыОтцаDataGridViewTextBoxColumn.Width = 125;
            // 
            // должностьОтцаDataGridViewTextBoxColumn
            // 
            this.должностьОтцаDataGridViewTextBoxColumn.DataPropertyName = "Должность отца";
            this.должностьОтцаDataGridViewTextBoxColumn.HeaderText = "Должность отца";
            this.должностьОтцаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.должностьОтцаDataGridViewTextBoxColumn.Name = "должностьОтцаDataGridViewTextBoxColumn";
            this.должностьОтцаDataGridViewTextBoxColumn.ReadOnly = true;
            this.должностьОтцаDataGridViewTextBoxColumn.Width = 125;
            // 
            // телефонМатериDataGridViewTextBoxColumn
            // 
            this.телефонМатериDataGridViewTextBoxColumn.DataPropertyName = "Телефон матери";
            this.телефонМатериDataGridViewTextBoxColumn.HeaderText = "Телефон матери";
            this.телефонМатериDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.телефонМатериDataGridViewTextBoxColumn.Name = "телефонМатериDataGridViewTextBoxColumn";
            this.телефонМатериDataGridViewTextBoxColumn.ReadOnly = true;
            this.телефонМатериDataGridViewTextBoxColumn.Width = 125;
            // 
            // телефонОтцаDataGridViewTextBoxColumn
            // 
            this.телефонОтцаDataGridViewTextBoxColumn.DataPropertyName = "Телефон отца";
            this.телефонОтцаDataGridViewTextBoxColumn.HeaderText = "Телефон отца";
            this.телефонОтцаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.телефонОтцаDataGridViewTextBoxColumn.Name = "телефонОтцаDataGridViewTextBoxColumn";
            this.телефонОтцаDataGridViewTextBoxColumn.ReadOnly = true;
            this.телефонОтцаDataGridViewTextBoxColumn.Width = 125;
            // 
            // почтаРодителейDataGridViewTextBoxColumn
            // 
            this.почтаРодителейDataGridViewTextBoxColumn.DataPropertyName = "Почта родителей";
            this.почтаРодителейDataGridViewTextBoxColumn.HeaderText = "Почта родителей";
            this.почтаРодителейDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.почтаРодителейDataGridViewTextBoxColumn.Name = "почтаРодителейDataGridViewTextBoxColumn";
            this.почтаРодителейDataGridViewTextBoxColumn.ReadOnly = true;
            this.почтаРодителейDataGridViewTextBoxColumn.Width = 125;
            // 
            // фамилияЗаконногоПредставителяЗПDataGridViewTextBoxColumn
            // 
            this.фамилияЗаконногоПредставителяЗПDataGridViewTextBoxColumn.DataPropertyName = "Фамилия законного представителя(ЗП)";
            this.фамилияЗаконногоПредставителяЗПDataGridViewTextBoxColumn.HeaderText = "Фамилия законного представителя(ЗП)";
            this.фамилияЗаконногоПредставителяЗПDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фамилияЗаконногоПредставителяЗПDataGridViewTextBoxColumn.Name = "фамилияЗаконногоПредставителяЗПDataGridViewTextBoxColumn";
            this.фамилияЗаконногоПредставителяЗПDataGridViewTextBoxColumn.ReadOnly = true;
            this.фамилияЗаконногоПредставителяЗПDataGridViewTextBoxColumn.Width = 125;
            // 
            // имяЗпDataGridViewTextBoxColumn
            // 
            this.имяЗпDataGridViewTextBoxColumn.DataPropertyName = "Имя зп";
            this.имяЗпDataGridViewTextBoxColumn.HeaderText = "Имя зп";
            this.имяЗпDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.имяЗпDataGridViewTextBoxColumn.Name = "имяЗпDataGridViewTextBoxColumn";
            this.имяЗпDataGridViewTextBoxColumn.ReadOnly = true;
            this.имяЗпDataGridViewTextBoxColumn.Width = 125;
            // 
            // отчествоЗпDataGridViewTextBoxColumn
            // 
            this.отчествоЗпDataGridViewTextBoxColumn.DataPropertyName = "Отчество зп";
            this.отчествоЗпDataGridViewTextBoxColumn.HeaderText = "Отчество зп";
            this.отчествоЗпDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.отчествоЗпDataGridViewTextBoxColumn.Name = "отчествоЗпDataGridViewTextBoxColumn";
            this.отчествоЗпDataGridViewTextBoxColumn.ReadOnly = true;
            this.отчествоЗпDataGridViewTextBoxColumn.Width = 125;
            // 
            // телефонЗпDataGridViewTextBoxColumn
            // 
            this.телефонЗпDataGridViewTextBoxColumn.DataPropertyName = "Телефон зп";
            this.телефонЗпDataGridViewTextBoxColumn.HeaderText = "Телефон зп";
            this.телефонЗпDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.телефонЗпDataGridViewTextBoxColumn.Name = "телефонЗпDataGridViewTextBoxColumn";
            this.телефонЗпDataGridViewTextBoxColumn.ReadOnly = true;
            this.телефонЗпDataGridViewTextBoxColumn.Width = 125;
            // 
            // местоРаботыЗпDataGridViewTextBoxColumn
            // 
            this.местоРаботыЗпDataGridViewTextBoxColumn.DataPropertyName = "Место работы зп";
            this.местоРаботыЗпDataGridViewTextBoxColumn.HeaderText = "Место работы зп";
            this.местоРаботыЗпDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.местоРаботыЗпDataGridViewTextBoxColumn.Name = "местоРаботыЗпDataGridViewTextBoxColumn";
            this.местоРаботыЗпDataGridViewTextBoxColumn.ReadOnly = true;
            this.местоРаботыЗпDataGridViewTextBoxColumn.Width = 125;
            // 
            // должностьЗпDataGridViewTextBoxColumn
            // 
            this.должностьЗпDataGridViewTextBoxColumn.DataPropertyName = "Должность зп";
            this.должностьЗпDataGridViewTextBoxColumn.HeaderText = "Должность зп";
            this.должностьЗпDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.должностьЗпDataGridViewTextBoxColumn.Name = "должностьЗпDataGridViewTextBoxColumn";
            this.должностьЗпDataGridViewTextBoxColumn.ReadOnly = true;
            this.должностьЗпDataGridViewTextBoxColumn.Width = 125;
            // 
            // имейлЗпDataGridViewTextBoxColumn
            // 
            this.имейлЗпDataGridViewTextBoxColumn.DataPropertyName = "Имейл зп";
            this.имейлЗпDataGridViewTextBoxColumn.HeaderText = "Имейл зп";
            this.имейлЗпDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.имейлЗпDataGridViewTextBoxColumn.Name = "имейлЗпDataGridViewTextBoxColumn";
            this.имейлЗпDataGridViewTextBoxColumn.ReadOnly = true;
            this.имейлЗпDataGridViewTextBoxColumn.Width = 125;
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
            // родителиBindingSource
            // 
            this.родителиBindingSource.DataMember = "Родители";
            this.родителиBindingSource.DataSource = this.бД3DataSet;
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
            this.StudentFormDelete.Location = new System.Drawing.Point(37, 97);
            this.StudentFormDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StudentFormDelete.Name = "StudentFormDelete";
            this.StudentFormDelete.Size = new System.Drawing.Size(191, 36);
            this.StudentFormDelete.TabIndex = 50;
            this.StudentFormDelete.Text = "Найти";
            this.StudentFormDelete.UseVisualStyleBackColor = true;
            this.StudentFormDelete.Click += new System.EventHandler(this.StudentFormDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(34, 36);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 17);
            this.label7.TabIndex = 49;
            this.label7.Text = "Код студента";
            // 
            // textBoxKod
            // 
            this.textBoxKod.Location = new System.Drawing.Point(37, 54);
            this.textBoxKod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxKod.Name = "textBoxKod";
            this.textBoxKod.Size = new System.Drawing.Size(92, 20);
            this.textBoxKod.TabIndex = 48;
            // 
            // родителиTableAdapter
            // 
            this.родителиTableAdapter.ClearBeforeFill = true;
            // 
            // SearchParentsForm
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
            this.Name = "SearchParentsForm";
            this.Text = "SearchParentsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchParentsForm_FormClosing);
            this.Load += new System.EventHandler(this.SearchParentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.родителиBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource родителиBindingSource;
        private БД3DataSetTableAdapters.РодителиTableAdapter родителиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодРодителейDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияМатериDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяМатериDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоМатериDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn местоРаботыМатериDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьМатериDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияОтцаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяОтцаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоОтцаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn местоРаботыОтцаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьОтцаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонМатериDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонОтцаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn почтаРодителейDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияЗаконногоПредставителяЗПDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяЗпDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоЗпDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонЗпDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn местоРаботыЗпDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьЗпDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имейлЗпDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСтудентаDataGridViewTextBoxColumn;
    }
}