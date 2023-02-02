using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Data.OleDb;

namespace WindowsFormsApp7
{
    public partial class SearchRegistrationForm : Form
    {
        public static string connectsString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=БД3.mdb";
        private OleDbConnection myConnection;
        public SearchRegistrationForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectsString);
            myConnection.Open();
        }

        private void SearchRegistrationForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД3DataSet.Место_регистрации_студента". При необходимости она может быть перемещена или удалена.
            this.место_регистрации_студентаTableAdapter.Fill(this.бД3DataSet.Место_регистрации_студента);

        }

        private void SearchRegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
            e.Cancel = true;
            Hide();
        }

        private void StudentFormDelete_Click(object sender, EventArgs e)
        {
            местоРегистрацииСтудентаBindingSource.Filter = "[Код студента]=\'" + Convert.ToInt32(textBoxKod.Text) + "\'";
        }
    }
}
