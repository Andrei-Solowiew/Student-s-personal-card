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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
            AddStudent = new AddStudentForm();
            AddSpecialization = new AddSpecializationForm();
            AddFamily = new AddFamilyForm();
            AddNeeds = new AddNeedsForm();
            AddStudy = new AddStudyForm();
            AddRegistration = new AddRegistrationForm();
            AddLiving = new AddLivingForm();
            AddParents = new AddParentsForm();
            AddStudentDoc = new AddDocumetsStudent();
            AddCollegeDoc = new AddDocumetsCollege();
            AddSchool = new AddLastSchool();
            AddContacts = new AddContactsForm();

        }

        AddStudentForm AddStudent;
        AddSpecializationForm AddSpecialization;
        AddFamilyForm AddFamily;
        AddNeedsForm AddNeeds;
        AddStudyForm AddStudy;
        AddRegistrationForm AddRegistration;
        AddLivingForm AddLiving;
        AddParentsForm AddParents;
        AddDocumetsStudent AddStudentDoc;
        AddDocumetsCollege AddCollegeDoc;
        AddLastSchool AddSchool;
        AddContactsForm AddContacts;

        private void AddForm_Load(object sender, EventArgs e)
        {
            
        }

        private void AddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void Form3BtnStudent_Click(object sender, EventArgs e)
        {
            AddStudent.Show();
        }

        private void Form3BtnSpecial_Click(object sender, EventArgs e)
        {
            AddSpecialization.Show();
        }

        private void Form3BtnFamily_Click(object sender, EventArgs e)
        {
            AddFamily.Show();
        }

        private void Form3BtnNeeds_Click(object sender, EventArgs e)
        {
            AddNeeds.Show();
        }

        private void Form3BtnStudy_Click(object sender, EventArgs e)
        {
            AddStudy.Show();
        }

        private void Form3BtnRegistration_Click(object sender, EventArgs e)
        {
            AddRegistration.Show();
        }

        private void Form3BtnHabitation_Click(object sender, EventArgs e)
        {
            AddLiving.Show();
        }

        private void Form3BtnParents_Click(object sender, EventArgs e)
        {
            AddParents.Show();
        }

        private void Form3BtnStudentDoc_Click(object sender, EventArgs e)
        {
            AddStudentDoc.Show();
        }

        private void Form3BtnCollegeDoc_Click(object sender, EventArgs e)
        {
            AddCollegeDoc.Show();
        }

        private void Form3BtnSchool_Click(object sender, EventArgs e)
        {
            AddSchool.Show();
        }

        private void Form3BtnContacts_Click(object sender, EventArgs e)
        {
            AddContacts.Show();
        }
    }
}
