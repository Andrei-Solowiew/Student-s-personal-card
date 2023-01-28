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
    public partial class AddSpecializationForm : Form
    {
        public static string connectsString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=БД3.mdb";
        private OleDbConnection myConnection;
        public AddSpecializationForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectsString);
            myConnection.Open();
        }

        private void AddSpecializationForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД3DataSet.Специальность". При необходимости она может быть перемещена или удалена.
            this.специальностьTableAdapter.Fill(this.бД3DataSet.Специальность);

        }

        private void AddSpecializationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
            e.Cancel = true;
            Hide();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBoxAddKod.Text);
            string specialization = textBoxAddSurname.Text;
            int student_kod = Convert.ToInt32(textBoxAddToday.Text);
            string query = "INSERT INTO Специальность ([Код специальности], Специальность, [Код студента]) VALUES(" + kod + ",'" + specialization + "','" + student_kod + "')";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные добавлены");
            this.специальностьTableAdapter.Fill(this.бД3DataSet.Специальность);
        }
    }
}
