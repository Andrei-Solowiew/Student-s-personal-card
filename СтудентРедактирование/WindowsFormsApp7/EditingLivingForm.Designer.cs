
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодПроживанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.населенныйПунктПроживанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.улицаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.домDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.квартираDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСтудентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.местоПроживанияСтудентаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet = new WindowsFormsApp7._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet();
            this.место_проживания_студентаTableAdapter = new WindowsFormsApp7._СР_5_ОПБД_Соловьев_Андрей_П9021DataSetTableAdapters.Место_проживания_студентаTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.dataGridView1.DataSource = this.местоПроживанияСтудентаBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 8);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(786, 277);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодПроживанияDataGridViewTextBoxColumn
            // 
            this.кодПроживанияDataGridViewTextBoxColumn.DataPropertyName = "Код проживания";
            this.кодПроживанияDataGridViewTextBoxColumn.HeaderText = "Код проживания";
            this.кодПроживанияDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.кодПроживанияDataGridViewTextBoxColumn.Name = "кодПроживанияDataGridViewTextBoxColumn";
            this.кодПроживанияDataGridViewTextBoxColumn.Width = 150;
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
            // EditingLivingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 292);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditingLivingForm";
            this.Text = "EditingLivingForm";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.местоПроживанияСтудентаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _СР_5_ОПБД_Соловьев_Андрей_П9021DataSet _СР_5_ОПБД_Соловьев_Андрей_П9021DataSet;
        private System.Windows.Forms.BindingSource местоПроживанияСтудентаBindingSource;
        private _СР_5_ОПБД_Соловьев_Андрей_П9021DataSetTableAdapters.Место_проживания_студентаTableAdapter место_проживания_студентаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПроживанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn населенныйПунктПроживанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn улицаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn домDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn квартираDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСтудентаDataGridViewTextBoxColumn;
    }
}