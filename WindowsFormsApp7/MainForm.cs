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
            Add = new AddForm();
            Delete = new DelForm();
        }

        EditingForm form3;
        Search_form SearchForm;
        HelpForm HelpForm;
        AddForm Add;
        DelForm Delete;



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

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Add.Show();

        }

        private void Del_Click(object sender, EventArgs e)
        {
            Delete.Show();
        }
    }
}
