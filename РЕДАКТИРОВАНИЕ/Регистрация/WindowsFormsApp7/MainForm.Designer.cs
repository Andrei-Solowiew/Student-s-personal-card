
namespace WindowsFormsApp7
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Form2BtnEdit = new System.Windows.Forms.Button();
            this.Form2BtnSearch = new System.Windows.Forms.Button();
            this.Form2BtnHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(146, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите действие";
            // 
            // Form2BtnEdit
            // 
            this.Form2BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Form2BtnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Form2BtnEdit.Location = new System.Drawing.Point(153, 122);
            this.Form2BtnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.Form2BtnEdit.Name = "Form2BtnEdit";
            this.Form2BtnEdit.Size = new System.Drawing.Size(329, 40);
            this.Form2BtnEdit.TabIndex = 7;
            this.Form2BtnEdit.Text = "Редактирование";
            this.Form2BtnEdit.UseVisualStyleBackColor = true;
            this.Form2BtnEdit.Click += new System.EventHandler(this.Form2BtnEdit_Click);
            // 
            // Form2BtnSearch
            // 
            this.Form2BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Form2BtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Form2BtnSearch.Location = new System.Drawing.Point(153, 185);
            this.Form2BtnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.Form2BtnSearch.Name = "Form2BtnSearch";
            this.Form2BtnSearch.Size = new System.Drawing.Size(329, 40);
            this.Form2BtnSearch.TabIndex = 8;
            this.Form2BtnSearch.Text = "Поиск";
            this.Form2BtnSearch.UseVisualStyleBackColor = true;
            this.Form2BtnSearch.Click += new System.EventHandler(this.Form2BtnSearch_Click);
            // 
            // Form2BtnHelp
            // 
            this.Form2BtnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Form2BtnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Form2BtnHelp.Location = new System.Drawing.Point(497, 398);
            this.Form2BtnHelp.Name = "Form2BtnHelp";
            this.Form2BtnHelp.Size = new System.Drawing.Size(155, 40);
            this.Form2BtnHelp.TabIndex = 9;
            this.Form2BtnHelp.Text = "Помощь";
            this.Form2BtnHelp.UseVisualStyleBackColor = true;
            this.Form2BtnHelp.Click += new System.EventHandler(this.Form2BtnHelp_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 450);
            this.Controls.Add(this.Form2BtnHelp);
            this.Controls.Add(this.Form2BtnSearch);
            this.Controls.Add(this.Form2BtnEdit);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Form2BtnEdit;
        private System.Windows.Forms.Button Form2BtnSearch;
        private System.Windows.Forms.Button Form2BtnHelp;
    }
}