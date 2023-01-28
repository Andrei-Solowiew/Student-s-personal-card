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
    public partial class AutorizationForm : Form
    {
        public AutorizationForm()
        {
            InitializeComponent();
            form2 = new MainForm();
        }

        MainForm form2;
        string Login = "a";
        string Password = "1";
        private void Form1Btn_Click(object sender, EventArgs e)
        {
            string Log = Form1Log.Text;
            string Pas = Form1Pas.Text;


            if (Log == Login && Password == Pas)
            {
                form2.Show();
            }
            else
            {
                MessageBox.Show("Ошибка ввода");
            }
        }
    }
}
