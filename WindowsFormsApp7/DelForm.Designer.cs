
namespace WindowsFormsApp7
{
    partial class DelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DelForm));
            this.Form3BtnStudent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Form3BtnStudent
            // 
            this.Form3BtnStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Form3BtnStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Form3BtnStudent.Location = new System.Drawing.Point(285, 136);
            this.Form3BtnStudent.Margin = new System.Windows.Forms.Padding(2);
            this.Form3BtnStudent.Name = "Form3BtnStudent";
            this.Form3BtnStudent.Size = new System.Drawing.Size(282, 68);
            this.Form3BtnStudent.TabIndex = 32;
            this.Form3BtnStudent.Text = "Студент";
            this.Form3BtnStudent.UseVisualStyleBackColor = true;
            this.Form3BtnStudent.Click += new System.EventHandler(this.Form3BtnStudent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(861, 37);
            this.label1.TabIndex = 31;
            this.label1.Text = "Если вы удалите студента, удалится вся информация о нем";
            // 
            // DelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 450);
            this.Controls.Add(this.Form3BtnStudent);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DelForm";
            this.Text = "DelForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DelForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Form3BtnStudent;
        private System.Windows.Forms.Label label1;
    }
}