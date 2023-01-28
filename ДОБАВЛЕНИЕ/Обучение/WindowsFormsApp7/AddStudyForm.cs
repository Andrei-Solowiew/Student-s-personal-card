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
    public partial class AddStudyForm : Form
    {
        public static string connectsString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=БД3.mdb";
        private OleDbConnection myConnection;
        public AddStudyForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectsString);
            myConnection.Open();
        }

        private void AddStudyForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД3DataSet.Обучение_студента". При необходимости она может быть перемещена или удалена.
            this.обучение_студентаTableAdapter.Fill(this.бД3DataSet.Обучение_студента);

        }

        private void AddStudyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
            e.Cancel = true;
            Hide();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            int kod_study = Convert.ToInt32(textBoxKodStudy.Text);
            string form = textBoxForm.Text;
            string format = textBoxFormat.Text;
            string group = textBoxGroup.Text;
            string term = textBoxTerm.Text;
            int kod_student = Convert.ToInt32(textBoxKodStudent.Text);
            string query = "INSERT INTO [Обучение студента] ([Код обучения], [Форма обучения], [Формат обучения], [Группа], [Срок обучения], [Код студента]) VALUES(" + kod_study + ",'" + form + "','" + format + "','" + group + "','" + term + "','" + kod_student + "')";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные добавлены");
            this.обучение_студентаTableAdapter.Fill(this.бД3DataSet.Обучение_студента);
        }
    }
}
