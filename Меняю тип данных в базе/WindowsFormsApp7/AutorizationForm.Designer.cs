
namespace WindowsFormsApp7
{
    partial class AutorizationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Form1_lab = new System.Windows.Forms.Label();
            this.Form1Log = new System.Windows.Forms.TextBox();
            this.Form1Pas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Form1Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(44, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            // 
            // Form1_lab
            // 
            this.Form1_lab.AutoSize = true;
            this.Form1_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Form1_lab.Location = new System.Drawing.Point(125, 106);
            this.Form1_lab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Form1_lab.Name = "Form1_lab";
            this.Form1_lab.Size = new System.Drawing.Size(62, 24);
            this.Form1_lab.TabIndex = 1;
            this.Form1_lab.Text = "логин";
            // 
            // Form1Log
            // 
            this.Form1Log.Location = new System.Drawing.Point(50, 145);
            this.Form1Log.Margin = new System.Windows.Forms.Padding(2);
            this.Form1Log.Multiline = true;
            this.Form1Log.Name = "Form1Log";
            this.Form1Log.Size = new System.Drawing.Size(210, 34);
            this.Form1Log.TabIndex = 2;
            // 
            // Form1Pas
            // 
            this.Form1Pas.Location = new System.Drawing.Point(50, 245);
            this.Form1Pas.Margin = new System.Windows.Forms.Padding(2);
            this.Form1Pas.Multiline = true;
            this.Form1Pas.Name = "Form1Pas";
            this.Form1Pas.Size = new System.Drawing.Size(210, 34);
            this.Form1Pas.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(125, 206);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "пароль";
            // 
            // Form1Btn
            // 
            this.Form1Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Form1Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Form1Btn.Location = new System.Drawing.Point(103, 305);
            this.Form1Btn.Margin = new System.Windows.Forms.Padding(2);
            this.Form1Btn.Name = "Form1Btn";
            this.Form1Btn.Size = new System.Drawing.Size(102, 40);
            this.Form1Btn.TabIndex = 6;
            this.Form1Btn.Text = "Отправить";
            this.Form1Btn.UseVisualStyleBackColor = true;
            this.Form1Btn.Click += new System.EventHandler(this.Form1Btn_Click);
            // 
            // AutorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 366);
            this.Controls.Add(this.Form1Btn);
            this.Controls.Add(this.Form1Pas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Form1Log);
            this.Controls.Add(this.Form1_lab);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AutorizationForm";
            this.Text = "Autorization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Form1_lab;
        private System.Windows.Forms.TextBox Form1Log;
        private System.Windows.Forms.TextBox Form1Pas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Form1Btn;
    }
}

