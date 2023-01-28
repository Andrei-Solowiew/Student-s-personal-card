using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class EditingForm : Form
    {
        public EditingForm()
        {
            InitializeComponent();
            form4 = new EditingStudentForm();
            form5 = new EditingSpecializationForm();
            form6 = new EditingFamilyForm();
            form7 = new EditingNeedsForm();
            form8 = new EditingStudyForm();
            form9 = new EditingRegistrationForm();
            form10 = new EditingLivingForm();
            form11 = new EditingParentsForm();
            form12 = new EditingStudentDocumetsForm();
            form13 = new EditingCollegeDocumetsForm();
            form14 = new EditingLastSchoolForm();

        }

        EditingStudentForm form4;
        EditingSpecializationForm form5;
        EditingFamilyForm form6;
        EditingNeedsForm form7;
        EditingStudyForm form8;
        EditingRegistrationForm form9;
        EditingLivingForm form10;
        EditingParentsForm form11;
        EditingStudentDocumetsForm form12;
        EditingCollegeDocumetsForm form13;
        EditingLastSchoolForm form14;


        private void Form3BtnStudent_Click(object sender, EventArgs e)
        {
            form4.Show();
        }

        private void Form3BtnSpecial_Click(object sender, EventArgs e)
        {
            form5.Show();
        }

        private void Form3BtnFamily_Click(object sender, EventArgs e)
        {
            form6.Show();
        }

        private void Form3BtnNeeds_Click(object sender, EventArgs e)
        {
            form7.Show();
        }

        private void Form3BtnStudy_Click(object sender, EventArgs e)
        {
            form8.Show();

        }

        private void Form3BtnRegistration_Click(object sender, EventArgs e)
        {
            form9.Show();

        }

        private void Form3BtnHabitation_Click(object sender, EventArgs e)
        {
            form10.Show();

        }

        private void Form3BtnParents_Click(object sender, EventArgs e)
        {
            form11.Show();

        }

        private void Form3BtnStudentDoc_Click(object sender, EventArgs e)
        {
            form12.Show();

        }

        private void Form3BtnCollegeDoc_Click(object sender, EventArgs e)
        {
            form13.Show();

        }

        private void Form3BtnSchool_Click(object sender, EventArgs e)
        {
            form14.Show();

        }
    }
}
