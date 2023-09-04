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
    public partial class SearchMainForm : Form
    {
        public SearchMainForm()
        {
            InitializeComponent();
            SearchStudent = new SearchStudentForm();
            SearchSpecialization = new SearchSpecializationForm();
            SearchFamily = new SearchFamilyForm();
            SearchNeeds = new SearchNeedsForm();
            SearchStudy = new SearchStudyForm();
            SearchRegistration = new SearchRegistrationForm();
            SearchLiving = new SearchLivingForm();
            SearchParents = new SearchParentsForm();
            SearchStudentDoc = new SearchDocumentsStudentForm();
            SearchCollegeDoc = new SearchDocumentsCollegeForm();
            SearchSchool = new SearchLastSchoolForm();
            SearchContacts = new SearchContactsForm();
        }

        SearchStudentForm SearchStudent;
        SearchSpecializationForm SearchSpecialization;
        SearchFamilyForm SearchFamily;
        SearchNeedsForm SearchNeeds;
        SearchStudyForm SearchStudy;
        SearchRegistrationForm SearchRegistration;
        SearchLivingForm SearchLiving;
        SearchParentsForm SearchParents;
        SearchDocumentsStudentForm SearchStudentDoc;
        SearchDocumentsCollegeForm SearchCollegeDoc;
        SearchLastSchoolForm SearchSchool;
        SearchContactsForm SearchContacts;

        private void SearchMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void Form3BtnStudent_Click(object sender, EventArgs e)
        {
            SearchStudent.Show();
        }

        private void Form3BtnSpecial_Click(object sender, EventArgs e)
        {
            SearchSpecialization.Show();
        }

        private void Form3BtnFamily_Click(object sender, EventArgs e)
        {
            SearchFamily.Show();

        }

        private void Form3BtnNeeds_Click(object sender, EventArgs e)
        {
            SearchNeeds.Show();

        }

        private void Form3BtnStudy_Click(object sender, EventArgs e)
        {
            SearchStudy.Show();
        }

        private void Form3BtnRegistration_Click(object sender, EventArgs e)
        {
            SearchRegistration.Show();

        }

        private void Form3BtnHabitation_Click(object sender, EventArgs e)
        {
            SearchLiving.Show();

        }

        private void Form3BtnParents_Click(object sender, EventArgs e)
        {
            SearchParents.Show();

        }

        private void Form3BtnStudentDoc_Click(object sender, EventArgs e)
        {
            SearchStudentDoc.Show();

        }

        private void Form3BtnCollegeDoc_Click(object sender, EventArgs e)
        {
            SearchCollegeDoc.Show();

        }

        private void Form3BtnSchool_Click(object sender, EventArgs e)
        {
            SearchSchool.Show();

        }

        private void SearchMainForm_Load(object sender, EventArgs e)
        {

        }

        private void Form3BtnContacts_Click(object sender, EventArgs e)
        {
            SearchContacts.Show();
        }
    }
}
