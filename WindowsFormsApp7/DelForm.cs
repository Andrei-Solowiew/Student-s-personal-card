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
    public partial class DelForm : Form
    {
        public DelForm()
        {
            InitializeComponent();
            DelStudent = new DelStudentForm();

        }
        DelStudentForm DelStudent;


        private void DelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void Form3BtnStudent_Click(object sender, EventArgs e)
        {
            DelStudent.Show();
        }
    }
}
