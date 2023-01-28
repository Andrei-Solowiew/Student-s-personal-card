
namespace WindowsFormsApp7
{
    partial class EditingParentsForm
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
            this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet = new WindowsFormsApp7._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet();
            this.родителиTableAdapter = new WindowsFormsApp7._СР_5_ОПБД_Соловьев_Андрей_П9021DataSetTableAdapters.РодителиTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.родителиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
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
            this.dataGridView1.Location = new System.Drawing.Point(-1, -1);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(782, 285);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодРодителейDataGridViewTextBoxColumn
            // 
            this.кодРодителейDataGridViewTextBoxColumn.DataPropertyName = "Код родителей";
            this.кодРодителейDataGridViewTextBoxColumn.HeaderText = "Код родителей";
            this.кодРодителейDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.кодРодителейDataGridViewTextBoxColumn.Name = "кодРодителейDataGridViewTextBoxColumn";
            this.кодРодителейDataGridViewTextBoxColumn.Width = 150;
            // 
            // фамилияМатериDataGridViewTextBoxColumn
            // 
            this.фамилияМатериDataGridViewTextBoxColumn.DataPropertyName = "Фамилия матери";
            this.фамилияМатериDataGridViewTextBoxColumn.HeaderText = "Фамилия матери";
            this.фамилияМатериDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.фамилияМатериDataGridViewTextBoxColumn.Name = "фамилияМатериDataGridViewTextBoxColumn";
            this.фамилияМатериDataGridViewTextBoxColumn.Width = 150;
            // 
            // имяМатериDataGridViewTextBoxColumn
            // 
            this.имяМатериDataGridViewTextBoxColumn.DataPropertyName = "Имя матери";
            this.имяМатериDataGridViewTextBoxColumn.HeaderText = "Имя матери";
            this.имяМатериDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.имяМатериDataGridViewTextBoxColumn.Name = "имяМатериDataGridViewTextBoxColumn";
            this.имяМатериDataGridViewTextBoxColumn.Width = 150;
            // 
            // отчествоМатериDataGridViewTextBoxColumn
            // 
            this.отчествоМатериDataGridViewTextBoxColumn.DataPropertyName = "Отчество матери";
            this.отчествоМатериDataGridViewTextBoxColumn.HeaderText = "Отчество матери";
            this.отчествоМатериDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.отчествоМатериDataGridViewTextBoxColumn.Name = "отчествоМатериDataGridViewTextBoxColumn";
            this.отчествоМатериDataGridViewTextBoxColumn.Width = 150;
            // 
            // местоРаботыМатериDataGridViewTextBoxColumn
            // 
            this.местоРаботыМатериDataGridViewTextBoxColumn.DataPropertyName = "Место работы матери";
            this.местоРаботыМатериDataGridViewTextBoxColumn.HeaderText = "Место работы матери";
            this.местоРаботыМатериDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.местоРаботыМатериDataGridViewTextBoxColumn.Name = "местоРаботыМатериDataGridViewTextBoxColumn";
            this.местоРаботыМатериDataGridViewTextBoxColumn.Width = 150;
            // 
            // должностьМатериDataGridViewTextBoxColumn
            // 
            this.должностьМатериDataGridViewTextBoxColumn.DataPropertyName = "Должность матери";
            this.должностьМатериDataGridViewTextBoxColumn.HeaderText = "Должность матери";
            this.должностьМатериDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.должностьМатериDataGridViewTextBoxColumn.Name = "должностьМатериDataGridViewTextBoxColumn";
            this.должностьМатериDataGridViewTextBoxColumn.Width = 150;
            // 
            // фамилияОтцаDataGridViewTextBoxColumn
            // 
            this.фамилияОтцаDataGridViewTextBoxColumn.DataPropertyName = "Фамилия отца";
            this.фамилияОтцаDataGridViewTextBoxColumn.HeaderText = "Фамилия отца";
            this.фамилияОтцаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.фамилияОтцаDataGridViewTextBoxColumn.Name = "фамилияОтцаDataGridViewTextBoxColumn";
            this.фамилияОтцаDataGridViewTextBoxColumn.Width = 150;
            // 
            // имяОтцаDataGridViewTextBoxColumn
            // 
            this.имяОтцаDataGridViewTextBoxColumn.DataPropertyName = "Имя отца";
            this.имяОтцаDataGridViewTextBoxColumn.HeaderText = "Имя отца";
            this.имяОтцаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.имяОтцаDataGridViewTextBoxColumn.Name = "имяОтцаDataGridViewTextBoxColumn";
            this.имяОтцаDataGridViewTextBoxColumn.Width = 150;
            // 
            // отчествоОтцаDataGridViewTextBoxColumn
            // 
            this.отчествоОтцаDataGridViewTextBoxColumn.DataPropertyName = "Отчество отца";
            this.отчествоОтцаDataGridViewTextBoxColumn.HeaderText = "Отчество отца";
            this.отчествоОтцаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.отчествоОтцаDataGridViewTextBoxColumn.Name = "отчествоОтцаDataGridViewTextBoxColumn";
            this.отчествоОтцаDataGridViewTextBoxColumn.Width = 150;
            // 
            // местоРаботыОтцаDataGridViewTextBoxColumn
            // 
            this.местоРаботыОтцаDataGridViewTextBoxColumn.DataPropertyName = "Место работы отца";
            this.местоРаботыОтцаDataGridViewTextBoxColumn.HeaderText = "Место работы отца";
            this.местоРаботыОтцаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.местоРаботыОтцаDataGridViewTextBoxColumn.Name = "местоРаботыОтцаDataGridViewTextBoxColumn";
            this.местоРаботыОтцаDataGridViewTextBoxColumn.Width = 150;
            // 
            // должностьОтцаDataGridViewTextBoxColumn
            // 
            this.должностьОтцаDataGridViewTextBoxColumn.DataPropertyName = "Должность отца";
            this.должностьОтцаDataGridViewTextBoxColumn.HeaderText = "Должность отца";
            this.должностьОтцаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.должностьОтцаDataGridViewTextBoxColumn.Name = "должностьОтцаDataGridViewTextBoxColumn";
            this.должностьОтцаDataGridViewTextBoxColumn.Width = 150;
            // 
            // телефонМатериDataGridViewTextBoxColumn
            // 
            this.телефонМатериDataGridViewTextBoxColumn.DataPropertyName = "Телефон матери";
            this.телефонМатериDataGridViewTextBoxColumn.HeaderText = "Телефон матери";
            this.телефонМатериDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.телефонМатериDataGridViewTextBoxColumn.Name = "телефонМатериDataGridViewTextBoxColumn";
            this.телефонМатериDataGridViewTextBoxColumn.Width = 150;
            // 
            // телефонОтцаDataGridViewTextBoxColumn
            // 
            this.телефонОтцаDataGridViewTextBoxColumn.DataPropertyName = "Телефон отца";
            this.телефонОтцаDataGridViewTextBoxColumn.HeaderText = "Телефон отца";
            this.телефонОтцаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.телефонОтцаDataGridViewTextBoxColumn.Name = "телефонОтцаDataGridViewTextBoxColumn";
            this.телефонОтцаDataGridViewTextBoxColumn.Width = 150;
            // 
            // почтаРодителейDataGridViewTextBoxColumn
            // 
            this.почтаРодителейDataGridViewTextBoxColumn.DataPropertyName = "Почта родителей";
            this.почтаРодителейDataGridViewTextBoxColumn.HeaderText = "Почта родителей";
            this.почтаРодителейDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.почтаРодителейDataGridViewTextBoxColumn.Name = "почтаРодителейDataGridViewTextBoxColumn";
            this.почтаРодителейDataGridViewTextBoxColumn.Width = 150;
            // 
            // фамилияЗаконногоПредставителяЗПDataGridViewTextBoxColumn
            // 
            this.фамилияЗаконногоПредставителяЗПDataGridViewTextBoxColumn.DataPropertyName = "Фамилия законного представителя(ЗП)";
            this.фамилияЗаконногоПредставителяЗПDataGridViewTextBoxColumn.HeaderText = "Фамилия законного представителя(ЗП)";
            this.фамилияЗаконногоПредставителяЗПDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.фамилияЗаконногоПредставителяЗПDataGridViewTextBoxColumn.Name = "фамилияЗаконногоПредставителяЗПDataGridViewTextBoxColumn";
            this.фамилияЗаконногоПредставителяЗПDataGridViewTextBoxColumn.Width = 150;
            // 
            // имяЗпDataGridViewTextBoxColumn
            // 
            this.имяЗпDataGridViewTextBoxColumn.DataPropertyName = "Имя зп";
            this.имяЗпDataGridViewTextBoxColumn.HeaderText = "Имя зп";
            this.имяЗпDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.имяЗпDataGridViewTextBoxColumn.Name = "имяЗпDataGridViewTextBoxColumn";
            this.имяЗпDataGridViewTextBoxColumn.Width = 150;
            // 
            // отчествоЗпDataGridViewTextBoxColumn
            // 
            this.отчествоЗпDataGridViewTextBoxColumn.DataPropertyName = "Отчество зп";
            this.отчествоЗпDataGridViewTextBoxColumn.HeaderText = "Отчество зп";
            this.отчествоЗпDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.отчествоЗпDataGridViewTextBoxColumn.Name = "отчествоЗпDataGridViewTextBoxColumn";
            this.отчествоЗпDataGridViewTextBoxColumn.Width = 150;
            // 
            // телефонЗпDataGridViewTextBoxColumn
            // 
            this.телефонЗпDataGridViewTextBoxColumn.DataPropertyName = "Телефон зп";
            this.телефонЗпDataGridViewTextBoxColumn.HeaderText = "Телефон зп";
            this.телефонЗпDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.телефонЗпDataGridViewTextBoxColumn.Name = "телефонЗпDataGridViewTextBoxColumn";
            this.телефонЗпDataGridViewTextBoxColumn.Width = 150;
            // 
            // местоРаботыЗпDataGridViewTextBoxColumn
            // 
            this.местоРаботыЗпDataGridViewTextBoxColumn.DataPropertyName = "Место работы зп";
            this.местоРаботыЗпDataGridViewTextBoxColumn.HeaderText = "Место работы зп";
            this.местоРаботыЗпDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.местоРаботыЗпDataGridViewTextBoxColumn.Name = "местоРаботыЗпDataGridViewTextBoxColumn";
            this.местоРаботыЗпDataGridViewTextBoxColumn.Width = 150;
            // 
            // должностьЗпDataGridViewTextBoxColumn
            // 
            this.должностьЗпDataGridViewTextBoxColumn.DataPropertyName = "Должность зп";
            this.должностьЗпDataGridViewTextBoxColumn.HeaderText = "Должность зп";
            this.должностьЗпDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.должностьЗпDataGridViewTextBoxColumn.Name = "должностьЗпDataGridViewTextBoxColumn";
            this.должностьЗпDataGridViewTextBoxColumn.Width = 150;
            // 
            // имейлЗпDataGridViewTextBoxColumn
            // 
            this.имейлЗпDataGridViewTextBoxColumn.DataPropertyName = "Имейл зп";
            this.имейлЗпDataGridViewTextBoxColumn.HeaderText = "Имейл зп";
            this.имейлЗпDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.имейлЗпDataGridViewTextBoxColumn.Name = "имейлЗпDataGridViewTextBoxColumn";
            this.имейлЗпDataGridViewTextBoxColumn.Width = 150;
            // 
            // кодСтудентаDataGridViewTextBoxColumn
            // 
            this.кодСтудентаDataGridViewTextBoxColumn.DataPropertyName = "Код студента";
            this.кодСтудентаDataGridViewTextBoxColumn.HeaderText = "Код студента";
            this.кодСтудентаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.кодСтудентаDataGridViewTextBoxColumn.Name = "кодСтудентаDataGridViewTextBoxColumn";
            this.кодСтудентаDataGridViewTextBoxColumn.Width = 150;
            // 
            // родителиBindingSource
            // 
            this.родителиBindingSource.DataMember = "Родители";
            this.родителиBindingSource.DataSource = this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet;
            // 
            // _СР_5_ОПБД_Соловьев_Андрей_П9021DataSet
            // 
            this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.DataSetName = "_СР_5_ОПБД_Соловьев_Андрей_П9021DataSet";
            this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // родителиTableAdapter
            // 
            this.родителиTableAdapter.ClearBeforeFill = true;
            // 
            // EditingParentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 292);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditingParentsForm";
            this.Text = "EditingParentsForm";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.родителиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _СР_5_ОПБД_Соловьев_Андрей_П9021DataSet _СР_5_ОПБД_Соловьев_Андрей_П9021DataSet;
        private System.Windows.Forms.BindingSource родителиBindingSource;
        private _СР_5_ОПБД_Соловьев_Андрей_П9021DataSetTableAdapters.РодителиTableAdapter родителиTableAdapter;
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