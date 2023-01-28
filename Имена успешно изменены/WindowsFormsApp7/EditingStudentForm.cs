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
    public partial class EditingStudentForm : Form
    {
        public static string connectsString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=СР-5_ОПБД_Соловьев_Андрей_П9021.mdb";
        private OleDbConnection myConnection;
        public EditingStudentForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectsString);
            myConnection.Open();
        }


        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.Студент". При необходимости она может быть перемещена или удалена.
            this.студентTableAdapter.Fill(this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.Студент);

        }
    }
}
