
namespace WindowsFormsApp7
{
    partial class EditingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditingForm));
            this.label1 = new System.Windows.Forms.Label();
            this.Form3BtnStudent = new System.Windows.Forms.Button();
            this.Form3BtnSpecial = new System.Windows.Forms.Button();
            this.Form3BtnFamily = new System.Windows.Forms.Button();
            this.Form3BtnParents = new System.Windows.Forms.Button();
            this.Form3BtnNeeds = new System.Windows.Forms.Button();
            this.Form3BtnStudy = new System.Windows.Forms.Button();
            this.Form3BtnRegistration = new System.Windows.Forms.Button();
            this.Form3BtnHabitation = new System.Windows.Forms.Button();
            this.Form3BtnStudentDoc = new System.Windows.Forms.Button();
            this.Form3BtnCollegeDoc = new System.Windows.Forms.Button();
            this.Form3BtnSchool = new System.Windows.Forms.Button();
            this.Form3BtnStudentContacts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(68, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(767, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите таблицу, которую хотите отредактировать";
            // 
            // Form3BtnStudent
            // 
            this.Form3BtnStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Form3BtnStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Form3BtnStudent.Location = new System.Drawing.Point(75, 84);
            this.Form3BtnStudent.Margin = new System.Windows.Forms.Padding(2);
            this.Form3BtnStudent.Name = "Form3BtnStudent";
            this.Form3BtnStudent.Size = new System.Drawing.Size(157, 40);
            this.Form3BtnStudent.TabIndex = 8;
            this.Form3BtnStudent.Text = "Студент";
            this.Form3BtnStudent.UseVisualStyleBackColor = true;
            this.Form3BtnStudent.Click += new System.EventHandler(this.Form3BtnStudent_Click);
            // 
            // Form3BtnSpecial
            // 
            this.Form3BtnSpecial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Form3BtnSpecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Form3BtnSpecial.Location = new System.Drawing.Point(262, 84);
            this.Form3BtnSpecial.Margin = new System.Windows.Forms.Padding(2);
            this.Form3BtnSpecial.Name = "Form3BtnSpecial";
            this.Form3BtnSpecial.Size = new System.Drawing.Size(157, 40);
            this.Form3BtnSpecial.TabIndex = 9;
            this.Form3BtnSpecial.Text = "Специальность";
            this.Form3BtnSpecial.UseVisualStyleBackColor = true;
            this.Form3BtnSpecial.Click += new System.EventHandler(this.Form3BtnSpecial_Click);
            // 
            // Form3BtnFamily
            // 
            this.Form3BtnFamily.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Form3BtnFamily.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Form3BtnFamily.Location = new System.Drawing.Point(455, 84);
            this.Form3BtnFamily.Margin = new System.Windows.Forms.Padding(2);
            this.Form3BtnFamily.Name = "Form3BtnFamily";
            this.Form3BtnFamily.Size = new System.Drawing.Size(157, 40);
            this.Form3BtnFamily.TabIndex = 10;
            this.Form3BtnFamily.Text = "Семья";
            this.Form3BtnFamily.UseVisualStyleBackColor = true;
            this.Form3BtnFamily.Click += new System.EventHandler(this.Form3BtnFamily_Click);
            // 
            // Form3BtnParents
            // 
            this.Form3BtnParents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Form3BtnParents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Form3BtnParents.Location = new System.Drawing.Point(656, 142);
            this.Form3BtnParents.Margin = new System.Windows.Forms.Padding(2);
            this.Form3BtnParents.Name = "Form3BtnParents";
            this.Form3BtnParents.Size = new System.Drawing.Size(157, 40);
            this.Form3BtnParents.TabIndex = 15;
            this.Form3BtnParents.Text = "Родители";
            this.Form3BtnParents.UseVisualStyleBackColor = true;
            this.Form3BtnParents.Click += new System.EventHandler(this.Form3BtnParents_Click);
            // 
            // Form3BtnNeeds
            // 
            this.Form3BtnNeeds.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Form3BtnNeeds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Form3BtnNeeds.Location = new System.Drawing.Point(656, 84);
            this.Form3BtnNeeds.Margin = new System.Windows.Forms.Padding(2);
            this.Form3BtnNeeds.Name = "Form3BtnNeeds";
            this.Form3BtnNeeds.Size = new System.Drawing.Size(157, 40);
            this.Form3BtnNeeds.TabIndex = 11;
            this.Form3BtnNeeds.Text = "Потребности";
            this.Form3BtnNeeds.UseVisualStyleBackColor = true;
            this.Form3BtnNeeds.Click += new System.EventHandler(this.Form3BtnNeeds_Click);
            // 
            // Form3BtnStudy
            // 
            this.Form3BtnStudy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Form3BtnStudy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Form3BtnStudy.Location = new System.Drawing.Point(75, 142);
            this.Form3BtnStudy.Margin = new System.Windows.Forms.Padding(2);
            this.Form3BtnStudy.Name = "Form3BtnStudy";
            this.Form3BtnStudy.Size = new System.Drawing.Size(157, 40);
            this.Form3BtnStudy.TabIndex = 12;
            this.Form3BtnStudy.Text = "Обучение";
            this.Form3BtnStudy.UseVisualStyleBackColor = true;
            this.Form3BtnStudy.Click += new System.EventHandler(this.Form3BtnStudy_Click);
            // 
            // Form3BtnRegistration
            // 
            this.Form3BtnRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Form3BtnRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Form3BtnRegistration.Location = new System.Drawing.Point(262, 142);
            this.Form3BtnRegistration.Margin = new System.Windows.Forms.Padding(2);
            this.Form3BtnRegistration.Name = "Form3BtnRegistration";
            this.Form3BtnRegistration.Size = new System.Drawing.Size(157, 40);
            this.Form3BtnRegistration.TabIndex = 13;
            this.Form3BtnRegistration.Text = "Регистрация";
            this.Form3BtnRegistration.UseVisualStyleBackColor = true;
            this.Form3BtnRegistration.Click += new System.EventHandler(this.Form3BtnRegistration_Click);
            // 
            // Form3BtnHabitation
            // 
            this.Form3BtnHabitation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Form3BtnHabitation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Form3BtnHabitation.Location = new System.Drawing.Point(455, 142);
            this.Form3BtnHabitation.Margin = new System.Windows.Forms.Padding(2);
            this.Form3BtnHabitation.Name = "Form3BtnHabitation";
            this.Form3BtnHabitation.Size = new System.Drawing.Size(157, 40);
            this.Form3BtnHabitation.TabIndex = 14;
            this.Form3BtnHabitation.Text = "Проживание";
            this.Form3BtnHabitation.UseVisualStyleBackColor = true;
            this.Form3BtnHabitation.Click += new System.EventHandler(this.Form3BtnHabitation_Click);
            // 
            // Form3BtnStudentDoc
            // 
            this.Form3BtnStudentDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Form3BtnStudentDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Form3BtnStudentDoc.Location = new System.Drawing.Point(455, 203);
            this.Form3BtnStudentDoc.Margin = new System.Windows.Forms.Padding(2);
            this.Form3BtnStudentDoc.Name = "Form3BtnStudentDoc";
            this.Form3BtnStudentDoc.Size = new System.Drawing.Size(254, 40);
            this.Form3BtnStudentDoc.TabIndex = 17;
            this.Form3BtnStudentDoc.Text = "Документы студента";
            this.Form3BtnStudentDoc.UseVisualStyleBackColor = true;
            this.Form3BtnStudentDoc.Click += new System.EventHandler(this.Form3BtnStudentDoc_Click);
            // 
            // Form3BtnCollegeDoc
            // 
            this.Form3BtnCollegeDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Form3BtnCollegeDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Form3BtnCollegeDoc.Location = new System.Drawing.Point(165, 267);
            this.Form3BtnCollegeDoc.Margin = new System.Windows.Forms.Padding(2);
            this.Form3BtnCollegeDoc.Name = "Form3BtnCollegeDoc";
            this.Form3BtnCollegeDoc.Size = new System.Drawing.Size(254, 40);
            this.Form3BtnCollegeDoc.TabIndex = 18;
            this.Form3BtnCollegeDoc.Text = "Документы от колледжа";
            this.Form3BtnCollegeDoc.UseVisualStyleBackColor = true;
            this.Form3BtnCollegeDoc.Click += new System.EventHandler(this.Form3BtnCollegeDoc_Click);
            // 
            // Form3BtnSchool
            // 
            this.Form3BtnSchool.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Form3BtnSchool.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Form3BtnSchool.Location = new System.Drawing.Point(455, 267);
            this.Form3BtnSchool.Margin = new System.Windows.Forms.Padding(2);
            this.Form3BtnSchool.Name = "Form3BtnSchool";
            this.Form3BtnSchool.Size = new System.Drawing.Size(254, 40);
            this.Form3BtnSchool.TabIndex = 19;
            this.Form3BtnSchool.Text = "Данные о прошлом УЗ";
            this.Form3BtnSchool.UseVisualStyleBackColor = true;
            this.Form3BtnSchool.Click += new System.EventHandler(this.Form3BtnSchool_Click);
            // 
            // Form3BtnStudentContacts
            // 
            this.Form3BtnStudentContacts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Form3BtnStudentContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Form3BtnStudentContacts.Location = new System.Drawing.Point(165, 203);
            this.Form3BtnStudentContacts.Margin = new System.Windows.Forms.Padding(2);
            this.Form3BtnStudentContacts.Name = "Form3BtnStudentContacts";
            this.Form3BtnStudentContacts.Size = new System.Drawing.Size(254, 40);
            this.Form3BtnStudentContacts.TabIndex = 16;
            this.Form3BtnStudentContacts.Text = "Контакты студента";
            this.Form3BtnStudentContacts.UseVisualStyleBackColor = true;
            this.Form3BtnStudentContacts.Click += new System.EventHandler(this.Form3BtnStudentContacts_Click);
            // 
            // EditingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 450);
            this.Controls.Add(this.Form3BtnStudentContacts);
            this.Controls.Add(this.Form3BtnSchool);
            this.Controls.Add(this.Form3BtnCollegeDoc);
            this.Controls.Add(this.Form3BtnStudentDoc);
            this.Controls.Add(this.Form3BtnHabitation);
            this.Controls.Add(this.Form3BtnRegistration);
            this.Controls.Add(this.Form3BtnStudy);
            this.Controls.Add(this.Form3BtnNeeds);
            this.Controls.Add(this.Form3BtnParents);
            this.Controls.Add(this.Form3BtnFamily);
            this.Controls.Add(this.Form3BtnSpecial);
            this.Controls.Add(this.Form3BtnStudent);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditingForm";
            this.Text = "EditingForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditingForm_FormClosing);
            this.Load += new System.EventHandler(this.EditingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Form3BtnStudent;
        private System.Windows.Forms.Button Form3BtnSpecial;
        private System.Windows.Forms.Button Form3BtnFamily;
        private System.Windows.Forms.Button Form3BtnParents;
        private System.Windows.Forms.Button Form3BtnNeeds;
        private System.Windows.Forms.Button Form3BtnStudy;
        private System.Windows.Forms.Button Form3BtnRegistration;
        private System.Windows.Forms.Button Form3BtnHabitation;
        private System.Windows.Forms.Button Form3BtnStudentDoc;
        private System.Windows.Forms.Button Form3BtnCollegeDoc;
        private System.Windows.Forms.Button Form3BtnSchool;
        private System.Windows.Forms.Button Form3BtnStudentContacts;
    }
}