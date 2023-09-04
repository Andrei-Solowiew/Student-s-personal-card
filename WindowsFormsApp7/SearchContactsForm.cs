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
    public partial class SearchContactsForm : Form
    {
        public static string connectsString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=БД3.mdb";
        private OleDbConnection myConnection;
        public SearchContactsForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectsString);
            myConnection.Open();
        }

        private void SearchContactsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД3DataSet.Контактные_данные_студента". При необходимости она может быть перемещена или удалена.
            this.контактные_данные_студентаTableAdapter.Fill(this.бД3DataSet.Контактные_данные_студента);

        }

        private void SearchContactsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
            e.Cancel = true;
            Hide();
        }

        private void StudentFormDelete_Click(object sender, EventArgs e)
        {
            контактныеДанныеСтудентаBindingSource.Filter = "[Код студента]=\'" + Convert.ToInt32(textBoxKod.Text) + "\'";
        }
    }
}
