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
        public static string connectsString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=БД3.mdb";
        private OleDbConnection myConnection;
        public EditingStudentForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectsString);
            myConnection.Open();
        }


        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД3DataSet.Студент". При необходимости она может быть перемещена или удалена.
            this.студентTableAdapter1.Fill(this.бД3DataSet.Студент);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.Студент". При необходимости она может быть перемещена или удалена.
            this.студентTableAdapter.Fill(this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.Студент);

        }

        private void EditingStudentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
            e.Cancel = true;
            Hide();
        }

        private void StudentFormChange_Click(object sender, EventArgs e)
        {
            string data = DateTime.UtcNow.Date.ToString("dd/MM/yyyy");
            string query = $"UPDATE Студент SET [Сегодняшняя дата] = '{data}'";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Дата обновлена");
            this.студентTableAdapter1.Fill(this.бД3DataSet.Студент);
        }
    }
}
