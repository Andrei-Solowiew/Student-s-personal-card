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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            form3 = new EditingForm();
            SearchForm = new Search_form();
            HelpForm = new HelpForm();


        }

        EditingForm form3;
        Search_form SearchForm;
        HelpForm HelpForm;



        private void Form2BtnEdit_Click(object sender, EventArgs e)
        {
            form3.Show();
        }

        private void Form2BtnSearch_Click(object sender, EventArgs e)
        {
            SearchForm.Show();
        }

        private void Form2BtnHelp_Click(object sender, EventArgs e)
        {
            HelpForm.Show();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
