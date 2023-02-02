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
    public partial class SearchNeedsForm : Form
    {
        public static string connectsString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=БД3.mdb";
        private OleDbConnection myConnection;
        public SearchNeedsForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectsString);
            myConnection.Open();
        }

        private void SearchNeedsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД3DataSet.Потребности_студента". При необходимости она может быть перемещена или удалена.
            this.потребности_студентаTableAdapter.Fill(this.бД3DataSet.Потребности_студента);

        }

        private void SearchNeedsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
            e.Cancel = true;
            Hide();
        }

        private void StudentFormDelete_Click(object sender, EventArgs e)
        {
            потребностиСтудентаBindingSource.Filter = "[Код студента]=\'" + Convert.ToInt32(textBoxKod.Text) + "\'";
        }
    }
}
