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
    public partial class AddStudentForm : Form
    {
        public static string connectsString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=БД3.mdb";
        private OleDbConnection myConnection;
        public AddStudentForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectsString);
            myConnection.Open();
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД3DataSet.Студент". При необходимости она может быть перемещена или удалена.
            this.студентTableAdapter.Fill(this.бД3DataSet.Студент);

        }

        private void AddStudentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
            e.Cancel = true;
            Hide();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBoxAddKod.Text);
            string surname = textBoxAddSurname.Text;
            string name = textBoxAddName.Text;
            string fathername = textBoxAddNameFather.Text;
            string birthday = textBoxAddBirthday.Text;
            string today = DateTime.UtcNow.Date.ToString("dd/MM/yyyy");
            string query = "INSERT INTO Студент ([Код студента], [Фамилия студента], [Имя студента], [Отчество студента], [Дата рождения], [Сегодняшняя дата]) VALUES(" + kod + ",'" + surname + "','" + name + "','" + fathername + "','" + birthday + "','" + today + "')";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные добавлены");
            this.студентTableAdapter.Fill(this.бД3DataSet.Студент);
        }
    }
}
