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
    public partial class AddDocumetsStudent : Form
    {
        public static string connectsString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=БД3.mdb";
        private OleDbConnection myConnection;
        public AddDocumetsStudent()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectsString);
            myConnection.Open();
        }

        private void AddDocumetsStudent_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД3DataSet.Документы_студента". При необходимости она может быть перемещена или удалена.
            this.документы_студентаTableAdapter.Fill(this.бД3DataSet.Документы_студента);

        }

        private void AddDocumetsStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
            e.Cancel = true;
            Hide();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            int pasport = Convert.ToInt32(textBoxPasport.Text);
            int kod_student = Convert.ToInt32(textBoxKodStudent.Text);
            string attestat = textBoxAttestat.Text;
            string citezenship = textBoxCitezenship.Text;
            string query = "INSERT INTO [Документы студента] (Паспорт, [Код студента], Аттестат, Гражданство) VALUES(" + pasport + ",'" + kod_student + "','" + attestat + "','" + citezenship +  "')";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные добавлены");
            this.документы_студентаTableAdapter.Fill(this.бД3DataSet.Документы_студента);
        }
    }
}
